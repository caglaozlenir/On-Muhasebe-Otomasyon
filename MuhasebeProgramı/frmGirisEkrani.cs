using DevExpress.XtraSplashScreen;
using MuhasebeProgramı.Modul_Kullanici;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MuhasebeProgramı
{
    public partial class frmGirisEkrani : SplashScreen
    {
        public frmGirisEkrani()
        {
            InitializeComponent();
            timer1.Start();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion
        public enum SplashScreenCommand
        {
        }

        private void peImage_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelStatus_Click(object sender, EventArgs e)
        {

        }

        private void progressBarControl_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            frmKullaniciPanel Panel = new frmKullaniciPanel();
            Panel.Show();
        }

        private void frmGirisEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}