﻿namespace ADO_ver.UI_Layers
{
    partial class CartForm2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ADDBUT = new System.Windows.Forms.Button();
            this.MinusBUTT = new System.Windows.Forms.Button();
            this.DELBUTT = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(574, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gio Hang";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(13, 41);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1237, 561);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ADDBUT
            // 
            this.ADDBUT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ADDBUT.BackgroundImage = global::ADO_ver.Properties.Resources.plus;
            this.ADDBUT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ADDBUT.Location = new System.Drawing.Point(336, 608);
            this.ADDBUT.Name = "ADDBUT";
            this.ADDBUT.Size = new System.Drawing.Size(152, 53);
            this.ADDBUT.TabIndex = 2;
            this.ADDBUT.UseVisualStyleBackColor = true;
            this.ADDBUT.Click += new System.EventHandler(this.ADDBUT_Click);
            // 
            // MinusBUTT
            // 
            this.MinusBUTT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MinusBUTT.BackgroundImage = global::ADO_ver.Properties.Resources.minus;
            this.MinusBUTT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinusBUTT.Location = new System.Drawing.Point(560, 608);
            this.MinusBUTT.Name = "MinusBUTT";
            this.MinusBUTT.Size = new System.Drawing.Size(152, 53);
            this.MinusBUTT.TabIndex = 3;
            this.MinusBUTT.UseVisualStyleBackColor = true;
            this.MinusBUTT.Click += new System.EventHandler(this.MinusBUTT_Click);
            // 
            // DELBUTT
            // 
            this.DELBUTT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DELBUTT.BackgroundImage = global::ADO_ver.Properties.Resources.bin;
            this.DELBUTT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DELBUTT.Location = new System.Drawing.Point(785, 608);
            this.DELBUTT.Name = "DELBUTT";
            this.DELBUTT.Size = new System.Drawing.Size(152, 53);
            this.DELBUTT.TabIndex = 4;
            this.DELBUTT.UseVisualStyleBackColor = true;
            this.DELBUTT.Click += new System.EventHandler(this.DELBUTT_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(999, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CartForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DELBUTT);
            this.Controls.Add(this.MinusBUTT);
            this.Controls.Add(this.ADDBUT);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "CartForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CartForm2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ADDBUT;
        private System.Windows.Forms.Button MinusBUTT;
        private System.Windows.Forms.Button DELBUTT;
        private System.Windows.Forms.TextBox textBox1;
    }
}