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
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.ValorUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCriarCompra = new System.Windows.Forms.Button();
            this.buttonCancelarCompra = new System.Windows.Forms.Button();
            this.buttonRemoverCompra = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTotalPrev = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNomeCompra
            // 
            this.textBoxNomeCompra.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxNomeCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNomeCompra.Location = new System.Drawing.Point(197, 13);
            this.textBoxNomeCompra.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxNomeCompra.Multiline = true;
            this.textBoxNomeCompra.Name = "textBoxNomeCompra";
            this.textBoxNomeCompra.Size = new System.Drawing.Size(223, 31);
            this.textBoxNomeCompra.TabIndex = 0;
            // 
            // labelNomeCompra
            // 
            this.labelNomeCompra.AutoSize = true;
            this.labelNomeCompra.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeCompra.Location = new System.Drawing.Point(29, 16);
            this.labelNomeCompra.Name = "labelNomeCompra";
            this.labelNomeCompra.Size = new System.Drawing.Size(151, 23);
            this.labelNomeCompra.TabIndex = 1;
            this.labelNomeCompra.Text = "Nome da Compra:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonAddItem);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.labelQuantidadePrev);
            this.groupBox1.Controls.Add(this.comboBoxArtigoNovaCompra);
            this.groupBox1.Controls.Add(this.labelArtigoNovaCompra);
            this.groupBox1.Location = new System.Drawing.Point(32, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 133);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Itens";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(503, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "€";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Preço Unitário:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(421, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(81, 22);
            this.textBox1.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(237, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selecionar tipo do produto: ";
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddItem.Location = new System.Drawing.Point(567, 81);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(127, 26);
            this.buttonAddItem.TabIndex = 4;
            this.buttonAddItem.Text = "Adicionar Item";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Location = new System.Drawing.Point(177, 84);
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
            this.labelQuantidadePrev.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantidadePrev.Location = new System.Drawing.Point(6, 82);
            this.labelQuantidadePrev.Name = "labelQuantidadePrev";
            this.labelQuantidadePrev.Size = new System.Drawing.Size(168, 23);
            this.labelQuantidadePrev.TabIndex = 2;
            this.labelQuantidadePrev.Text = "Quantidade Prevista:";
            // 
            // comboBoxArtigoNovaCompra
            // 
            this.comboBoxArtigoNovaCompra.FormattingEnabled = true;
            this.comboBoxArtigoNovaCompra.Location = new System.Drawing.Point(499, 34);
            this.comboBoxArtigoNovaCompra.Name = "comboBoxArtigoNovaCompra";
            this.comboBoxArtigoNovaCompra.Size = new System.Drawing.Size(196, 24);
            this.comboBoxArtigoNovaCompra.TabIndex = 1;
            // 
            // labelArtigoNovaCompra
            // 
            this.labelArtigoNovaCompra.AutoSize = true;
            this.labelArtigoNovaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArtigoNovaCompra.Location = new System.Drawing.Point(435, 35);
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
            this.Quantidade,
            this.ValorUnit,
            this.Subtotal});
            this.dataGridView1.Location = new System.Drawing.Point(33, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(713, 408);
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
            // ValorUnit
            // 
            this.ValorUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ValorUnit.HeaderText = "Valor Unitário";
            this.ValorUnit.MinimumWidth = 6;
            this.ValorUnit.Name = "ValorUnit";
            this.ValorUnit.Width = 117;
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.MinimumWidth = 6;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Width = 85;
            // 
            // buttonCriarCompra
            // 
            this.buttonCriarCompra.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonCriarCompra.FlatAppearance.BorderSize = 0;
            this.buttonCriarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCriarCompra.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCriarCompra.ForeColor = System.Drawing.Color.White;
            this.buttonCriarCompra.Location = new System.Drawing.Point(611, 640);
            this.buttonCriarCompra.Name = "buttonCriarCompra";
            this.buttonCriarCompra.Size = new System.Drawing.Size(107, 27);
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
            this.buttonCancelarCompra.Location = new System.Drawing.Point(489, 640);
            this.buttonCancelarCompra.Name = "buttonCancelarCompra";
            this.buttonCancelarCompra.Size = new System.Drawing.Size(107, 27);
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
            this.buttonRemoverCompra.Location = new System.Drawing.Point(32, 608);
            this.buttonRemoverCompra.Name = "buttonRemoverCompra";
            this.buttonRemoverCompra.Size = new System.Drawing.Size(148, 27);
            this.buttonRemoverCompra.TabIndex = 7;
            this.buttonRemoverCompra.Text = "Remover Artigo";
            this.buttonRemoverCompra.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(540, 608);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total Previsto: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(700, 608);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "€";
            // 
            // labelTotalPrev
            // 
            this.labelTotalPrev.AutoSize = true;
            this.labelTotalPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrev.Location = new System.Drawing.Point(668, 608);
            this.labelTotalPrev.Name = "labelTotalPrev";
            this.labelTotalPrev.Size = new System.Drawing.Size(0, 20);
            this.labelTotalPrev.TabIndex = 10;
            // 
            // NovaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(771, 693);
            this.Controls.Add(this.labelTotalPrev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonRemoverCompra);
            this.Controls.Add(this.buttonCancelarCompra);
            this.Controls.Add(this.buttonCriarCompra);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelNomeCompra);
            this.Controls.Add(this.textBoxNomeCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "NovaCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NovaCompra";
            this.Load += new System.EventHandler(this.NovaCompra_Load);
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
        private System.Windows.Forms.Button buttonRemoverCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeArtigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTotalPrev;
    }
}