using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Views
{
    public partial class Gestao_Utilizadores : Form
    {
        private LoginController controller = new LoginController();
        private Utilizadores _selecionada = null;
        private int _userId;
        public Gestao_Utilizadores(int userId)
        {
            InitializeComponent();
            _userId = userId;// Armazena o ID do utilizador para associar as compras e alterações a esse utilizador
            AtualizarLista();
        }

        private void AtualizarLista()
        {
            listBoxUtilizadores.SelectedIndexChanged -= listBoxUtilizares_SelectedIndexChanged; 
            listBoxUtilizadores.DataSource = null;
            listBoxUtilizadores.DataSource = controller.GetUtilizadores(); 
            listBoxUtilizadores.DisplayMember = "Username"; // Exibe o nome do utilizador na lista
            listBoxUtilizadores.SelectedIndex = -1;
            listBoxUtilizadores.SelectedIndexChanged += listBoxUtilizares_SelectedIndexChanged;

            _selecionada = null; // Limpa a seleção
            textBoxNome.Clear();// Limpa o campo de texto
            textBoxPassword.Clear(); // Limpa o campo de texto

        }
        private void listBoxUtilizares_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selecionada = listBoxUtilizadores.SelectedItem as Utilizadores;


            if (_selecionada == null) return;// Se não há nada selecionado, sai do método

            {                
                textBoxNome.Text = _selecionada.Username;
                textBoxPassword.Text = _selecionada.Password;
            }
        }
       
        private void buttonCriar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBoxNome.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Os campos não podem estar vazios");
                return;
            }
            try
            {
                controller.AdicionarCliente(textBoxNome.Text, textBoxPassword.Text);
                AtualizarLista();

            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if(_selecionada == null)
            {
                MessageBox.Show("Selecione um utilizador:");
                return;

            }
            if(string.IsNullOrWhiteSpace(textBoxNome.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Os campos não podem estar vazios");
                return;
            }
            _selecionada.Username = textBoxNome.Text;
            _selecionada.Password = textBoxPassword.Text;
            controller.EditarUtilizador(_selecionada);
            AtualizarLista();
        }

        private void buttonElimiar_Click(object sender, EventArgs e)
        {
            if (_selecionada == null)
            {
                MessageBox.Show("Selecione um utilizador:");
                return;
            }
            if (_selecionada.Id == _userId)
            {
                MessageBox.Show("Não é possível eliminar o utilizador com sessão ativa.");
                return;
            }
            if (MessageBox.Show("Eliminar utilizador?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    controller.EliminarUtilizador(_selecionada);
                }
                catch (Exception)
                {
                    MessageBox.Show("Não é possível eliminar este utilizador.");
                }
                AtualizarLista();
            }
        }

        private void Gestao_Utilizadores_Load(object sender, EventArgs e)
        {

        }
    }
}