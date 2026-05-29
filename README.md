# Supermercado
Nome do Projeto: Sistema de Supermercado — CRUD, Compras e Emissão de Nota

Integrantes: 
MARIA NICOLLY BEZERRA LIMA	(923104157);																					
RAFAEL FERREIRA BENEDITO (923111689);																				
CLAUDIO ALVES RODRIGUES JUNIOR (923101514);																					
MICAEL DOS SANTOS RIBEIRO	(923110499);																				
BRUNO ALVES DE SOUZA	(923100014);																					
JOAO VICTOR SANTOS DE SOUZA (923102159);
SAMUEL DE AGUIAR GOES (923112994).

Descrição: O objetivo do sistema é facilitar o controle de estoque, o cadastro de produtos e o processo de vendas, oferecendo uma forma simples e organizada de registrar compras e gerar notas fiscais simples.

Funcionalidades do sistema:
🔹 Cadastro de Produtos
Inserção de novos produtos
Edição de informações (nome, categoria, preço e quantidade)
Exclusão de produtos
Listagem dos produtos cadastrados

🔹 Controle de Compras (Carrinho)
Seleção de produtos disponíveis
Adição de itens ao carrinho de compra
Definição de quantidade
Remoção de itens selecionados do carrinho
Limpeza completa do carrinho

🔹 Cálculo automático
Subtotal calculado automaticamente
Aplicação de desconto
Cálculo do valor total da compra


🔹 Registro de vendas
Armazenamento da venda no banco de dados
Registro dos itens comprados
Associação entre venda e produtos


🔹 Nota fiscal
Geração de nota fiscal simples
Exibição dos produtos comprados
Quantidade e preço por item
Valor total da compra

Dados obtidos através de uma VIEW no banco de dados

Tecnologias utilizadas
Linguagem: C#
Interface: Windows Forms
Banco de dados: SQL Server

Como configurar o banco de dados:

O usuário deve substituir:
SEU_SERVIDOR

Por exemplo:
DESKTOP-1234\SQLEXPRESS
configuration>
  <connectionStrings>
    <add name="MinhaConexao"
         connectionString="Server=SEU_SERVIDOR;Database=SupermercadoDB;Trusted_Connection=True;"
         providerName="System.Data.SqlClient" />
  </connectionStrings>
</configuration>
