using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuhasebeProgramı.StokModul
{
    public partial class frmStokKarti : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyon.DataClasses1DataContext DB = new Fonksiyon.DataClasses1DataContext();
        Fonksiyon.Mesajlar Mesajlar = new Fonksiyon.Mesajlar();
        Fonksiyon.Numara Numaralar = new Fonksiyon.Numara();
        Fonksiyon.Formlar Formlar = new Fonksiyon.Formlar();
        Fonksiyon.Resimleme Resimleme = new Fonksiyon.Resimleme();

        bool Edit = false;
        bool Resim = false;
        OpenFileDialog Dosya = new OpenFileDialog();
        int GrupID = -1;
        int StokID = -1;
        public frmStokKarti()
        {
            InitializeComponent();
        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void frmStokKarti_Load(object sender, EventArgs e)
        {
           txtStokKodu.Text = Numaralar.StokKodNumarasi();
            Mesajlar.FormAcilis(this.Text);
        }

        void Temizle ()
        {
            txtStokKodu.Text = Numaralar.StokKodNumarasi();
            txtStokAdı.Text = "";
            txtSatisKDV.Text = "0";
            txtSatisFiyat.Text = "0";
            txtGrupKodu.Text = "";
            txtGrupAdi.Text = "";
            txtBirim.SelectedIndex = 0;
            txtBarkod.Text = "";
            txtAlisKDV.Text = "0";
            txtAlisFiyat.Text = "0";
            pictureBox1.Image = null;
            Edit = false;
            Resim = false;
            GrupID = -1;
            StokID = -1;
            AnaForm.Aktarma = -1;
        }

        void ResimSec()
        {
            Dosya.Filter = "Jpg(*jpg)|*.jpg|Jpeg(*.jpeg)|*.jpeg";
            if (Dosya.ShowDialog() == DialogResult.OK )
            {
                pictureBox1.ImageLocation = Dosya.FileName;
                Resim = true;
            }
        }
        private void btnresimsec_Click(object sender, EventArgs e)
        {
            ResimSec();
        }

        public void Ac(int ID)
        {
            Edit = true;
            StokID = ID;
            Fonksiyon.TBL_STOKLAR Stok = DB.TBL_STOKLARs.First(s => s.ID == StokID);
            GrupAc(Stok.STOKGRUPID.Value);
            pictureBox1.Image = Resimleme.ResimGetirme(Stok.STOKRESIM.ToArray());
            txtAlisFiyat.Text = Stok.STOKALISFIYAT.ToString();
            txtAlisKDV.Text = Stok.STOKALISKDV.ToString();
            txtBarkod.Text = Stok.STOKBARKOD;
            txtBirim.Text = Stok.STOKBIRIM;
            txtSatisFiyat.Text = Stok.STOKSATISFIYAT.ToString();
            txtSatisKDV.Text = Stok.STOKSATISKDV.ToString();
            txtStokAdı.Text = Stok.STOKADI;
            txtStokKodu.Text = Stok.STOKKODU;

        }
        void GrupAc(int ID)
        {
            GrupID = ID;
            txtGrupAdi.Text = DB.TBL_STOKGRUPLARIs.First(s => s.ID == GrupID).GRUPADI;
            txtGrupKodu.Text = DB.TBL_STOKGRUPLARIs.First(s => s.ID == GrupID).GRUPKODU;

        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyon.TBL_STOKLAR Stok = new Fonksiyon.TBL_STOKLAR();
                Stok.STOKADI = txtStokAdı.Text;
                Stok.STOKALISFIYAT = decimal.Parse(txtAlisFiyat.Text);
                Stok.STOKALISKDV = decimal.Parse(txtAlisKDV.Text);
                Stok.STOKBARKOD = txtBarkod.Text;
                Stok.STOKBIRIM = txtBirim.Text;
                Stok.STOKGRUPID = GrupID;
                Stok.STOKKODU = txtStokKodu.Text;
                 if (Resim) Stok.STOKRESIM = new System.Data.Linq.Binary(Resimleme.ResimYukleme(pictureBox1.Image));
                Stok.STOKSATISFIYAT = decimal.Parse(txtSatisFiyat.Text);
                Stok.STOKSATISKDV = decimal.Parse(txtSatisKDV.Text);
                Stok.STOKSAVEDATE = DateTime.Now;
                Stok.STOKSAVEUSER = AnaForm.UserID;
                DB.TBL_STOKLARs.InsertOnSubmit(Stok);
                DB.SubmitChanges();
                Mesajlar.YeniKayıt("Yeni stok kaydı oluşturuldu.");
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void Guncelle()
        {
            try
            {
                Fonksiyon.TBL_STOKLAR Stok = DB.TBL_STOKLARs.First(s => s.ID == StokID);
                Stok.STOKADI = txtStokAdı.Text;
                Stok.STOKALISFIYAT = decimal.Parse(txtAlisFiyat.Text);
                Stok.STOKALISKDV = decimal.Parse(txtAlisKDV.Text);
                Stok.STOKBARKOD = txtBarkod.Text;
                Stok.STOKBIRIM = txtBirim.Text;
                Stok.STOKGRUPID = GrupID;
                Stok.STOKKODU = txtStokKodu.Text;
                if (Resim) Stok.STOKRESIM = new System.Data.Linq.Binary(Resimleme.ResimYukleme(pictureBox1.Image));
                Stok.STOKSATISFIYAT = decimal.Parse(txtSatisFiyat.Text);
                Stok.STOKSATISKDV = decimal.Parse(txtSatisKDV.Text);
                Stok.STOKEDITDATE = DateTime.Now;
                Stok.STOKEDITUSER = AnaForm.UserID;
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }

        }

        void Sil()
        {
            try 
            {
                DB.TBL_STOKLARs.DeleteOnSubmit(DB.TBL_STOKLARs.First(s => s.ID == StokID));
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        private void txtStokKodu_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtStokKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.StokListesi(true);
            if (ID > 0)
            {
                Ac(ID);
            }
            AnaForm.Aktarma = -1;
        }

        private void txtGrupKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.StokGrupları(true);
            if (Id > 0)
            {
                GrupAc(Id);
            }
            AnaForm.Aktarma = -1;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && StokID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && StokID > 0 && Mesajlar.Guncelle() == DialogResult.Yes)
            {
                Guncelle();
            }
            else 
            {
                YeniKaydet();
            }
        }
    }
}