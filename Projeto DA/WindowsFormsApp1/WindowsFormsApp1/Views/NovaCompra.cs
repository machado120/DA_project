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
    public partial class NovaCompra : Form
    {
        private ArtigosController artigosController = new ArtigosController();// Controlador para gerir as operações relacionadas com os artigos
        private ComprasController comprasController = new ComprasController();// Controlador para gerir as operações relacionadas com as compras
        private int _userId;
        private Compras _compra; // null = nova compra, não null = editar existente
        private List<Item> _itens = new List<Item>();// Lista para armazenar os itens da compra, mesmo antes de serem salvos na base de dados
        public NovaCompra(int userId, Compras compraExistente = null)
        {
            InitializeComponent();
            _userId = userId; // Armazena o ID do utilizador para associar as compras e alterações a esse utilizador
            _compra = compraExistente;

            CarregarTipos();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            buttonAddItem.Click += buttonAddItem_Click;
            buttonRemoverCompra.Click += buttonRemoverCompra_Click;
            buttonCriarCompra.Click += buttonCriarCompra_Click;
            buttonCancelarCompra.Click += (s, e) => this.Close();

            if (_compra != null)
            {
                textBoxNomeCompra.Text = _compra.NomeCompra;
                buttonCriarCompra.Text = "Guardar";
                CarregarItensExistentes();

                if (_compra.EstaFechada)
                    ModoLeituraApenas();
            }
        }
        private void CarregarTipos()// Carrega os tipos de artigos para o comboBox1, permitindo ao utilizador selecionar um tipo e ver os artigos correspondentes
        {
            var tipos = artigosController.Get_tipo_de_Artigos();
            comboBox1.DataSource = tipos;
            comboBox1.DisplayMember = "descricao";
            comboBox1.ValueMember = "Id";
            comboBox1.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)// Método que é chamado quando a seleção no comboBox1 muda, atualizando o comboBoxArtigoNovaCompra com os artigos correspondentes ao tipo selecionado
        {
            if (comboBox1.SelectedItem == null) return;// Verifica se um item está selecionado, caso contrário, não faz nada
            int tipoId = ((Tipo_de_Artigos)comboBox1.SelectedItem).Id;
            var artigos = artigosController.GetArtigosPorTipo(tipoId);
            comboBoxArtigoNovaCompra.DataSource = artigos;
            comboBoxArtigoNovaCompra.DisplayMember = "Nome";
            comboBoxArtigoNovaCompra.ValueMember = "Id";
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            if (comboBoxArtigoNovaCompra.SelectedItem == null)
            {
                MessageBox.Show("Selecione um artigo.");
                return;
            }

            var artigo = (Artigos)comboBoxArtigoNovaCompra.SelectedItem;
            decimal qtd = numericUpDown1.Value;
            decimal preco = 0;
            decimal.TryParse(textBox1.Text, out preco);

            var item = new Item { ArtigoId = artigo.Id, QuantidadePrevista = qtd, PrecoUnitario = preco, E_Previsto = true };
            _itens.Add(item);
            dataGridView1.Rows.Add(artigo.Nome, artigo.TipoArtigo?.descricao ?? "", qtd, preco, qtd * preco);
            AtualizarTotal();
        }

        private void buttonRemoverCompra_Click(object sender, EventArgs e)// Método que é chamado quando o utilizador clica no botão para remover um item da compra, removendo o item selecionado tanto da lista de itens quanto da grelha de exibição
        {
            if (dataGridView1.CurrentRow == null) return;
            int idx = dataGridView1.CurrentRow.Index;// Obtém o índice da linha selecionada na grelha
            if (idx < 0 || idx >= _itens.Count) return;

            var item = _itens[idx];// Obtém o item correspondente ao índice selecionado na grelha
            if (item.Id > 0)
                comprasController.RemoverItem(item.Id);

            _itens.RemoveAt(idx);
            dataGridView1.Rows.RemoveAt(idx);
            AtualizarTotal();
        }

        private void buttonCriarCompra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNomeCompra.Text))
            {
                MessageBox.Show("Insira o nome da compra.");
                return;
            }

            try
            {
                if (_compra == null)
                {
                    _compra = comprasController.CriarCompra(textBoxNomeCompra.Text.Trim(), _userId);
                    foreach (var item in _itens)
                        comprasController.AddItem(_compra.Id, item.ArtigoId, item.QuantidadePrevista, item.PrecoUnitario);
                }
                else
                {
                    comprasController.EditarCompra(_compra, textBoxNomeCompra.Text.Trim(), _userId);// Edita a compra existente, atualizando o nome e associando as alterações ao utilizador
                    foreach (var item in _itens.FindAll(i => i.Id == 0))// Adiciona apenas os itens que ainda não foram salvos na base de dados (Id == 0)
                        comprasController.AddItem(_compra.Id, item.ArtigoId, item.QuantidadePrevista);// Adiciona os novos itens à compra existente, garantindo que apenas os itens recém-adicionados sejam inseridos na base de dados, evitando duplicações dos itens já existentes.
                }

                MessageBox.Show("Compra guardada com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CarregarItensExistentes()
        {
            _itens = comprasController.GetItens(_compra.Id);// Carrega os itens existentes da compra, permitindo que sejam exibidos na grelha e editados se necessário
            dataGridView1.Rows.Clear();
            foreach (var item in _itens)
                dataGridView1.Rows.Add(item.Artigos?.Nome ?? "", item.Artigos?.TipoArtigo?.descricao ?? "",
                    item.QuantidadePrevista, item.PrecoUnitario, item.QuantidadePrevista * item.PrecoUnitario);// Adiciona cada item à grelha, exibindo o nome do artigo, tipo, quantidade prevista, preço unitário e subtotal (quantidade x preço)
            AtualizarTotal();
        }

        private void AtualizarTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (decimal.TryParse(row.Cells["Subtotal"].Value?.ToString(), out decimal sub))
                    total += sub;
            }
            labelTotalPrev.Text = total.ToString("F2");// Atualiza o rótulo que exibe o total previsto da compra, formatando o valor como moeda com duas casas decimais
        }

        private void ModoLeituraApenas()// Configura a interface para um modo de leitura apenas, desabilitando a edição do nome da compra, a adição e remoção de itens, e alterando o título da janela para indicar que a compra está fechada
        {
            textBoxNomeCompra.ReadOnly = true;// Define o campo de texto do nome da compra como somente leitura, impedindo que o utilizador faça alterações
            groupBox1.Enabled = false;
            buttonCriarCompra.Enabled = false;
            buttonRemoverCompra.Enabled = false;
            this.Text = "Compra (Fechada - Só Leitura)";
        }
    
        private void NovaCompra_Load(object sender, EventArgs e)
        {

        }
    }
}
