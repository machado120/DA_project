using GereOficina.Controller;
using GereOficina.Model;
using GereOficina.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GereOficina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizarClientes();//quando a app carrega vai mostrar a lista de clients
            return;
            using (OficinaContext context = new OficinaContext())
            {
                //criacao do objeto cliente
                Cliente cliente = new Cliente();
                cliente.Nome = "Ola";
                cliente.Nif = "DB";

                context.Clientes.Add(cliente);//Adiciona o cliente ao contexto(Memoria)
                //commit para a DB

                context.SaveChanges();//é o comit para a base de dados...
                Carro novoCarro = new Carro();

                novoCarro.Matricula = "qwerty";
                novoCarro.Dono = cliente;
                //Adicionar o carro ao contexto 
                context.Carros.Add(novoCarro);

                //Comit para a DB
                context.SaveChanges();


            }
        }



        private void AtualizarClientes()
        {
            listBoxClientes.DataSource = null;

            using (OficinaContext context = new OficinaContext())
            {
                listBoxClientes.DataSource = context.Clientes.ToList();// to list para obrigar a converter 
             }
        }
        private void buttonAdd_Click(object sender, EventArgs e)//evento do click do botao adicionar cliente
        {
            Oficinacontroller controller = new Oficinacontroller(); //instancia do controller para chamar o metodo adicionar cliente
            try
            {
                controller.AdicionarCliente(textBoxNome.Text, textBoxNif.Text);//chama o metodo adicionar cliente do controller para adicionar um cliente a base de dados

            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);//mostra a mensagem de erro caso haja um erro
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar cliente!");//mostra a mensagem de erro caso haja um erro
            }
            AtualizarClientes();
        }

        private void buttonRemove_Click(object sender, EventArgs e)//evento do click do botao remover cliente
        {
            Cliente clienteSelecionado = listBoxClientes.SelectedItem as Cliente;//obtem o cliente selecionado na lista de clientes
            if(clienteSelecionado == null)
            {
                MessageBox.Show("SELECIONAR O CLIENTE A REMOVER!");//mostra a mensagem de erro caso nao haja um cliente selecionado
                return;
            }
            

            Oficinacontroller controller = new Oficinacontroller();
            controller.RemoverCliente(clienteSelecionado.Id);//chama o metodo remover cliente do controller para remover um cliente da base de dados
            AtualizarClientes();
        }

        private void listBoxClientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Cliente clienteSelecionado = listBoxClientes.SelectedItem as Cliente;//obtem o cliente selecionado na lista de clientes
            if (clienteSelecionado == null)
            {
               return;
            }
            Detalhes formDetalhes = new Detalhes(clienteSelecionado);//instancia do formulario de detalhes para mostrar os detalhes do cliente selecionado
            this.Hide();//esconde o formulario principal
            formDetalhes.ShowDialog();//mostra o formulario de detalhes como uma caixa de diálogo modal
            this.Show();//mostra o formulario principal novamente quando o formulario de detalhes for fechado
        }
    }
}