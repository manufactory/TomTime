using System.Windows.Forms;

namespace TomTime
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void llblLicence_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://en.wikipedia.org/wiki/Beerware");
        }

        private void lblLicence_Click(object sender, System.EventArgs e)
        {

        }
    }
}
