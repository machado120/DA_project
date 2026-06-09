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

namespace WindowsFormsApp1.Views
{
    public partial class Estatística : Form
    {
        private readonly int _userId;
        private readonly OrcamentosController _orcCtrl = new OrcamentosController();// Controladores para acessar os dados de orçamentos e compras
        private readonly ComprasController _comprasCtrl = new ComprasController();// Controladores para acessar os dados de orçamentos e compras

        public Estatística(int userId)
        {
            InitializeComponent();
            _userId = userId;
            this.Load += Estatística_Load;// Evento para carregar os dados quando o formulário for carregado
            button1.Click += button1_Click;// Evento para gerar sugestões de orçamento e artigos quando o botão for clicado
        }

        private void Estatística_Load(object sender, EventArgs e)
        {
            CarregarAnaliseOrcamentos();
            CarregarAnaliseCompras();
        }

        private void CarregarAnaliseOrcamentos()
        {
            dataGridView1.Rows.Clear();
            var orcamentos = _orcCtrl.GetOrcamentos();// Obtém todos os orçamentos para analisar o desempenho em relação ao orçamento definido para cada mês/ano
            var comprasFechadas = _comprasCtrl.GetComprasFechadas();// Obtém todas as compras fechadas para calcular o total gasto em cada mês/ano e comparar com o orçamento definido, permitindo avaliar se os gastos estão dentro do orçamento ou se há desvios significativos

            foreach (var orc in orcamentos)
            {
                // Soma o total gasto em compras fechadas nesse mês/ano
                decimal totalGasto = 0;
                foreach (var compra in comprasFechadas)
                {
                    if (compra.DataCriacao.Month == orc.Mes &&
                        compra.DataCriacao.Year == orc.Ano)
                    {
                        var itens = _comprasCtrl.GetItens(compra.Id);
                        totalGasto += itens.Sum(i => i.QuantidadeAdquirida * i.PrecoUnitario);
                    }
                }

                decimal diferenca = orc.ValorMaximo - totalGasto;
                double percentagem = orc.ValorMaximo > 0
                    ? Math.Round((double)(totalGasto / orc.ValorMaximo) * 100, 1)
                    : 0;

                dataGridView1.Rows.Add(
                    $"{orc.Mes:D2}/{orc.Ano}",
                    orc.ValorMaximo.ToString("F2"),
                    totalGasto.ToString("F2"),
                    diferenca.ToString("F2"),
                    percentagem + "%");// Adiciona uma linha na tabela com o mês/ano, valor do orçamento, total gasto, diferença e percentagem do orçamento gasto
            }
        }

        private void CarregarAnaliseCompras()
        {
            dataGridView2.Rows.Clear();
            var comprasFechadas = _comprasCtrl.GetComprasFechadas();// Obtém todas as compras fechadas para analisar a proporção de itens previstos vs. não previstos em cada compra, permitindo avaliar a eficácia do planeamento e identificar áreas de melhoria na previsão de necessidades de compra

            foreach (var compra in comprasFechadas)
            {
                var itens = _comprasCtrl.GetItens(compra.Id);
                int total = itens.Count;
                int previstos = itens.Count(i => i.E_Previsto);
                int naoPrev = total - previstos;

                string pctPrev = total > 0
                    ? Math.Round((double)previstos / total * 100, 1) + "%" : "0%";
                string pctNao = total > 0
                    ? Math.Round((double)naoPrev / total * 100, 1) + "%" : "0%";

                dataGridView2.Rows.Add(
                    compra.NomeCompra,
                    compra.DataCriacao.ToString("dd/MM/yyyy"),
                    total,
                    pctPrev,
                    pctNao);
            }// Adiciona uma linha na tabela com o nome da compra, data de criação, total de itens, percentagem de itens previstos e percentagem de itens não previstos
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            var orcamentos = _orcCtrl.GetOrcamentos();

            // Sugestão orçamento: média dos orçamentos anteriores
            decimal sugestaoOrc = orcamentos.Any()
                ? orcamentos.Average(o => o.ValorMaximo)
                : 0;

            // Semana atual do mês (1ª a 4ª)
            int diaHoje = DateTime.Now.Day;
            int semanaAtual = (diaHoje - 1) / 7 + 1;

            // Artigos mais comprados na mesma semana de meses anteriores
            var comprasFechadas = _comprasCtrl.GetComprasFechadas();// Obtém todas as compras fechadas para analisar os dados históricos
            var comprasMesmaSemana = comprasFechadas 
                .Where(c => (c.DataCriacao.Day - 1) / 7 + 1 == semanaAtual)// Filtra as compras que ocorreram na mesma semana do mês atual, permitindo identificar padrões de compra relacionados a períodos específicos do mês
                .ToList();

            var frequencia = new Dictionary<string, int>();
            foreach (var compra in comprasMesmaSemana)
            {
                var itens = _comprasCtrl.GetItens(compra.Id);
                foreach (var item in itens.Where(i => i.E_Previsto))
                {
                    string nome = item.Artigos?.Nome ?? "?";
                    if (!frequencia.ContainsKey(nome)) frequencia[nome] = 0;
                    frequencia[nome]++;
                }
            }

            // Mostrar sugestão de orçamento na 1ª linha
            dataGridView3.Rows.Add(// Adiciona uma linha com a sugestão de orçamento, a semana atual e o número de compras anteriores na mesma semana
                "Sugestão Orçamento",
                $"{sugestaoOrc:F2} €",
                $"Semana {semanaAtual} do mês",
                $"{comprasMesmaSemana.Count} compras anteriores",
                "");

            // Mostrar lista de artigos sugeridos
            foreach (var kv in frequencia.OrderByDescending(x => x.Value))// Ordena os artigos por frequência de compra, do mais comprado para o menos comprado
                dataGridView3.Rows.Add("Artigo Sugerido", kv.Key, $"{kv.Value}x", "", "");
        }
    }
}
