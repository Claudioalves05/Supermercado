using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Supermercad
{
    public partial class FrmCompras : Form
    {
        List<ItemCarrinho> carrinho = new List<ItemCarrinho>();

        public FrmCompras()
        {
            InitializeComponent();
        }


        private void FrmCompras_Load(object sender, EventArgs e)
        {
            {
                // O código de estilo que você já tinha
                foreach (Control c in PnlMenu.Controls)
                {
                    if (c is Button)
                    {
                        c.MouseEnter += EstiloMenu.Menu_MouseEnter;
                        c.MouseLeave += EstiloMenu.Menu_MouseLeave;
                    }
                }

                CarregarProdutos();
            }

        }

        private void CarregarProdutos()
        {
            string stringConexao = ConfigurationManager.ConnectionStrings["MinhaConexao"].ConnectionString;

            using (SqlConnection conexao = new SqlConnection(stringConexao))
            {
                string query = "SELECT CodigoProduto, Nome, Preco FROM Produtos";

                SqlCommand cmd = new SqlCommand(query, conexao);
                conexao.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                lstProdutos.Items.Clear();

                while (dr.Read())
                {
                    Produto p = new Produto()
                    {
                        Codigo = dr["CodigoProduto"].ToString(),
                        Nome = dr["Nome"].ToString(),
                        Preco = Convert.ToDecimal(dr["Preco"])
                    };

                    lstProdutos.Items.Add(p);
                }
            }
        }

        // --- MÉTODOS DE NAVEGAÇÃO (Para parar os erros do Designer) ---
        private void btnDashboard_Click(object sender, EventArgs e) { /* Lógica futura */ }
        private void BtnProduto_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.Show();
            this.Hide();
        }
        private void btnCompras_Click(object sender, EventArgs e) { }
        private void btnClientes_Click(object sender, EventArgs e) { }
        private void btnFornecedores_Click(object sender, EventArgs e) { }
        private void btnRelatorio_Click(object sender, EventArgs e) { }
        private void btnConfiguracao_Click(object sender, EventArgs e) { }

        // --- MÉTODOS DE AÇÃO ---
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            string stringConexao = ConfigurationManager.ConnectionStrings["MinhaConexao"].ConnectionString;

            using (SqlConnection conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                string nota = "";

                string query = "SELECT * FROM NotaFiscal WHERE CodigoVenda = @id";
                string queryVenda = "INSERT INTO Vendas (DataVenda, FormaPagamento, ValorTotal) OUTPUT INSERTED.CodigoVenda VALUES (@data, @pagamento, @total)";

                SqlCommand cmdVenda = new SqlCommand(queryVenda, conexao);

                cmdVenda.Parameters.AddWithValue("@data", DateTime.Now);
                cmdVenda.Parameters.AddWithValue("@pagamento", "Dinheiro");
                cmdVenda.Parameters.AddWithValue("@total", Convert.ToDecimal(lblValorTotal.Text.Replace("R$", "").Trim()));

                int idPedido = (int)cmdVenda.ExecuteScalar();

                foreach (var item in carrinho)
                {
                    string queryItem = @"INSERT INTO ItensVendas 
        (CodigoVenda, CodigoProduto, Quantidade, PrecoUnitario)
        VALUES (@venda, @produto, @qtd, @preco)";

                    SqlCommand cmdItem = new SqlCommand(queryItem, conexao);

                    cmdItem.Parameters.AddWithValue("@venda", idPedido);
                    cmdItem.Parameters.AddWithValue("@produto", item.CodigoProduto);
                    cmdItem.Parameters.AddWithValue("@qtd", item.Quantidade);
                    cmdItem.Parameters.AddWithValue("@preco", item.Preco);

                    cmdItem.ExecuteNonQuery();
                }

                using (SqlCommand cmd = new SqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", idPedido);

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        nota += "Produto: " + dr["Nome"].ToString() + "\n";
                        nota += "Quantidade: " + dr["Quantidade"].ToString() + "\n";
                        nota += "Preço: " + Convert.ToDecimal(dr["PrecoUnitario"]).ToString("C") + "\n";
                        nota += "Total Item: " + Convert.ToDecimal(dr["Total"]).ToString("C") + "\n";
                        nota += "----------------------\n";
                    }
                    nota += "\nTOTAL DA COMPRA: " + lblValorTotal.Text + "\n";


                    dr.Close();
                    if (nota == "")
                    {
                        MessageBox.Show("A nota está vazia!");
                    }
                    else
                    {
                        MessageBox.Show(nota, "Nota Fiscal");
                    }

                }
            }
        }

        private void txtLista_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProdutos.SelectedItem != null)
            {
                Produto produto = (Produto)lstProdutos.SelectedItem;

                cboCategoriaCarrinho.Text = produto.Nome;
            }
        }

        private void btnAddCarrinho_Click(object sender, EventArgs e)
        {
            { }
            if (lstProdutos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um produto!");
                return;
            }

            Produto prod = (Produto)lstProdutos.SelectedItem;

            ItemCarrinho item = new ItemCarrinho()
            {
                CodigoProduto = prod.Codigo,
                Nome = prod.Nome,
                Preco = prod.Preco,
                Quantidade = (int)nudQuantidade.Value
            };

            carrinho.Add(item);

            AtualizarCarrinho();
        }

    
    private void AtualizarCarrinho()
        {
            lstCarrinho.Items.Clear();

            decimal subtotal = 0;

            foreach (var item in carrinho)
            {
                lstCarrinho.Items.Add(item);
                subtotal += item.Total;
            }

            lblValorSubtotal.Text = subtotal.ToString("C");

            decimal desconto = 0;
            decimal.TryParse(txtDesconto.Text, out desconto);

            decimal total = subtotal - desconto;

            lblValorTotal.Text = total.ToString("C");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                // Verifica se selecionou algo
                if (lstCarrinho.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecione um item para remover!");
                    return;
                }

                int index = lstCarrinho.SelectedIndex;

                // Remove da lista interna
                carrinho.RemoveAt(index);

                // Atualiza o carrinho na tela
                AtualizarCarrinho();
            }

        }
    }
}
