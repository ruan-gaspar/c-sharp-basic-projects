# Registro de Ocorrências - Aplicação ASP.NET Core MVC

## Descrição do Projeto

Este projeto é uma aplicação web de **registro de ocorrências**, criada como exemplo de **CRUD completo**, organizada com boas práticas de **ASP.NET Core MVC**.  
O objetivo é demonstrar a integração entre **Models, Controllers e Views**, além de aplicar conceitos de **UX/UI** em uma interface agradável, com cores inspiradas na **Polícia Civil**.

A aplicação permite gerenciar:
- Ocorrências
- Agentes responsáveis
- Delegacias
- Terceiros envolvidos
- Noticiantes

E também possui uma página **About** com informações do projeto.

---

## Tecnologias Utilizadas

- **ASP.NET Core MVC**: Framework principal para desenvolvimento web.
- **C#**: Linguagem de programação.
- **Entity Framework Core**: ORM para acesso e gerenciamento do banco de dados.
- **Bootstrap 5**: Framework CSS para estilização e responsividade.
- **HTML5 / CSS3**: Estrutura e estilização das páginas.
- **Visual Studio / Rider / VSCode**: IDEs recomendadas para desenvolvimento.
- **Banco de Dados**: Pode ser SQLite, SQL Server ou outro suportado pelo EF Core.

---

## Estrutura do Projeto

```
RegistroOcorrencias/
│
├─ Controllers/
│ ├─ OcorrenciaController.cs
│ ├─ AgenteResponsavelController.cs
│ ├─ DelegaciaController.cs
│ └─ ...
│
├─ Models/
│ ├─ Ocorrencia.cs
│ ├─ AgenteResponsavel.cs
│ ├─ Delegacia.cs
│ ├─ Terceiros.cs
│ └─ Noticiante.cs
│
├─ Views/
│ ├─ Shared/
│ │ └─ _Layout.cshtml # Layout compartilhado (header, footer, estilos)
│ ├─ Home/
│ │ ├─ Index.cshtml # Página inicial
│ │ └─ About.cshtml # Página estática do projeto
│ ├─ Ocorrencia/
│ │ ├─ Index.cshtml # Listagem de ocorrências
│ │ ├─ Create.cshtml # Criar nova ocorrência
│ │ ├─ Edit.cshtml # Editar ocorrência
│ │ ├─ Delete.cshtml # Confirmar exclusão
│ │ └─ Details.cshtml # Detalhes da ocorrência
│ └─ ... # Outras pastas de entidades (AgenteResponsavel, Delegacia, etc.)
│
├─ wwwroot/
│ ├─ css/
│ │ └─ site.css # Estilos globais da aplicação
│ └─ js/
│
├─ Data/
│ └─ ApplicationDbContext.cs # Configuração do EF Core
│
├─ appsettings.json # Configurações da aplicação
└─ Program.cs / Startup.cs # Configuração inicial do ASP.NET Core
```


## Navegação da Aplicação

- **Home**: Página inicial com informações gerais e navegação.
- **Ocorrências**: CRUD completo de ocorrências.
- **Agentes Responsáveis**: CRUD de agentes.
- **Delegacias**: CRUD de delegacias.
- **About**: Página estática com informações sobre o projeto.
- **Terceiros e Noticiantes**: CRUD de pessoas envolvidas.

O menu do cabeçalho (`_Layout.cshtml`) contém botões estilizados que direcionam para cada uma dessas páginas, mantendo um layout consistente e cores personalizadas (fundo preto, letras amarelas, títulos em vermelho).


## Estilo e UX/UI

- **Cores predominantes**: Preto (fundo), amarelo (texto), vermelho (alertas/títulos).
- **Botões**: Todos padronizados com cores consistentes (ex.: botões de ação em amarelo).
- **Tabelas**: Texto amarelo com fundo escuro para melhor contraste.
- **Responsividade**: Layout adaptável a diferentes resoluções usando Bootstrap.


## Como Rodar o Projeto

1. Clone o repositório:
   `git clone <URL_DO_REPOSITORIO>
   cd registro-ocorrencia-dotnet-application`


2. Restaure os pacotes:
`dotnet restore`

 
3. Execute a aplicação:
`dotnet restore`


4. Abra o navegador em:
`https://localhost:5001`

Contribuição

Pull requests são bem-vindos. Para grandes mudanças, abra uma issue primeiro para discutir o que você deseja modificar.

## Integrantes do Grupo:
Ruan Gaspar
RM: 559567
Turma: 2TDSPA 

Rodrigo Paes Morales
RM: 560209
Turma: 2TDSPA