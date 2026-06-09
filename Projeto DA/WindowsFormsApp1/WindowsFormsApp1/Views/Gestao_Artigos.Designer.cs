namespace WindowsFormsApp1.Views
{
    partial class Gestao_de_Artigos
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
            this.labelTipodeArtigo = new System.Windows.Forms.Label();
            this.comboBoxTipoArtigo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NomeArtigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoArtigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonEditarArt = new System.Windows.Forms.Button();
            this.buttonApagarArt = new System.Windows.Forms.Button();
            this.buttonCriarArt = new System.Windows.Forms.Button();
            this.textNomeArtig = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFiltrar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTipodeArtigo
            // 
            this.labelTipodeArtigo.AutoSize = true;
            this.labelTipodeArtigo.Location = new System.Drawing.Point(6, 34);
            this.labelTipodeArtigo.Name = "labelTipodeArtigo";
            this.labelTipodeArtigo.Size = new System.Drawing.Size(95, 16);
            this.labelTipodeArtigo.TabIndex = 0;
            this.labelTipodeArtigo.Text = "Tipo de Artigo:";
            // 
            // comboBoxTipoArtigo
            // 
            this.comboBoxTipoArtigo.FormattingEnabled = true;
            this.comboBoxTipoArtigo.Location = new System.Drawing.Point(113, 31);
            this.comboBoxTipoArtigo.Name = "comboBoxTipoArtigo";
            this.comboBoxTipoArtigo.Size = new System.Drawing.Size(241, 24);
            this.comboBoxTipoArtigo.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeArtigo,
            this.TipoArtigo});
            this.dataGridView1.Location = new System.Drawing.Point(33, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(426, 338);
            this.dataGridView1.TabIndex = 2;
            // 
            // NomeArtigo
            // 
            this.NomeArtigo.HeaderText = "Nome do Artigo";
            this.NomeArtigo.MinimumWidth = 6;
            this.NomeArtigo.Name = "NomeArtigo";
            this.NomeArtigo.ReadOnly = true;
            // 
            // TipoArtigo
            // 
            this.TipoArtigo.HeaderText = "Tipo de Artigo";
            this.TipoArtigo.MinimumWidth = 6;
            this.TipoArtigo.Name = "TipoArtigo";
            this.TipoArtigo.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonEditarArt);
            this.groupBox1.Controls.Add(this.buttonApagarArt);
            this.groupBox1.Controls.Add(this.buttonCriarArt);
            this.groupBox1.Controls.Add(this.textNomeArtig);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelTipodeArtigo);
            this.groupBox1.Controls.Add(this.comboBoxTipoArtigo);
            this.groupBox1.Location = new System.Drawing.Point(480, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 369);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalhes do Artigo";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(250, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttonEditarArt
            // 
            this.buttonEditarArt.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonEditarArt.FlatAppearance.BorderSize = 0;
            this.buttonEditarArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditarArt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarArt.ForeColor = System.Drawing.Color.Black;
            this.buttonEditarArt.Location = new System.Drawing.Point(130, 129);
            this.buttonEditarArt.Name = "buttonEditarArt";
            this.buttonEditarArt.Size = new System.Drawing.Size(104, 31);
            this.buttonEditarArt.TabIndex = 8;
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
            this.buttonApagarArt.Location = new System.Drawing.Point(250, 129);
            this.buttonApagarArt.Name = "buttonApagarArt";
            this.buttonApagarArt.Size = new System.Drawing.Size(104, 31);
            this.buttonApagarArt.TabIndex = 7;
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
            this.buttonCriarArt.Location = new System.Drawing.Point(6, 129);
            this.buttonCriarArt.Name = "buttonCriarArt";
            this.buttonCriarArt.Size = new System.Drawing.Size(104, 31);
            this.buttonCriarArt.TabIndex = 6;
            this.buttonCriarArt.Text = "Criar ";
            this.buttonCriarArt.UseVisualStyleBackColor = false;
            // 
            // textNomeArtig
            // 
            this.textNomeArtig.Location = new System.Drawing.Point(113, 74);
            this.textNomeArtig.Name = "textNomeArtig";
            this.textNomeArtig.Size = new System.Drawing.Size(241, 22);
            this.textNomeArtig.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do Artigo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filtrar por Tipo:";
            // 
            // comboBoxFiltrar
            // 
            this.comboBoxFiltrar.FormattingEnabled = true;
            this.comboBoxFiltrar.Location = new System.Drawing.Point(138, 48);
            this.comboBoxFiltrar.Name = "comboBoxFiltrar";
            this.comboBoxFiltrar.Size = new System.Drawing.Size(321, 24);
            this.comboBoxFiltrar.TabIndex = 11;
            // 
            // Gestao_de_Artigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxFiltrar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Gestao_de_Artigos";
            this.Text = "Gestao de Artigos";
            this.Load += new System.EventHandler(this.Gestao_de_Artigos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTipodeArtigo;
        private System.Windows.Forms.ComboBox comboBoxTipoArtigo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textNomeArtig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonEditarArt;
        private System.Windows.Forms.Button buttonApagarArt;
        private System.Windows.Forms.Button buttonCriarArt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFiltrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeArtigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoArtigo;
    }
}