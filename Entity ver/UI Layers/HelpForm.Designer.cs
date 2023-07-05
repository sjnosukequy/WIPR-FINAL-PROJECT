﻿namespace ADO_ver.UI_Layers
{
    partial class HelpForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DeptBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProblemBox = new System.Windows.Forms.TextBox();
            this.SummitButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "HELP";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Department";
            // 
            // DeptBox
            // 
            this.DeptBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeptBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DeptBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptBox.FormattingEnabled = true;
            this.DeptBox.Items.AddRange(new object[] {
            "CSKH",
            "Sales",
            "Technical"});
            this.DeptBox.Location = new System.Drawing.Point(158, 93);
            this.DeptBox.Name = "DeptBox";
            this.DeptBox.Size = new System.Drawing.Size(225, 28);
            this.DeptBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 100);
            this.label3.TabIndex = 3;
            this.label3.Text = "Describe\r\nproblems\r\nyou have\r\nencountered";
            // 
            // ProblemBox
            // 
            this.ProblemBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProblemBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProblemBox.Location = new System.Drawing.Point(158, 174);
            this.ProblemBox.Multiline = true;
            this.ProblemBox.Name = "ProblemBox";
            this.ProblemBox.Size = new System.Drawing.Size(583, 296);
            this.ProblemBox.TabIndex = 4;
            // 
            // SummitButt
            // 
            this.SummitButt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SummitButt.BackColor = System.Drawing.SystemColors.Highlight;
            this.SummitButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SummitButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummitButt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SummitButt.Location = new System.Drawing.Point(337, 486);
            this.SummitButt.Name = "SummitButt";
            this.SummitButt.Size = new System.Drawing.Size(156, 61);
            this.SummitButt.TabIndex = 5;
            this.SummitButt.Text = "SUMMIT";
            this.SummitButt.UseVisualStyleBackColor = false;
            this.SummitButt.Click += new System.EventHandler(this.SummitButt_Click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 559);
            this.Controls.Add(this.SummitButt);
            this.Controls.Add(this.ProblemBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeptBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HelpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DeptBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProblemBox;
        private System.Windows.Forms.Button SummitButt;
    }
}