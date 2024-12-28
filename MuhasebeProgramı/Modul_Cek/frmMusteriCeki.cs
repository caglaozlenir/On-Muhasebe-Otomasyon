using System;
using System.Linq;
using System.Windows.Forms;

namespace MuhasebeProgramı.Modul_Cek
{
    public partial class frmMusteriCeki : DevExpress.XtraEditors.XtraForm
    {

        Fonksiyon.DataClasses1DataContext DB = new Fonksiyon.DataClasses1DataContext();
        Fonksiyon.Formlar Formlar = new Fonksiyon.Formlar();
        Fonksiyon.Mesajlar Mesajlar = new Fonksiyon.Mesajlar();

        int CariID = -1;
        int CekID = -1;
        bool Edit = false;

        public frmMusteriCeki()
        {
            InitializeComponent();
        }

        public void Ac(int ID)
        {
            try
            {
                CekID = ID;
                Fonksiyon.TBL_CEKLER Cek = DB.TBL_CEKLERs.First(s => s.ID == CekID);
                txtAciklama.Text = Cek.ACIKLAMA;
                if (Cek.ACKODU == "A") txtCekTuru.SelectedIndex = 0;
                if (Cek.ACKODU == "C") txtCekTuru.SelectedIndex = 1;
                txtAsilBorclu.Text = Cek.ASILBORCLU;
                txtBanka.Text = Cek.BANKA;
                txtBelgeNo.Text = Cek.BELGENO;
                txtCekNo.Text = Cek.CEKNO;
                txtHesapNo.Text = Cek.HESAPNO;
                txtSube.Text = Cek.SUBE;
                txtTutar.Text = Cek.TUTAR.Value.ToString();
                txtVadeTarihi.Text = Cek.VADETARIHI.Value.ToShortDateString();
                CariAc(Cek.ALINANCARIID.Value);
                Edit = true;



            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
                Temizle();
            }
        }

        void Temizle()
        {
            txtAciklama.Text = "";
            txtAsilBorclu.Text = "";
            txtBanka.Text = "";
            txtBelgeNo.Text = "";
            txtCariAdi.Text = "";
            txtCariKodu.Text = "";
            txtCekTuru.SelectedIndex = 0;
            txtHesapNo.Text = "";
            txtSube.Text = "";
            txtTutar.Text = "";
            txtVadeTarihi.Text = DateTime.Now.ToShortDateString();
            CariID = -1;
            CekID = -1;
            AnaForm.Aktarma = -1;
            Edit = false;
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMusteriCeki_Load(object sender, EventArgs e)
        {
            txtVadeTarihi.Text = DateTime.Now.ToShortDateString();
        }

        void YeniCekKaydet()
        {
            try
            {
                Fonksiyon.TBL_CEKLER Cek = new Fonksiyon.TBL_CEKLER();
                Cek.ACIKLAMA = txtAciklama.Text;
                if (txtCekTuru.SelectedIndex == 0) Cek.ACKODU = "A";
                if (txtCekTuru.SelectedIndex == 1) Cek.ACKODU = "C";
                Cek.ALINANCARIID = CariID;
                Cek.BANKA = txtBanka.Text;
                Cek.BELGENO = txtBelgeNo.Text;
                Cek.CEKNO = txtCekNo.Text;
                Cek.DURUMU = "Portföy";
                Cek.HESAPNO = txtHesapNo.Text;
                Cek.SUBE = txtSube.Text;
                Cek.TAHSIL = "Hayır";
                Cek.TARIH = DateTime.Now;
                Cek.VADETARIHI = DateTime.Parse(txtVadeTarihi.Text);
                Cek.TUTAR = decimal.Parse(txtTutar.Text);
                Cek.TIPI = "Müşteri Çeki";
                Cek.ASILBORCLU = txtAsilBorclu.Text;
                Cek.SAVEDATE = DateTime.Now;
                Cek.SAVEUSER = AnaForm.UserID;
                DB.TBL_CEKLERs.InsertOnSubmit(Cek);
                DB.SubmitChanges();
                Mesajlar.YeniKayıt(txtCekNo.Text + " No'lu müşteri çeki kaydı gerçekleşmiştir.");
                Fonksiyon.TBL_CARIHAREKETLERI CariHareket = new Fonksiyon.TBL_CARIHAREKETLERI();
                CariHareket.ACIKLAMA = txtBelgeNo.Text + " belge numaralı ve " + txtCekNo.Text + "çek numaralı müşteri çeki.";
                CariHareket.CARIID = CariID;
                CariHareket.EVRAKID = Cek.ID;
                CariHareket.EVRAKTURU = "Müşteri Çeki";
                CariHareket.TARIH = DateTime.Now;
                CariHareket.TIPI = "MÇ";
                CariHareket.SAVEDATE = DateTime.Now;
                CariHareket.SAVEUSER = AnaForm.UserID;
                DB.TBL_CARIHAREKETLERIs.InsertOnSubmit(CariHareket);
                DB.SubmitChanges();
                Mesajlar.YeniKayıt(txtCekNo.Text + " No'lu müşteri çeki cari kaydı gerçekleşmiştir.");
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
                Fonksiyon.TBL_CEKLER Cek = DB.TBL_CEKLERs.First(s => s.ID == CekID);
                Cek.ACIKLAMA = txtAciklama.Text;
                if (txtCekTuru.SelectedIndex == 0) Cek.ACKODU = "A";
                if (txtCekTuru.SelectedIndex == 1) Cek.ACKODU = "C";
                Cek.ALINANCARIID = CariID;
                Cek.BANKA = txtBanka.Text;
                Cek.BELGENO = txtBelgeNo.Text;
                Cek.CEKNO = txtCekNo.Text;
                Cek.DURUMU = "Portföy";
                Cek.HESAPNO = txtHesapNo.Text;
                Cek.SUBE = txtSube.Text;
                Cek.TAHSIL = "Hayır";
                Cek.VADETARIHI = DateTime.Parse(txtVadeTarihi.Text);
                Cek.TUTAR = decimal.Parse(txtTutar.Text);
                Cek.TIPI = "Müşteri Çeki";
                Cek.ASILBORCLU = txtAsilBorclu.Text;
                Cek.EDITDATE = DateTime.Now;
                Cek.EDITUSER = AnaForm.UserID;
                DB.SubmitChanges();
                Fonksiyon.TBL_CARIHAREKETLERI CariHareket = DB.TBL_CARIHAREKETLERIs.First(s => s.EVRAKID == CekID && s.EVRAKTURU == "Müşteri Çeki" && s.TIPI == "MÇ");
                CariHareket.ACIKLAMA = txtBelgeNo.Text + " belge numaralı ve " + txtCekNo.Text + "çek numaralı müşteri çeki.";
                CariHareket.CARIID = CariID;
                CariHareket.EVRAKID = Cek.ID;
                CariHareket.EVRAKTURU = "Müşteri Çeki";
                CariHareket.TARIH = DateTime.Now;
                CariHareket.TIPI = "MÇ";
                CariHareket.EDITDATE = DateTime.Now;
                CariHareket.EDITUSER = AnaForm.UserID;
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void CariAc(int ID)
        {
            CariID = ID;
            Fonksiyon.TBL_CARILER Cari = DB.TBL_CARILERs.First(s => s.ID == CariID);
            txtCariAdi.Text = Cari.CARIADI;
            txtCariKodu.Text = Cari.CARIKODU;

        }

        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = Formlar.CariListesi(true);
            if (id > 0)
            {
                CariAc(id);
                AnaForm.Aktarma = -1;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtBelgeNo.Text != "")
            {
                if (Edit) Guncelle();
                else YeniCekKaydet();
            }
        }

        private void btnnSil_Click(object sender, EventArgs e)
        {
            if (Edit && CekID > 0 && Mesajlar.Sil() == DialogResult.Yes)
            {
                DB.TBL_CEKLERs.DeleteOnSubmit(DB.TBL_CEKLERs.First(s => s.ID == CekID));
                DB.TBL_CARIHAREKETLERIs.DeleteOnSubmit(DB.TBL_CARIHAREKETLERIs.First(s => s.EVRAKID == CekID && s.EVRAKTURU == "Müşteri Çeki"));
                Temizle();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtHesapNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
        }
    }
}