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
            this.SuspendLayout();
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsername.Location = new System.Drawing.Point(85, 59);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(86, 21);
            this.LabelUsername.TabIndex = 0;
            this.LabelUsername.Text = "Username:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(85, 90);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(77, 21);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(177, 60);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(138, 22);
            this.textUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(177, 90);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(138, 22);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.Location = new System.Drawing.Point(207, 130);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(108, 28);
            this.buttonEntrar.TabIndex = 4;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            // 
            // btnRecoverPwd
            // 
            this.btnRecoverPwd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRecoverPwd.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRecoverPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecoverPwd.Location = new System.Drawing.Point(108, 210);
            this.btnRecoverPwd.Margin = new System.Windows.Forms.Padding(0);
            this.btnRecoverPwd.Name = "btnRecoverPwd";
            this.btnRecoverPwd.Size = new System.Drawing.Size(207, 25);
            this.btnRecoverPwd.TabIndex = 5;
            this.btnRecoverPwd.Text = "Recuperar Palavra-Passe";
            this.btnRecoverPwd.UseVisualStyleBackColor = false;
            // 
            // buttonCriarNovoUtilizador
            // 
            this.buttonCriarNovoUtilizador.Location = new System.Drawing.Point(207, 164);
            this.buttonCriarNovoUtilizador.Name = "buttonCriarNovoUtilizador";
            this.buttonCriarNovoUtilizador.Size = new System.Drawing.Size(108, 28);
            this.buttonCriarNovoUtilizador.TabIndex = 6;
            this.buttonCriarNovoUtilizador.Text = "Criar utilizador";
            this.buttonCriarNovoUtilizador.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 302);
            this.Controls.Add(this.buttonCriarNovoUtilizador);
            this.Controls.Add(this.btnRecoverPwd);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.LabelUsername);
            this.Name = "Login";
            this.Text = "Logincs";
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
    }
}