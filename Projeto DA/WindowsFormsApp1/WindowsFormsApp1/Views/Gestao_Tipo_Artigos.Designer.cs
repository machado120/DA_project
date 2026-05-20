namespace WindowsFormsApp1.Views
{
    partial class Gestao_de_Tipo_de_Artigos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonEditarArt = new System.Windows.Forms.Button();
            this.buttonApagarArt = new System.Windows.Forms.Button();
            this.buttonCriarArt = new System.Windows.Forms.Button();
            this.textBoxDetalhesArtigos = new System.Windows.Forms.TextBox();
            this.labelDetalhes = new System.Windows.Forms.Label();
            this.listBoxTipos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonEditarArt);
            this.groupBox1.Controls.Add(this.buttonApagarArt);
            this.groupBox1.Controls.Add(this.buttonCriarArt);
            this.groupBox1.Controls.Add(this.textBoxDetalhesArtigos);
            this.groupBox1.Controls.Add(this.labelDetalhes);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(408, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 151);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalhes do Tipo de Artigo";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(280, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttonEditarArt
            // 
            this.buttonEditarArt.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonEditarArt.FlatAppearance.BorderSize = 0;
            this.buttonEditarArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditarArt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarArt.ForeColor = System.Drawing.Color.White;
            this.buttonEditarArt.Location = new System.Drawing.Point(170, 70);
            this.buttonEditarArt.Name = "buttonEditarArt";
            this.buttonEditarArt.Size = new System.Drawing.Size(104, 31);
            this.buttonEditarArt.TabIndex = 4;
            this.buttonEditarArt.Text = "Editar";
            this.buttonEditarArt.UseVisualStyleBackColor = false;
            // 
            // buttonApagarArt
            // 
            this.buttonApagarArt.BackColor = System.Drawing.Color.IndianRed;
            this.buttonApagarArt.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonApagarArt.FlatAppearance.BorderSize = 0;
            this.buttonApagarArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApagarArt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApagarArt.ForeColor = System.Drawing.Color.White;
            this.buttonApagarArt.Location = new System.Drawing.Point(280, 70);
            this.buttonApagarArt.Name = "buttonApagarArt";
            this.buttonApagarArt.Size = new System.Drawing.Size(104, 31);
            this.buttonApagarArt.TabIndex = 3;
            this.buttonApagarArt.Text = "Eliminar";
            this.buttonApagarArt.UseVisualStyleBackColor = false;
            // 
            // buttonCriarArt
            // 
            this.buttonCriarArt.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonCriarArt.FlatAppearance.BorderSize = 0;
            this.buttonCriarArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCriarArt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCriarArt.ForeColor = System.Drawing.Color.White;
            this.buttonCriarArt.Location = new System.Drawing.Point(60, 70);
            this.buttonCriarArt.Name = "buttonCriarArt";
            this.buttonCriarArt.Size = new System.Drawing.Size(104, 31);
            this.buttonCriarArt.TabIndex = 2;
            this.buttonCriarArt.Text = "Criar ";
            this.buttonCriarArt.UseVisualStyleBackColor = false;
            this.buttonCriarArt.Click += new System.EventHandler(this.buttonCriarArt_Click);
            // 
            // textBoxDetalhesArtigos
            // 
            this.textBoxDetalhesArtigos.Location = new System.Drawing.Point(143, 25);
            this.textBoxDetalhesArtigos.Name = "textBoxDetalhesArtigos";
            this.textBoxDetalhesArtigos.Size = new System.Drawing.Size(241, 27);
            this.textBoxDetalhesArtigos.TabIndex = 1;
            // 
            // labelDetalhes
            // 
            this.labelDetalhes.AutoSize = true;
            this.labelDetalhes.Location = new System.Drawing.Point(6, 28);
            this.labelDetalhes.Name = "labelDetalhes";
            this.labelDetalhes.Size = new System.Drawing.Size(113, 20);
            this.labelDetalhes.TabIndex = 0;
            this.labelDetalhes.Text = "Nome do tipo:";
            // 
            // listBoxTipos
            // 
            this.listBoxTipos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxTipos.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTipos.FormattingEnabled = true;
            this.listBoxTipos.ItemHeight = 23;
            this.listBoxTipos.Location = new System.Drawing.Point(23, 41);
            this.listBoxTipos.Name = "listBoxTipos";
            this.listBoxTipos.Size = new System.Drawing.Size(357, 508);
            this.listBoxTipos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descrição / Nome:";
            // 
            // Gestao_de_Tipo_de_Artigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 626);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxTipos);
            this.Controls.Add(this.groupBox1);
            this.Name = "Gestao_de_Tipo_de_Artigos";
            this.Text = "Gestão de Tipos de Artigos";
            this.Load += new System.EventHandler(this.Gestao_de_Tipo_de_Artigos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonEditarArt;
        private System.Windows.Forms.Button buttonApagarArt;
        private System.Windows.Forms.Button buttonCriarArt;
        private System.Windows.Forms.TextBox textBoxDetalhesArtigos;
        private System.Windows.Forms.Label labelDetalhes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxTipos;
        private System.Windows.Forms.Label label1;
    }
}