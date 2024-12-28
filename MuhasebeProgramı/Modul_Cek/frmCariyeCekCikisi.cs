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

namespace MuhasebeProgramı.Modul_Cek
{
    public partial class frmCariyeCekCikisi : DevExpress.XtraEditors.XtraForm
    {

        Fonksiyon.DataClasses1DataContext DB = new Fonksiyon.DataClasses1DataContext();
        Fonksiyon.Formlar Formlar = new Fonksiyon.Formlar();
        Fonksiyon.Mesajlar Mesajlar = new Fonksiyon.Mesajlar();

        int CariID = -1;
        int CekID = -1;
        bool Edit = false;
        public frmCariyeCekCikisi()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmCariyeCekCikisi_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtVadeTarihi.Text = DateTime.Now.ToShortDateString();
        }

        void Temizle()
        {
            txtBanka.Text = "";
            txtBelgeNo.Text = "";
            txtCariAdi.Text = "";
            txtCariKodu.Text = "";
            txtCekNo.Text = "";
            txtSube.Text = "";
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtTutar.Text = "";
            txtVadeTarihi.Text = DateTime.Now.ToShortDateString();
            CariID = -1;
            CekID = -1;
            Edit = false;
            AnaForm.Aktarma = -1;
        }

        void CariAC(int ID)
        {
            try
            {
                CariID = ID;
                Fonksiyon.TBL_CARILER Cari = DB.TBL_CARILERs.First(s => s.ID == CariID);
                txtCariAdi.Text = Cari.CARIADI;
                txtCariKodu.Text = Cari.CARIKODU;
            }
            catch (Exception EX)
            {

                Mesajlar.Hata(EX);
            }
        }

        void CekGetir(int ID)
        {
            try
            {
                CekID = ID;
                Fonksiyon.TBL_CEKLER Cek = DB.TBL_CEKLERs.First(s => s.ID == CekID);
                txtBanka.Text = Cek.BANKA;
                txtCekNo.Text = Cek.CEKNO;
                txtSube.Text = Cek.SUBE;
                txtVadeTarihi.Text = Cek.VADETARIHI.Value.ToShortDateString();
                txtTutar.Text = Cek.TUTAR.Value.ToString();
                if (Cek.VERILENCARIID != null)
                {
                    if (Cek.VERILENCARIID.Value > 0)

                    {
                        CariAC(Cek.VERILENCARIID.Value);
                        txtBelgeNo.Text = Cek.VERILENCARI_BELGENO;
                        txtTarih.Text = Cek.VERILENCARI_TARIHI.Value.ToShortDateString();
                    } 
                }
            }
            catch (Exception EX)
            {

                Mesajlar.Hata(EX);
            }
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyon.TBL_CEKLER Cek = DB.TBL_CEKLERs.First(s => s.ID == CekID);
                Cek.VERILENCARIID = CariID;
                Cek.VERILENCARI_TARIHI = DateTime.Parse(txtTarih.Text);
                Cek.VERILENCARI_BELGENO = txtBelgeNo.Text;
                Cek.DURUMU = "Caride";
                Cek.EDITDATE = DateTime.Now;
                Cek.EDITUSER = AnaForm.UserID;
                DB.SubmitChanges();
                Fonksiyon.TBL_CARIHAREKETLERI CariHareket = new Fonksiyon.TBL_CARIHAREKETLERI();
                CariHareket.ACIKLAMA = txtCekNo.Text + " çek numaralı ve " + txtBelgeNo.Text + " belge numaralı çek.";
                CariHareket.BORC = decimal.Parse(txtTutar.Text);
                CariHareket.CARIID = CariID;
                CariHareket.EVRAKID = CekID;
                CariHareket.EVRAKTURU = "Cariye Çek";
                CariHareket.TARIH = DateTime.Now;
                CariHareket.TIPI = "Çek İşlemi";
                CariHareket.SAVEDATE = DateTime.Now;
                CariHareket.SAVEUSER = AnaForm.UserID;
                DB.TBL_CARIHAREKETLERIs.InsertOnSubmit(CariHareket);
                DB.SubmitChanges();
                Mesajlar.YeniKayıt("Cariye çek çıkışı işleminin hareket kaydı ve çek kaydı güncellemesi yapılmıştır.");
                Temizle();
            }
            catch (Exception EX)
            {

                Mesajlar.Hata(EX);
            }
        }

        void Guncelle()
        {
            try
            {
                Fonksiyon.TBL_CEKLER Cek = DB.TBL_CEKLERs.First(s => s.ID == CekID);
                Cek.VERILENCARIID = CariID;
                Cek.VERILENCARI_TARIHI = DateTime.Parse(txtTarih.Text);
                Cek.VERILENCARI_BELGENO = txtBelgeNo.Text;
                Cek.DURUMU = "Caride";
                Cek.EDITDATE = DateTime.Now;
                Cek.EDITUSER = AnaForm.UserID;
                DB.SubmitChanges();
                Fonksiyon.TBL_CARIHAREKETLERI CariHareket = DB.TBL_CARIHAREKETLERIs.First(s => s.EVRAKTURU == "Cariye Çek" && s.EVRAKID == CekID);
                CariHareket.ACIKLAMA = txtCekNo.Text + " çek numaralı ve " + txtBelgeNo.Text + " belge numaralı çek.";
                CariHareket.BORC = decimal.Parse(txtTutar.Text);
                CariHareket.CARIID = CariID;
                CariHareket.EVRAKID = CekID;
                CariHareket.EVRAKTURU = "Cariye Çek";
                CariHareket.TARIH = DateTime.Now;
                CariHareket.TIPI = "Çek İşlemi";
                CariHareket.EDITDATE = DateTime.Now;
                CariHareket.EDITUSER = AnaForm.UserID;
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception EX)
            {

                Mesajlar.Hata(EX);
            }
        }

        public void Ac(int CekinIDsi)
        {
            try
            {
                CekID = CekinIDsi;
                CekGetir(CekID);
                Edit = true;
            }
            catch (Exception EX)
            {

                Mesajlar.Hata(EX);
                Temizle();
            }
        }

        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = Formlar.CariListesi(true);
            if (id > 0) CariAC(id);
            AnaForm.Aktarma = -1;
        }

        private void txtCekNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = Formlar.CekListesi(true);
            if (id > 0) CekGetir(id);
            AnaForm.Aktarma = -1;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && Mesajlar.Guncelle() == DialogResult.Yes && CariID > 0 && CekID > 0) Guncelle();
            else if (CariID > 0 && CekID > 0) YeniKaydet();
            else MessageBox.Show("Çek veya Cari Seçimi yapılmamış.");

        }

        private void btnnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (Edit && Mesajlar.Sil() == DialogResult.Yes && CariID > 0 && CekID > 0)
                {
                    DB.TBL_CARIHAREKETLERIs.DeleteOnSubmit(DB.TBL_CARIHAREKETLERIs.First(s => s.EVRAKTURU == "Cariye Çek" && s.EVRAKID == CekID));
                    Fonksiyon.TBL_CEKLER Cek = DB.TBL_CEKLERs.First(s => s.ID == CekID);
                    Cek.VERILENBANKA_BELGENO = "";
                    Cek.VERILENCARIID = -1;
                    DB.SubmitChanges();
                }
            }
            catch (Exception EX)
            {

                Mesajlar.Hata(EX);
            }

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}