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
            this.labelArtigoNovaCompra = new System.Windows.Forms.Label();
            this.comboBoxArtigoNovaCompra = new System.Windows.Forms.ComboBox();
            this.labelQuantidadePrev = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNomeCompra
            // 
            this.textBoxNomeCompra.Location = new System.Drawing.Point(152, 31);
            this.textBoxNomeCompra.Name = "textBoxNomeCompra";
            this.textBoxNomeCompra.Size = new System.Drawing.Size(100, 22);
            this.textBoxNomeCompra.TabIndex = 0;
            // 
            // labelNomeCompra
            // 
            this.labelNomeCompra.AutoSize = true;
            this.labelNomeCompra.Location = new System.Drawing.Point(29, 34);
            this.labelNomeCompra.Name = "labelNomeCompra";
            this.labelNomeCompra.Size = new System.Drawing.Size(117, 16);
            this.labelNomeCompra.TabIndex = 1;
            this.labelNomeCompra.Text = "Nome da Compra:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAddItem);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.labelQuantidadePrev);
            this.groupBox1.Controls.Add(this.comboBoxArtigoNovaCompra);
            this.groupBox1.Controls.Add(this.labelArtigoNovaCompra);
            this.groupBox1.Location = new System.Drawing.Point(32, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 89);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Itens";
            // 
            // labelArtigoNovaCompra
            // 
            this.labelArtigoNovaCompra.AutoSize = true;
            this.labelArtigoNovaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArtigoNovaCompra.Location = new System.Drawing.Point(16, 39);
            this.labelArtigoNovaCompra.Name = "labelArtigoNovaCompra";
            this.labelArtigoNovaCompra.Size = new System.Drawing.Size(50, 18);
            this.labelArtigoNovaCompra.TabIndex = 0;
            this.labelArtigoNovaCompra.Text = "Artigo:";
            // 
            // comboBoxArtigoNovaCompra
            // 
            this.comboBoxArtigoNovaCompra.FormattingEnabled = true;
            this.comboBoxArtigoNovaCompra.Location = new System.Drawing.Point(72, 33);
            this.comboBoxArtigoNovaCompra.Name = "comboBoxArtigoNovaCompra";
            this.comboBoxArtigoNovaCompra.Size = new System.Drawing.Size(121, 24);
            this.comboBoxArtigoNovaCompra.TabIndex = 1;
            // 
            // labelQuantidadePrev
            // 
            this.labelQuantidadePrev.AutoSize = true;
            this.labelQuantidadePrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantidadePrev.Location = new System.Drawing.Point(199, 41);
            this.labelQuantidadePrev.Name = "labelQuantidadePrev";
            this.labelQuantidadePrev.Size = new System.Drawing.Size(144, 18);
            this.labelQuantidadePrev.TabIndex = 2;
            this.labelQuantidadePrev.Text = "Quantidade Prevista:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Location = new System.Drawing.Point(349, 39);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(51, 22);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddItem.Location = new System.Drawing.Point(406, 36);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(117, 25);
            this.buttonAddItem.TabIndex = 4;
            this.buttonAddItem.Text = "Adicionar Item";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(551, 389);
            this.dataGridView1.TabIndex = 3;
            // 
            // NovaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 631);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelNomeCompra);
            this.Controls.Add(this.textBoxNomeCompra);
            this.Name = "NovaCompra";
            this.Text = "NovaCompra";
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
    }
}