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
    }
}
