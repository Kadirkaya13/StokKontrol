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
    public partial class FrmStockAdd : Form
    {
        public FrmStockAdd()
        {
            InitializeComponent();
        }

        private StokDbEntities _db = new StokDbEntities();

        private void FrmStockAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnStockAdd_Click(object sender, EventArgs e)
        {
            if (txtStokKodu.Text != "" && txtAdet.Text != null && txtAd.Text != "" && txtStokTip.Text != "" && txtAlisFiyat.Text != null && txtSatisFiyat.Text != null
                  && txtBosaltmaYontemi.Text != "" && txtYerleştirme.Text != "" && txtYüklemeBosaltmaAlani.Text != "")
            {
                StokKart stokKart = new StokKart();
                stokKart.StokKodu = txtStokKodu.Text;
                stokKart.OzelKod = txtOzelKod.Text;
                stokKart.Ad = txtAd.Text;
                stokKart.GenelAd = txtGenelAd.Text;
                stokKart.AlışFiyat = Convert.ToInt16(txtAlisFiyat.Text);
                stokKart.SatışFiyat = Convert.ToInt16(txtSatisFiyat.Text);
                stokKart.Adet=Convert.ToInt16(txtAdet.Text);
                stokKart.Kdv = Convert.ToInt16(txtSatisFiyat.Text)*(Convert.ToInt16(1 + txtKdv.Text));
                stokKart.StokTipi = txtStokTip.Text;
                stokKart.Barkod = txtBarkod.Text;
                stokKart.Durum = Convert.ToInt32(radioStatus1.Checked) > 0 ? true : false;

                _db.StokKart.Add(stokKart);
                _db.SaveChanges();

                Adresleme adresleme = new Adresleme();
                adresleme.StokKodu = txtStokKodu.Text;
                adresleme.BosaltmaYontemi = txtBosaltmaYontemi.Text;
                adresleme.GeciciKabul = Convert.ToInt32(radioStatus1GK.Checked) > 0 ? true : false;
                adresleme.MalKabul = Convert.ToInt32(radioStatus1MK.Checked) > 0 ? true : false;
                adresleme.Yerleştirme = txtYerleştirme.Text;
                adresleme.YüklemeBosaltmaAlani = txtYüklemeBosaltmaAlani.Text;
                _db.Adresleme.Add(adresleme);
                _db.SaveChanges();

                MessageBox.Show("Ürün başarı ile eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Doldurulmayan alanları doldurunuz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtAlisFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSatisFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtKdv_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
