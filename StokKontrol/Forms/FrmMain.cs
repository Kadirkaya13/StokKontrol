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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmStockAdd frmStockAdd = new FrmStockAdd();
            frmStockAdd.Show();
        }

        private void btnStokGüncelle_Click(object sender, EventArgs e)
        {
            FrmStockUpdate frmStockUpdate = new FrmStockUpdate();
            frmStockUpdate.Show();
        }

        private void btnStockDel_Click(object sender, EventArgs e)
        {
            FrmStockDel frmStockDel = new FrmStockDel();
            frmStockDel.Show();
        }

        private void btnStockList_Click(object sender, EventArgs e)
        {
            FrmList frmList = new FrmList();
            frmList.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Raporlama rprStok = new Raporlama();
            rprStok.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdresRaporlama rprAdres = new AdresRaporlama();
            rprAdres.Show();
        }
    }
}
