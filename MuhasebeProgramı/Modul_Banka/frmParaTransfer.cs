using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Design;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuhasebeProgramı.Modul_Banka
{
    public partial class frmParaTransfer : DevExpress.XtraEditors.XtraForm
    {

        Fonksiyon.DataClasses1DataContext DB = new Fonksiyon.DataClasses1DataContext();
        Fonksiyon.Mesajlar Mesajlar = new Fonksiyon.Mesajlar();
        Fonksiyon.Formlar Formlar = new Fonksiyon.Formlar();


        bool Edit = false;
        int BankaID = -1;
        int CariID = -1;
        int IslemID = -1;
        public frmParaTransfer()
        {
            InitializeComponent();
        }

        private void frmParaTransfer_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void txtTransferTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtTransferTuru.SelectedIndex == 0)
            {
                rbtnGelen.Text = "Gelen Havale";
                rbtnGiden.Text = "Giden Havale";
            }
            else if (txtTransferTuru.SelectedIndex == 1)
            {
                rbtnGelen.Text = "Gelen EFT";
                rbtnGiden.Text = "Giden EFT";
            }
        }

        void Temizle()
        {
            txtAciklama.Text = "";
            txtBelgeNo.Text = "";
            txtCariAdi.Text = "";
            txtCariKodu.Text = "";
            txtHesapAdi.Text = "";
            txtHesapNo.Text = "";
            txtTransferTuru.SelectedIndex = 0;
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtTutar.Text = "0";
            Edit = false;
            BankaID = -1;
            CariID = -1;
            IslemID = -1;
            AnaForm.Aktarma = -1;
        }

        public void Ac(int ID)
        {
            try
            {
                Edit = true;
                IslemID = ID;
                Fonksiyon.TBL_BANKAHAREKETLERI Banka = DB.TBL_BANKAHAREKETLERIs.First(s => s.ID == IslemID);
                BankaAc(Banka.BANKAID.Value);
                CariAc(Banka.CARIID.Value);
                txtAciklama.Text = Banka.ACIKLAMA;
                txtBelgeNo.Text = Banka.BELGENO;
                if (Banka.EVRAKTURU == "Banka Havalesi") txtTransferTuru.SelectedIndex = 0;
                if (Banka.EVRAKTURU == "Banka EFT") txtTransferTuru.SelectedIndex = 1;
                txtTarih.Text = Banka.TARIH.Value.ToShortDateString();
                // txtTransferTuru.Text = Banka.EVRAKTURU;
                txtTutar.Text = Banka.TUTAR.ToString();
                if (Banka.GCKODU == "G") rbtnGelen.Checked = true;
                if (Banka.GCKODU == "C") rbtnGiden.Checked = true;


            }
            catch (Exception e)
            {
                Temizle();
                Mesajlar.Hata(e);
            }
        }

        void BankaAc(int ID)
        {
            try
            {
                BankaID = ID;
                txtHesapAdi.Text = DB.TBL_BANKALARs.First(s => s.ID == BankaID).HESAPADI;
                txtHesapNo.Text = DB.TBL_BANKALARs.First(s => s.ID == BankaID).HESAPNO;

            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void CariAc(int ID)
        {
            try
            {
                CariID = ID;
                txtCariKodu.Text = DB.TBL_CARILERs.First(s => s.ID == CariID).CARIKODU;
                txtCariAdi.Text = DB.TBL_CARILERs.First(s => s.ID == CariID).CARIADI;
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyon.TBL_BANKAHAREKETLERI Banka = new Fonksiyon.TBL_BANKAHAREKETLERI();
                Banka.ACIKLAMA = txtAciklama.Text;
                Banka.BANKAID = BankaID;
                Banka.BELGENO = txtBelgeNo.Text;
                Banka.CARIID = CariID;
                Banka.EVRAKTURU = txtTransferTuru.SelectedItem.ToString();
                if (rbtnGelen.Checked) Banka.GCKODU = "G";
                if (rbtnGiden.Checked) Banka.GCKODU = "C";
                Banka.TARIH = DateTime.Parse(txtTarih.Text);
                Banka.TUTAR = decimal.Parse(txtTutar.Text);
                Banka.SAVEDATE = DateTime.Now;
                Banka.SAVEUSER = AnaForm.UserID;
                DB.TBL_BANKAHAREKETLERIs.InsertOnSubmit(Banka);
                DB.SubmitChanges();
                Fonksiyon.TBL_CARIHAREKETLERI Cari = new Fonksiyon.TBL_CARIHAREKETLERI();
                Cari.ACIKLAMA = txtAciklama.Text;
                if (rbtnGelen.Checked) Cari.ALACAK = decimal.Parse(txtTutar.Text);
                if (rbtnGiden.Checked) Cari.BORC = decimal.Parse(txtTutar.Text);
                Cari.CARIID = CariID;
                Cari.EVRAKID = Banka.ID;
                Cari.EVRAKTURU = txtTransferTuru.SelectedItem.ToString();
                Cari.TARIH = DateTime.Parse(txtTarih.Text);
                if (txtTransferTuru.SelectedIndex == 0) Cari.TIPI = "BH";
                if (txtTransferTuru.SelectedIndex == 1) Cari.TIPI = "EFT";
                Cari.SAVEDATE = DateTime.Now;
                Cari.SAVEUSER = AnaForm.UserID;
                DB.TBL_CARIHAREKETLERIs.InsertOnSubmit(Cari);
                DB.SubmitChanges();
                Mesajlar.YeniKayıt("Para transfer kaydı işlendi.");
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
                Fonksiyon.TBL_BANKAHAREKETLERI Banka = DB.TBL_BANKAHAREKETLERIs.First(s => s.ID == IslemID);
                Banka.ACIKLAMA = txtAciklama.Text;
                Banka.BANKAID = BankaID;
                Banka.BELGENO = txtBelgeNo.Text;
                Banka.CARIID = CariID;
                Banka.EVRAKTURU = txtTransferTuru.SelectedItem.ToString();
                if (rbtnGelen.Checked) Banka.GCKODU = "G";
                if (rbtnGiden.Checked) Banka.GCKODU = "C";
                Banka.TARIH = DateTime.Parse(txtTarih.Text);
                Banka.TUTAR = decimal.Parse(txtTutar.Text);
                Banka.EDITDATE = DateTime.Now;
                Banka.EDITUSER = AnaForm.UserID;
                DB.SubmitChanges();
                Fonksiyon.TBL_CARIHAREKETLERI Cari = DB.TBL_CARIHAREKETLERIs.First(s => s.EVRAKTURU == txtTransferTuru.SelectedItem.ToString() && s.EVRAKID == IslemID);
                Cari.ACIKLAMA = txtAciklama.Text;
                if (rbtnGelen.Checked) Cari.ALACAK = decimal.Parse(txtTutar.Text);
                if (rbtnGiden.Checked) Cari.BORC = decimal.Parse(txtTutar.Text);
                Cari.CARIID = CariID;
                Cari.EVRAKID = Banka.ID;
                Cari.EVRAKTURU = txtTransferTuru.SelectedItem.ToString();
                Cari.TARIH = DateTime.Parse(txtTarih.Text);
                if (txtTransferTuru.SelectedIndex == 0) Cari.TIPI = "BH";
                if (txtTransferTuru.SelectedIndex == 1) Cari.TIPI = "EFT";
                Cari.EDITDATE = DateTime.Now;
                Cari.EDITUSER = AnaForm.UserID;
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
                DB.TBL_CARIHAREKETLERIs.DeleteOnSubmit(DB.TBL_CARIHAREKETLERIs.First(s => s.EVRAKTURU == txtTransferTuru.SelectedItem.ToString() && s.EVRAKID == IslemID));
                DB.TBL_BANKAHAREKETLERIs.DeleteOnSubmit(DB.TBL_BANKAHAREKETLERIs.First(s => s.ID == IslemID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        private void txtHesapAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.BankaListesi(true);
            if (Id > 0) BankaAc(Id);
            AnaForm.Aktarma = -1;
        }

        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.CariListesi(true);
            if (Id > 0) CariAc(Id);
            AnaForm.Aktarma = -1;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && BankaID > 0 && IslemID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && BankaID > 0 && IslemID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}