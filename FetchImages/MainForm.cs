using FetchImages.Common;
using FetchImages.Configuration;
using OfficeOpenXml;
using SoftwareManagement.Updater;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FetchImages
{
    public partial class MainForm : Form//, Updater.IUpdatableApplication
    {
        public static string TempDirectory => System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\Temp";
        private readonly ApplicationDeployment Updater;
        public MainForm()
        {
            InitializeComponent();
            lblAddressesNumber.Text = "";
            progressBar.Visible = lblAddressesNumber.Visible = false;
            this.Icon = Properties.Resources.Paomedia_Small_N_Flat_File_code;
            this.Updater = new ApplicationDeployment(this);

            this.olvColumnAddresses.AspectGetter = delegate (object r) 
            {
                FetchImagesResult o = r as FetchImagesResult;
                return o.IsSuccess ? o.Images.Count.ToString() : o.ErrorMessage;
            };
            this.olvColumnUrl.AspectGetter = delegate (object r) { return (r as FetchImagesResult).RawQueryString; };
        }

        private async void btnImportUrl_Click(object sender, EventArgs e)
        {
            var lines = Dialogs.GetLines();
            if (lines.Length == 0) return;

            var fetchers = new Fetchers.FetchersBuilder().BuildFetchers().ToList();

            this.progressBar.Value = 0;
            this.progressBar.Maximum = lines.Length;
            this.progressBar.Visible = this.lblAddressesNumber.Visible = true;

            int delay = (AppSettings.Instance.RequestProperties.UseRequestDelay 
                && AppSettings.Instance.RequestProperties.RequestDelay > 0)
                ? AppSettings.Instance.RequestProperties.RequestDelay 
                : 0;

            var requestProperties = AppSettings.Instance.RequestProperties;

            try
            {
                foreach (var line in lines)
                {
                    FetchImagesResult result;
                    var queryResult = await HttpEngine.LoadPageContent(line);
                    List<Uri> results = new List<Uri>();

                    if (queryResult.IsSuccess)
                    {
                        foreach (var fetcher in fetchers)
                        {
                            results.AddRange(fetcher.FetchImages(queryResult.Value));
                        }

                        result = new FetchImagesResult
                        {
                            RawQueryString = queryResult.Value.RawQueryString,
                            IsSuccess = true,
                            Images = results
                        };
                    }
                    else
                    {
                        result = new FetchImagesResult
                        {
                            RawQueryString = queryResult.Value.RawQueryString,
                            IsSuccess = false,
                            ErrorMessage = queryResult.Error.Message,
                            Images = results
                        };
                    }
                    
                    olvAddresses.AddObject(result);
                    this.progressBar.Value++;
                    lblAddressesNumber.Text = $"Поиск: {this.progressBar.Value} / {lines.Length}";

                    if (delay > 0)
                        await Task.Delay(delay);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.progressBar.Value = 0;
                this.progressBar.Maximum = 100;
                this.progressBar.Visible = false;
                lblAddressesNumber.Text = $"Адресов: {olvAddresses.GetItemCount()}";
            }
        }
        
        private async void btnExport_Click(object sender, EventArgs e)
        {
            List<FetchImagesResult> responses = new List<FetchImagesResult>();
            foreach (var item in olvAddresses.Objects)
            {
                responses.Add(item as FetchImagesResult);
            }
            if (responses.Count == 0) return;

            try
            {
                this.progressBar.Value = 0;
                this.progressBar.Visible = this.lblAddressesNumber.Visible = true;

                var progress = new System.Progress<OperationProgress>(UpdateProgress);

                var file = await ExportToExcel(responses, progress);

                Process.Start(file.FullName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.progressBar.Visible = false;
                lblAddressesNumber.Text = $"Адресов: {olvAddresses.GetItemCount()}";
            }
        }
        private async Task<FileInfo> ExportToExcel(List<FetchImagesResult> responses, IProgress<OperationProgress> progress)
        {
            if (!Directory.Exists(TempDirectory))
            {
                Directory.CreateDirectory(TempDirectory);
            }

            FileInfo tempFile = new FileInfo(Path.Combine(TempDirectory, $"{Guid.NewGuid()}.xlsx"));

            using (ExcelPackage excel = CreatePascage(responses, progress))
            {
                await excel.SaveAsAsync(tempFile);
            }

            return tempFile;
        }

        private static ExcelPackage CreatePascage(List<FetchImagesResult> responses, IProgress<OperationProgress> progress)
        {
            var max = responses.Where(a => a.IsSuccess).Max(a => a.Images.Count);
            ExcelPackage excel = new ExcelPackage();

            var sheet = excel.Workbook.Worksheets.Add("export");
            sheet.Cells[1, 1].Value = "Link";
            for (int i = 1; i <= max; i++)
            {
                sheet.Cells[Row: 1, Col: i + 1].Value = $"Index {i - 1}";
            }

            int len = responses.Count;
            int line = 2;

            foreach (var resp in responses)
            {
                sheet.Cells[Row: line, Col: 1].Value = resp.RawQueryString;
                if (!resp.IsSuccess)
                {
                    if (!string.IsNullOrEmpty(resp.ErrorMessage))
                        sheet.Cells[Row: line, Col: 2].Value = resp.ErrorMessage;
                }
                else
                {
                    int column = 2;
                    foreach (var address in resp.Images)
                    {
                        sheet.Cells[Row: line, Col: column].Value = address.ToString();
                        column++;
                    }
                }
                progress.Report(new OperationProgress(len, line - 1, $"Экспорт: {line - 1} / {len}"));
                line++;
            }

            return excel;
        }

        private void UpdateProgress(OperationProgress progress)
        {            
            this.progressBar.Value = (int)progress.Progress;
            if(progress.UserState != null)
            {
                this.lblAddressesNumber.Text = progress.UserState.ToString();
            }            
        }


        private void olvAddresses_DoubleClick(object sender, EventArgs e)
        {
            if (olvAddresses.SelectedObject == null) return;

            FetchImagesResult resp = olvAddresses.SelectedObject as FetchImagesResult;
            if (resp.ErrorMessage != null)
            {
                MessageBox.Show($"Error:\n{resp.ErrorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (var dlg = new AddressViewDialog(resp))
                {
                    dlg.ShowDialog(this);
                }
            }
        }              


        private async void btnAnalizePage_ClickAsync(object sender, EventArgs e)
        {
            var address = Dialogs.GetLine();

            if (string.IsNullOrWhiteSpace(address)) return;

            var fetchers = new Fetchers.FetchersBuilder().BuildFetchers().ToList();

            var response = await HttpEngine.LoadPageContent(address);

            if (!response.IsSuccess)
            {
                MessageBox.Show($"Error:\n{response.Error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Uri> results = new List<Uri>();

            foreach (var fetcher in fetchers)
            {                
                results.AddRange(fetcher.FetchImages(response.Value));
            }

            if (results.Count == 0)
            {
                MessageBox.Show("Не обнаружено ссылок по аресу: " + response.Value.RawQueryString, "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FetchImagesResult result = new FetchImagesResult
            {
                RawQueryString = response.Value.RawQueryString,
                IsSuccess = true,
                Images = results
            };

            using (var dlg = new AddressViewDialog(result))
            {
                dlg.ShowDialog(this);
            }           
        }
        private void MainWindow_Shown(object sender, EventArgs e)
        {
            Task.Run(() => Updater.UpdateApplication(UpdateMethod.Automatic));
        }  
        private void btnShowOptions_Click(object sender, EventArgs e)
        {

            using(FetchOptionsDialog dlg = new FetchOptionsDialog())
            {
                _ = dlg.ShowDialog(this);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.olvAddresses.ClearObjects();
            lblAddressesNumber.Text = "";
        }

        private void mnuSendLetter_Click(object sender, EventArgs e) =>
        System.Diagnostics.Process.Start(AboutDialog.GetSupportEmailProcessString(this.ApplicationName));

        private void mnuCheckUpdates_Click(object sender, EventArgs e)
        {
            Task.Run(() => this.Updater.UpdateApplication(UpdateMethod.Manual));
        }

        private void mnuShowAbout_Click(object sender, EventArgs e)
        {
            new AboutDialog(this).ShowDialog();
        }
    }
}
