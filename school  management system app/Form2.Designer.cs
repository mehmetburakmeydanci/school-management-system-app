
namespace OgrenciTablosuDenemesi
{
    partial class Form2
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnKaydetKapat = new DevExpress.XtraBars.BarButtonItem();
            this.btnKapat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciDataSet = new OgrenciTablosuDenemesi.ogrenciDataSet();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtBolum = new DevExpress.XtraEditors.TextEdit();
            this.txtOkul = new DevExpress.XtraEditors.TextEdit();
            this.txtNumara = new DevExpress.XtraEditors.TextEdit();
            this.txtAdSoyad = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lyNumara = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyAdSoyad = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyOkulu = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyBolumu = new DevExpress.XtraLayout.LayoutControlItem();
            this.ogrencitabloTableAdapter = new OgrenciTablosuDenemesi.ogrenciDataSetTableAdapters.ogrencitabloTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBolum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOkul.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumara.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyNumara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyAdSoyad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyOkulu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyBolumu)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnKaydetKapat,
            this.btnKapat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnKaydetKapat),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnKapat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnKaydetKapat
            // 
            this.btnKaydetKapat.Caption = "Kaydet ve Kapat";
            this.btnKaydetKapat.Id = 0;
            this.btnKaydetKapat.Name = "btnKaydetKapat";
            this.btnKaydetKapat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKaydetKapat_ItemClick);
            // 
            // btnKapat
            // 
            this.btnKapat.Caption = "Kapat";
            this.btnKapat.Id = 1;
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKapat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 170);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 150);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 150);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "ogrencitablo";
            this.bindingSource1.DataSource = this.ogrenciDataSet;
            // 
            // ogrenciDataSet
            // 
            this.ogrenciDataSet.DataSetName = "ogrenciDataSet";
            this.ogrenciDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtBolum);
            this.layoutControl1.Controls.Add(this.txtOkul);
            this.layoutControl1.Controls.Add(this.txtNumara);
            this.layoutControl1.Controls.Add(this.txtAdSoyad);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 20);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(800, 150);
            this.layoutControl1.TabIndex = 23;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtBolum
            // 
            this.txtBolum.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "ogrencibolum", true));
            this.txtBolum.Location = new System.Drawing.Point(74, 84);
            this.txtBolum.MenuManager = this.barManager1;
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Size = new System.Drawing.Size(714, 20);
            this.txtBolum.StyleController = this.layoutControl1;
            this.txtBolum.TabIndex = 5;
            // 
            // txtOkul
            // 
            this.txtOkul.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "ogrenciokul", true));
            this.txtOkul.Location = new System.Drawing.Point(74, 60);
            this.txtOkul.MenuManager = this.barManager1;
            this.txtOkul.Name = "txtOkul";
            this.txtOkul.Size = new System.Drawing.Size(714, 20);
            this.txtOkul.StyleController = this.layoutControl1;
            this.txtOkul.TabIndex = 4;
            // 
            // txtNumara
            // 
            this.txtNumara.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "ogrencinumara", true));
            this.txtNumara.Location = new System.Drawing.Point(74, 12);
            this.txtNumara.MenuManager = this.barManager1;
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(714, 20);
            this.txtNumara.StyleController = this.layoutControl1;
            this.txtNumara.TabIndex = 2;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "ogrenciadsoyad", true));
            this.txtAdSoyad.Location = new System.Drawing.Point(74, 36);
            this.txtAdSoyad.MenuManager = this.barManager1;
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(714, 20);
            this.txtAdSoyad.StyleController = this.layoutControl1;
            this.txtAdSoyad.TabIndex = 3;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.lyNumara,
            this.lyAdSoyad,
            this.lyOkulu,
            this.lyBolumu});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 150);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 96);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(780, 34);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lyNumara
            // 
            this.lyNumara.Control = this.txtNumara;
            this.lyNumara.Location = new System.Drawing.Point(0, 0);
            this.lyNumara.Name = "lyNumara";
            this.lyNumara.Size = new System.Drawing.Size(780, 24);
            this.lyNumara.Text = "Numarası";
            this.lyNumara.TextSize = new System.Drawing.Size(50, 13);
            // 
            // lyAdSoyad
            // 
            this.lyAdSoyad.Control = this.txtAdSoyad;
            this.lyAdSoyad.Location = new System.Drawing.Point(0, 24);
            this.lyAdSoyad.Name = "lyAdSoyad";
            this.lyAdSoyad.Size = new System.Drawing.Size(780, 24);
            this.lyAdSoyad.Text = "Adı Soyadı";
            this.lyAdSoyad.TextSize = new System.Drawing.Size(50, 13);
            // 
            // lyOkulu
            // 
            this.lyOkulu.Control = this.txtOkul;
            this.lyOkulu.Location = new System.Drawing.Point(0, 48);
            this.lyOkulu.Name = "lyOkulu";
            this.lyOkulu.Size = new System.Drawing.Size(780, 24);
            this.lyOkulu.Text = "Okulu";
            this.lyOkulu.TextSize = new System.Drawing.Size(50, 13);
            // 
            // lyBolumu
            // 
            this.lyBolumu.Control = this.txtBolum;
            this.lyBolumu.Location = new System.Drawing.Point(0, 72);
            this.lyBolumu.Name = "lyBolumu";
            this.lyBolumu.Size = new System.Drawing.Size(780, 24);
            this.lyBolumu.Text = "Bölümü";
            this.lyBolumu.TextSize = new System.Drawing.Size(50, 13);
            // 
            // ogrencitabloTableAdapter
            // 
            this.ogrencitabloTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 170);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBolum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOkul.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumara.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyNumara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyAdSoyad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyOkulu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyBolumu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnKaydetKapat;
        private DevExpress.XtraBars.BarButtonItem btnKapat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.TextEdit txtBolum;
        private DevExpress.XtraEditors.TextEdit txtOkul;
        private DevExpress.XtraEditors.TextEdit txtAdSoyad;
        private DevExpress.XtraEditors.TextEdit txtNumara;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem lyNumara;
        private DevExpress.XtraLayout.LayoutControlItem lyAdSoyad;
        private DevExpress.XtraLayout.LayoutControlItem lyOkulu;
        private DevExpress.XtraLayout.LayoutControlItem lyBolumu;
        private System.Windows.Forms.BindingSource bindingSource1;
        private ogrenciDataSet ogrenciDataSet;
        private ogrenciDataSetTableAdapters.ogrencitabloTableAdapter ogrencitabloTableAdapter;
    }
}