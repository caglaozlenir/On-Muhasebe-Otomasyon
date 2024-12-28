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
    public partial class frmKendiCekimiz : DevExpress.XtraEditors.XtraForm
    {

        Fonksiyon.DataClasses1DataContext DB = new Fonksiyon.DataClasses1DataContext();
        Fonksiyon.Formlar Formlar = new Fonksiyon.Formlar();
        Fonksiyon.Mesajlar Mesajlar = new Fonksiyon.Mesajlar();

        int CekID = -1;
        int BankaID = -1;
        bool Edit = false;
        public frmKendiCekimiz()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmKendiCekimiz_Load(object sender, EventArgs e)
        {
            txtVadeTarihi.Text = DateTime.Now.ToShortDateString();
        }

        void Temizle()
        {
            txtAciklama.Text = "";
            txtBanka.Text = "";
            txtBelgeNo.Text = "";
            txtCekNo.Text = "";
            txtHesapNo.Text = "";
            txtSube.Text = "";
            txtTutar.Text = "";
            txtVadeTarihi.Text = DateTime.Now.ToShortDateString();
            CekID = -1;
            BankaID = -1;
            Edit = false;
            AnaForm.Aktarma = -1;
        }

        public void Ac(int CekinIDsi)
        {
            try
            {
                CekID = CekinIDsi;
                Fonksiyon.TBL_CEKLER Cek = DB.TBL_CEKLERs.First(s => s.ID == CekID);
                BankaAc(DB.TBL_BANKALARs.First(s => s.BANKAADI == Cek.BANKA && s.HESAPNO == Cek.HESAPNO).ID);
                txtAciklama.Text = Cek.ACIKLAMA;
                txtBelgeNo.Text = Cek.BELGENO;
                txtCekNo.Text = Cek.CEKNO;
                txtTutar.Text = Cek.TUTAR.Value.ToString();
                txtVadeTarihi.Text = Cek.VADETARIHI.Value.ToShortDateString();
                Edit = true;
            }
            catch (Exception EX)
            {

                Mesajlar.Hata(EX);
                Temizle();
            }
        }
        void BankaAc(int BankaninIDsi)
        {
            try
            {
                BankaID = BankaninIDsi;
                Fonksiyon.TBL_BANKALAR Banka = DB.TBL_BANKALARs.First(s => s.ID == BankaID);
                txtBanka.Text = Banka.BANKAADI;
                txtHesapNo.Text = Banka.HESAPNO;
                txtSube.Text = Banka.SUBE;
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
                Fonksiyon.TBL_CEKLER Cek = new Fonksiyon.TBL_CEKLER();
                Cek.ACIKLAMA = txtAciklama.Text;
                Cek.ACKODU = "A";
                Cek.BELGENO = txtBelgeNo.Text;
                Cek.BANKA = txtBanka.Text;
                Cek.CEKNO = txtCekNo.Text;
                Cek.DURUMU = "Portföy";
                Cek.HESAPNO = txtHesapNo.Text;
                Cek.SUBE = txtSube.Text;
                Cek.TAHSIL = "Hayır";
                Cek.TARIH = DateTime.Now;
                Cek.TIPI = "Kendi Çekimiz";
                Cek.TUTAR = decimal.Parse(txtTutar.Text);
                Cek.VADETARIHI = DateTime.Parse(txtVadeTarihi.Text);
                Cek.SAVEUSER = AnaForm.UserID;
                Cek.SAVEDATE = DateTime.Now;
                DB.TBL_CEKLERs.InsertOnSubmit(Cek);
                DB.SubmitChanges();
                Mesajlar.YeniKayıt(txtCekNo.Text + " nolu kendi çekimizin çek kaydı yapılmıştır.");
                Fonksiyon.TBL_BANKAHAREKETLERI BankaHareket = new Fonksiyon.TBL_BANKAHAREKETLERI();
                BankaHareket.ACIKLAMA = txtCekNo + " nolu ve " + txtVadeTarihi.Text + " vadeli kendi çekiniz.";
                BankaHareket.BANKAID = BankaID;
                BankaHareket.BELGENO = txtBelgeNo.Text;
                BankaHareket.EVRAKID = Cek.ID;
                BankaHareket.EVRAKTURU = "Kendi Çekimiz";
                BankaHareket.GCKODU = "C";
                BankaHareket.TARIH = DateTime.Now;
                BankaHareket.TUTAR = 0;
                BankaHareket.SAVEUSER = AnaForm.UserID;
                BankaHareket.SAVEDATE = DateTime.Now;
                DB.TBL_BANKAHAREKETLERIs.InsertOnSubmit(BankaHareket);
                DB.SubmitChanges();
                Mesajlar.YeniKayıt(txtCekNo.Text + " nolu kendi çekimizin banka kaydı yapılmıştır.");
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
                Fonksiyon.TBL_CEKLER Cek = DB.TBL_CEKLERs.First(S => S.ID == CekID);
                Cek.ACIKLAMA = txtAciklama.Text;
                Cek.ACKODU = "A";
                Cek.BELGENO = txtBelgeNo.Text;
                Cek.BANKA = txtBanka.Text;
                Cek.CEKNO = txtCekNo.Text;
                Cek.DURUMU = "Portföy";
                Cek.HESAPNO = txtHesapNo.Text;
                Cek.SUBE = txtSube.Text;
                Cek.TAHSIL = "Hayır";
                Cek.TARIH = DateTime.Now;
                Cek.TIPI = "Kendi Çekimiz";
                Cek.TUTAR = decimal.Parse(txtTutar.Text);
                Cek.VADETARIHI = DateTime.Parse(txtVadeTarihi.Text);
                Cek.EDITUSER = AnaForm.UserID;
                Cek.EDITDATE = DateTime.Now;
                DB.SubmitChanges();
                Fonksiyon.TBL_BANKAHAREKETLERI BankaHareket = DB.TBL_BANKAHAREKETLERIs.First(S => S.EVRAKID == CekID && S.EVRAKTURU == "Kendi Çekimiz");
                BankaHareket.ACIKLAMA = txtCekNo + " nolu ve " + txtVadeTarihi.Text + " vadeli kendi çekiniz.";
                BankaHareket.BANKAID = BankaID;
                BankaHareket.BELGENO = txtBelgeNo.Text;
                BankaHareket.EVRAKID = Cek.ID;
                BankaHareket.EVRAKTURU = "Kendi Çekimiz";
                BankaHareket.GCKODU = "C";
                BankaHareket.TARIH = DateTime.Now;
                BankaHareket.TUTAR = 0;
                BankaHareket.EDITUSER = AnaForm.UserID;
                BankaHareket.EDITDATE = DateTime.Now;
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
                DB.TBL_BANKAHAREKETLERIs.DeleteOnSubmit(DB.TBL_BANKAHAREKETLERIs.First(s => s.EVRAKID == CekID && s.EVRAKTURU == "Kendi Çekimiz"));
                DB.TBL_CEKLERs.DeleteOnSubmit(DB.TBL_CEKLERs.First(s => s.ID == CekID));
                DB.SubmitChanges();
            }
            catch (Exception EX)
            {

                Mesajlar.Hata(EX);
            }
        }

        private void txtHesapNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = Formlar.BankaListesi(true);
            if (id > 0) BankaAc(id);
            AnaForm.Aktarma = -1;    
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && CekID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet ();
        }

        private void btnnSil_Click(object sender, EventArgs e)
        {
            if (Edit && CekID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}