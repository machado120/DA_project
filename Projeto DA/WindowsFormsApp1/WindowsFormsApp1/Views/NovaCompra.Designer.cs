namespace WindowsFormsApp1.Views
{
    partial class NovaCompra
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
            this.textBoxNomeCompra = new System.Windows.Forms.TextBox();
            this.labelNomeCompra = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelQuantidadePrev = new System.Windows.Forms.Label();
            this.comboBoxArtigoNovaCompra = new System.Windows.Forms.ComboBox();
            this.labelArtigoNovaCompra = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NomeArtigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCriarCompra = new System.Windows.Forms.Button();
            this.buttonCancelarCompra = new System.Windows.Forms.Button();
            this.buttonRemoverCompra = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNomeCompra
            // 
            this.textBoxNomeCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNomeCompra.Location = new System.Drawing.Point(186, 49);
            this.textBoxNomeCompra.Multiline = true;
            this.textBoxNomeCompra.Name = "textBoxNomeCompra";
            this.textBoxNomeCompra.Size = new System.Drawing.Size(162, 31);
            this.textBoxNomeCompra.TabIndex = 0;
            // 
            // labelNomeCompra
            // 
            this.labelNomeCompra.AutoSize = true;
            this.labelNomeCompra.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeCompra.Location = new System.Drawing.Point(29, 52);
            this.labelNomeCompra.Name = "labelNomeCompra";
            this.labelNomeCompra.Size = new System.Drawing.Size(151, 23);
            this.labelNomeCompra.TabIndex = 1;
            this.labelNomeCompra.Text = "Nome da Compra:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonAddItem);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.labelQuantidadePrev);
            this.groupBox1.Controls.Add(this.comboBoxArtigoNovaCompra);
            this.groupBox1.Controls.Add(this.labelArtigoNovaCompra);
            this.groupBox1.Location = new System.Drawing.Point(32, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Itens";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(192, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selecionar tipo do produto: ";
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddItem.Location = new System.Drawing.Point(430, 82);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(117, 25);
            this.buttonAddItem.TabIndex = 4;
            this.buttonAddItem.Text = "Adicionar Item";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Location = new System.Drawing.Point(373, 85);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(51, 22);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelQuantidadePrev
            // 
            this.labelQuantidadePrev.AutoSize = true;
            this.labelQuantidadePrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantidadePrev.Location = new System.Drawing.Point(229, 86);
            this.labelQuantidadePrev.Name = "labelQuantidadePrev";
            this.labelQuantidadePrev.Size = new System.Drawing.Size(144, 18);
            this.labelQuantidadePrev.TabIndex = 2;
            this.labelQuantidadePrev.Text = "Quantidade Prevista:";
            // 
            // comboBoxArtigoNovaCompra
            // 
            this.comboBoxArtigoNovaCompra.FormattingEnabled = true;
            this.comboBoxArtigoNovaCompra.Location = new System.Drawing.Point(62, 81);
            this.comboBoxArtigoNovaCompra.Name = "comboBoxArtigoNovaCompra";
            this.comboBoxArtigoNovaCompra.Size = new System.Drawing.Size(155, 24);
            this.comboBoxArtigoNovaCompra.TabIndex = 1;
            // 
            // labelArtigoNovaCompra
            // 
            this.labelArtigoNovaCompra.AutoSize = true;
            this.labelArtigoNovaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArtigoNovaCompra.Location = new System.Drawing.Point(-1, 82);
            this.labelArtigoNovaCompra.Name = "labelArtigoNovaCompra";
            this.labelArtigoNovaCompra.Size = new System.Drawing.Size(58, 20);
            this.labelArtigoNovaCompra.TabIndex = 0;
            this.labelArtigoNovaCompra.Text = "Artigo:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeArtigo,
            this.TipoArt,
            this.Quantidade});
            this.dataGridView1.Location = new System.Drawing.Point(32, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(551, 389);
            this.dataGridView1.TabIndex = 3;
            // 
            // NomeArtigo
            // 
            this.NomeArtigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeArtigo.HeaderText = "Nome Artigo";
            this.NomeArtigo.MinimumWidth = 6;
            this.NomeArtigo.Name = "NomeArtigo";
            // 
            // TipoArt
            // 
            this.TipoArt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TipoArt.HeaderText = "Tipo de Artigo";
            this.TipoArt.MinimumWidth = 6;
            this.TipoArt.Name = "TipoArt";
            // 
            // Quantidade
            // 
            this.Quantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.MinimumWidth = 6;
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Width = 106;
            // 
            // buttonCriarCompra
            // 
            this.buttonCriarCompra.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonCriarCompra.FlatAppearance.BorderSize = 0;
            this.buttonCriarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCriarCompra.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCriarCompra.ForeColor = System.Drawing.Color.White;
            this.buttonCriarCompra.Location = new System.Drawing.Point(495, 615);
            this.buttonCriarCompra.Name = "buttonCriarCompra";
            this.buttonCriarCompra.Size = new System.Drawing.Size(88, 27);
            this.buttonCriarCompra.TabIndex = 5;
            this.buttonCriarCompra.Text = "Criar";
            this.buttonCriarCompra.UseVisualStyleBackColor = false;
            // 
            // buttonCancelarCompra
            // 
            this.buttonCancelarCompra.BackColor = System.Drawing.Color.IndianRed;
            this.buttonCancelarCompra.FlatAppearance.BorderSize = 0;
            this.buttonCancelarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelarCompra.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarCompra.ForeColor = System.Drawing.Color.White;
            this.buttonCancelarCompra.Location = new System.Drawing.Point(401, 615);
            this.buttonCancelarCompra.Name = "buttonCancelarCompra";
            this.buttonCancelarCompra.Size = new System.Drawing.Size(88, 27);
            this.buttonCancelarCompra.TabIndex = 6;
            this.buttonCancelarCompra.Text = "Cancelar";
            this.buttonCancelarCompra.UseVisualStyleBackColor = false;
            // 
            // buttonRemoverCompra
            // 
            this.buttonRemoverCompra.BackColor = System.Drawing.Color.LightBlue;
            this.buttonRemoverCompra.FlatAppearance.BorderSize = 0;
            this.buttonRemoverCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoverCompra.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoverCompra.ForeColor = System.Drawing.Color.Black;
            this.buttonRemoverCompra.Location = new System.Drawing.Point(33, 615);
            this.buttonRemoverCompra.Name = "buttonRemoverCompra";
            this.buttonRemoverCompra.Size = new System.Drawing.Size(137, 27);
            this.buttonRemoverCompra.TabIndex = 7;
            this.buttonRemoverCompra.Text = "Remover Artigo";
            this.buttonRemoverCompra.UseVisualStyleBackColor = false;
            // 
            // NovaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 696);
            this.Controls.Add(this.buttonRemoverCompra);
            this.Controls.Add(this.buttonCancelarCompra);
            this.Controls.Add(this.buttonCriarCompra);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelNomeCompra);
            this.Controls.Add(this.textBoxNomeCompra);
            this.Name = "NovaCompra";
            this.Text = "x";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNomeCompra;
        private System.Windows.Forms.Label labelNomeCompra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelQuantidadePrev;
        private System.Windows.Forms.ComboBox comboBoxArtigoNovaCompra;
        private System.Windows.Forms.Label labelArtigoNovaCompra;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCriarCompra;
        private System.Windows.Forms.Button buttonCancelarCompra;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeArtigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.Button buttonRemoverCompra;
    }
}