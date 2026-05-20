using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controllers;

namespace WindowsFormsApp1.Views
{
    public partial class Gestao_de_Tipo_de_Artigos : Form
    {
        private ArtigosController controller = new ArtigosController();
        public Gestao_de_Tipo_de_Artigos()
        {
            InitializeComponent();
            atualiza_text();
        }


        private void buttonCriarArt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDetalhesArtigos.Text))
            {
                MessageBox.Show("Os campo não podem estar vazio");
            }
            else
            {
                controller.Add_Tipo_artigo(textBoxDetalhesArtigos.Text);
            }
            atualiza_text();
        }

        private void Gestao_de_Tipo_de_Artigos_Load(object sender, EventArgs e)
        {

        }

        private void atualiza_text()
        {
            listBoxTipos.DataSource = null;

            listBoxTipos.DataSource = controller.Get_tipo_de_Artigos();
        }
    }
}
