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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDetalhes = new System.Windows.Forms.Label();
            this.textBoxDetalhesArtigos = new System.Windows.Forms.TextBox();
            this.buttonCriarArt = new System.Windows.Forms.Button();
            this.buttonApagarArt = new System.Windows.Forms.Button();
            this.buttonEditarArt = new System.Windows.Forms.Button();
            this.IDTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDTipo,
            this.Descrição_Nome});
            this.dataGridView1.Location = new System.Drawing.Point(24, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(378, 395);
            this.dataGridView1.TabIndex = 0;
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
            // labelDetalhes
            // 
            this.labelDetalhes.AutoSize = true;
            this.labelDetalhes.Location = new System.Drawing.Point(6, 28);
            this.labelDetalhes.Name = "labelDetalhes";
            this.labelDetalhes.Size = new System.Drawing.Size(113, 20);
            this.labelDetalhes.TabIndex = 0;
            this.labelDetalhes.Text = "Nome do tipo:";
            // 
            // textBoxDetalhesArtigos
            // 
            this.textBoxDetalhesArtigos.Location = new System.Drawing.Point(143, 25);
            this.textBoxDetalhesArtigos.Name = "textBoxDetalhesArtigos";
            this.textBoxDetalhesArtigos.Size = new System.Drawing.Size(241, 27);
            this.textBoxDetalhesArtigos.TabIndex = 1;
            // 
            // buttonCriarArt
            // 
            this.buttonCriarArt.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonCriarArt.FlatAppearance.BorderSize = 0;
            this.buttonCriarArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCriarArt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCriarArt.ForeColor = System.Drawing.Color.White;
            this.buttonCriarArt.Location = new System.Drawing.Point(33, 70);
            this.buttonCriarArt.Name = "buttonCriarArt";
            this.buttonCriarArt.Size = new System.Drawing.Size(104, 31);
            this.buttonCriarArt.TabIndex = 2;
            this.buttonCriarArt.Text = "Criar ";
            this.buttonCriarArt.UseVisualStyleBackColor = false;
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
            // buttonEditarArt
            // 
            this.buttonEditarArt.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonEditarArt.FlatAppearance.BorderSize = 0;
            this.buttonEditarArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditarArt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarArt.ForeColor = System.Drawing.Color.Black;
            this.buttonEditarArt.Location = new System.Drawing.Point(160, 70);
            this.buttonEditarArt.Name = "buttonEditarArt";
            this.buttonEditarArt.Size = new System.Drawing.Size(104, 31);
            this.buttonEditarArt.TabIndex = 4;
            this.buttonEditarArt.Text = "Editar";
            this.buttonEditarArt.UseVisualStyleBackColor = false;
            // 
            // IDTipo
            // 
            this.IDTipo.HeaderText = "IDTipo";
            this.IDTipo.MinimumWidth = 6;
            this.IDTipo.Name = "IDTipo";
            // 
            // Descrição_Nome
            // 
            this.Descrição_Nome.HeaderText = "Descrição/Nome";
            this.Descrição_Nome.MinimumWidth = 6;
            this.Descrição_Nome.Name = "Descrição_Nome";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(280, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Gestao_de_Tipo_de_Artigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 512);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Gestao_de_Tipo_de_Artigos";
            this.Text = "Gestão de Tipos de Artigos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonEditarArt;
        private System.Windows.Forms.Button buttonApagarArt;
        private System.Windows.Forms.Button buttonCriarArt;
        private System.Windows.Forms.TextBox textBoxDetalhesArtigos;
        private System.Windows.Forms.Label labelDetalhes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição_Nome;
        private System.Windows.Forms.Button button1;
    }
}