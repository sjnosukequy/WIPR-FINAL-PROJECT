namespace ADO_ver.UI_Layers
{
    partial class UserForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FNameBox = new System.Windows.Forms.TextBox();
            this.UNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddrBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EditBUTT = new System.Windows.Forms.Button();
            this.SaveBUTT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImage = global::ADO_ver.Properties.Resources.user;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(242, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 171);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "FULL NAME";
            // 
            // FNameBox
            // 
            this.FNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNameBox.Location = new System.Drawing.Point(12, 244);
            this.FNameBox.Name = "FNameBox";
            this.FNameBox.Size = new System.Drawing.Size(299, 27);
            this.FNameBox.TabIndex = 2;
            // 
            // UNameBox
            // 
            this.UNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UNameBox.Location = new System.Drawing.Point(12, 329);
            this.UNameBox.Name = "UNameBox";
            this.UNameBox.Size = new System.Drawing.Size(299, 27);
            this.UNameBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "USER NAME";
            // 
            // PassBox
            // 
            this.PassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassBox.Location = new System.Drawing.Point(389, 329);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(294, 27);
            this.PassBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(385, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "PASSWORD";
            // 
            // AddrBox
            // 
            this.AddrBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddrBox.Location = new System.Drawing.Point(16, 417);
            this.AddrBox.Name = "AddrBox";
            this.AddrBox.Size = new System.Drawing.Size(667, 27);
            this.AddrBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "ADDRESS";
            // 
            // EditBUTT
            // 
            this.EditBUTT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EditBUTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBUTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBUTT.Location = new System.Drawing.Point(119, 493);
            this.EditBUTT.Name = "EditBUTT";
            this.EditBUTT.Size = new System.Drawing.Size(145, 51);
            this.EditBUTT.TabIndex = 9;
            this.EditBUTT.Text = "EDIT";
            this.EditBUTT.UseVisualStyleBackColor = true;
            this.EditBUTT.Click += new System.EventHandler(this.EditBUTT_Click);
            // 
            // SaveBUTT
            // 
            this.SaveBUTT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SaveBUTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBUTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBUTT.Location = new System.Drawing.Point(399, 493);
            this.SaveBUTT.Name = "SaveBUTT";
            this.SaveBUTT.Size = new System.Drawing.Size(145, 51);
            this.SaveBUTT.TabIndex = 10;
            this.SaveBUTT.Text = "SAVE";
            this.SaveBUTT.UseVisualStyleBackColor = true;
            this.SaveBUTT.Click += new System.EventHandler(this.SaveBUTT_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 556);
            this.Controls.Add(this.SaveBUTT);
            this.Controls.Add(this.EditBUTT);
            this.Controls.Add(this.AddrBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UserForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FNameBox;
        private System.Windows.Forms.TextBox UNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddrBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EditBUTT;
        private System.Windows.Forms.Button SaveBUTT;
    }
}