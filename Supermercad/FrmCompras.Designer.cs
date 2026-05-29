using System.Drawing;
using System.Windows.Forms;

namespace Supermercad
{
    partial class FrmCompras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConfiguracao = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnFornecedores = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.BtnProduto = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblSistGestao = new System.Windows.Forms.Label();
            this.lblSupermercado = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblDescCadastro = new System.Windows.Forms.Label();
            this.lblCadasProduto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstProdutos = new System.Windows.Forms.ListBox();
            this.cmbListaCategoria = new System.Windows.Forms.ComboBox();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.lblListaProduto = new System.Windows.Forms.Label();
            this.pnlAddCarrinho = new System.Windows.Forms.Panel();
            this.btnAddCarrinho = new System.Windows.Forms.Button();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblProdutoCarrinho = new System.Windows.Forms.Label();
            this.cboCategoriaCarrinho = new System.Windows.Forms.ComboBox();
            this.lblCarrinho = new System.Windows.Forms.Label();
            this.pnlCarrinho = new System.Windows.Forms.Panel();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblValorSubtotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lstCarrinho = new System.Windows.Forms.ListBox();
            this.lblCarrinhoCompra = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.PnlMenu.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlAddCarrinho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            this.pnlCarrinho.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMenu
            // 
            this.PnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.PnlMenu.Controls.Add(this.btnSair);
            this.PnlMenu.Controls.Add(this.btnConfiguracao);
            this.PnlMenu.Controls.Add(this.btnRelatorio);
            this.PnlMenu.Controls.Add(this.btnFornecedores);
            this.PnlMenu.Controls.Add(this.btnClientes);
            this.PnlMenu.Controls.Add(this.btnCompras);
            this.PnlMenu.Controls.Add(this.BtnProduto);
            this.PnlMenu.Controls.Add(this.btnDashboard);
            this.PnlMenu.Controls.Add(this.lblSistGestao);
            this.PnlMenu.Controls.Add(this.lblSupermercado);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(267, 735);
            this.PnlMenu.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(0, 492);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(267, 55);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConfiguracao
            // 
            this.btnConfiguracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.btnConfiguracao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguracao.FlatAppearance.BorderSize = 0;
            this.btnConfiguracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnConfiguracao.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracao.Location = new System.Drawing.Point(0, 437);
            this.btnConfiguracao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfiguracao.Name = "btnConfiguracao";
            this.btnConfiguracao.Size = new System.Drawing.Size(267, 55);
            this.btnConfiguracao.TabIndex = 8;
            this.btnConfiguracao.Text = "Configurações";
            this.btnConfiguracao.UseVisualStyleBackColor = false;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.btnRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorio.FlatAppearance.BorderSize = 0;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnRelatorio.Location = new System.Drawing.Point(0, 382);
            this.btnRelatorio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(267, 55);
            this.btnRelatorio.TabIndex = 7;
            this.btnRelatorio.Text = "Relatórios";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.btnFornecedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFornecedores.FlatAppearance.BorderSize = 0;
            this.btnFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecedores.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnFornecedores.ForeColor = System.Drawing.Color.White;
            this.btnFornecedores.Location = new System.Drawing.Point(0, 326);
            this.btnFornecedores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Size = new System.Drawing.Size(267, 55);
            this.btnFornecedores.TabIndex = 6;
            this.btnFornecedores.Text = "Fornecedores";
            this.btnFornecedores.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Location = new System.Drawing.Point(0, 271);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(267, 55);
            this.btnClientes.TabIndex = 5;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnCompras
            // 
            this.btnCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCompras.ForeColor = System.Drawing.Color.White;
            this.btnCompras.Location = new System.Drawing.Point(0, 215);
            this.btnCompras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(267, 55);
            this.btnCompras.TabIndex = 4;
            this.btnCompras.Text = "Compras";
            this.btnCompras.UseVisualStyleBackColor = false;
            // 
            // BtnProduto
            // 
            this.BtnProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.BtnProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProduto.FlatAppearance.BorderSize = 0;
            this.BtnProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProduto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BtnProduto.ForeColor = System.Drawing.Color.White;
            this.BtnProduto.Location = new System.Drawing.Point(0, 160);
            this.BtnProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnProduto.Name = "BtnProduto";
            this.BtnProduto.Size = new System.Drawing.Size(267, 55);
            this.BtnProduto.TabIndex = 3;
            this.BtnProduto.Text = "Produtos";
            this.BtnProduto.UseVisualStyleBackColor = false;
            this.BtnProduto.Click += new System.EventHandler(this.BtnProduto_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 105);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(267, 55);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // lblSistGestao
            // 
            this.lblSistGestao.AutoSize = true;
            this.lblSistGestao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSistGestao.Location = new System.Drawing.Point(69, 49);
            this.lblSistGestao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSistGestao.Name = "lblSistGestao";
            this.lblSistGestao.Size = new System.Drawing.Size(122, 16);
            this.lblSistGestao.TabIndex = 1;
            this.lblSistGestao.Text = "Sistema de Gestão";
            // 
            // lblSupermercado
            // 
            this.lblSupermercado.AutoSize = true;
            this.lblSupermercado.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSupermercado.ForeColor = System.Drawing.Color.White;
            this.lblSupermercado.Location = new System.Drawing.Point(41, 18);
            this.lblSupermercado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupermercado.Name = "lblSupermercado";
            this.lblSupermercado.Size = new System.Drawing.Size(180, 32);
            this.lblSupermercado.TabIndex = 0;
            this.lblSupermercado.Text = "Supermercado";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.White;
            this.pnlTitulo.Controls.Add(this.lblDescCadastro);
            this.pnlTitulo.Controls.Add(this.lblCadasProduto);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(267, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1020, 86);
            this.pnlTitulo.TabIndex = 2;
            // 
            // lblDescCadastro
            // 
            this.lblDescCadastro.AutoSize = true;
            this.lblDescCadastro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDescCadastro.ForeColor = System.Drawing.Color.Gray;
            this.lblDescCadastro.Location = new System.Drawing.Point(37, 50);
            this.lblDescCadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescCadastro.Name = "lblDescCadastro";
            this.lblDescCadastro.Size = new System.Drawing.Size(263, 20);
            this.lblDescCadastro.TabIndex = 0;
            this.lblDescCadastro.Text = "Adicione produtos à compra e finalize";
            // 
            // lblCadasProduto
            // 
            this.lblCadasProduto.AutoSize = true;
            this.lblCadasProduto.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblCadasProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblCadasProduto.Location = new System.Drawing.Point(33, 11);
            this.lblCadasProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadasProduto.Name = "lblCadasProduto";
            this.lblCadasProduto.Size = new System.Drawing.Size(129, 41);
            this.lblCadasProduto.TabIndex = 2;
            this.lblCadasProduto.Text = "Compra";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lstProdutos);
            this.panel1.Controls.Add(this.cmbListaCategoria);
            this.panel1.Controls.Add(this.txtLista);
            this.panel1.Controls.Add(this.lblListaProduto);
            this.panel1.Location = new System.Drawing.Point(276, 101);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 421);
            this.panel1.TabIndex = 3;
            // 
            // lstProdutos
            // 
            this.lstProdutos.BackColor = System.Drawing.Color.White;
            this.lstProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstProdutos.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lstProdutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lstProdutos.ItemHeight = 25;
            this.lstProdutos.Location = new System.Drawing.Point(25, 73);
            this.lstProdutos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(400, 300);
            this.lstProdutos.TabIndex = 0;
            this.lstProdutos.SelectedIndexChanged += new System.EventHandler(this.lstProdutos_SelectedIndexChanged);
            // 
            // cmbListaCategoria
            // 
            this.cmbListaCategoria.FormattingEnabled = true;
            this.cmbListaCategoria.Location = new System.Drawing.Point(279, 39);
            this.cmbListaCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbListaCategoria.Name = "cmbListaCategoria";
            this.cmbListaCategoria.Size = new System.Drawing.Size(160, 24);
            this.cmbListaCategoria.TabIndex = 2;
            // 
            // txtLista
            // 
            this.txtLista.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtLista.Location = new System.Drawing.Point(25, 41);
            this.txtLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(244, 22);
            this.txtLista.TabIndex = 1;
            this.txtLista.Text = "Pesquisar Produto";
            this.txtLista.TextChanged += new System.EventHandler(this.txtLista_TextChanged);
            // 
            // lblListaProduto
            // 
            this.lblListaProduto.AutoSize = true;
            this.lblListaProduto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblListaProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblListaProduto.Location = new System.Drawing.Point(23, 14);
            this.lblListaProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListaProduto.Name = "lblListaProduto";
            this.lblListaProduto.Size = new System.Drawing.Size(142, 23);
            this.lblListaProduto.TabIndex = 2;
            this.lblListaProduto.Text = "Lista de Produtos";
            // 
            // pnlAddCarrinho
            // 
            this.pnlAddCarrinho.BackColor = System.Drawing.Color.White;
            this.pnlAddCarrinho.Controls.Add(this.btnAddCarrinho);
            this.pnlAddCarrinho.Controls.Add(this.nudQuantidade);
            this.pnlAddCarrinho.Controls.Add(this.lblQuantidade);
            this.pnlAddCarrinho.Controls.Add(this.lblProdutoCarrinho);
            this.pnlAddCarrinho.Controls.Add(this.cboCategoriaCarrinho);
            this.pnlAddCarrinho.Controls.Add(this.lblCarrinho);
            this.pnlAddCarrinho.Location = new System.Drawing.Point(279, 529);
            this.pnlAddCarrinho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAddCarrinho.Name = "pnlAddCarrinho";
            this.pnlAddCarrinho.Size = new System.Drawing.Size(463, 192);
            this.pnlAddCarrinho.TabIndex = 4;
            // 
            // btnAddCarrinho
            // 
            this.btnAddCarrinho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAddCarrinho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCarrinho.FlatAppearance.BorderSize = 0;
            this.btnAddCarrinho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCarrinho.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddCarrinho.ForeColor = System.Drawing.Color.White;
            this.btnAddCarrinho.Location = new System.Drawing.Point(251, 123);
            this.btnAddCarrinho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddCarrinho.Name = "btnAddCarrinho";
            this.btnAddCarrinho.Size = new System.Drawing.Size(187, 49);
            this.btnAddCarrinho.TabIndex = 3;
            this.btnAddCarrinho.Text = "Adicionar";
            this.btnAddCarrinho.UseVisualStyleBackColor = false;
            this.btnAddCarrinho.Click += new System.EventHandler(this.btnAddCarrinho_Click);
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudQuantidade.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudQuantidade.Location = new System.Drawing.Point(23, 135);
            this.nudQuantidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudQuantidade.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(205, 30);
            this.nudQuantidade.TabIndex = 0;
            this.nudQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblQuantidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblQuantidade.Location = new System.Drawing.Point(17, 111);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(100, 23);
            this.lblQuantidade.TabIndex = 2;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblProdutoCarrinho
            // 
            this.lblProdutoCarrinho.AutoSize = true;
            this.lblProdutoCarrinho.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblProdutoCarrinho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblProdutoCarrinho.Location = new System.Drawing.Point(17, 43);
            this.lblProdutoCarrinho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProdutoCarrinho.Name = "lblProdutoCarrinho";
            this.lblProdutoCarrinho.Size = new System.Drawing.Size(72, 23);
            this.lblProdutoCarrinho.TabIndex = 2;
            this.lblProdutoCarrinho.Text = "Produto";
            // 
            // cboCategoriaCarrinho
            // 
            this.cboCategoriaCarrinho.FormattingEnabled = true;
            this.cboCategoriaCarrinho.Location = new System.Drawing.Point(23, 70);
            this.cboCategoriaCarrinho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCategoriaCarrinho.Name = "cboCategoriaCarrinho";
            this.cboCategoriaCarrinho.Size = new System.Drawing.Size(413, 24);
            this.cboCategoriaCarrinho.TabIndex = 1;
            // 
            // lblCarrinho
            // 
            this.lblCarrinho.AutoSize = true;
            this.lblCarrinho.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCarrinho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblCarrinho.Location = new System.Drawing.Point(20, 14);
            this.lblCarrinho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarrinho.Name = "lblCarrinho";
            this.lblCarrinho.Size = new System.Drawing.Size(177, 23);
            this.lblCarrinho.TabIndex = 2;
            this.lblCarrinho.Text = "Adicionar ao Carrinho";
            // 
            // pnlCarrinho
            // 
            this.pnlCarrinho.BackColor = System.Drawing.Color.White;
            this.pnlCarrinho.Controls.Add(this.btnRemover);
            this.pnlCarrinho.Controls.Add(this.btnFinalizarCompra);
            this.pnlCarrinho.Controls.Add(this.lblValorTotal);
            this.pnlCarrinho.Controls.Add(this.lblTotal);
            this.pnlCarrinho.Controls.Add(this.txtDesconto);
            this.pnlCarrinho.Controls.Add(this.lblDesconto);
            this.pnlCarrinho.Controls.Add(this.lblValorSubtotal);
            this.pnlCarrinho.Controls.Add(this.lblSubtotal);
            this.pnlCarrinho.Controls.Add(this.lstCarrinho);
            this.pnlCarrinho.Controls.Add(this.lblCarrinhoCompra);
            this.pnlCarrinho.Location = new System.Drawing.Point(771, 102);
            this.pnlCarrinho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCarrinho.Name = "pnlCarrinho";
            this.pnlCarrinho.Size = new System.Drawing.Size(500, 618);
            this.pnlCarrinho.TabIndex = 5;
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnFinalizarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizarCompra.FlatAppearance.BorderSize = 0;
            this.btnFinalizarCompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(120)))), ((int)(((byte)(50)))));
            this.btnFinalizarCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(58)))));
            this.btnFinalizarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarCompra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFinalizarCompra.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarCompra.Location = new System.Drawing.Point(234, 553);
            this.btnFinalizarCompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(238, 49);
            this.btnFinalizarCompra.TabIndex = 4;
            this.btnFinalizarCompra.Text = "Finalizar Compra";
            this.btnFinalizarCompra.UseVisualStyleBackColor = false;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.btnFinalizarCompra_Click);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblValorTotal.ForeColor = System.Drawing.Color.Blue;
            this.lblValorTotal.Location = new System.Drawing.Point(336, 523);
            this.lblValorTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(107, 28);
            this.lblValorTotal.TabIndex = 2;
            this.lblValorTotal.Text = "ValorTotal";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.Blue;
            this.lblTotal.Location = new System.Drawing.Point(35, 523);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(167, 28);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total da Compra";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(320, 471);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(132, 22);
            this.txtDesconto.TabIndex = 5;
            this.txtDesconto.Text = "0,00";
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDesconto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblDesconto.Location = new System.Drawing.Point(35, 471);
            this.lblDesconto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(82, 23);
            this.lblDesconto.TabIndex = 2;
            this.lblDesconto.Text = "Desconto";
            // 
            // lblValorSubtotal
            // 
            this.lblValorSubtotal.AutoSize = true;
            this.lblValorSubtotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorSubtotal.Location = new System.Drawing.Point(373, 430);
            this.lblValorSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorSubtotal.Name = "lblValorSubtotal";
            this.lblValorSubtotal.Size = new System.Drawing.Size(78, 23);
            this.lblValorSubtotal.TabIndex = 3;
            this.lblValorSubtotal.Text = "ValorSub";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(36, 430);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(74, 23);
            this.lblSubtotal.TabIndex = 2;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // lstCarrinho
            // 
            this.lstCarrinho.FormattingEnabled = true;
            this.lstCarrinho.ItemHeight = 16;
            this.lstCarrinho.Location = new System.Drawing.Point(27, 39);
            this.lstCarrinho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstCarrinho.Name = "lstCarrinho";
            this.lstCarrinho.Size = new System.Drawing.Size(444, 372);
            this.lstCarrinho.TabIndex = 1;
            // 
            // lblCarrinhoCompra
            // 
            this.lblCarrinhoCompra.AutoSize = true;
            this.lblCarrinhoCompra.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCarrinhoCompra.Location = new System.Drawing.Point(21, 12);
            this.lblCarrinhoCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarrinhoCompra.Name = "lblCarrinhoCompra";
            this.lblCarrinhoCompra.Size = new System.Drawing.Size(173, 23);
            this.lblCarrinhoCompra.TabIndex = 0;
            this.lblCarrinhoCompra.Text = "Carrinho de Compras";
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.Red;
            this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnRemover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(31, 555);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(163, 49);
            this.btnRemover.TabIndex = 7;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 735);
            this.Controls.Add(this.pnlCarrinho);
            this.Controls.Add(this.pnlAddCarrinho);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.PnlMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCompras";
            this.Load += new System.EventHandler(this.FrmCompras_Load);
            this.PnlMenu.ResumeLayout(false);
            this.PnlMenu.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlAddCarrinho.ResumeLayout(false);
            this.pnlAddCarrinho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            this.pnlCarrinho.ResumeLayout(false);
            this.pnlCarrinho.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnConfiguracao;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnFornecedores;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button BtnProduto;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label lblSistGestao;
        private System.Windows.Forms.Label lblSupermercado;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblDescCadastro;
        private System.Windows.Forms.Label lblCadasProduto;
        private Panel panel1;
        private TextBox txtLista;
        private Label lblListaProduto;
        private ListBox lstProdutos;
        private ComboBox cmbListaCategoria;
        private Panel pnlAddCarrinho;
        private Label lblCarrinho;
        private NumericUpDown nudQuantidade;
        private Label lblQuantidade;
        private Label lblProdutoCarrinho;
        private ComboBox cboCategoriaCarrinho;
        private Button btnAddCarrinho;
        private Panel pnlCarrinho;
        private TextBox txtDesconto;
        private Label lblDesconto;
        private Label lblValorSubtotal;
        private Label lblSubtotal;
        private ListBox lstCarrinho;
        private Label lblCarrinhoCompra;
        private Label lblValorTotal;
        private Label lblTotal;
        private Button btnFinalizarCompra;

        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private Button btnRemover;
    }
}