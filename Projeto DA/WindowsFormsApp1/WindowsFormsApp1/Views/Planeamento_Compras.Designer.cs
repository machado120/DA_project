namespace WindowsFormsApp1.Views
{
    partial class Planeamento_Compras
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataCriacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.buttonNovaCompra = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonModoCompra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNome,
            this.colDataCriacao,
            this.colEstado});
            this.dataGridView1.Location = new System.Drawing.Point(20, 50);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(560, 380);
            this.dataGridView1.TabIndex = 0;
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome da Compra";
            this.colNome.MinimumWidth = 6;
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colDataCriacao
            // 
            this.colDataCriacao.HeaderText = "Data Criação";
            this.colDataCriacao.MinimumWidth = 6;
            this.colDataCriacao.Name = "colDataCriacao";
            this.colDataCriacao.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.MinimumWidth = 6;
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.Items.AddRange(new object[] {
            "Todas",
            "Abertas",
            "Fechadas"});
            this.comboBoxFiltro.Location = new System.Drawing.Point(70, 15);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(150, 24);
            this.comboBoxFiltro.TabIndex = 1;
            // 
            // labelFiltro
            // 
            this.labelFiltro.AutoSize = true;
            this.labelFiltro.Location = new System.Drawing.Point(20, 18);
            this.labelFiltro.Name = "labelFiltro";
            this.labelFiltro.Size = new System.Drawing.Size(43, 16);
            this.labelFiltro.TabIndex = 1;
            this.labelFiltro.Text = "Filtrar:";
            // 
            // buttonNovaCompra
            // 
            this.buttonNovaCompra.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonNovaCompra.FlatAppearance.BorderSize = 0;
            this.buttonNovaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNovaCompra.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.buttonNovaCompra.ForeColor = System.Drawing.Color.White;
            this.buttonNovaCompra.Location = new System.Drawing.Point(600, 50);
            this.buttonNovaCompra.Name = "buttonNovaCompra";
            this.buttonNovaCompra.Size = new System.Drawing.Size(160, 35);
            this.buttonNovaCompra.TabIndex = 2;
            this.buttonNovaCompra.Text = "Nova Compra";
            this.buttonNovaCompra.UseVisualStyleBackColor = false;
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonEditar.FlatAppearance.BorderSize = 0;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.buttonEditar.ForeColor = System.Drawing.Color.White;
            this.buttonEditar.Location = new System.Drawing.Point(600, 105);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(160, 35);
            this.buttonEditar.TabIndex = 3;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.buttonEliminar.FlatAppearance.BorderSize = 0;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.buttonEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonEliminar.Location = new System.Drawing.Point(600, 160);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(160, 35);
            this.buttonEliminar.TabIndex = 4;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            // 
            // buttonModoCompra
            // 
            this.buttonModoCompra.BackColor = System.Drawing.Color.Orange;
            this.buttonModoCompra.FlatAppearance.BorderSize = 0;
            this.buttonModoCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModoCompra.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.buttonModoCompra.ForeColor = System.Drawing.Color.White;
            this.buttonModoCompra.Location = new System.Drawing.Point(600, 395);
            this.buttonModoCompra.Name = "buttonModoCompra";
            this.buttonModoCompra.Size = new System.Drawing.Size(160, 35);
            this.buttonModoCompra.TabIndex = 5;
            this.buttonModoCompra.Text = "Modo Compra";
            this.buttonModoCompra.UseVisualStyleBackColor = false;
            this.buttonModoCompra.Click += new System.EventHandler(this.buttonModoCompra_Click);
            // 
            // Planeamento_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 460);
            this.Controls.Add(this.buttonModoCompra);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelFiltro);
            this.Controls.Add(this.comboBoxFiltro);
            this.Controls.Add(this.buttonNovaCompra);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonEliminar);
            this.Name = "Planeamento_Compras";
            this.Text = "Planeamento de Compras";
            this.Load += new System.EventHandler(this.Planeamento_Compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataCriacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.ComboBox comboBoxFiltro;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.Button buttonNovaCompra;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModoCompra;
    }
}
