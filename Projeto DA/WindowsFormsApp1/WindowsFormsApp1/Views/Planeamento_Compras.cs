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
    public partial class Planeamento_Compras : Form
    {

        private ComprasController controller = new ComprasController();
        private int _userId;
        private List<Compras> _compras;
        private Compras _selecionada = null;
        public Planeamento_Compras(int userId)
        {
            InitializeComponent();
            _userId = userId;
            comboBoxFiltro.SelectedIndex = 0;// 0 = Todas, 1 = Abertas, 2 = Fechadas
            comboBoxFiltro.SelectedIndexChanged += comboBoxFiltro_SelectedIndexChanged;// Associa o evento de mudança de seleção do comboBoxFiltro ao método comboBoxFiltro_SelectedIndexChanged, que atualiza a grelha de compras com base no filtro selecionado
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;// Associa o evento de mudança de seleção do dataGridView1 ao método dataGridView1_SelectionChanged
            buttonNovaCompra.Click += buttonNovaCompra_Click;// Associa o evento de clique do buttonNovaCompra ao método buttonNovaCompra_Click
            buttonEditar.Click += buttonEditar_Click;
            buttonEliminar.Click += buttonEliminar_Click;
            AtualizarGrelha();
        }

        private void AtualizarGrelha()
        {
            dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged; // Desassocia temporariamente o evento de mudança de seleção do dataGridView1 para evitar que o método dataGridView1_SelectionChanged seja chamado durante a atualização da grelha
            _selecionada = null; // Limpa a variável _selecionada, garantindo que nenhuma compra esteja selecionada durante a atualização da grelha
            _compras = controller.GetCompras(); // Obtém a lista de compras do controller e armazena na variável _compras
            
            if (comboBoxFiltro.SelectedIndex == 1)
                _compras = _compras.FindAll(c => !c.EstaFechada);
            else if (comboBoxFiltro.SelectedIndex == 2)
                _compras = _compras.FindAll(c => c.EstaFechada);

            dataGridView1.Rows.Clear();
            foreach (var c in _compras)
                dataGridView1.Rows.Add(c.NomeCompra, c.DataCriacao.ToString("dd/MM/yyyy"),
                    c.EstaFechada ? "Fechada" : "Aberta");

            dataGridView1.ClearSelection();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)// Método que é chamado quando a seleção no dataGridView1 muda, atualizando a variável _selecionada com a compra atualmente selecionada na grelha
        {
            if (dataGridView1.SelectedRows.Count == 0) return;// Verifica se há alguma linha selecionada no dataGridView1. Se não houver, o método retorna sem fazer nada.
            int idx = dataGridView1.SelectedRows[0].Index;// Obtém o índice da primeira linha selecionada no dataGridView1.
            if (idx < 0 || idx >= _compras.Count) return;
            _selecionada = _compras[idx];
        }

        private void comboBoxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarGrelha();
        }

        private void buttonNovaCompra_Click(object sender, EventArgs e)
        {
            var form = new NovaCompra(_userId);
            form.ShowDialog();
            AtualizarGrelha();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (_selecionada == null) { MessageBox.Show("Selecione uma compra."); return; }
            var form = new NovaCompra(_userId, _selecionada);
            form.ShowDialog();
            AtualizarGrelha();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (_selecionada == null) { MessageBox.Show("Selecione uma compra."); return; }
            if (_selecionada.EstaFechada) { MessageBox.Show("Não é possível eliminar uma compra fechada."); return; }
            if (MessageBox.Show("Eliminar compra?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                controller.EliminarCompra(_selecionada);
                AtualizarGrelha();
            }
        }

        private void Planeamento_Compras_Load(object sender, EventArgs e)
        {

        }

        private void buttonModoCompra_Click(object sender, EventArgs e)
        {
            buttonModoCompra.Click += (s, ex) =>
            {
              if (_selecionada == null) { MessageBox.Show("Selecione uma compra."); return; }
              if (_selecionada.EstaFechada) { MessageBox.Show("Esta compra está fechada."); return; }
              var form = new ModoCompra(_selecionada, _userId);
                form.ShowDialog();
                AtualizarGrelha();
            };
        }
    }
}
