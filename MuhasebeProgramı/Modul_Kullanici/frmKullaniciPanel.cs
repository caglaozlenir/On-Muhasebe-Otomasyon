using DevExpress.XtraEditors;
using MuhasebeProgramı.Fonksiyon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuhasebeProgramı.Modul_Kullanici
{
    public partial class frmKullaniciPanel : DevExpress.XtraEditors.XtraForm
    {

        Fonksiyon.DataClasses1DataContext DB = new Fonksiyon.DataClasses1DataContext();
        Fonksiyon.Mesajlar Mesajlar = new Fonksiyon.Mesajlar();
        public frmKullaniciPanel()
        {
            InitializeComponent();

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                string KullaniciAdi = txtKullanici.Text;
                string Sifre = txtSifre.Text;
                var GirisKontrol = DB.TBL_GIRIs.Where(G => G.KULLANICIADI == KullaniciAdi && G.SIFRE == Sifre).FirstOrDefault();
                if (GirisKontrol != null) 
                {
                    XtraMessageBox.Show("Giriş yapıldı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AnaForm frm = new AnaForm();
                    frm.Show();
                    this.Hide();                  
                }
                else
                {
                    XtraMessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception EX)
            {
                Mesajlar.Hata(EX);
            }
        }

        private void frmKullaniciPanel_Load(object sender, EventArgs e)
        {

        }
    }
}