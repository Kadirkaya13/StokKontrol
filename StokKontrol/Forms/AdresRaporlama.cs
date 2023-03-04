using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokKontrol.Forms
{
    public partial class AdresRaporlama : Form
    {
        public AdresRaporlama()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void AdresRaporlama_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://localhost:44383/Adreslemes/AdresRaporlama");
        }
    }
}
