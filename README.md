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

## ⚙️ Configuração do Banco de Dados

### 1️⃣ Criar o Banco de Dados

Abra o SQL Server Management Studio (SSMS), conecte ao servidor SQL Server e execute o seguinte comando:

```sql id="9okfdu"
CREATE DATABASE SupermercadoDB;
```

---

### 2️⃣ Executar os Scripts SQL

Após criar o banco:

1. Selecione o banco `SupermercadoDB`
2. Abra os arquivos `.sql` disponíveis na pasta do projeto
3. Execute os scripts para:

   * Criar tabelas
   * Criar relacionamentos
   * Criar a `VIEW` de nota fiscal
   * Inserir estruturas necessárias

---

### 3️⃣ Configurar a Conexão com o Banco

No Visual Studio, localize o arquivo:

```txt id="7f8q8h"
App.config
```

Configure a `connectionString` com o nome do seu servidor SQL:

```xml id="ghlhl5"
<configuration>
  <connectionStrings>
    <add name="MinhaConexao"
         connectionString="Server=SEU_SERVIDOR;Database=SupermercadoDB;Trusted_Connection=True;"
         providerName="System.Data.SqlClient" />
  </connectionStrings>
</configuration>
```

### 🔹 Exemplos de servidor SQL

```txt id="o1g2aq"
.\SQLEXPRESS
```

ou

```txt id="kjjk8f"
DESKTOP-XXXX\SQLEXPRESS
```

---

## ▶️ Como Executar o Projeto

### ✅ Pré-requisitos

* Visual Studio instalado
* SQL Server instalado e ativo
* Carga de trabalho `.NET Desktop Development`

---

### 📥 Clonar o Repositório

```bash id="uhjvdr"
git clone https://github.com/Claudioalves05/Supermercado.git
```

Ou faça o download do projeto em `.zip`.

---

### 📂 Abrir o Projeto

Abra o arquivo:

```txt id="jlwm0d"
Supermercado.sln
```

no Visual Studio.

---

### ⚙️ Verificar Configuração

Certifique-se de que o `App.config` está apontando corretamente para o seu servidor SQL.

---

### ▶️ Executar o Sistema

Pressione:

```txt id="0pg0jg"
F5
```

ou clique em:

```txt id="2z7jcf"
Start
```

na barra superior do Visual Studio.

O sistema será compilado e executado automaticamente.
