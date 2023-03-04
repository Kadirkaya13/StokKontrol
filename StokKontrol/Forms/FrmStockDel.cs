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
    public partial class FrmStockDel : Form
    {
        public FrmStockDel()
        {
            InitializeComponent();
        }
        private StokDbEntities _db = new StokDbEntities();

        private void FrmStockDel_Load(object sender, EventArgs e)
        {
            CategorySelection();
        }

        private void btnStockUpdate_Click(object sender, EventArgs e)
        {
            var id = cbxStokKodu.SelectedValue.ToString();
            var stokKart = _db.StokKart.Find(id);


            stokKart.Durum = false;


            _db.SaveChanges();

            MessageBox.Show("Ürün pasif hale getrildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }
        void CategorySelection()
        {
            cbxStokKodu.DataSource = _db.StokKart.Select(p => p.StokKodu).ToList();
        }
    }
}
