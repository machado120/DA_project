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
    public partial class Gestao_de_Orcamentos : Form
    {
        private OrcamentosController controller = new OrcamentosController();
        private int _userId;
        private List<Orcamento> _orcamentos;
        private Orcamento _selecionado = null;
        public Gestao_de_Orcamentos(int userId)
        {
            InitializeComponent();
            labelMesAno.Text = "Mês/Ano selecionado:" + DateTime.Now.Month + "/" + DateTime.Now.Year; // Define o texto inicial do label com o mês e ano atuais
            monthCalendar1.DateChanged += (s, args) =>
            {
                labelMesAno.Text = "Mês/Ano selecionado:" + monthCalendar1.SelectionStart.Month + "/" +
                monthCalendar1.SelectionStart.Year;// Atualiza o label com o mês e ano selecionados no MonthCalendar
            };
            _userId = userId;

            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;// Adiciona o evento de seleção para o DataGridView
            AtualizarGrelha();
        }
        private void AtualizarGrelha()
        {
            _orcamentos = controller.GetOrcamentos();
            dataGridView1.Rows.Clear();// Limpa as linhas existentes antes de adicionar as novas
            foreach (var o in _orcamentos)// Adiciona cada orçamento à grelha
            {
                dataGridView1.Rows.Add(o.Mes, o.Ano, o.ValorMaximo.ToString("F2"));

            }
            _selecionado = null;
        }
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;// Verifica se há alguma linha selecionada
            int idx = dataGridView1.SelectedRows[0].Index;// Obtém o índice da linha selecionada
            if (idx < 0 || idx >= _orcamentos.Count) return;// Verifica se o índice é válido


            _selecionado = _orcamentos[idx];// Obtém o orçamento selecionado com base no índice da linha selecionada]

            numericValor.Value = _selecionado.ValorMaximo;
            monthCalendar1.SetDate(new DateTime(_selecionado.Ano, _selecionado.Mes, 1)); // Define a data do MonthCalendar para o mês e ano do orçamento selecionado
        }


        private void buttonGravar_Click(object sender, EventArgs e)
        {
            int mes = monthCalendar1.SelectionStart.Month;// Obtém o mês e ano selecionados no MonthCalendar
            int ano = monthCalendar1.SelectionStart.Year;// Obtém o ano selecionado no MonthCalendar
            decimal valor = numericValor.Value;// Obtém o valor do orçamento a partir do NumericUpDown

            try
            {

                var existente = controller.GetOrcamentoPorMes(mes, ano); // Verifica se já existe um orçamento para o mês e ano selecionados

                if (existente != null)
                {
                    if (MessageBox.Show("Já existe um orçamento para " + mes + "/" + ano + ". Deseja atualizar o valor?",
                        "Orçamento existente", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;
                }

                if (existente == null)
                    controller.CriarOrcamento(mes, ano, valor, _userId);// Cria um novo orçamento se não existir
                else
                    controller.EditarOrcamento(existente, valor, _userId);// Atualiza o orçamento existente com o novo valor

                AtualizarGrelha();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar orçamento: " + ex.Message);
            }
        }


        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (_selecionado == null)// Verifica se há um orçamento selecionado para eliminar
            {
                MessageBox.Show("Selecione um orçamento para eliminar.");
                return;
            }
            if (MessageBox.Show("Eliminar o Orçamento?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                controller.EliminarOrcamento(_selecionado);
                AtualizarGrelha();
            }

            
        }

        private void Gestao_de_Orcamentos_Load(object sender, EventArgs e)
        {

        }
    }
}
