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
    public partial class ModoCompra : Form
    {
        private readonly Compras _compra;
        private readonly int _userId;
        private readonly ComprasController _comprasCtrl = new ComprasController();
        private readonly OrcamentosController _orcCtrl = new OrcamentosController();
        private readonly ArtigosController _artigosCtrl = new ArtigosController();
        private List<Item> _itens = new List<Item>();
        private decimal _orcamentoInicial = 0;

        public ModoCompra(Compras compra, int userId)
        {
            InitializeComponent();
            _compra = compra;
            _userId = userId;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Load += ModoCompra_Load;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            buttonMarcar.Click += buttonMarcar_Click;
            comboBoxTipoNP.SelectedIndexChanged += comboBoxTipoNP_SelectedIndexChanged;
            buttonAddNaoPrevisto.Click += buttonAddNaoPrevisto_Click;
            buttonFecharCompra.Click += buttonFecharCompra_Click;
            buttonVoltar.Click += (s, e) => this.Close();
        }

        private void ModoCompra_Load(object sender, EventArgs e)
        {
            labelmodocompra.Text = "A processar: " + _compra.NomeCompra;

            // Orçamento do mês atual
            var orc = _orcCtrl.GetOrcamentoPorMes(DateTime.Now.Month, DateTime.Now.Year);
            if (orc != null)
            {
                _orcamentoInicial = orc.ValorMaximo;
                label1.Text = $"Orçamento {orc.Mes}/{orc.Ano}: {orc.ValorMaximo:F2} €";
            }
            else
            {
                label1.Text = "Sem orçamento para este mês";
                _orcamentoInicial = 0;
            }

            // Carregar tipos para artigos não previstos
            var tipos = _artigosCtrl.Get_tipo_de_Artigos();
            comboBoxTipoNP.DisplayMember = "descricao";// Define o membro de exibição para o comboBoxTipoNP, permitindo que o utilizador veja a descrição do tipo de artigo
            comboBoxTipoNP.ValueMember = "Id";// Define os membros de exibição e valor para o comboBoxTipoNP, permitindo que o utilizador veja a descrição do tipo de artigo e selecione um tipo com base no seu ID
            comboBoxTipoNP.DataSource = tipos;// Carrega os tipos de artigos para o comboBoxTipoNP, permitindo ao utilizador selecionar um tipo e ver os artigos correspondentes
            comboBoxTipoNP.SelectedIndex = -1;// Nenhum tipo selecionado por padrão

            // Modo só leitura se compra fechada
            if (_compra.EstaFechada)
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                buttonFecharCompra.Enabled = false;
                this.Text = "Modo Compra (Fechada — Só Leitura)";
            }

            AtualizarGrelha();
        }

        private void AtualizarGrelha()
        {
            _itens = _comprasCtrl.GetItens(_compra.Id);
            dataGridView1.Rows.Clear();
            decimal totalGasto = 0;

            foreach (var item in _itens)
            {
                decimal subtotal = item.QuantidadeAdquirida * item.PrecoUnitario;
                totalGasto += subtotal;
                string nomeArtigo = item.Artigos?.Nome ?? "?";
                string tipoArtigo = item.E_Previsto
                    ? (item.Artigos?.TipoArtigo?.descricao ?? "")
                    : "Não Previsto";

                dataGridView1.Rows.Add(
                    nomeArtigo,
                    tipoArtigo,
                    item.QuantidadePrevista > 0 ? item.QuantidadePrevista.ToString("F2") : "-",
                    item.QuantidadeAdquirida > 0 ? item.QuantidadeAdquirida.ToString("F2") : "",
                    item.PrecoUnitario > 0 ? item.PrecoUnitario.ToString("F2") : "",
                    subtotal > 0 ? subtotal.ToString("F2") : "");
            }

            // Atualizar valor disponível com alerta de cor
            decimal restante = _orcamentoInicial - totalGasto;
            textBox1.Text = restante.ToString("F2") + " €";
            if (_orcamentoInicial > 0 && restante < 0)
            {
                textBox1.ForeColor = Color.Red; // ultrapassou orçamento
            }
            else
            {
                textBox1.ForeColor = Color.White;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            int idx = dataGridView1.SelectedRows[0].Index;
            if (idx < 0 || idx >= _itens.Count) return;

            var item = _itens[idx];
            lblArtigoSelecionado.Text = item.Artigos?.Nome ?? "?";
            numericUpDown1.Value = item.QuantidadeAdquirida > 0 ? item.QuantidadeAdquirida : item.QuantidadePrevista;
            textBox2.Text = item.PrecoUnitario > 0 ? item.PrecoUnitario.ToString("F2") : "";
        }

        private void buttonMarcar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um artigo na lista.");
                return;
            }
            int idx = dataGridView1.SelectedRows[0].Index;
            if (idx < 0 || idx >= _itens.Count) return;

            decimal preco = 0;
            decimal.TryParse(textBox2.Text.Replace(",", "."),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out preco);

            _comprasCtrl.MarcarAdquirido(_itens[idx].Id, numericUpDown1.Value, preco);
            AtualizarGrelha();
        }

        private void comboBoxTipoNP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipoNP.SelectedValue == null) return;
            int tipoId = (int)comboBoxTipoNP.SelectedValue;
            var artigos = _artigosCtrl.GetArtigosPorTipo(tipoId);
            comboBoxArtigoNP.DataSource = artigos;
            comboBoxArtigoNP.DisplayMember = "Nome";
            comboBoxArtigoNP.ValueMember = "Id";
            comboBoxArtigoNP.SelectedIndex = -1;
        }

        private void buttonAddNaoPrevisto_Click(object sender, EventArgs e)
        {
            if (comboBoxArtigoNP.SelectedValue == null)
            {
                MessageBox.Show("Selecione um artigo.");
                return;
            }

            decimal preco = 0;
            decimal.TryParse(textBoxPrecoNP.Text.Replace(",", "."),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out preco);

            int artigoId = (int)comboBoxArtigoNP.SelectedValue;
            _comprasCtrl.AddItemNaoPrevisto(_compra.Id, artigoId, numericUpDownNP.Value, preco);
            AtualizarGrelha();
        }

        private void buttonFecharCompra_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Fechar esta compra? Não poderá ser editada depois.",
                "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _comprasCtrl.FecharCompra(_compra, _userId);
                MessageBox.Show("Compra fechada com sucesso!");
                this.Close();
            }
        }

       
    }
}

