namespace WindowsFormsApp1.Views
{
    partial class Gestao_Utilizadores
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
            this.listBoxUtilizadores = new System.Windows.Forms.ListBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCriar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonElimiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxUtilizadores
            // 
            this.listBoxUtilizadores.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxUtilizadores.FormattingEnabled = true;
            this.listBoxUtilizadores.ItemHeight = 23;
            this.listBoxUtilizadores.Location = new System.Drawing.Point(28, 37);
            this.listBoxUtilizadores.Name = "listBoxUtilizadores";
            this.listBoxUtilizadores.Size = new System.Drawing.Size(290, 280);
            this.listBoxUtilizadores.TabIndex = 0;
            this.listBoxUtilizadores.SelectedIndexChanged += new System.EventHandler(this.listBoxUtilizares_SelectedIndexChanged);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(327, 64);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(145, 30);
            this.textBoxNome.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(327, 134);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(145, 30);
            this.textBoxPassword.TabIndex = 2;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(324, 37);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(91, 23);
            this.labelUser.TabIndex = 3;
            this.labelUser.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // buttonCriar
            // 
            this.buttonCriar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonCriar.FlatAppearance.BorderSize = 0;
            this.buttonCriar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCriar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCriar.ForeColor = System.Drawing.Color.White;
            this.buttonCriar.Location = new System.Drawing.Point(515, 134);
            this.buttonCriar.Name = "buttonCriar";
            this.buttonCriar.Size = new System.Drawing.Size(136, 30);
            this.buttonCriar.TabIndex = 7;
            this.buttonCriar.Text = "Criar";
            this.buttonCriar.UseVisualStyleBackColor = false;
            this.buttonCriar.Click += new System.EventHandler(this.buttonCriar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonEditar.FlatAppearance.BorderSize = 0;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.Location = new System.Drawing.Point(336, 224);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(136, 30);
            this.buttonEditar.TabIndex = 8;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonElimiar
            // 
            this.buttonElimiar.BackColor = System.Drawing.Color.IndianRed;
            this.buttonElimiar.FlatAppearance.BorderSize = 0;
            this.buttonElimiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonElimiar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonElimiar.Location = new System.Drawing.Point(515, 224);
            this.buttonElimiar.Name = "buttonElimiar";
            this.buttonElimiar.Size = new System.Drawing.Size(136, 30);
            this.buttonElimiar.TabIndex = 9;
            this.buttonElimiar.Text = "Eliminar";
            this.buttonElimiar.UseVisualStyleBackColor = false;
            this.buttonElimiar.Click += new System.EventHandler(this.buttonElimiar_Click);
            // 
            // Gestao_Utilizadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 322);
            this.Controls.Add(this.buttonElimiar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonCriar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.listBoxUtilizadores);
            this.Name = "Gestao_Utilizadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestao_Utilizadores";
            this.Load += new System.EventHandler(this.Gestao_Utilizadores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUtilizadores;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCriar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonElimiar;
    }
}