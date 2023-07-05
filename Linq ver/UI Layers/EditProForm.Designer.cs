namespace ADO_ver.UI_Layers
{
    partial class EditProForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ADDBUTT = new System.Windows.Forms.Button();
            this.UpdateBUTT = new System.Windows.Forms.Button();
            this.DelBUTT = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TenBox = new System.Windows.Forms.TextBox();
            this.SLBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GiaBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GiamBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LoaiBox = new System.Windows.Forms.ComboBox();
            this.NhaSXBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SpecBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CompBUTT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1238, 414);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ADDBUTT
            // 
            this.ADDBUTT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ADDBUTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDBUTT.Location = new System.Drawing.Point(269, 610);
            this.ADDBUTT.Name = "ADDBUTT";
            this.ADDBUTT.Size = new System.Drawing.Size(152, 51);
            this.ADDBUTT.TabIndex = 1;
            this.ADDBUTT.TabStop = false;
            this.ADDBUTT.Text = "ADD";
            this.ADDBUTT.UseVisualStyleBackColor = true;
            this.ADDBUTT.Click += new System.EventHandler(this.ADDBUTT_Click);
            // 
            // UpdateBUTT
            // 
            this.UpdateBUTT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UpdateBUTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBUTT.Location = new System.Drawing.Point(545, 610);
            this.UpdateBUTT.Name = "UpdateBUTT";
            this.UpdateBUTT.Size = new System.Drawing.Size(152, 51);
            this.UpdateBUTT.TabIndex = 2;
            this.UpdateBUTT.TabStop = false;
            this.UpdateBUTT.Text = "UPDATE";
            this.UpdateBUTT.UseVisualStyleBackColor = true;
            this.UpdateBUTT.Click += new System.EventHandler(this.UpdateBUTT_Click);
            // 
            // DelBUTT
            // 
            this.DelBUTT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DelBUTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelBUTT.Location = new System.Drawing.Point(829, 610);
            this.DelBUTT.Name = "DelBUTT";
            this.DelBUTT.Size = new System.Drawing.Size(152, 51);
            this.DelBUTT.TabIndex = 3;
            this.DelBUTT.TabStop = false;
            this.DelBUTT.Text = "DELETE";
            this.DelBUTT.UseVisualStyleBackColor = true;
            this.DelBUTT.Click += new System.EventHandler(this.DelBUTT_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1100, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ten SP";
            // 
            // TenBox
            // 
            this.TenBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TenBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenBox.Location = new System.Drawing.Point(93, 10);
            this.TenBox.Name = "TenBox";
            this.TenBox.Size = new System.Drawing.Size(399, 27);
            this.TenBox.TabIndex = 0;
            // 
            // SLBox
            // 
            this.SLBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SLBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SLBox.Location = new System.Drawing.Point(93, 57);
            this.SLBox.Name = "SLBox";
            this.SLBox.Size = new System.Drawing.Size(184, 27);
            this.SLBox.TabIndex = 3;
            this.SLBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SLBox_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "SL Kho";
            // 
            // GiaBox
            // 
            this.GiaBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GiaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiaBox.Location = new System.Drawing.Point(409, 57);
            this.GiaBox.Name = "GiaBox";
            this.GiaBox.Size = new System.Drawing.Size(210, 27);
            this.GiaBox.TabIndex = 4;
            this.GiaBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SLBox_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gia Tien";
            // 
            // GiamBox
            // 
            this.GiamBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GiamBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiamBox.Location = new System.Drawing.Point(780, 57);
            this.GiamBox.Name = "GiamBox";
            this.GiamBox.Size = new System.Drawing.Size(173, 27);
            this.GiamBox.TabIndex = 5;
            this.GiamBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SLBox_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(670, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Giam Gia";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(872, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nha SX";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(570, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Loai";
            // 
            // LoaiBox
            // 
            this.LoaiBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoaiBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LoaiBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoaiBox.FormattingEnabled = true;
            this.LoaiBox.Items.AddRange(new object[] {
            "Laptop",
            "Ram",
            "Mouse",
            "Speaker",
            "Phone",
            "Ipad",
            "Headphone",
            "Television",
            "Touchpen",
            "Case",
            "USB"});
            this.LoaiBox.Location = new System.Drawing.Point(635, 10);
            this.LoaiBox.Name = "LoaiBox";
            this.LoaiBox.Size = new System.Drawing.Size(200, 28);
            this.LoaiBox.TabIndex = 1;
            // 
            // NhaSXBox
            // 
            this.NhaSXBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NhaSXBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NhaSXBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhaSXBox.FormattingEnabled = true;
            this.NhaSXBox.Items.AddRange(new object[] {
            "ACER",
            "Apple",
            "ASUS",
            "GOOGLE",
            "HP",
            "JBL",
            "KINGSTON",
            "LENOVO",
            "LG",
            "LOGITECH",
            "MSI",
            "SAMSUNG",
            "SONY"});
            this.NhaSXBox.Location = new System.Drawing.Point(968, 10);
            this.NhaSXBox.Name = "NhaSXBox";
            this.NhaSXBox.Size = new System.Drawing.Size(200, 28);
            this.NhaSXBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Spec";
            // 
            // SpecBox
            // 
            this.SpecBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SpecBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecBox.Location = new System.Drawing.Point(93, 105);
            this.SpecBox.Name = "SpecBox";
            this.SpecBox.Size = new System.Drawing.Size(1156, 27);
            this.SpecBox.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CompBUTT
            // 
            this.CompBUTT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CompBUTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompBUTT.Location = new System.Drawing.Point(1117, 44);
            this.CompBUTT.Name = "CompBUTT";
            this.CompBUTT.Size = new System.Drawing.Size(132, 55);
            this.CompBUTT.TabIndex = 18;
            this.CompBUTT.Text = "ALL NhaSX";
            this.CompBUTT.UseVisualStyleBackColor = true;
            this.CompBUTT.Click += new System.EventHandler(this.CompBUTT_Click);
            // 
            // EditProForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.CompBUTT);
            this.Controls.Add(this.SpecBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NhaSXBox);
            this.Controls.Add(this.LoaiBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GiamBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GiaBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SLBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TenBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DelBUTT);
            this.Controls.Add(this.UpdateBUTT);
            this.Controls.Add(this.ADDBUTT);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EditProForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditProForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ADDBUTT;
        private System.Windows.Forms.Button UpdateBUTT;
        private System.Windows.Forms.Button DelBUTT;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TenBox;
        private System.Windows.Forms.TextBox SLBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GiaBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GiamBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox LoaiBox;
        private System.Windows.Forms.ComboBox NhaSXBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SpecBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button CompBUTT;
    }
}