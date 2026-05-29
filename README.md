# 🛒 Sistema de Supermercado

Projeto acadêmico para controle de estoque, gerenciamento de vendas e emissão de notas fiscais.

## 👥 Integrantes
- **Maria Nicolly Bezerra Lima** (923104157)
- **Rafael Ferreira Benedito** (923111689)
- **Claudio Alves Rodrigues Junior** (923101514)
- **Micael dos Santos Ribeiro** (923110499)
- **Bruno Alves de Souza** (923100014)
- **Joao Victor Santos de Souza** (923102159)
- **Samuel de Aguiar Goes** (923112994)

---

## 🚀 Funcionalidades
- **Cadastro de Produtos:** Inserção, edição, exclusão e listagem.
- **Controle de Compras:** Adição/remoção de itens ao carrinho e cálculo de quantidade.
- **Cálculo Automático:** Subtotal, aplicação de descontos e valor total.
- **Registro de Vendas:** Armazenamento persistente no banco de dados.
- **Nota Fiscal:** Geração baseada em `VIEW` do SQL Server.

---

## 🛠 Tecnologias Utilizadas
- **Linguagem:** C#
- **Interface:** Windows Forms
- **Banco de Dados:** SQL Server

---

## 🏗 Arquitetura do Sistema
Aqui está um diagrama básico do fluxo de dados:

```mermaid
graph TD
    A[Usuário] --> B[Windows Forms]
    B --> C[Lógica de Negócios C#]
    C --> D[(SQL Server)]
    D --> E{VIEW Nota Fiscal}
    E --> B