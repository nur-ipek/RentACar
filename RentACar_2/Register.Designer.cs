namespace RentACar_2
{
    partial class Register
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
            this.txtMailAdress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSignIn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.txtFirstName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtLastName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // txtMailAdress
            // 
            this.txtMailAdress.Depth = 0;
            this.txtMailAdress.Hint = "Mail Adresi *";
            this.txtMailAdress.Location = new System.Drawing.Point(36, 202);
            this.txtMailAdress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMailAdress.Name = "txtMailAdress";
            this.txtMailAdress.PasswordChar = '\0';
            this.txtMailAdress.SelectedText = "";
            this.txtMailAdress.SelectionLength = 0;
            this.txtMailAdress.SelectionStart = 0;
            this.txtMailAdress.Size = new System.Drawing.Size(225, 23);
            this.txtMailAdress.TabIndex = 0;
            this.txtMailAdress.UseSystemPasswordChar = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Depth = 0;
            this.txtPassword.Hint = "Şifre *";
            this.txtPassword.Location = new System.Drawing.Point(36, 244);
            this.txtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.Size = new System.Drawing.Size(225, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Depth = 0;
            this.btnSignIn.Location = new System.Drawing.Point(94, 284);
            this.btnSignIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Primary = true;
            this.btnSignIn.Size = new System.Drawing.Size(106, 31);
            this.btnSignIn.TabIndex = 3;
            this.btnSignIn.Text = "KAYIT OL";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(35, 333);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(226, 2);
            this.materialDivider1.TabIndex = 4;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Depth = 0;
            this.txtFirstName.Hint = "Ad *";
            this.txtFirstName.Location = new System.Drawing.Point(35, 111);
            this.txtFirstName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.SelectionLength = 0;
            this.txtFirstName.SelectionStart = 0;
            this.txtFirstName.Size = new System.Drawing.Size(225, 23);
            this.txtFirstName.TabIndex = 5;
            this.txtFirstName.UseSystemPasswordChar = false;
            // 
            // txtLastName
            // 
            this.txtLastName.Depth = 0;
            this.txtLastName.Hint = "Soyad *";
            this.txtLastName.Location = new System.Drawing.Point(36, 157);
            this.txtLastName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.SelectedText = "";
            this.txtLastName.SelectionLength = 0;
            this.txtLastName.SelectionStart = 0;
            this.txtLastName.Size = new System.Drawing.Size(225, 23);
            this.txtLastName.TabIndex = 6;
            this.txtLastName.UseSystemPasswordChar = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 417);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtMailAdress);
            this.Name = "Register";
            this.Text = "Kayıt Ol";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtMailAdress;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPassword;
        private MaterialSkin.Controls.MaterialRaisedButton btnSignIn;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFirstName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLastName;
    }
}

