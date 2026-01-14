# Desafio Técnico - Paradigma

Este repositório contém a solução para o desafio técnico da Paradigma, abrangendo duas tarefas principais: consulta SQL e algoritmo de construção de árvore binária em C#.

## 📋 Descrição do Projeto

A avaliação técnica foi desenvolvida para demonstrar capacidade de interpretação de especificações, lógica de programação e criatividade na resolução de problemas. O projeto utiliza tecnologias modernas como C#, .NET e SQL Server, seguindo as melhores práticas de arquitetura e design patterns.

## 🏗️ Estrutura do Projeto

```
desafio-tecnico-paradigma/
├── desafio-tecnico-paradigma-task-1/     # Tarefa 1 - SQL
│   ├── sql/
│   │   ├── create_tables.sql            # Criação das tabelas
│   │   └── seed_data.sql                # Dados de exemplo
│   └── query.sql                        # Consulta SQL principal
└── desafio-tecnico-paradigma-task-2/     # Tarefa 2 - C#
    └── DesafioTecnicoParadigma/
        ├── DesafioTecnicoParadigma.Application/
        │   ├── Dtos/                     # Data Transfer Objects
        │   ├── Interfaces/
        │   │   ├── Services/             # Interfaces de serviços
        │   │   ├── Validators/           # Interfaces de validadores
        |   |   └── UseCases/             # Interfaces de casos de uso
        │   ├── Services/                 # Implementações de serviços
        │   ├── UseCases/                 # Casos de uso
        │   └── Validators/               # Validadores
        ├── DesafioTecnicoParadigma.Domain/
        │   └── Exceptions/               # Exceções de domínio
        ├── DesafioTecnicoParadigma.IoC/
        │   └── DependencyInjection/      # Configuração de DI
        └── DesafioTecnicoParadigma.Presentation/
            └── ConsoleUI/                # Interface de usuário
```

## 📊 Tarefa 1 - Consulta SQL

### Objetivo
Encontrar os colaboradores com maior salário em cada departamento.

## 🌳 Tarefa 2 - Algoritmo de Árvore Binária

### Objetivo
Construir uma árvore binária a partir de um array seguindo regras específicas:
- **Raiz**: Maior valor do array
- **Galhos da esquerda**: Valores à esquerda da raiz, em ordem decrescente
- **Galhos da direita**: Valores à direita da raiz, em ordem decrescente

### Exemplos

#### Cenário 1
**Entrada**: `[3, 2, 1, 6, 0, 5]`
```
Raiz: 6
Galhos da esquerda: 3, 2, 1
Galhos da direita: 5, 0
```
```
        6
      /   \
     3     5
    /       \
   2         0
  /
 1
```

#### Cenário 2
**Entrada**: `[7, 5, 13, 9, 1, 6, 4]`
```
Raiz: 13
Galhos da esquerda: 7, 5
Galhos da direita: 9, 6, 4, 1
```
```
     13
    /  \
  7      9
 /        \
5          6
            \
             4
              \
               1
```

## 🛠️ Tecnologias Utilizadas

- **.NET 8** - Framework principal
- **C# 12** - Linguagem de programação
- **SQL Server** - Banco de dados (Tarefa 1)
- **Dependency Injection** - Injeção de dependências
- **Clean Architecture** - Arquitetura limpa
- **SOLID Principles** - Princípios de design

## 🚀 Como Executar

### Pré-requisitos
- .NET 8 SDK
- SQL Server (para Tarefa 1)
- Visual Studio 2022 ou VS Code

### Tarefa 1 - SQL
1. Execute o script `create_tables.sql` para criar as tabelas
2. Execute o script `seed_data.sql` para inserir dados de exemplo
3. Execute a consulta em `query.sql`

### Tarefa 2 - C#
```bash
# Navegar até o diretório do projeto
cd desafio-tecnico-paradigma-task-2/DesafioTecnicoParadigma

# Restaurar pacotes
dotnet restore

# Executar o projeto
dotnet run
```

## 🎮 Interface do Usuário

O sistema oferece um menu interativo com as seguintes opções:

```
╔══════════════════════════════════════════════════════════════╗
║                       MENU DO SISTEMA                        ║
╠══════════════════════════════════════════════════════════════╣
║                                                              ║
║  [1] Usar Arrays de Exemplo                                  ║
║  [2] Inserir seu Próprio Array                               ║
║  [3] Sair do Sistema                                         ║
║                                                              ║
╚══════════════════════════════════════════════════════════════╝
```
