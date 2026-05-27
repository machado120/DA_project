using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class Principal : Form
    {
        public Principal(string username)
        {
            InitializeComponent();
            UtilizadorLogado.Text = "Utilizador Logado: " + username; // Exibe o nome do utilizador logado
        }

        private void paraCsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = "Document"; // Default file name
            dlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; // Default file  extensions
            dlg.FilterIndex = 1; // Default filter index
                                 // Show save file dialog box e process save file dialog box results
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Save document
                string filename = dlg.FileName;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void tiposDeArtigosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestao_de_Tipo_de_Artigos form = new Gestao_de_Tipo_de_Artigos();
            form.Show();
            form.FormClosed += (s, args) => this.Close();
            this.Hide();
        }

        private void utilizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void artigosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestao_de_Artigos form = new Gestao_de_Artigos();
            form.Show();
            form.FormClosed += (s, args) => this.Close();
            this.Hide();
        }

        private void orçamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestao_de_Orcamentos form = new Gestao_de_Orcamentos();
            form.Show();
            form.FormClosed += (s, args) => this.Close();
            this.Hide();
        }
    }
}
