namespace RentACar_2
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
            this.btnLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRegister = new MaterialSkin.Controls.MaterialRaisedButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.araçİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçEkleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilimiGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new MaterialSkin.Controls.MaterialLabel();
            this.btnExit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.araçlarıListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Depth = 0;
            this.btnLogin.Location = new System.Drawing.Point(628, 40);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Primary = true;
            this.btnLogin.Size = new System.Drawing.Size(160, 32);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "giriş yap";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Depth = 0;
            this.btnRegister.Location = new System.Drawing.Point(628, 78);
            this.btnRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Primary = true;
            this.btnRegister.Size = new System.Drawing.Size(160, 32);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "kayıt ol";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.araçİşlemleriToolStripMenuItem,
            this.araçEkleToolStripMenuItem,
            this.kullanıcıBilgileriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // araçİşlemleriToolStripMenuItem
            // 
            this.araçİşlemleriToolStripMenuItem.Name = "araçİşlemleriToolStripMenuItem";
            this.araçİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.araçİşlemleriToolStripMenuItem.Text = "Araçlar";
            // 
            // araçEkleToolStripMenuItem
            // 
            this.araçEkleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.araçEkleToolStripMenuItem1,
            this.araçlarıListeleToolStripMenuItem});
            this.araçEkleToolStripMenuItem.Name = "araçEkleToolStripMenuItem";
            this.araçEkleToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.araçEkleToolStripMenuItem.Text = "Araç";
            // 
            // araçEkleToolStripMenuItem1
            // 
            this.araçEkleToolStripMenuItem1.Name = "araçEkleToolStripMenuItem1";
            this.araçEkleToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.araçEkleToolStripMenuItem1.Text = "Araç Ekle";
            this.araçEkleToolStripMenuItem1.Click += new System.EventHandler(this.araçEkleToolStripMenuItem1_Click);
            // 
            // kullanıcıBilgileriToolStripMenuItem
            // 
            this.kullanıcıBilgileriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilimiGörüntüleToolStripMenuItem});
            this.kullanıcıBilgileriToolStripMenuItem.Name = "kullanıcıBilgileriToolStripMenuItem";
            this.kullanıcıBilgileriToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.kullanıcıBilgileriToolStripMenuItem.Text = "Profilim";
            // 
            // profilimiGörüntüleToolStripMenuItem
            // 
            this.profilimiGörüntüleToolStripMenuItem.Name = "profilimiGörüntüleToolStripMenuItem";
            this.profilimiGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.profilimiGörüntüleToolStripMenuItem.Text = "Profilimi Görüntüle";
            this.profilimiGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.profilimiGörüntüleToolStripMenuItem_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Depth = 0;
            this.lblWelcome.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblWelcome.Location = new System.Drawing.Point(22, 46);
            this.lblWelcome.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 19);
            this.lblWelcome.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Depth = 0;
            this.btnExit.Location = new System.Drawing.Point(628, 116);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.Primary = true;
            this.btnExit.Size = new System.Drawing.Size(160, 32);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "çıkış yap";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // araçlarıListeleToolStripMenuItem
            // 
            this.araçlarıListeleToolStripMenuItem.Name = "araçlarıListeleToolStripMenuItem";
            this.araçlarıListeleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.araçlarıListeleToolStripMenuItem.Text = "Araçları Listele";
            this.araçlarıListeleToolStripMenuItem.Click += new System.EventHandler(this.araçlarıListeleToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnLogin;
        private MaterialSkin.Controls.MaterialRaisedButton btnRegister;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem araçİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilimiGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçEkleToolStripMenuItem;
        private MaterialSkin.Controls.MaterialLabel lblWelcome;
        private MaterialSkin.Controls.MaterialRaisedButton btnExit;
        private System.Windows.Forms.ToolStripMenuItem araçEkleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem araçlarıListeleToolStripMenuItem;
    }
}