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
            this.panelModoCompra.Controls.Add(this.dateTimePicker1);
            this.panelModoCompra.Controls.Add(this.textBox1);
            this.panelModoCompra.Controls.Add(this.label2);
            this.panelModoCompra.Controls.Add(this.label1);
            this.panelModoCompra.Location = new System.Drawing.Point(941, 77);
            this.panelModoCompra.Name = "panelModoCompra";
            this.panelModoCompra.Size = new System.Drawing.Size(666, 510);
            this.panelModoCompra.TabIndex = 1;
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
            this.textBox1.Location = new System.Drawing.Point(165, 14);
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
            this.label2.Location = new System.Drawing.Point(271, 7);
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
            this.dataGridView1.Location = new System.Drawing.Point(28, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(795, 510);
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
            this.ClientSize = new System.Drawing.Size(1619, 700);
            this.Controls.Add(this.panelModoCompra);
            this.Controls.Add(this.labelmodocompra);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ModoCompra";
            this.Text = "Modo Compra";
            this.panelModoCompra.ResumeLayout(false);
            this.panelModoCompra.PerformLayout();
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
    }
}