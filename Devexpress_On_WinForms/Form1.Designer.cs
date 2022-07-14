namespace Devexpress_On_WinForms
{
    partial class Form1
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumer_zamowienia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colopis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnazwa_klienta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewOnWinFormsDataSet2 = new Devexpress_On_WinForms.GridViewOnWinFormsDataSet2();
            this.zamowieniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zamowieniaTableAdapter = new Devexpress_On_WinForms.GridViewOnWinFormsDataSet2TableAdapters.zamowieniaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOnWinFormsDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.zamowieniaBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 450);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colnumer_zamowienia,
            this.colopis,
            this.colnazwa_klienta});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colnumer_zamowienia
            // 
            this.colnumer_zamowienia.FieldName = "numer_zamowienia";
            this.colnumer_zamowienia.Name = "colnumer_zamowienia";
            this.colnumer_zamowienia.Visible = true;
            this.colnumer_zamowienia.VisibleIndex = 1;
            // 
            // colopis
            // 
            this.colopis.FieldName = "opis";
            this.colopis.Name = "colopis";
            this.colopis.Visible = true;
            this.colopis.VisibleIndex = 2;
            // 
            // colnazwa_klienta
            // 
            this.colnazwa_klienta.FieldName = "nazwa_klienta";
            this.colnazwa_klienta.Name = "colnazwa_klienta";
            this.colnazwa_klienta.Visible = true;
            this.colnazwa_klienta.VisibleIndex = 3;
            // 
            // gridViewOnWinFormsDataSet2
            // 
            this.gridViewOnWinFormsDataSet2.DataSetName = "GridViewOnWinFormsDataSet2";
            this.gridViewOnWinFormsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zamowieniaBindingSource
            // 
            this.zamowieniaBindingSource.DataMember = "zamowienia";
            this.zamowieniaBindingSource.DataSource = this.gridViewOnWinFormsDataSet2;
            // 
            // zamowieniaTableAdapter
            // 
            this.zamowieniaTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Devexpress On WinForms";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOnWinFormsDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colnumer_zamowienia;
        private DevExpress.XtraGrid.Columns.GridColumn colopis;
        private DevExpress.XtraGrid.Columns.GridColumn colnazwa_klienta;
        private GridViewOnWinFormsDataSet2 gridViewOnWinFormsDataSet2;
        private System.Windows.Forms.BindingSource zamowieniaBindingSource;
        private GridViewOnWinFormsDataSet2TableAdapters.zamowieniaTableAdapter zamowieniaTableAdapter;
    }
}

