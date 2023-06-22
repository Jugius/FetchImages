using FetchImages.Common;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace FetchImages
{
    public partial class FetchOptionsDialog : Form
    {        
        public FetchOptionsDialog()
        {
            InitializeComponent();

            var options = Configuration.AppSettings.Instance;

            chkUseHtmlSrcCode.Checked = options.FetchProperties.UseHtmlSrcCode;

            chkUseRegEx.Checked = options.FetchProperties.UseRegexp;
            lblDefaultRegex.Text = Properties.Resources.RegExpression;
            chkUseCustomRegexpPattern.Checked = options.FetchProperties.UseCustomRegexpPattern;
            txtCustomRegexpPattern.Text = options.FetchProperties.CustomRegexpPattern;

            chkUseEmbeddedStrategies.Checked = options.FetchProperties.UseEmbeddedStrategies;

            chkUseRequestDelay.Checked = options.RequestProperties.UseRequestDelay;
            txtRequestDelay.Text = options.RequestProperties.RequestDelay.ToString();
        }        
        private void _secondaryPanel_Paint(object sender, PaintEventArgs e)
        {
            VisualStyleRenderer renderer = new VisualStyleRenderer(VisualStyleElement.CreateElement("TASKDIALOG", 8, 0));
            renderer.DrawBackground(e.Graphics, _secondaryPanel.ClientRectangle, e.ClipRectangle);
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            var verifyResult = IsVerified();
            if (!verifyResult.IsSuccess)
            { 
                MessageBox.Show(verifyResult.Error.Message, "Ошибка проверки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var options = Configuration.AppSettings.Instance;

            options.FetchProperties.UseHtmlSrcCode = chkUseHtmlSrcCode.Checked;

            options.FetchProperties.UseRegexp = chkUseRegEx.Checked;
            options.FetchProperties.UseCustomRegexpPattern = chkUseCustomRegexpPattern.Checked;
            options.FetchProperties.CustomRegexpPattern = txtCustomRegexpPattern.Text;

            options.FetchProperties.UseEmbeddedStrategies = chkUseEmbeddedStrategies.Checked;
            
            options.RequestProperties.UseRequestDelay = chkUseRequestDelay.Checked;
            options.RequestProperties.RequestDelay = int.TryParse(txtRequestDelay.Text, out int result) ? result : 0;

            options.Save();

            this.DialogResult = DialogResult.OK;
        }
        private OperationResult<bool> IsVerified()
        {
            if (!(chkUseHtmlSrcCode.Checked || chkUseRegEx.Checked || chkUseEmbeddedStrategies.Checked))
                return new System.Exception("Должна быть выбрана хотя бы одна стратегия поиска.");

            if (chkUseRegEx.Checked && chkUseCustomRegexpPattern.Checked && string.IsNullOrWhiteSpace(txtCustomRegexpPattern.Text))
                return new System.Exception("Должен быть указан паттерн регулярного выражения");

            if (!string.IsNullOrWhiteSpace(txtRequestDelay.Text) && !int.TryParse(txtRequestDelay.Text, out _))
                return new System.Exception("Задержка запросов должна быть указана числом (миллисекунды)");

            return true;
        }
    }
}
