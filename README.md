# 🎬 Sistema de Gerenciamento de Filmes de Locadora

> **Status:** Em Desenvolvimento 🚧

## 📝 Descrição

Este projeto é uma aplicação de console desenvolvida em C# como parte de um trabalho acadêmico. O objetivo é criar um sistema de CRUD (Criar, Ler, Atualizar, Deletar) completo para gerenciar o acervo de filmes de uma locadora , utilizando o MySQL como banco de dados para a persistência das informações.

---

## ✨ Funcionalidades

-   **Gerenciamento de Filmes:**
    -   [✔️] Incluir novos filmes no acervo.
    -   [✔️] Alterar informações de filmes existentes.
    -   [✔️] Excluir filmes do catálogo.
    -   [✔️] Listar todos os filmes cadastrados.
-   **Busca e Filtros:**
    -   [✔️] Pesquisar filmes por Título, Gênero, Ano de Lançamento e Classificação Indicativa.
-   **Relatórios:**
    -   [✔️] Gerar um relatório com todos os filmes ordenados por título.
    -   [✔️] Gerar um relatório de filmes filtrados por gênero.

---

## 🛠️ Tecnologias Utilizadas

As seguintes tecnologias foram utilizadas no desenvolvimento do projeto:

-   **Linguagem:** C# 
-   **Plataforma:** .NET Console
-   **Banco de Dados:** MySQL 
-   **Gerenciador de Pacotes:** NuGet
    -   `MySql.Data`

---

## 🏛️ Arquitetura

O sistema foi projetado utilizando uma arquitetura em camadas para separar as responsabilidades e promover um código mais limpo e de fácil manutenção:

-   **Apresentação (View):** Interface de usuário via console.
-   **Controle (Controller):** Camada que orquestra o fluxo, aplica validações e regras de negócio.
-   **Acesso a Dados (DAO):** Camada responsável pela comunicação direta com o banco de dados MySQL, encapsulando todos os comandos SQL.
-   **Modelo (Model):** Classes que representam as entidades do sistema.

---

## 👨‍💻 Autores

| [<img src="https://avatars.githubusercontent.com/u/80902181?v=4" width="100px;"/><br /><sub><b>Kayo</b></sub>](https://github.com/kayoweiber)<br /> | [<img src="https://avatars.githubusercontent.com/u/10137?v=4" width="100px;"/><br /><sub><b>John</b></sub>](https://github.com/JohnWeslley01)<br /> |
| :---: | :---: |

**Grupo 5** 