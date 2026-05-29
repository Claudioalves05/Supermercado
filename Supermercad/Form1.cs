using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Supermercad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Aplica estilos de mouse (conforme seu projeto)
            foreach (Control c in pnlMenu.Controls)
            {
                if (c is System.Windows.Forms.Button)
                {
                    c.MouseEnter += EstiloMenu.Menu_MouseEnter;
                    c.MouseLeave += EstiloMenu.Menu_MouseLeave;
                }
                cboCategoria.Items.Clear(); // Limpa antes para não duplicar
                cboCategoria.Items.Add("Bebidas");
                cboCategoria.Items.Add("Limpeza");
                cboCategoria.Items.Add("Higiene");
                cboCategoria.Items.Add("Alimentos");
                cboCategoria.Items.Add("Padaria");
            }

            // Carrega os dados do banco na tabela
            CarregarDados();
        }

        private void CarregarDados()
        {
            string stringConexao = ConfigurationManager.ConnectionStrings["MinhaConexao"].ConnectionString;

            using (SqlConnection conexao = new SqlConnection(stringConexao))
            {
                try
                {
                    conexao.Open();
                    // IMPORTANTE: Verifique o nome da sua tabela no SQL (ex: Produtos)
                    string query = "SELECT * FROM Produtos";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexao);
                    DataTable tabela = new DataTable();

                    adapter.Fill(tabela);
                    dgvTabela.DataSource = tabela;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados: " + ex.Message);
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodProduto.Clear();
            txtNomeProduto.Clear();
            txtQuantidade.Clear();
            txtPreco.Clear();
            cboCategoria.SelectedIndex = -1;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int qtd;
            decimal preco;

            if (!int.TryParse(txtQuantidade.Text, out qtd))
            {
                MessageBox.Show("A quantidade deve ser um número inteiro.");
                txtQuantidade.Focus(); // Coloca o cursor no campo errado
                return; // Para o código aqui e não tenta salvar
            }

            if (!decimal.TryParse(txtPreco.Text.Replace(".", ","), out preco))
            {
                MessageBox.Show("O preço deve ser um valor válido (use vírgula para decimais).");
                txtPreco.Focus();
                return;
            }
            {
                // 1. Pegar a string de conexão
                string stringConexao = ConfigurationManager.ConnectionStrings["MinhaConexao"].ConnectionString;

                // 2. Criar a query de inserção
                string query = "INSERT INTO Produtos (CodigoProduto, Nome, Categoria, QuantidadeEstoque, Preco) " +
                               "VALUES (@codigo, @nome, @categoria, @qtd, @preco)";

                using (SqlConnection conexao = new SqlConnection(stringConexao))
                {
                    try
                    {
                        conexao.Open();
                        using (SqlCommand comando = new SqlCommand(query, conexao))
                        {
                            // 3. Adicionar os parâmetros (evita erros e ataques de SQL Injection)
                            comando.Parameters.AddWithValue("@codigo", txtCodProduto.Text);
                            comando.Parameters.AddWithValue("@nome", txtNomeProduto.Text);
                            comando.Parameters.AddWithValue("@categoria", cboCategoria.Text);
                            comando.Parameters.AddWithValue("@qtd", int.Parse(txtQuantidade.Text));
                            comando.Parameters.AddWithValue("@preco", decimal.Parse(txtPreco.Text));

                            comando.ExecuteNonQuery(); // Executa o comando no banco
                        }

                        MessageBox.Show("Cadastro realizado com sucesso!");

                        // 4. Limpa os campos e atualiza a grid para mostrar o novo item
                        btnLimpar_Click(sender, e);
                        CarregarDados();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar: " + ex.Message);
                    }
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string stringConexao = ConfigurationManager.ConnectionStrings["MinhaConexao"].ConnectionString;

            // UPDATE altera as colunas onde o Código for o que você digitou
            string query = "UPDATE Produtos SET Nome = @nome, Categoria = @categoria, " +
                           "QuantidadeEstoque = @qtd, Preco = @preco WHERE CodigoProduto = @codigo";
            {
                int qtd;
                decimal preco;

                if (!int.TryParse(txtQuantidade.Text, out qtd))
                {
                    MessageBox.Show("A quantidade deve ser um número inteiro.");
                    txtQuantidade.Focus(); // Coloca o cursor no campo errado
                    return; // Para o código aqui e não tenta salvar
                }

                if (!decimal.TryParse(txtPreco.Text.Replace(".", ","), out preco))
                {
                    MessageBox.Show("O preço deve ser um valor válido (use vírgula para decimais).");
                    txtPreco.Focus();
                    return;
                }
            }
                using (SqlConnection conexao = new SqlConnection(stringConexao))
            {
                try
                {
                    conexao.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@codigo", txtCodProduto.Text);
                        comando.Parameters.AddWithValue("@nome", txtNomeProduto.Text);
                        comando.Parameters.AddWithValue("@categoria", cboCategoria.Text);
                        comando.Parameters.AddWithValue("@qtd", int.Parse(txtQuantidade.Text));
                        comando.Parameters.AddWithValue("@preco", decimal.Parse(txtPreco.Text));

                        comando.ExecuteNonQuery();
                    }
                    MessageBox.Show("Dados atualizados com sucesso!");
                    CarregarDados(); // Atualiza a grid para mostrar a alteração
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar: " + ex.Message);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este produto?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string stringConexao = ConfigurationManager.ConnectionStrings["MinhaConexao"].ConnectionString;
                string query = "DELETE FROM Produtos WHERE CodigoProduto = @codigo";

                using (SqlConnection conexao = new SqlConnection(stringConexao))
                {
                    try
                    {
                        conexao.Open();
                        using (SqlCommand comando = new SqlCommand(query, conexao))
                        {
                            comando.Parameters.AddWithValue("@codigo", txtCodProduto.Text);
                            comando.ExecuteNonQuery();
                        }
                        MessageBox.Show("Produto excluído com sucesso!");
                        CarregarDados(); // Atualiza a grid para remover o item
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir: " + ex.Message);
                    }
                }
            }
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            FrmCompras tela = new FrmCompras();
            tela.Show();
            this.Hide();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        { }
            public class Produto
        {
            public string Codigo { get; set; }
            public string Nome { get; set; }
            public decimal Preco { get; set; }

            public override string ToString()
            {
                return Nome;
            }
        }
        

        private void btnDashboard_Click(object sender, EventArgs e) { }
    }
}