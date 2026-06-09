using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WindowsFormsApp1.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            LoginController controller = new LoginController();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            // Validações iniciais
            if (string.IsNullOrWhiteSpace(textUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Os campos não podem estar vazios");
            }
            else
            {
                LoginController controller = new LoginController();

                // Cria uma variável para guardar a resposta em vez de usar o Text da janela
                Utilizadores utilizador = controller.VerificarPass(textUsername.Text, txtPassword.Text);

                // Se correu bem, não precisas de mostrar MessageBox, a janela Principal já vai abrir.
                if (utilizador != null)
                {
                    // 1. Abre a janela Principal
                    Principal janelaPrincipal = new Principal(utilizador.Id, utilizador.Username);
                    janelaPrincipal.Show();

                    // 2. Garante que, quando o utilizador fechar a janela Principal, a aplicação fecha por completo
                    janelaPrincipal.FormClosed += (s, args) => this.Close();

                    // 3. Esconde a janela de Login
                    this.Hide();
                }
                else
                {
                    // Só mostras a mensagem se houver erro (Password incorreta ou Não encontrado)
                    MessageBox.Show("Utilizador não encontrado ou password incorreta");
                }
            }
        }

        private void buttonCriarNovoUtilizador_Click(object sender, EventArgs e)
        {
            LoginController controller = new LoginController(); //instancia do controller para chamar o metodo adicionar cliente
            if (string.IsNullOrWhiteSpace(textUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Os campos não podem estar vazios");
            }
            else
            {
                try
                {
                    controller.AdicionarCliente(textUsername.Text, txtPassword.Text);//chama o metodo adicionar cliente do controller para adicionar um cliente a base de dados

                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);//mostra a mensagem de erro caso haja um erro
                }
            }
        }

        private void btnRecoverPwd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Introduza o username e a nova password.");
                return;
            }
            LoginController controller = new LoginController();
            var utilizadores = controller.GetUtilizadores();
            var u = utilizadores.FirstOrDefault(x => x.Username == textUsername.Text);

            if (u == null)
            {
                MessageBox.Show("Utilizador não encontrado.");
                return;
            }
            u.Password = txtPassword.Text;
            controller.EditarUtilizador(u);
            MessageBox.Show("Password atualizada com sucesso!");
        }
    }
}

