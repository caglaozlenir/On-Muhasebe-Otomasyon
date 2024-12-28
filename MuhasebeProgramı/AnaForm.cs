using DevExpress.XtraBars;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MuhasebeProgramı
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Fonksiyon.Formlar Formlar = new Fonksiyon.Formlar();

        public static Fonksiyon.TBL_KULLANICILAR Kullanici;
        public static int UserID = -1;
        public static int Aktarma = -1;
        public AnaForm()
        {
            InitializeComponent();
        }

        public AnaForm(Fonksiyon.TBL_KULLANICILAR GelenKullanici)
        {
            InitializeComponent();
            Kullanici = GelenKullanici;
            UserID = Kullanici.ID;
            txtAltKullanici.Caption = Kullanici.KULLANICI;
            if(Kullanici.KODU == "Normal")
            {
                barBtnKullanici.Visibility = BarItemVisibility.Never;
            }
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }
        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        public void Mesaj(string Baslik, string Mesaj)
        {
            ALC.Show(this, Baslik, Mesaj);
        }

        private void AnaForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {

        }

        #region Stok_Butonları

        private void barBtnStokKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokKarti();
        }
        private void barBtnStokListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokListesi();
        }
        private void barBtnStokGruplari_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokGrupları();
        }
        private void barBtnStokHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokHareketleri();
        }
        private void navBtnStokKarti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.StokKarti();
        }

        private void navBtnStokListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.StokListesi();
        }

        private void navBtnStokGruplari_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.StokGrupları();
        }

        private void navBtnStokHareketleri_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.StokHareketleri();
        }

        #endregion

        #region Cari_Butonları

        private void barBtnCariAcilisKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CariAcilisKarti();
        }
        private void barBtnCariGruplari_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CariGruplari();
        }
        private void barBtnCariListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CariListesi();
        }
        private void barBtnCariHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        private void navBtnCariListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.CariListesi();
        }

        private void navBtnCariGruplari_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.CariGruplari();
        }

        private void navBtnCariAcilisKarti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.CariAcilisKarti();
        }

        private void navBtnCariHareketleri_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }
#endregion

        #region Kasa_Butonları

        private void barBtnKasaAcilisKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KasaAcilisKarti();
        }

        private void barBtnKasaDevirIslemKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KasaDevirIslemKarti();
        }

        private void barBtnKasaListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KasaListesi();
        }

        private void barBtnKasaTahsilatOdeme_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KasaTahsilatOdemeKarti();
        }

        private void barBtnKasaHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KasaHareketleri();
        }

        private void navBtnKasaListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.KasaListesi();
        }

        private void navBtnKasaAcilisKarti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.BankaAcilisKarti();
        }

        private void navBtnKasaHareketleri_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.KasaHareketleri();
        }

        private void navBtnKasaDevirIslemKarti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.KasaDevirIslemKarti();
        }

        private void navBtnKasaTahsilatOdeme_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.KasaTahsilatOdemeKarti();
        }
        #endregion Kasa_Butonları

        #region Banka_Butonları

        private void barBtnBankaAcilisKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.BankaAcilisKarti();
        }

        private void barBtnBankaİslemi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.BankaIslem();
        }

        private void barBtnBankaListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.BankaListesi();
        }

        private void barBtnParaTransferi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.BankaParaTransfer();
        }

        private void barBtnBankaHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.BankaHareketleri();
        }

        private void navBarControl2_Click(object sender, EventArgs e)
        {

        }
        private void navBtnBankaIslemi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.BankaIslem();
        }

        private void navBtnBankaListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.BankaListesi();
        }

        private void navBtnParaTransferi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.BankaParaTransfer();
        }

        private void navBtnBankaAcilisKarti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.BankaAcilisKarti();
        }

        private void navBtnBankaHareketleri_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.BankaHareketleri();
        }
        #endregion

        #region Çek_Butonları
        private void barBtnMusteriCeki_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.MusteriCeki();
        }

        private void barBtnKendiCekimiz_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KendiCekimiz();
        }

        private void barBtnBankayaCekCikisi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.BankayaCekCikisi();
        }

        private void barBtnCariyeCekCikisi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CariyeCekCikisi();
        }

        private void barBtnCekListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CekListesi();
        }

        #endregion
       

        private void barBtnSatisFaturasi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.Fatura();
        }

        private void barBtnSatisIadeFaturasi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.FaturaListesi();
        }

        private void barBtnKullanici_ItemClick(object sender, ItemClickEventArgs e)
        {
        }
    }
}