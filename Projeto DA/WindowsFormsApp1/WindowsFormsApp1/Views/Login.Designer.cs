namespace WindowsFormsApp1.Views
{
    partial class Login
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
            this.LabelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.btnRecoverPwd = new System.Windows.Forms.Button();
            this.buttonCriarNovoUtilizador = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsername.Location = new System.Drawing.Point(27, 57);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(86, 21);
            this.LabelUsername.TabIndex = 0;
            this.LabelUsername.Text = "Username:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(27, 88);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(77, 21);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(119, 56);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(230, 22);
            this.textUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(119, 88);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(230, 22);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonEntrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEntrar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEntrar.ForeColor = System.Drawing.Color.White;
            this.buttonEntrar.Location = new System.Drawing.Point(174, 132);
            this.buttonEntrar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(175, 31);
            this.buttonEntrar.TabIndex = 3;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = false;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // btnRecoverPwd
            // 
            this.btnRecoverPwd.BackColor = System.Drawing.Color.DarkGray;
            this.btnRecoverPwd.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnRecoverPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecoverPwd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecoverPwd.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRecoverPwd.Location = new System.Drawing.Point(174, 221);
            this.btnRecoverPwd.Margin = new System.Windows.Forms.Padding(0);
            this.btnRecoverPwd.Name = "btnRecoverPwd";
            this.btnRecoverPwd.Size = new System.Drawing.Size(175, 50);
            this.btnRecoverPwd.TabIndex = 5;
            this.btnRecoverPwd.Text = "Recuperar Palavra-Passe";
            this.btnRecoverPwd.UseVisualStyleBackColor = false;
            // 
            // buttonCriarNovoUtilizador
            // 
            this.buttonCriarNovoUtilizador.BackColor = System.Drawing.Color.DarkGray;
            this.buttonCriarNovoUtilizador.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonCriarNovoUtilizador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCriarNovoUtilizador.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCriarNovoUtilizador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCriarNovoUtilizador.Location = new System.Drawing.Point(174, 177);
            this.buttonCriarNovoUtilizador.Name = "buttonCriarNovoUtilizador";
            this.buttonCriarNovoUtilizador.Size = new System.Drawing.Size(175, 31);
            this.buttonCriarNovoUtilizador.TabIndex = 4;
            this.buttonCriarNovoUtilizador.Text = "Criar utilizador";
            this.buttonCriarNovoUtilizador.UseVisualStyleBackColor = false;
            this.buttonCriarNovoUtilizador.Click += new System.EventHandler(this.buttonCriarNovoUtilizador_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.png_clipart_padlock_computer_icons_security_padlock_technic_area_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 132);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.buttonEntrar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(403, 280);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCriarNovoUtilizador);
            this.Controls.Add(this.btnRecoverPwd);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.LabelUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iShopping - Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.Button btnRecoverPwd;
        private System.Windows.Forms.Button buttonCriarNovoUtilizador;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}