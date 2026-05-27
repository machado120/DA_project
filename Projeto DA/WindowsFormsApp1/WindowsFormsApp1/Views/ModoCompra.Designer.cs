namespace WindowsFormsApp1.Views
{
    partial class ModoCompra
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
            this.labelmodocompra = new System.Windows.Forms.Label();
            this.panelModoCompra = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblArtigoSelecionado = new System.Windows.Forms.Label();
            this.labelartSelec = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Artigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdPrevista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdAdquirida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelModoCompra.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelmodocompra
            // 
            this.labelmodocompra.AutoSize = true;
            this.labelmodocompra.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmodocompra.Location = new System.Drawing.Point(23, 38);
            this.labelmodocompra.Name = "labelmodocompra";
            this.labelmodocompra.Size = new System.Drawing.Size(249, 25);
            this.labelmodocompra.TabIndex = 0;
            this.labelmodocompra.Text = "A processar Compra do Mês:";
            // 
            // panelModoCompra
            // 
            this.panelModoCompra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelModoCompra.Controls.Add(this.groupBox2);
            this.panelModoCompra.Controls.Add(this.groupBox1);
            this.panelModoCompra.Controls.Add(this.dateTimePicker1);
            this.panelModoCompra.Controls.Add(this.textBox1);
            this.panelModoCompra.Controls.Add(this.label2);
            this.panelModoCompra.Controls.Add(this.label1);
            this.panelModoCompra.Location = new System.Drawing.Point(587, 77);
            this.panelModoCompra.Name = "panelModoCompra";
            this.panelModoCompra.Size = new System.Drawing.Size(666, 510);
            this.panelModoCompra.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(18, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(635, 206);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblArtigoSelecionado);
            this.groupBox1.Controls.Add(this.labelartSelec);
            this.groupBox1.Location = new System.Drawing.Point(18, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 206);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Location = new System.Drawing.Point(109, 53);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 22);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(281, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(68, 22);
            this.textBox2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Artigo Selecionado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Preço Unitário (€):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Qtd. Adquirida:";
            // 
            // lblArtigoSelecionado
            // 
            this.lblArtigoSelecionado.AutoSize = true;
            this.lblArtigoSelecionado.Location = new System.Drawing.Point(138, 22);
            this.lblArtigoSelecionado.Name = "lblArtigoSelecionado";
            this.lblArtigoSelecionado.Size = new System.Drawing.Size(171, 16);
            this.lblArtigoSelecionado.TabIndex = 1;
            this.lblArtigoSelecionado.Text = "Selecione um artigo na lista";
            // 
            // labelartSelec
            // 
            this.labelartSelec.AutoSize = true;
            this.labelartSelec.Location = new System.Drawing.Point(7, 22);
            this.labelartSelec.Name = "labelartSelec";
            this.labelartSelec.Size = new System.Drawing.Size(125, 16);
            this.labelartSelec.TabIndex = 0;
            this.labelartSelec.Text = "Artigo Selecionado:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePicker1.Location = new System.Drawing.Point(463, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(159, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 15);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Valor Do orc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(271, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor Disponível: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Orçamento N.º: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Artigo,
            this.Tipo,
            this.QtdPrevista,
            this.QtdAdquirida,
            this.PrecoUnit,
            this.Subtotal});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(28, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(528, 510);
            this.dataGridView1.TabIndex = 2;
            // 
            // Artigo
            // 
            this.Artigo.HeaderText = "Artigo";
            this.Artigo.MinimumWidth = 6;
            this.Artigo.Name = "Artigo";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            // 
            // QtdPrevista
            // 
            this.QtdPrevista.HeaderText = "Qtd. Prevista";
            this.QtdPrevista.MinimumWidth = 6;
            this.QtdPrevista.Name = "QtdPrevista";
            // 
            // QtdAdquirida
            // 
            this.QtdAdquirida.HeaderText = "Qtd. Adquirida";
            this.QtdAdquirida.MinimumWidth = 6;
            this.QtdAdquirida.Name = "QtdAdquirida";
            // 
            // PrecoUnit
            // 
            this.PrecoUnit.HeaderText = "Prreço Unit.";
            this.PrecoUnit.MinimumWidth = 6;
            this.PrecoUnit.Name = "PrecoUnit";
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.MinimumWidth = 6;
            this.Subtotal.Name = "Subtotal";
            // 
            // ModoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 622);
            this.Controls.Add(this.panelModoCompra);
            this.Controls.Add(this.labelmodocompra);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ModoCompra";
            this.Text = "Modo Compra";
            this.panelModoCompra.ResumeLayout(false);
            this.panelModoCompra.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelmodocompra;
        private System.Windows.Forms.Panel panelModoCompra;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdPrevista;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdAdquirida;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblArtigoSelecionado;
        private System.Windows.Forms.Label labelartSelec;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}