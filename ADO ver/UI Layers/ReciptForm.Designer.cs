namespace ADO_ver.UI_Layers
{
    partial class ReciptForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.GioHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dIENTUDataSet1 = new ADO_ver.DIENTUDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TTButt = new System.Windows.Forms.Button();
            this.dataTable1TableAdapter = new ADO_ver.DIENTUDataSetTableAdapters.DataTable1TableAdapter();
            this.gioHangTableAdapter = new ADO_ver.DIENTUDataSetTableAdapters.GioHangTableAdapter();
            this.dIENTUDataSet = new ADO_ver.DIENTUDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.GioHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIENTUDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIENTUDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // GioHangBindingSource
            // 
            this.GioHangBindingSource.DataMember = "DataTable1";
            this.GioHangBindingSource.DataSource = this.dIENTUDataSet1;
            // 
            // dIENTUDataSet1
            // 
            this.dIENTUDataSet1.DataSetName = "DIENTUDataSet";
            this.dIENTUDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "GioHang";
            reportDataSource1.Value = this.GioHangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ADO_ver.Report.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(783, 589);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // TTButt
            // 
            this.TTButt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TTButt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.TTButt.FlatAppearance.BorderSize = 0;
            this.TTButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TTButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTButt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TTButt.Location = new System.Drawing.Point(279, 607);
            this.TTButt.Name = "TTButt";
            this.TTButt.Size = new System.Drawing.Size(234, 58);
            this.TTButt.TabIndex = 2;
            this.TTButt.TabStop = false;
            this.TTButt.Text = "Thanh Toan";
            this.TTButt.UseVisualStyleBackColor = false;
            this.TTButt.Click += new System.EventHandler(this.TTButt_Click);
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // gioHangTableAdapter
            // 
            this.gioHangTableAdapter.ClearBeforeFill = true;
            // 
            // dIENTUDataSet
            // 
            this.dIENTUDataSet.DataSetName = "DIENTUDataSet";
            this.dIENTUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReciptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 673);
            this.Controls.Add(this.TTButt);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "ReciptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReciptForm";
            this.Load += new System.EventHandler(this.ReciptForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GioHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIENTUDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIENTUDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button TTButt;
        private System.Windows.Forms.BindingSource GioHangBindingSource;
        private DIENTUDataSet dIENTUDataSet1;
        private DIENTUDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private DIENTUDataSetTableAdapters.GioHangTableAdapter gioHangTableAdapter;
        private DIENTUDataSet dIENTUDataSet;
    }
}