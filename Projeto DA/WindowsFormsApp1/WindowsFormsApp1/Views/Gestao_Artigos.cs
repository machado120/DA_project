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
    public partial class Gestao_de_Artigos : Form
    {
        private ArtigosController controller = new ArtigosController();
        private List<Artigos> _artigos = new List<Artigos>();
        private Artigos _selecionado = null;
        public Gestao_de_Artigos()
        {
            InitializeComponent();
            buttonCriarArt.Click += buttonCriarArt_Click;
            buttonEditarArt.Click += buttonEditarArt_Click;
            buttonApagarArt.Click += buttonApagarArt_Click;
            button1.Click += buttonLimpar_Click;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            comboBoxFiltrar.SelectedIndexChanged += comboBoxFiltrar_SelectedIndexChanged;

            CarregarTipos();
            AtualizarGrelha(null);
        }

        // Preenche os dois ComboBoxes com os tipos de artigo existentes
        private void CarregarTipos()
        {
            var tipos = controller.Get_tipo_de_Artigos();

            // ComboBox do formulário (para criar/editar)
            comboBoxTipoArtigo.DataSource = tipos.ToList();
            comboBoxTipoArtigo.DisplayMember = "descricao";
            comboBoxTipoArtigo.ValueMember = "Id";
            comboBoxTipoArtigo.SelectedIndex = -1;

            // ComboBox de filtro — adiciona opção "Todos" no topo
            var tiposFiltro = new List<Tipo_de_Artigos>();
            tiposFiltro.Add(new Tipo_de_Artigos { Id = 0, descricao = "Todos" });
            tiposFiltro.AddRange(tipos);

            comboBoxFiltrar.SelectedIndexChanged -= comboBoxFiltrar_SelectedIndexChanged;
            comboBoxFiltrar.DataSource = tiposFiltro;
            comboBoxFiltrar.DisplayMember = "descricao";
            comboBoxFiltrar.ValueMember = "Id";
            comboBoxFiltrar.SelectedIndex = 0;
            comboBoxFiltrar.SelectedIndexChanged += comboBoxFiltrar_SelectedIndexChanged;
        }

        // Recarrega a DataGridView; tipoId=null ou 0 mostra todos
        private void AtualizarGrelha(int? tipoId)
        {
            _artigos = (tipoId == null || tipoId == 0)
                ? controller.GetArtigos()
                : controller.GetArtigosPorTipo(tipoId.Value);

            dataGridView1.Rows.Clear();
            foreach (var a in _artigos)
                dataGridView1.Rows.Add(a.Nome, a.TipoArtigo?.descricao ?? "");

            LimparCampos();
        }

        private void LimparCampos()
        {
            textNomeArtig.Clear();
            comboBoxTipoArtigo.SelectedIndex = -1;
            _selecionado = null;
        }

        // Clique numa linha da grid → preenche os campos do formulário
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            int idx = dataGridView1.SelectedRows[0].Index;
            if (idx < 0 || idx >= _artigos.Count) return;

            _selecionado = _artigos[idx];
            textNomeArtig.Text = _selecionado.Nome;

            // Seleciona o tipo correspondente no ComboBox
            for (int i = 0; i < comboBoxTipoArtigo.Items.Count; i++)
            {
                var t = comboBoxTipoArtigo.Items[i] as Tipo_de_Artigos;
                if (t != null && t.Id == _selecionado.TipoArtigoId)
                {
                    comboBoxTipoArtigo.SelectedIndex = i;
                    break;
                }
            }
        }

        private void buttonCriarArt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNomeArtig.Text) || comboBoxTipoArtigo.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha o nome e selecione o tipo do artigo.");
                return;
            }
            int tipoId = ((Tipo_de_Artigos)comboBoxTipoArtigo.SelectedItem).Id;
            controller.AddArtigo(textNomeArtig.Text.Trim(), tipoId);
            AtualizarGrelha(FiltroAtual());
        }

        private void buttonEditarArt_Click(object sender, EventArgs e)
        {
            if (_selecionado == null)
            {
                MessageBox.Show("Selecione um artigo na lista.");
                return;
            }
            if (string.IsNullOrWhiteSpace(textNomeArtig.Text) || comboBoxTipoArtigo.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha o nome e selecione o tipo do artigo.");
                return;
            }
            _selecionado.Nome = textNomeArtig.Text.Trim();
            _selecionado.TipoArtigoId = ((Tipo_de_Artigos)comboBoxTipoArtigo.SelectedItem).Id;
            _selecionado.TipoArtigo = null; // evita conflito de rastreamento no EF
            controller.EditarArtigo(_selecionado);
            AtualizarGrelha(FiltroAtual());
        }

        private void buttonApagarArt_Click(object sender, EventArgs e)
        {
            if (_selecionado == null)
            {
                MessageBox.Show("Selecione um artigo na lista.");
                return;
            }
            if (MessageBox.Show("Eliminar o artigo selecionado?", "Confirmar",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                controller.EliminarArtigo(_selecionado);
                AtualizarGrelha(FiltroAtual());
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void comboBoxFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tipo = comboBoxFiltrar.SelectedItem as Tipo_de_Artigos;
            if (tipo == null) return;
            AtualizarGrelha(tipo.Id == 0 ? (int?)null : tipo.Id);
        }

        // Devolve o Id do tipo seleccionado no filtro (0 = Todos)
        private int? FiltroAtual()
        {
            var tipo = comboBoxFiltrar.SelectedItem as Tipo_de_Artigos;
            return (tipo == null || tipo.Id == 0) ? (int?)null : tipo.Id;
        }

        private void Gestao_de_Artigos_Load(object sender, EventArgs e)
        {

        }
    }
}
