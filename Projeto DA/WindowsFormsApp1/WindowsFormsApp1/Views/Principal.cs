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
    public partial class Principal : Form
    {
        private int _userId;
        private List<Compras> _comprasAbertas = new List<Compras>();
        private readonly ComprasController _ctrl = new ComprasController();

        public Principal(int userId, string username)
        {
            InitializeComponent();
            _userId = userId;
            UtilizadorLogado.Text = "Utilizador Logado: " + username;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            button1.Click += button1_Click; // Nova Compra / Planear
            button2.Click += button2_Click; // Aceder ao Modo Compra
            
            estatísticaToolStripMenuItem.Click += estatísticaToolStripMenuItem_Click;
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            AtualizarComprasAbertas();
        }

        private void AtualizarComprasAbertas()
        {
            dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged;
            _comprasAbertas = _ctrl.GetComprasAbertas();
            dataGridView1.Rows.Clear();
            foreach (var c in _comprasAbertas)
                dataGridView1.Rows.Add(c.NomeCompra,
                    c.DataCriacao.ToString("dd/MM/yyyy"),
                    _ctrl.GetNomeUtilizador(c.CriadaPorUtilizadorId));
            dataGridView1.ClearSelection();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            dataGridView2.Rows.Clear();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            int idx = dataGridView1.SelectedRows[0].Index;
            if (idx < 0 || idx >= _comprasAbertas.Count) return;

            var itens = _ctrl.GetItens(_comprasAbertas[idx].Id);
            dataGridView2.Rows.Clear();
            foreach (var item in itens)
                dataGridView2.Rows.Add(
                    item.Artigos?.TipoArtigo?.descricao ?? "",
                    item.Artigos?.Nome ?? "",
                    item.QuantidadePrevista,
                    item.QuantidadeAdquirida > 0 ? item.QuantidadeAdquirida.ToString() : "",
                    item.PrecoUnitario > 0 ? item.PrecoUnitario.ToString("F2") : "");
        }

        private void button1_Click(object sender, EventArgs e) // Nova Compra / Planear
        {
            var form = new Planeamento_Compras(_userId);
            form.ShowDialog();
            AtualizarComprasAbertas();
        }

        private void button2_Click(object sender, EventArgs e) // Aceder ao Modo Compra
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma compra em aberto.");
                return;
            }
            int idx = dataGridView1.SelectedRows[0].Index;
            var form = new ModoCompra(_comprasAbertas[idx], _userId);
            form.ShowDialog();
            AtualizarComprasAbertas();
        }

        private void planeamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Planeamento_Compras(_userId);
            form.ShowDialog();
            AtualizarComprasAbertas();
        }

        private void estatísticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Estatística(_userId);
            form.ShowDialog();
        }

        // --- Menus de Gestão ---
        private void tiposDeArtigosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Gestao_de_Tipo_de_Artigos();
            form.Show();
            form.FormClosed += (s, args) => this.Show();
            this.Hide();
        }

        private void artigosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Gestao_de_Artigos();
            form.Show();
            form.FormClosed += (s, args) => this.Show();
            this.Hide();
        }

        private void utilizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Gestao_Utilizadores(_userId);
            form.Show();
            form.FormClosed += (s, args) => this.Show();
            this.Hide();
        }

        private void orçamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Gestao_de_Orcamentos(_userId);
            form.Show();
            form.FormClosed += (s, args) => this.Show();
            this.Hide();
        }

        private void paraCsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            dlg.FileName = "compras_fechadas";
            
            if (dlg.ShowDialog() != DialogResult.OK) return;
            var compras = _ctrl.GetCompras();// Obter todas as compras, incluindo as fechadas
            var sb = new System.Text.StringBuilder();// Criar o conteúdo CSV
            sb.AppendLine("NomeCompra;DataCriacao;DataFechada;NomeArtigo;ArtigoPrevisto;ArtigoNaoPrevisto;QuantidadePrevista;QuantidadeAdquirida;PrecoUnitario");

            foreach (var compra in compras)
            {
                var itens = _ctrl.GetItens(compra.Id);
                foreach (var item in itens)
                {
                    sb.AppendLine(string.Join(";",
                        compra.NomeCompra,
                        compra.DataCriacao.ToString("dd/MM/yyyy HH:mm"),
                        compra.DataFecho.HasValue ? compra.DataFecho.Value.ToString("dd/MM/yyyy HH:mm") : "",
                        item.Artigos?.Nome ?? "",
                        item.E_Previsto ? "Sim" : "Não",
                        item.E_Previsto ? "Não" : "Sim",
                        item.QuantidadePrevista.ToString("F2"),
                        item.QuantidadeAdquirida.ToString("F2"),
                        item.PrecoUnitario.ToString("F2")));
                }
            }
            System.IO.File.WriteAllText(dlg.FileName, sb.ToString(), System.Text.Encoding.UTF8);
            MessageBox.Show("Ficheiro exportado com sucesso!");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void terminarSessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

           
                Application.Restart();
            }
        }
}