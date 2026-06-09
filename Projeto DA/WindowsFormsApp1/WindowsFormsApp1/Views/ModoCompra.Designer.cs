namespace WindowsFormsApp1.Views
{
    partial class ModoCompra
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelmodocompra = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Artigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdPrevista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdAdquirida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelModoCompra = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelartSelec = new System.Windows.Forms.Label();
            this.lblArtigoSelecionado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonMarcar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelTipoNP = new System.Windows.Forms.Label();
            this.comboBoxTipoNP = new System.Windows.Forms.ComboBox();
            this.labelArtigoNP = new System.Windows.Forms.Label();
            this.comboBoxArtigoNP = new System.Windows.Forms.ComboBox();
            this.labelQtdNP = new System.Windows.Forms.Label();
            this.numericUpDownNP = new System.Windows.Forms.NumericUpDown();
            this.labelPrecoNP = new System.Windows.Forms.Label();
            this.textBoxPrecoNP = new System.Windows.Forms.TextBox();
            this.buttonAddNaoPrevisto = new System.Windows.Forms.Button();
            this.labelObsNP = new System.Windows.Forms.Label();
            this.textBoxObsNP = new System.Windows.Forms.TextBox();
            this.buttonFecharCompra = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelModoCompra.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNP)).BeginInit();
            this.SuspendLayout();
            // 
            // labelmodocompra
            // 
            this.labelmodocompra.AutoSize = true;
            this.labelmodocompra.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelmodocompra.Location = new System.Drawing.Point(23, 20);
            this.labelmodocompra.Name = "labelmodocompra";
            this.labelmodocompra.Size = new System.Drawing.Size(182, 25);
            this.labelmodocompra.TabIndex = 0;
            this.labelmodocompra.Text = "A processar Compra:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Artigo,
            this.Tipo,
            this.QtdPrevista,
            this.QtdAdquirida,
            this.PrecoUnit,
            this.Subtotal});
            this.dataGridView1.Location = new System.Drawing.Point(20, 55);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(540, 510);
            this.dataGridView1.TabIndex = 0;
            // 
            // Artigo
            // 
            this.Artigo.HeaderText = "Artigo";
            this.Artigo.MinimumWidth = 6;
            this.Artigo.Name = "Artigo";
            this.Artigo.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // QtdPrevista
            // 
            this.QtdPrevista.HeaderText = "Qtd. Prevista";
            this.QtdPrevista.MinimumWidth = 6;
            this.QtdPrevista.Name = "QtdPrevista";
            this.QtdPrevista.ReadOnly = true;
            // 
            // QtdAdquirida
            // 
            this.QtdAdquirida.HeaderText = "Qtd. Adquirida";
            this.QtdAdquirida.MinimumWidth = 6;
            this.QtdAdquirida.Name = "QtdAdquirida";
            this.QtdAdquirida.ReadOnly = true;
            // 
            // PrecoUnit
            // 
            this.PrecoUnit.HeaderText = "Preço Unit.";
            this.PrecoUnit.MinimumWidth = 6;
            this.PrecoUnit.Name = "PrecoUnit";
            this.PrecoUnit.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.MinimumWidth = 6;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // panelModoCompra
            // 
            this.panelModoCompra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelModoCompra.Controls.Add(this.label1);
            this.panelModoCompra.Controls.Add(this.label2);
            this.panelModoCompra.Controls.Add(this.textBox1);
            this.panelModoCompra.Controls.Add(this.groupBox1);
            this.panelModoCompra.Controls.Add(this.groupBox2);
            this.panelModoCompra.Location = new System.Drawing.Point(580, 55);
            this.panelModoCompra.Name = "panelModoCompra";
            this.panelModoCompra.Size = new System.Drawing.Size(660, 510);
            this.panelModoCompra.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orçamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(280, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor Disponível:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(430, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(120, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0.00 €";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelartSelec);
            this.groupBox1.Controls.Add(this.lblArtigoSelecionado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.buttonMarcar);
            this.groupBox1.Location = new System.Drawing.Point(10, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 180);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marcar Item Adquirido";
            // 
            // labelartSelec
            // 
            this.labelartSelec.AutoSize = true;
            this.labelartSelec.Location = new System.Drawing.Point(10, 25);
            this.labelartSelec.Name = "labelartSelec";
            this.labelartSelec.Size = new System.Drawing.Size(125, 16);
            this.labelartSelec.TabIndex = 0;
            this.labelartSelec.Text = "Artigo Selecionado:";
            // 
            // lblArtigoSelecionado
            // 
            this.lblArtigoSelecionado.AutoSize = true;
            this.lblArtigoSelecionado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblArtigoSelecionado.Location = new System.Drawing.Point(140, 25);
            this.lblArtigoSelecionado.Name = "lblArtigoSelecionado";
            this.lblArtigoSelecionado.Size = new System.Drawing.Size(201, 20);
            this.lblArtigoSelecionado.TabIndex = 1;
            this.lblArtigoSelecionado.Text = "Selecione um artigo na lista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Qtd. Adquirida:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(120, 67);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 22);
            this.numericUpDown1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Preço Unit. (€):";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(330, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(80, 22);
            this.textBox2.TabIndex = 5;
            // 
            // buttonMarcar
            // 
            this.buttonMarcar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonMarcar.FlatAppearance.BorderSize = 0;
            this.buttonMarcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMarcar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.buttonMarcar.ForeColor = System.Drawing.Color.White;
            this.buttonMarcar.Location = new System.Drawing.Point(440, 63);
            this.buttonMarcar.Name = "buttonMarcar";
            this.buttonMarcar.Size = new System.Drawing.Size(160, 30);
            this.buttonMarcar.TabIndex = 6;
            this.buttonMarcar.Text = "Marcar Adquirido";
            this.buttonMarcar.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelTipoNP);
            this.groupBox2.Controls.Add(this.comboBoxTipoNP);
            this.groupBox2.Controls.Add(this.labelArtigoNP);
            this.groupBox2.Controls.Add(this.comboBoxArtigoNP);
            this.groupBox2.Controls.Add(this.labelQtdNP);
            this.groupBox2.Controls.Add(this.numericUpDownNP);
            this.groupBox2.Controls.Add(this.labelPrecoNP);
            this.groupBox2.Controls.Add(this.textBoxPrecoNP);
            this.groupBox2.Controls.Add(this.buttonAddNaoPrevisto);
            this.groupBox2.Controls.Add(this.labelObsNP);
            this.groupBox2.Controls.Add(this.textBoxObsNP);
            this.groupBox2.Location = new System.Drawing.Point(10, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(635, 200);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adicionar Item Não Previsto";
            // 
            // labelTipoNP
            // 
            this.labelTipoNP.AutoSize = true;
            this.labelTipoNP.Location = new System.Drawing.Point(10, 30);
            this.labelTipoNP.Name = "labelTipoNP";
            this.labelTipoNP.Size = new System.Drawing.Size(38, 16);
            this.labelTipoNP.TabIndex = 0;
            this.labelTipoNP.Text = "Tipo:";
            // 
            // comboBoxTipoNP
            // 
            this.comboBoxTipoNP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoNP.FormattingEnabled = true;
            this.comboBoxTipoNP.Location = new System.Drawing.Point(60, 27);
            this.comboBoxTipoNP.Name = "comboBoxTipoNP";
            this.comboBoxTipoNP.Size = new System.Drawing.Size(200, 24);
            this.comboBoxTipoNP.TabIndex = 1;
            // 
            // labelArtigoNP
            // 
            this.labelArtigoNP.AutoSize = true;
            this.labelArtigoNP.Location = new System.Drawing.Point(10, 65);
            this.labelArtigoNP.Name = "labelArtigoNP";
            this.labelArtigoNP.Size = new System.Drawing.Size(45, 16);
            this.labelArtigoNP.TabIndex = 2;
            this.labelArtigoNP.Text = "Artigo:";
            // 
            // comboBoxArtigoNP
            // 
            this.comboBoxArtigoNP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxArtigoNP.FormattingEnabled = true;
            this.comboBoxArtigoNP.Location = new System.Drawing.Point(60, 62);
            this.comboBoxArtigoNP.Name = "comboBoxArtigoNP";
            this.comboBoxArtigoNP.Size = new System.Drawing.Size(200, 24);
            this.comboBoxArtigoNP.TabIndex = 3;
            // 
            // labelQtdNP
            // 
            this.labelQtdNP.AutoSize = true;
            this.labelQtdNP.Location = new System.Drawing.Point(4, 103);
            this.labelQtdNP.Name = "labelQtdNP";
            this.labelQtdNP.Size = new System.Drawing.Size(80, 16);
            this.labelQtdNP.TabIndex = 4;
            this.labelQtdNP.Text = "Quantidade:";
            // 
            // numericUpDownNP
            // 
            this.numericUpDownNP.DecimalPlaces = 2;
            this.numericUpDownNP.Location = new System.Drawing.Point(90, 100);
            this.numericUpDownNP.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownNP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownNP.Name = "numericUpDownNP";
            this.numericUpDownNP.Size = new System.Drawing.Size(80, 22);
            this.numericUpDownNP.TabIndex = 5;
            this.numericUpDownNP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelPrecoNP
            // 
            this.labelPrecoNP.AutoSize = true;
            this.labelPrecoNP.Location = new System.Drawing.Point(190, 103);
            this.labelPrecoNP.Name = "labelPrecoNP";
            this.labelPrecoNP.Size = new System.Drawing.Size(93, 16);
            this.labelPrecoNP.TabIndex = 6;
            this.labelPrecoNP.Text = "Preço Unit. (€):";
            // 
            // textBoxPrecoNP
            // 
            this.textBoxPrecoNP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPrecoNP.Location = new System.Drawing.Point(300, 100);
            this.textBoxPrecoNP.Name = "textBoxPrecoNP";
            this.textBoxPrecoNP.Size = new System.Drawing.Size(80, 22);
            this.textBoxPrecoNP.TabIndex = 7;
            // 
            // buttonAddNaoPrevisto
            // 
            this.buttonAddNaoPrevisto.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonAddNaoPrevisto.FlatAppearance.BorderSize = 0;
            this.buttonAddNaoPrevisto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNaoPrevisto.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.buttonAddNaoPrevisto.ForeColor = System.Drawing.Color.White;
            this.buttonAddNaoPrevisto.Location = new System.Drawing.Point(420, 97);
            this.buttonAddNaoPrevisto.Name = "buttonAddNaoPrevisto";
            this.buttonAddNaoPrevisto.Size = new System.Drawing.Size(180, 30);
            this.buttonAddNaoPrevisto.TabIndex = 8;
            this.buttonAddNaoPrevisto.Text = "+ Adicionar";
            this.buttonAddNaoPrevisto.UseVisualStyleBackColor = false;
            // 
            // labelObsNP
            // 
            this.labelObsNP.AutoSize = true;
            this.labelObsNP.Location = new System.Drawing.Point(5, 143);
            this.labelObsNP.Name = "labelObsNP";
            this.labelObsNP.Size = new System.Drawing.Size(38, 16);
            this.labelObsNP.TabIndex = 9;
            this.labelObsNP.Text = "Obs.:";
            // 
            // textBoxObsNP
            // 
            this.textBoxObsNP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxObsNP.Location = new System.Drawing.Point(60, 140);
            this.textBoxObsNP.Name = "textBoxObsNP";
            this.textBoxObsNP.Size = new System.Drawing.Size(540, 22);
            this.textBoxObsNP.TabIndex = 10;
            // 
            // buttonFecharCompra
            // 
            this.buttonFecharCompra.BackColor = System.Drawing.Color.IndianRed;
            this.buttonFecharCompra.FlatAppearance.BorderSize = 0;
            this.buttonFecharCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFecharCompra.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.buttonFecharCompra.ForeColor = System.Drawing.Color.White;
            this.buttonFecharCompra.Location = new System.Drawing.Point(900, 580);
            this.buttonFecharCompra.Name = "buttonFecharCompra";
            this.buttonFecharCompra.Size = new System.Drawing.Size(170, 35);
            this.buttonFecharCompra.TabIndex = 2;
            this.buttonFecharCompra.Text = "Fechar Compra";
            this.buttonFecharCompra.UseVisualStyleBackColor = false;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.BackColor = System.Drawing.Color.Gray;
            this.buttonVoltar.FlatAppearance.BorderSize = 0;
            this.buttonVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVoltar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.buttonVoltar.ForeColor = System.Drawing.Color.White;
            this.buttonVoltar.Location = new System.Drawing.Point(20, 580);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(120, 35);
            this.buttonVoltar.TabIndex = 3;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = false;
            // 
            // ModoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 635);
            this.Controls.Add(this.labelmodocompra);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelModoCompra);
            this.Controls.Add(this.buttonFecharCompra);
            this.Controls.Add(this.buttonVoltar);
            this.Name = "ModoCompra";
            this.Text = "Modo Compra";
            this.Load += new System.EventHandler(this.ModoCompra_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelModoCompra.ResumeLayout(false);
            this.panelModoCompra.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelmodocompra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdPrevista;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdAdquirida;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Panel panelModoCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelartSelec;
        private System.Windows.Forms.Label lblArtigoSelecionado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonMarcar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelTipoNP;
        private System.Windows.Forms.ComboBox comboBoxTipoNP;
        private System.Windows.Forms.Label labelArtigoNP;
        private System.Windows.Forms.ComboBox comboBoxArtigoNP;
        private System.Windows.Forms.Label labelQtdNP;
        private System.Windows.Forms.NumericUpDown numericUpDownNP;
        private System.Windows.Forms.Label labelPrecoNP;
        private System.Windows.Forms.TextBox textBoxPrecoNP;
        private System.Windows.Forms.Button buttonAddNaoPrevisto;
        private System.Windows.Forms.Label labelObsNP;
        private System.Windows.Forms.TextBox textBoxObsNP;
        private System.Windows.Forms.Button buttonFecharCompra;
        private System.Windows.Forms.Button buttonVoltar;
    }
}
