
namespace OgrenciTablosuDenemesi
{
    partial class Form4
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciDataSet1 = new OgrenciTablosuDenemesi.ogrenciDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgrenciID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.leOgrenci = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ogrencitabloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colDersID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.secilenderslerTableAdapter = new OgrenciTablosuDenemesi.ogrenciDataSetTableAdapters.secilenderslerTableAdapter();
            this.ogrencitabloTableAdapter = new OgrenciTablosuDenemesi.ogrenciDataSetTableAdapters.ogrencitabloTableAdapter();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leOgrenci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencitabloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.leOgrenci});
            this.gridControl1.Size = new System.Drawing.Size(836, 321);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "secilendersler";
            this.bindingSource1.DataSource = this.ogrenciDataSet1;
            // 
            // ogrenciDataSet1
            // 
            this.ogrenciDataSet1.DataSetName = "ogrenciDataSet";
            this.ogrenciDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colOgrenciID,
            this.colDersID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 73;
            // 
            // colOgrenciID
            // 
            this.colOgrenciID.ColumnEdit = this.leOgrenci;
            this.colOgrenciID.FieldName = "OgrenciID";
            this.colOgrenciID.Name = "colOgrenciID";
            this.colOgrenciID.Visible = true;
            this.colOgrenciID.VisibleIndex = 1;
            this.colOgrenciID.Width = 157;
            // 
            // leOgrenci
            // 
            this.leOgrenci.AutoHeight = false;
            this.leOgrenci.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leOgrenci.DataSource = this.ogrencitabloBindingSource;
            this.leOgrenci.DisplayMember = "ogrenciadsoyad";
            this.leOgrenci.Name = "leOgrenci";
            this.leOgrenci.ValueMember = "ogrenciID";
            // 
            // ogrencitabloBindingSource
            // 
            this.ogrencitabloBindingSource.DataMember = "ogrencitablo";
            this.ogrencitabloBindingSource.DataSource = this.ogrenciDataSet1BindingSource;
            // 
            // ogrenciDataSet1BindingSource
            // 
            this.ogrenciDataSet1BindingSource.DataSource = this.ogrenciDataSet1;
            this.ogrenciDataSet1BindingSource.Position = 0;
            // 
            // colDersID
            // 
            this.colDersID.FieldName = "DersID";
            this.colDersID.Name = "colDersID";
            this.colDersID.Visible = true;
            this.colDersID.VisibleIndex = 2;
            this.colDersID.Width = 581;
            // 
            // secilenderslerTableAdapter
            // 
            this.secilenderslerTableAdapter.ClearBeforeFill = true;
            // 
            // ogrencitabloTableAdapter
            // 
            this.ogrencitabloTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 321);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leOgrenci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencitabloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private ogrenciDataSet ogrenciDataSet1;
        private ogrenciDataSetTableAdapters.secilenderslerTableAdapter secilenderslerTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrenciID;
        private DevExpress.XtraGrid.Columns.GridColumn colDersID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit leOgrenci;
        private System.Windows.Forms.BindingSource ogrenciDataSet1BindingSource;
        private System.Windows.Forms.BindingSource ogrencitabloBindingSource;
        private ogrenciDataSetTableAdapters.ogrencitabloTableAdapter ogrencitabloTableAdapter;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}