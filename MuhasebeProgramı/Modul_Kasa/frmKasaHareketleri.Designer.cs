namespace MuhasebeProgramı.Modul_Kasa
{
    partial class frmKasaHareketleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKasaHareketleri));
            this.ACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtBakiye = new DevExpress.XtraEditors.TextEdit();
            this.txtCikis = new DevExpress.XtraEditors.TextEdit();
            this.txtGiris = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtKasaAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.GIRIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EVRAKID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EVRAKTURU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtKasaKodu = new DevExpress.XtraEditors.ButtonEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CIKIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BELGENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.DevirKartiDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.TahsilatOdemeDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.SagTik = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtBakiye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCikis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiris.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SagTik.SuspendLayout();
            this.SuspendLayout();
            // 
            // ACIKLAMA
            // 
            this.ACIKLAMA.Caption = "AÇIKLAMA";
            this.ACIKLAMA.FieldName = "ACIKLAMA";
            this.ACIKLAMA.MinWidth = 30;
            this.ACIKLAMA.Name = "ACIKLAMA";
            this.ACIKLAMA.OptionsColumn.AllowEdit = false;
            this.ACIKLAMA.OptionsColumn.AllowFocus = false;
            this.ACIKLAMA.Visible = true;
            this.ACIKLAMA.VisibleIndex = 5;
            this.ACIKLAMA.Width = 876;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(600, 44);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 19);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Bakiye :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(423, 84);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(44, 19);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Çıkış :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(423, 44);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 19);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Giriş :";
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(662, 41);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Properties.ReadOnly = true;
            this.txtBakiye.Size = new System.Drawing.Size(108, 26);
            this.txtBakiye.TabIndex = 4;
            // 
            // txtCikis
            // 
            this.txtCikis.Location = new System.Drawing.Point(482, 81);
            this.txtCikis.Name = "txtCikis";
            this.txtCikis.Properties.ReadOnly = true;
            this.txtCikis.Size = new System.Drawing.Size(108, 26);
            this.txtCikis.TabIndex = 4;
            // 
            // txtGiris
            // 
            this.txtGiris.Location = new System.Drawing.Point(482, 41);
            this.txtGiris.Name = "txtGiris";
            this.txtGiris.Properties.ReadOnly = true;
            this.txtGiris.Size = new System.Drawing.Size(108, 26);
            this.txtGiris.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 80);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 19);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Kasa Adı :";
            // 
            // txtKasaAdi
            // 
            this.txtKasaAdi.Location = new System.Drawing.Point(147, 77);
            this.txtKasaAdi.Name = "txtKasaAdi";
            this.txtKasaAdi.Properties.ReadOnly = true;
            this.txtKasaAdi.Size = new System.Drawing.Size(266, 26);
            this.txtKasaAdi.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Kasa Kodu :";
            // 
            // GIRIS
            // 
            this.GIRIS.Caption = "GİRİŞ";
            this.GIRIS.FieldName = "GIRIS";
            this.GIRIS.MinWidth = 30;
            this.GIRIS.Name = "GIRIS";
            this.GIRIS.OptionsColumn.AllowEdit = false;
            this.GIRIS.OptionsColumn.AllowFocus = false;
            this.GIRIS.OptionsColumn.FixedWidth = true;
            this.GIRIS.Visible = true;
            this.GIRIS.VisibleIndex = 3;
            this.GIRIS.Width = 140;
            // 
            // EVRAKID
            // 
            this.EVRAKID.Caption = "EVRAK ID";
            this.EVRAKID.FieldName = "EVRAKID";
            this.EVRAKID.MinWidth = 30;
            this.EVRAKID.Name = "EVRAKID";
            this.EVRAKID.Width = 112;
            // 
            // EVRAKTURU
            // 
            this.EVRAKTURU.Caption = "EVRAK TÜRÜ";
            this.EVRAKTURU.FieldName = "EVRAKTURU";
            this.EVRAKTURU.MinWidth = 30;
            this.EVRAKTURU.Name = "EVRAKTURU";
            this.EVRAKTURU.OptionsColumn.AllowEdit = false;
            this.EVRAKTURU.OptionsColumn.AllowFocus = false;
            this.EVRAKTURU.OptionsColumn.FixedWidth = true;
            this.EVRAKTURU.Visible = true;
            this.EVRAKTURU.VisibleIndex = 1;
            this.EVRAKTURU.Width = 140;
            // 
            // txtKasaKodu
            // 
            this.txtKasaKodu.Location = new System.Drawing.Point(147, 41);
            this.txtKasaKodu.Name = "txtKasaKodu";
            this.txtKasaKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtKasaKodu.Properties.ReadOnly = true;
            this.txtKasaKodu.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtKasaKodu_Properties_ButtonClick);
            this.txtKasaKodu.Size = new System.Drawing.Size(266, 26);
            this.txtKasaKodu.TabIndex = 0;
            this.txtKasaKodu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtKasaKodu_ButtonClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.EVRAKTURU,
            this.EVRAKID,
            this.GIRIS,
            this.CIKIS,
            this.ACIKLAMA,
            this.TARIH,
            this.BELGENO});
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.MinWidth = 30;
            this.ID.Name = "ID";
            this.ID.Width = 112;
            // 
            // CIKIS
            // 
            this.CIKIS.Caption = "ÇIKIŞ";
            this.CIKIS.FieldName = "CIKIS";
            this.CIKIS.MinWidth = 30;
            this.CIKIS.Name = "CIKIS";
            this.CIKIS.OptionsColumn.AllowEdit = false;
            this.CIKIS.OptionsColumn.AllowFocus = false;
            this.CIKIS.OptionsColumn.FixedWidth = true;
            this.CIKIS.Visible = true;
            this.CIKIS.VisibleIndex = 4;
            this.CIKIS.Width = 140;
            // 
            // TARIH
            // 
            this.TARIH.Caption = "TARİH";
            this.TARIH.FieldName = "TARIH";
            this.TARIH.MinWidth = 30;
            this.TARIH.Name = "TARIH";
            this.TARIH.OptionsColumn.AllowEdit = false;
            this.TARIH.OptionsColumn.AllowFocus = false;
            this.TARIH.OptionsColumn.FixedWidth = true;
            this.TARIH.Visible = true;
            this.TARIH.VisibleIndex = 2;
            this.TARIH.Width = 112;
            // 
            // BELGENO
            // 
            this.BELGENO.Caption = "BELGE NO";
            this.BELGENO.FieldName = "BELGENO";
            this.BELGENO.MinWidth = 30;
            this.BELGENO.Name = "BELGENO";
            this.BELGENO.OptionsColumn.AllowEdit = false;
            this.BELGENO.OptionsColumn.AllowFocus = false;
            this.BELGENO.OptionsColumn.FixedWidth = true;
            this.BELGENO.Visible = true;
            this.BELGENO.VisibleIndex = 0;
            this.BELGENO.Width = 112;
            // 
            // Liste
            // 
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(2, 34);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(1123, 570);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.Liste);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 173);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1127, 606);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Hareket Listesi";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtBakiye);
            this.groupControl1.Controls.Add(this.txtCikis);
            this.groupControl1.Controls.Add(this.txtGiris);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtKasaAdi);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtKasaKodu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1127, 173);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Banka Bilgileri";
            // 
            // DevirKartiDuzenle
            // 
            this.DevirKartiDuzenle.Name = "DevirKartiDuzenle";
            this.DevirKartiDuzenle.Size = new System.Drawing.Size(362, 32);
            this.DevirKartiDuzenle.Text = "Devir İşlemini Düzenle";
            this.DevirKartiDuzenle.Click += new System.EventHandler(this.DevirKartiDuzenle_Click);
            // 
            // TahsilatOdemeDuzenle
            // 
            this.TahsilatOdemeDuzenle.Name = "TahsilatOdemeDuzenle";
            this.TahsilatOdemeDuzenle.Size = new System.Drawing.Size(362, 32);
            this.TahsilatOdemeDuzenle.Text = "Tahsilat/Ödeme İşlemini Düzenle";
            this.TahsilatOdemeDuzenle.Click += new System.EventHandler(this.TahsilatOdemeDuzenle_Click);
            // 
            // SagTik
            // 
            this.SagTik.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.SagTik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DevirKartiDuzenle,
            this.TahsilatOdemeDuzenle});
            this.SagTik.Name = "SagTik";
            this.SagTik.ShowCheckMargin = true;
            this.SagTik.Size = new System.Drawing.Size(363, 102);
            this.SagTik.Opening += new System.ComponentModel.CancelEventHandler(this.SagTik_Opening);
            this.SagTik.VisibleChanged += new System.EventHandler(this.SagTik_VisibleChanged);
            this.SagTik.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // frmKasaHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 779);
            this.ContextMenuStrip = this.SagTik;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmKasaHareketleri.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKasaHareketleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Hareketleri";
            this.Load += new System.EventHandler(this.frmKasaHareketleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBakiye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCikis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiris.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.SagTik.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn ACIKLAMA;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtBakiye;
        private DevExpress.XtraEditors.TextEdit txtCikis;
        private DevExpress.XtraEditors.TextEdit txtGiris;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtKasaAdi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn GIRIS;
        private DevExpress.XtraGrid.Columns.GridColumn EVRAKID;
        private DevExpress.XtraGrid.Columns.GridColumn EVRAKTURU;
        private DevExpress.XtraEditors.ButtonEdit txtKasaKodu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn CIKIS;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Columns.GridColumn TARIH;
        private DevExpress.XtraGrid.Columns.GridColumn BELGENO;
        private System.Windows.Forms.ToolStripMenuItem DevirKartiDuzenle;
        private System.Windows.Forms.ToolStripMenuItem TahsilatOdemeDuzenle;
        private System.Windows.Forms.ContextMenuStrip SagTik;
    }
}