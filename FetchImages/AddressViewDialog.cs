using FetchImages.Common;
using System;
using System.Windows.Forms;

namespace FetchImages
{
    internal partial class AddressViewDialog : Form
    {
        private readonly FetchImagesResult resp;
        public AddressViewDialog(FetchImagesResult response)
        {
            InitializeComponent();
            this.resp = response;
            this.Text = resp.RawQueryString;
            olvColumnUrl.AspectGetter = delegate (object r) { return r.ToString(); };
            //olvColumnIndex.AspectGetter = delegate (object r) { return (r as Interfaces.IResult).IndexOf; };
            olvAddresses.SetObjects(response.Images);
        }
        

        private void olvAddresses_SelectionChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            if (olvAddresses.SelectedObject == null)
                return;
            try
            {
                pictureBox1.LoadAsync(olvAddresses.SelectedObject.ToString());
            }
            catch            {            }
            
        }
    }
}
