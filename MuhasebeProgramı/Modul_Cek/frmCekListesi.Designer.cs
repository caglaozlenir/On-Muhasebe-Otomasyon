namespace MuhasebeProgramı.Modul_Cek
{
    partial class frmCekListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCekListesi));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.txtBanka = new DevExpress.XtraEditors.TextEdit();
            this.labelBanka = new DevExpress.XtraEditors.LabelControl();
            this.txtCekNo = new DevExpress.XtraEditors.TextEdit();
            this.labelCekNo = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCekTuru = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BANKA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CEKNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TIPI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kaybolanid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kaybolanstokkodu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.Liste);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1730, 797);
            this.splitContainerControl1.SplitterPosition = 314;
            this.splitContainerControl1.TabIndex = 3;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(309, 797);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnSil);
            this.xtraTabPage1.Controls.Add(this.btnAra);
            this.xtraTabPage1.Controls.Add(this.txtBanka);
            this.xtraTabPage1.Controls.Add(this.labelBanka);
            this.xtraTabPage1.Controls.Add(this.txtCekNo);
            this.xtraTabPage1.Controls.Add(this.labelCekNo);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.txtCekTuru);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(307, 762);
            this.xtraTabPage1.Text = "Arama";
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = global::MuhasebeProgramı.Properties.Resources.Sil32x32;
            this.btnSil.Location = new System.Drawing.Point(146, 242);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(128, 60);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Temizle";
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.Image = global::MuhasebeProgramı.Properties.Resources.Ara32x32;
            this.btnAra.Location = new System.Drawing.Point(12, 242);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(128, 60);
            this.btnAra.TabIndex = 6;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtBanka
            // 
            this.txtBanka.Location = new System.Drawing.Point(11, 191);
            this.txtBanka.Name = "txtBanka";
            this.txtBanka.Size = new System.Drawing.Size(254, 26);
            this.txtBanka.TabIndex = 5;
            // 
            // labelBanka
            // 
            this.labelBanka.Location = new System.Drawing.Point(11, 166);
            this.labelBanka.Name = "labelBanka";
            this.labelBanka.Size = new System.Drawing.Size(53, 19);
            this.labelBanka.TabIndex = 4;
            this.labelBanka.Text = "Bankası";
            // 
            // txtCekNo
            // 
            this.txtCekNo.Location = new System.Drawing.Point(11, 125);
            this.txtCekNo.Name = "txtCekNo";
            this.txtCekNo.Size = new System.Drawing.Size(254, 26);
            this.txtCekNo.TabIndex = 3;
            // 
            // labelCekNo
            // 
            this.labelCekNo.Location = new System.Drawing.Point(11, 100);
            this.labelCekNo.Name = "labelCekNo";
            this.labelCekNo.Size = new System.Drawing.Size(98, 19);
            this.labelCekNo.TabIndex = 2;
            this.labelCekNo.Text = "Çek Numarası";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Çek Türü";
            // 
            // txtCekTuru
            // 
            this.txtCekTuru.EditValue = "Kendi Çekimiz";
            this.txtCekTuru.Location = new System.Drawing.Point(11, 59);
            this.txtCekTuru.Name = "txtCekTuru";
            this.txtCekTuru.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCekTuru.Properties.Items.AddRange(new object[] {
            "Kendi Çekimiz",
            "Müşteri Çeki"});
            this.txtCekTuru.Size = new System.Drawing.Size(254, 26);
            this.txtCekTuru.TabIndex = 1;
            // 
            // Liste
            // 
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.MainView = this.gridView1;
            this.Liste.Margin = new System.Windows.Forms.Padding(4);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(1401, 797);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.BANKA,
            this.CEKNO,
            this.TIPI});
            this.gridView1.DetailHeight = 512;
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 1200;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.MinWidth = 30;
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.AllowFocus = false;
            this.ID.Width = 112;
            // 
            // BANKA
            // 
            this.BANKA.Caption = "BANKA";
            this.BANKA.FieldName = "BANKA";
            this.BANKA.MinWidth = 30;
            this.BANKA.Name = "BANKA";
            this.BANKA.OptionsColumn.AllowEdit = false;
            this.BANKA.OptionsColumn.AllowFocus = false;
            this.BANKA.OptionsColumn.FixedWidth = true;
            this.BANKA.Visible = true;
            this.BANKA.VisibleIndex = 0;
            this.BANKA.Width = 112;
            // 
            // CEKNO
            // 
            this.CEKNO.Caption = "ÇEK NUMARASI";
            this.CEKNO.FieldName = "CEKNO";
            this.CEKNO.MinWidth = 30;
            this.CEKNO.Name = "CEKNO";
            this.CEKNO.OptionsColumn.AllowEdit = false;
            this.CEKNO.OptionsColumn.AllowFocus = false;
            this.CEKNO.OptionsColumn.FixedWidth = true;
            this.CEKNO.Visible = true;
            this.CEKNO.VisibleIndex = 1;
            this.CEKNO.Width = 112;
            // 
            // TIPI
            // 
            this.TIPI.Caption = "ÇEK TÜRÜ";
            this.TIPI.FieldName = "TIPI";
            this.TIPI.MinWidth = 30;
            this.TIPI.Name = "TIPI";
            this.TIPI.OptionsColumn.AllowEdit = false;
            this.TIPI.OptionsColumn.AllowFocus = false;
            this.TIPI.OptionsColumn.FixedWidth = true;
            this.TIPI.Visible = true;
            this.TIPI.VisibleIndex = 2;
            this.TIPI.Width = 112;
            // 
            // kaybolanid
            // 
            this.kaybolanid.Caption = "ID";
            this.kaybolanid.FieldName = "kaybolanid";
            this.kaybolanid.MinWidth = 30;
            this.kaybolanid.Name = "kaybolanid";
            this.kaybolanid.Width = 112;
            // 
            // kaybolanstokkodu
            // 
            this.kaybolanstokkodu.Caption = "STOKKODU";
            this.kaybolanstokkodu.FieldName = "kaybolanstokkodu";
            this.kaybolanstokkodu.MinWidth = 30;
            this.kaybolanstokkodu.Name = "kaybolanstokkodu";
            this.kaybolanstokkodu.OptionsColumn.AllowEdit = false;
            this.kaybolanstokkodu.OptionsColumn.AllowFocus = false;
            this.kaybolanstokkodu.OptionsColumn.FixedWidth = true;
            this.kaybolanstokkodu.Visible = true;
            this.kaybolanstokkodu.VisibleIndex = 0;
            this.kaybolanstokkodu.Width = 112;
            // 
            // frmCekListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1730, 797);
            this.Controls.Add(this.splitContainerControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmCekListesi.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCekListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çek Listesi";
            this.Load += new System.EventHandler(this.frmCekListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.TextEdit txtBanka;
        private DevExpress.XtraEditors.LabelControl labelBanka;
        private DevExpress.XtraEditors.TextEdit txtCekNo;
        private DevExpress.XtraEditors.LabelControl labelCekNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn BANKA;
        private DevExpress.XtraGrid.Columns.GridColumn CEKNO;
        private DevExpress.XtraGrid.Columns.GridColumn kaybolanid;
        private DevExpress.XtraGrid.Columns.GridColumn kaybolanstokkodu;
        private DevExpress.XtraEditors.ComboBoxEdit txtCekTuru;
        private DevExpress.XtraGrid.Columns.GridColumn TIPI;
    }
}