using System.Windows.Forms;

namespace ADO_ver
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.MenuBUTT = new System.Windows.Forms.ToolStripButton();
            this.LoginBUTT = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolLOGINBUTT = new System.Windows.Forms.ToolStripMenuItem();
            this.EDITBUTT = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolSIGNBUTT = new System.Windows.Forms.ToolStripMenuItem();
            this.SIGNBUTT = new System.Windows.Forms.ToolStripMenuItem();
            this.CartBUTT = new System.Windows.Forms.ToolStripButton();
            this.SPBUTT = new System.Windows.Forms.ToolStripDropDownButton();
            this.LaptopBUTT = new System.Windows.Forms.ToolStripMenuItem();
            this.RamBUTT = new System.Windows.Forms.ToolStripMenuItem();
            this.MouseBUTT = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneTabletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speakerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mISCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpBUTT = new System.Windows.Forms.ToolStripButton();
            this.AboutBUTT = new System.Windows.Forms.ToolStripButton();
            this.Edit2BUTT = new System.Windows.Forms.ToolStripButton();
            this.SearchBox = new System.Windows.Forms.ToolStripTextBox();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.Buy = new System.Windows.Forms.DataGridViewButtonColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LogoLabel = new System.Windows.Forms.Label();
            this.Infolabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBUTT,
            this.LoginBUTT,
            this.CartBUTT,
            this.SPBUTT,
            this.HelpBUTT,
            this.AboutBUTT,
            this.Edit2BUTT,
            this.SearchBox,
            this.Infolabel});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1262, 32);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MenuBUTT
            // 
            this.MenuBUTT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MenuBUTT.Image = ((System.Drawing.Image)(resources.GetObject("MenuBUTT.Image")));
            this.MenuBUTT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuBUTT.Name = "MenuBUTT";
            this.MenuBUTT.Size = new System.Drawing.Size(65, 29);
            this.MenuBUTT.Text = "Home";
            this.MenuBUTT.Click += new System.EventHandler(this.MenuBUTT_Click);
            // 
            // LoginBUTT
            // 
            this.LoginBUTT.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.LoginBUTT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LoginBUTT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolLOGINBUTT,
            this.EDITBUTT,
            this.ToolSIGNBUTT,
            this.SIGNBUTT});
            this.LoginBUTT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoginBUTT.Image = ((System.Drawing.Image)(resources.GetObject("LoginBUTT.Image")));
            this.LoginBUTT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.LoginBUTT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LoginBUTT.Name = "LoginBUTT";
            this.LoginBUTT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LoginBUTT.Size = new System.Drawing.Size(70, 29);
            this.LoginBUTT.Text = "Login";
            this.LoginBUTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ToolLOGINBUTT
            // 
            this.ToolLOGINBUTT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolLOGINBUTT.Name = "ToolLOGINBUTT";
            this.ToolLOGINBUTT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ToolLOGINBUTT.Size = new System.Drawing.Size(178, 30);
            this.ToolLOGINBUTT.Text = "LOGIN";
            this.ToolLOGINBUTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ToolLOGINBUTT.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ToolLOGINBUTT.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ToolLOGINBUTT.Click += new System.EventHandler(this.LOGIN_Click);
            // 
            // EDITBUTT
            // 
            this.EDITBUTT.Name = "EDITBUTT";
            this.EDITBUTT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EDITBUTT.Size = new System.Drawing.Size(178, 30);
            this.EDITBUTT.Text = "EDIT";
            this.EDITBUTT.Click += new System.EventHandler(this.EDITBUTT_Click);
            // 
            // ToolSIGNBUTT
            // 
            this.ToolSIGNBUTT.Name = "ToolSIGNBUTT";
            this.ToolSIGNBUTT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ToolSIGNBUTT.Size = new System.Drawing.Size(178, 30);
            this.ToolSIGNBUTT.Text = "SIGN UP";
            this.ToolSIGNBUTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ToolSIGNBUTT.Click += new System.EventHandler(this.SIGNUP_Click);
            // 
            // SIGNBUTT
            // 
            this.SIGNBUTT.Name = "SIGNBUTT";
            this.SIGNBUTT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SIGNBUTT.Size = new System.Drawing.Size(178, 30);
            this.SIGNBUTT.Text = "SIGN OUT";
            this.SIGNBUTT.Click += new System.EventHandler(this.SIGNOUT_Click);
            // 
            // CartBUTT
            // 
            this.CartBUTT.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CartBUTT.Image = global::ADO_ver.Properties.Resources.cart;
            this.CartBUTT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CartBUTT.Name = "CartBUTT";
            this.CartBUTT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CartBUTT.Size = new System.Drawing.Size(68, 29);
            this.CartBUTT.Text = "Cart";
            this.CartBUTT.Click += new System.EventHandler(this.CartBUTT_Click);
            // 
            // SPBUTT
            // 
            this.SPBUTT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SPBUTT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LaptopBUTT,
            this.RamBUTT,
            this.MouseBUTT,
            this.phoneTabletToolStripMenuItem,
            this.speakerToolStripMenuItem,
            this.tiviToolStripMenuItem,
            this.mISCToolStripMenuItem});
            this.SPBUTT.Image = ((System.Drawing.Image)(resources.GetObject("SPBUTT.Image")));
            this.SPBUTT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SPBUTT.Name = "SPBUTT";
            this.SPBUTT.Size = new System.Drawing.Size(96, 29);
            this.SPBUTT.Text = "Products";
            // 
            // LaptopBUTT
            // 
            this.LaptopBUTT.Name = "LaptopBUTT";
            this.LaptopBUTT.Size = new System.Drawing.Size(224, 30);
            this.LaptopBUTT.Text = "Laptop";
            this.LaptopBUTT.Click += new System.EventHandler(this.LapMenuItem_Click);
            // 
            // RamBUTT
            // 
            this.RamBUTT.Name = "RamBUTT";
            this.RamBUTT.Size = new System.Drawing.Size(224, 30);
            this.RamBUTT.Text = "Ram";
            this.RamBUTT.Click += new System.EventHandler(this.RamBUTT_Click);
            // 
            // MouseBUTT
            // 
            this.MouseBUTT.Name = "MouseBUTT";
            this.MouseBUTT.Size = new System.Drawing.Size(224, 30);
            this.MouseBUTT.Text = "Mouse";
            this.MouseBUTT.Click += new System.EventHandler(this.MouseBUTT_Click);
            // 
            // phoneTabletToolStripMenuItem
            // 
            this.phoneTabletToolStripMenuItem.Name = "phoneTabletToolStripMenuItem";
            this.phoneTabletToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.phoneTabletToolStripMenuItem.Text = "Phone/Tablet";
            this.phoneTabletToolStripMenuItem.Click += new System.EventHandler(this.phoneTabletToolStripMenuItem_Click);
            // 
            // speakerToolStripMenuItem
            // 
            this.speakerToolStripMenuItem.Name = "speakerToolStripMenuItem";
            this.speakerToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.speakerToolStripMenuItem.Text = "Sound";
            this.speakerToolStripMenuItem.Click += new System.EventHandler(this.speakerToolStripMenuItem_Click);
            // 
            // tiviToolStripMenuItem
            // 
            this.tiviToolStripMenuItem.Name = "tiviToolStripMenuItem";
            this.tiviToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.tiviToolStripMenuItem.Text = "Tivi";
            this.tiviToolStripMenuItem.Click += new System.EventHandler(this.tiviToolStripMenuItem_Click);
            // 
            // mISCToolStripMenuItem
            // 
            this.mISCToolStripMenuItem.Name = "mISCToolStripMenuItem";
            this.mISCToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.mISCToolStripMenuItem.Text = "MISC";
            this.mISCToolStripMenuItem.Click += new System.EventHandler(this.mISCToolStripMenuItem_Click);
            // 
            // HelpBUTT
            // 
            this.HelpBUTT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.HelpBUTT.Image = ((System.Drawing.Image)(resources.GetObject("HelpBUTT.Image")));
            this.HelpBUTT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HelpBUTT.Name = "HelpBUTT";
            this.HelpBUTT.Size = new System.Drawing.Size(53, 29);
            this.HelpBUTT.Text = "Help";
            this.HelpBUTT.Click += new System.EventHandler(this.HelpBUTT_Click);
            // 
            // AboutBUTT
            // 
            this.AboutBUTT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AboutBUTT.Image = ((System.Drawing.Image)(resources.GetObject("AboutBUTT.Image")));
            this.AboutBUTT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutBUTT.Name = "AboutBUTT";
            this.AboutBUTT.Size = new System.Drawing.Size(89, 29);
            this.AboutBUTT.Text = "About us";
            this.AboutBUTT.Click += new System.EventHandler(this.AboutBUTT_Click);
            // 
            // Edit2BUTT
            // 
            this.Edit2BUTT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Edit2BUTT.Image = ((System.Drawing.Image)(resources.GetObject("Edit2BUTT.Image")));
            this.Edit2BUTT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit2BUTT.Name = "Edit2BUTT";
            this.Edit2BUTT.Size = new System.Drawing.Size(121, 29);
            this.Edit2BUTT.Text = "Edit Products";
            this.Edit2BUTT.Click += new System.EventHandler(this.Edit2BUTT_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SearchBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.SearchBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(200, 32);
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.DataGrid.Location = new System.Drawing.Point(12, 57);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowHeadersWidth = 51;
            this.DataGrid.RowTemplate.Height = 24;
            this.DataGrid.Size = new System.Drawing.Size(1238, 604);
            this.DataGrid.TabIndex = 1;
            this.DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellClick);
            this.DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Buy_Click);
            this.DataGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Buy_Click);
            this.DataGrid.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DataGrid_CellPainting);
            // 
            // Buy
            // 
            this.Buy.MinimumWidth = 6;
            this.Buy.Name = "Buy";
            this.Buy.Text = "BUY";
            this.Buy.Width = 125;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LogoLabel
            // 
            this.LogoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LogoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoLabel.Location = new System.Drawing.Point(569, 32);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(171, 22);
            this.LogoLabel.TabIndex = 2;
            this.LogoLabel.Text = "THE BOYS SHOP";
            // 
            // Infolabel
            // 
            this.Infolabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Infolabel.Name = "Infolabel";
            this.Infolabel.Size = new System.Drawing.Size(206, 29);
            this.Infolabel.Text = "Product has been added";
            this.Infolabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.LogoLabel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.DataGrid);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton MenuBUTT;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.DataGridViewButtonColumn Buy;
        private Timer timer1;
        private ToolStripButton CartBUTT;
        private Label LogoLabel;
        private ToolStripDropDownButton SPBUTT;
        private ToolStripMenuItem LaptopBUTT;
        private ToolStripMenuItem RamBUTT;
        private ToolStripMenuItem MouseBUTT;
        private ToolStripDropDownButton LoginBUTT;
        private ToolStripMenuItem ToolLOGINBUTT;
        private ToolStripMenuItem ToolSIGNBUTT;
        private ToolStripMenuItem SIGNBUTT;
        private ToolStripMenuItem EDITBUTT;
        private ToolStripMenuItem phoneTabletToolStripMenuItem;
        private ToolStripMenuItem speakerToolStripMenuItem;
        private ToolStripMenuItem tiviToolStripMenuItem;
        private ToolStripMenuItem mISCToolStripMenuItem;
        private ToolStripButton AboutBUTT;
        private ToolStripButton HelpBUTT;
        private ToolStripButton Edit2BUTT;
        private ToolStripTextBox SearchBox;
        private ToolStripLabel Infolabel;
    }
}

