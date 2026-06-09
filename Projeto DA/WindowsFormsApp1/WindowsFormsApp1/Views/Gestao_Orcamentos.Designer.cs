namespace WindowsFormsApp1.Views
{
    partial class Gestao_de_Orcamentos
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
            this.colMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.labelMesAno = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.numericValor = new System.Windows.Forms.NumericUpDown();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericValor)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMes,
            this.colAno,
            this.colValor,
            this.colId});
            this.dataGridView1.Location = new System.Drawing.Point(23, 45);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(420, 467);
            this.dataGridView1.TabIndex = 5;
            // 
            // colMes
            // 
            this.colMes.HeaderText = "Mês";
            this.colMes.MinimumWidth = 6;
            this.colMes.Name = "colMes";
            this.colMes.ReadOnly = true;
            // 
            // colAno
            // 
            this.colAno.HeaderText = "Ano";
            this.colAno.MinimumWidth = 6;
            this.colAno.Name = "colAno";
            this.colAno.ReadOnly = true;
            // 
            // colValor
            // 
            this.colValor.HeaderText = "Valor Máximo (€)";
            this.colValor.MinimumWidth = 6;
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(455, 45);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // labelMesAno
            // 
            this.labelMesAno.AutoSize = true;
            this.labelMesAno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelMesAno.Location = new System.Drawing.Point(462, 278);
            this.labelMesAno.Name = "labelMesAno";
            this.labelMesAno.Size = new System.Drawing.Size(164, 20);
            this.labelMesAno.TabIndex = 7;
            this.labelMesAno.Text = "Mês/Ano selecionado:";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(463, 357);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(110, 16);
            this.labelValor.TabIndex = 9;
            this.labelValor.Text = "Valor Máximo (€):";
            // 
            // numericValor
            // 
            this.numericValor.DecimalPlaces = 2;
            this.numericValor.Location = new System.Drawing.Point(463, 377);
            this.numericValor.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericValor.Name = "numericValor";
            this.numericValor.Size = new System.Drawing.Size(120, 22);
            this.numericValor.TabIndex = 8;
            // 
            // buttonGravar
            // 
            this.buttonGravar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonGravar.FlatAppearance.BorderSize = 0;
            this.buttonGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGravar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.buttonGravar.ForeColor = System.Drawing.Color.White;
            this.buttonGravar.Location = new System.Drawing.Point(463, 427);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(160, 35);
            this.buttonGravar.TabIndex = 10;
            this.buttonGravar.Text = "Gravar";
            this.buttonGravar.UseVisualStyleBackColor = false;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.buttonEliminar.FlatAppearance.BorderSize = 0;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.buttonEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonEliminar.Location = new System.Drawing.Point(463, 477);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(160, 35);
            this.buttonEliminar.TabIndex = 11;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // Gestao_de_Orcamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 636);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.labelMesAno);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.numericValor);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.buttonEliminar);
            this.Name = "Gestao_de_Orcamentos";
            this.Text = "Gestao_de_Orcamentos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label labelMesAno;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.NumericUpDown numericValor;
        private System.Windows.Forms.Button buttonGravar;
        private System.Windows.Forms.Button buttonEliminar;
    }
}