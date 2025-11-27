# 🛍️ CrudNpN - Sistema de Vendas

Sistema de gestão de vendas desenvolvido em ASP.NET Core MVC com Entity Framework Core, implementando funcionalidades completas de CRUD para clientes, produtos e vendas.

## 📋 Funcionalidades

### 🔐 Autenticação
- **Login** - Sistema de autenticação de usuários
- **Cadastro** - Registro de novos usuários
- **Validação** - Verificação de credenciais e duplicação de emails

### 👥 Gestão de Clientes
- Listagem completa de clientes
- Cadastro de novos clientes
- Edição de dados de clientes
- Visualização de detalhes
- Exclusão de registros

### 📦 Gestão de Produtos
- Catálogo de produtos
- Controle de estoque
- Preços e descrições
- Operações CRUD completas

### 💰 Sistema de Vendas
- Registro de vendas
- Associação cliente-produto
- Controle de quantidades
- Histórico de transações

## 🛠️ Tecnologias Utilizadas

- **ASP.NET Core 8.0 MVC**
- **Entity Framework Core**
- **PostgreSQL** (Npgsql)
- **Bootstrap 5**
- **jQuery**
- **HTML5/CSS3**

## 📁 Estrutura do Projeto

```
CrudNpN/
├── Controllers/          # Controladores MVC
│   ├── ClientesController.cs
│   ├── ProdutosController.cs
│   ├── VendasController.cs
│   ├── LoginController.cs
│   └── HomeController.cs
├── Models/              # Modelos de dados
│   ├── Cliente.cs
│   ├── Produto.cs
│   ├── Venda.cs
│   ├── Usuario.cs
│   └── VendaProduto.cs
├── Views/               # Interfaces visuais
│   ├── Clientes/
│   ├── Produtos/
│   ├── Vendas/
│   ├── Login/
│   └── Shared/
├── Data/                # Contexto do banco
│   └── AppDbContext.cs
├── Migrations/          # Migrações do banco
├── ViewModels/          # ViewModels
└── wwwroot/            # Arquivos estáticos
```

## ⚙️ Configuração e Instalação

### 1. **Pré-requisitos**
- .NET 8.0 SDK
- PostgreSQL
- Visual Studio Code ou Visual Studio

### 2. **Clonagem do Repositório**
```bash
git clone https://github.com/KaykyOne/f-nan-dotnet.git
cd CrudNpN
```

### 3. **Instalação de Pacotes**
```bash
# Pacotes principais
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL

# Ferramentas de scaffolding
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet tool install -g dotnet-aspnet-codegenerator
```

### 4. **Configuração do Banco de Dados**
```bash
# Aplicar migrações
dotnet ef database update

# Ou criar nova migração (se necessário)
dotnet ef migrations add "NomeDaMigracao"
```

### 5. **Executar o Projeto**
```bash
dotnet run
```

Acesse: `https://localhost:5074`

## 🗄️ Banco de Dados

### Tabelas Principais:
- **Usuarios** - Dados de autenticação
- **Clientes** - Informações dos clientes
- **Produtos** - Catálogo de produtos
- **Vendas** - Registro das vendas
- **VendaProduto** - Relacionamento N:N vendas-produtos

## 🚀 Comandos Úteis

### **Scaffolding de Controllers**
```bash
# Gerar controller com views
dotnet aspnet-codegenerator controller -name ClientesController -m Cliente -dc AppDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries

dotnet aspnet-codegenerator controller -name ProdutosController -m Produto -dc AppDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries

dotnet aspnet-codegenerator controller -name VendasController -m Venda -dc AppDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
```

### **Migrações**
```bash
# Criar migração
dotnet ef migrations add "DescricaoDaMudanca"

# Aplicar migração
dotnet ef database update

# Remover última migração
dotnet ef migrations remove
```

## 🎨 Layout e Design

O sistema utiliza:
- **Bootstrap 5** para responsividade
- **CSS personalizado** para temas específicos
- **Layout consistente** entre todas as páginas
- **Validação client-side** com jQuery

## 🔒 Segurança

- Validação de tokens antiforgery
- Sanitização de inputs
- Validação de modelos server-side
- Tratamento de erros adequado

## 📝 Licença

Este projeto foi desenvolvido para fins acadêmicos.

---

**Desenvolvido com ❤️ usando ASP.NET Core**
