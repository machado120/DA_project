namespace WindowsFormsApp1.Views
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraCsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.gestaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilizadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeArtigosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artigosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orçamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planeamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estatísticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.colTipoArtigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArtigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtdPrevista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtdAdquirida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomeCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTACriacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CriadaPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.UtilizadorLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, -1, 2);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem,
            this.toolStripTextBox1,
            this.gestaoToolStripMenuItem,
            this.toolStripTextBox2,
            this.comprasToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1196, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.ficheiroToolStripMenuItem.Text = "Ficheiro";
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.exportarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paraCsvToolStripMenuItem});
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exportarToolStripMenuItem.Text = "Exportar";
            // 
            // paraCsvToolStripMenuItem
            // 
            this.paraCsvToolStripMenuItem.Name = "paraCsvToolStripMenuItem";
            this.paraCsvToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.paraCsvToolStripMenuItem.Text = "Para csv.";
            this.paraCsvToolStripMenuItem.Click += new System.EventHandler(this.paraCsvToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.toolStripTextBox1.Margin = new System.Windows.Forms.Padding(-5);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(9, 34);
            this.toolStripTextBox1.Text = "|";
            // 
            // gestaoToolStripMenuItem
            // 
            this.gestaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilizadoresToolStripMenuItem,
            this.tiposDeArtigosToolStripMenuItem,
            this.artigosToolStripMenuItem,
            this.orçamentosToolStripMenuItem});
            this.gestaoToolStripMenuItem.Name = "gestaoToolStripMenuItem";
            this.gestaoToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.gestaoToolStripMenuItem.Text = "Gestao";
            // 
            // utilizadoresToolStripMenuItem
            // 
            this.utilizadoresToolStripMenuItem.Name = "utilizadoresToolStripMenuItem";
            this.utilizadoresToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.utilizadoresToolStripMenuItem.Text = "Utilizadores";
            this.utilizadoresToolStripMenuItem.Click += new System.EventHandler(this.utilizadoresToolStripMenuItem_Click);
            // 
            // tiposDeArtigosToolStripMenuItem
            // 
            this.tiposDeArtigosToolStripMenuItem.Name = "tiposDeArtigosToolStripMenuItem";
            this.tiposDeArtigosToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.tiposDeArtigosToolStripMenuItem.Text = "Tipos de Artigos";
            this.tiposDeArtigosToolStripMenuItem.Click += new System.EventHandler(this.tiposDeArtigosToolStripMenuItem_Click);
            // 
            // artigosToolStripMenuItem
            // 
            this.artigosToolStripMenuItem.Name = "artigosToolStripMenuItem";
            this.artigosToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.artigosToolStripMenuItem.Text = "Artigos";
            this.artigosToolStripMenuItem.Click += new System.EventHandler(this.artigosToolStripMenuItem_Click);
            // 
            // orçamentosToolStripMenuItem
            // 
            this.orçamentosToolStripMenuItem.Name = "orçamentosToolStripMenuItem";
            this.orçamentosToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.orçamentosToolStripMenuItem.Text = "Orçamentos";
            this.orçamentosToolStripMenuItem.Click += new System.EventHandler(this.orçamentosToolStripMenuItem_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.toolStripTextBox2.Margin = new System.Windows.Forms.Padding(-5);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(9, 34);
            this.toolStripTextBox2.Text = "|";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planeamentoToolStripMenuItem,
            this.estatísticaToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // planeamentoToolStripMenuItem
            // 
            this.planeamentoToolStripMenuItem.Name = "planeamentoToolStripMenuItem";
            this.planeamentoToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.planeamentoToolStripMenuItem.Text = "Planeamento";
            this.planeamentoToolStripMenuItem.Click += new System.EventHandler(this.planeamentoToolStripMenuItem_Click);
            // 
            // estatísticaToolStripMenuItem
            // 
            this.estatísticaToolStripMenuItem.Name = "estatísticaToolStripMenuItem";
            this.estatísticaToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.estatísticaToolStripMenuItem.Text = "Estatística";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(935, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Nova Compra / Planear";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTipoArtigo,
            this.colArtigo,
            this.colQtdPrevista,
            this.colQtdAdquirida,
            this.colPrecoUnitario});
            this.dataGridView2.Location = new System.Drawing.Point(455, 73);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView2.RowTemplate.Height = 50;
            this.dataGridView2.Size = new System.Drawing.Size(707, 447);
            this.dataGridView2.TabIndex = 3;
            // 
            // colTipoArtigo
            // 
            this.colTipoArtigo.HeaderText = "Tipo de Artigo";
            this.colTipoArtigo.MinimumWidth = 6;
            this.colTipoArtigo.Name = "colTipoArtigo";
            this.colTipoArtigo.ReadOnly = true;
            // 
            // colArtigo
            // 
            this.colArtigo.HeaderText = "Artigo";
            this.colArtigo.MinimumWidth = 6;
            this.colArtigo.Name = "colArtigo";
            this.colArtigo.ReadOnly = true;
            // 
            // colQtdPrevista
            // 
            this.colQtdPrevista.HeaderText = "Qtd. Prevista";
            this.colQtdPrevista.MinimumWidth = 6;
            this.colQtdPrevista.Name = "colQtdPrevista";
            this.colQtdPrevista.ReadOnly = true;
            // 
            // colQtdAdquirida
            // 
            this.colQtdAdquirida.HeaderText = "Qtd. Adquirida";
            this.colQtdAdquirida.MinimumWidth = 6;
            this.colQtdAdquirida.Name = "colQtdAdquirida";
            this.colQtdAdquirida.ReadOnly = true;
            // 
            // colPrecoUnitario
            // 
            this.colPrecoUnitario.HeaderText = "Preço Unitário";
            this.colPrecoUnitario.MinimumWidth = 6;
            this.colPrecoUnitario.Name = "colPrecoUnitario";
            this.colPrecoUnitario.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeCompra,
            this.DTACriacao,
            this.CriadaPor});
            this.dataGridView1.Location = new System.Drawing.Point(25, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.Size = new System.Drawing.Size(407, 447);
            this.dataGridView1.TabIndex = 6;
            // 
            // nomeCompra
            // 
            this.nomeCompra.HeaderText = "Nome Compra";
            this.nomeCompra.MinimumWidth = 6;
            this.nomeCompra.Name = "nomeCompra";
            this.nomeCompra.ReadOnly = true;
            // 
            // DTACriacao
            // 
            this.DTACriacao.HeaderText = "Data de Criação";
            this.DTACriacao.MinimumWidth = 6;
            this.DTACriacao.Name = "DTACriacao";
            this.DTACriacao.ReadOnly = true;
            // 
            // CriadaPor
            // 
            this.CriadaPor.HeaderText = "Criada por:";
            this.CriadaPor.MinimumWidth = 6;
            this.CriadaPor.Name = "CriadaPor";
            this.CriadaPor.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(691, 526);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "Aceder ao Modo Compra";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Compras em Aberto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(451, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Detalhes / Artigos da Compra";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UtilizadorLogado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 566);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1196, 26);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // UtilizadorLogado
            // 
            this.UtilizadorLogado.Name = "UtilizadorLogado";
            this.UtilizadorLogado.Size = new System.Drawing.Size(129, 20);
            this.UtilizadorLogado.Text = "Utilizador logado:";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1196, 592);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planeamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estatísticaToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoArtigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArtigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtdPrevista;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtdAdquirida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecoUnitario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTACriacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CriadaPor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem gestaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilizadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeArtigosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artigosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orçamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraCsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel UtilizadorLogado;
    }
}