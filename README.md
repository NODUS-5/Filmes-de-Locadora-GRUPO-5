# 🎬 Sistema de Gerenciamento de Filmes de Locadora

> **Status:** Em Desenvolvimento 🚧

## 🏫 Informações Acadêmicas

Este projeto foi desenvolvido como **trabalho da disciplina "Programação 1"** no ano de 2025, ministrada pelo **professor Dr. Sérgio Carlos Portari Júnior**, do curso de **Sistemas de Informação** da **Universidade do Estado de Minas Gerais (UEMG) - Unidade Frutal**.

O objetivo da atividade é aplicar os conceitos fundamentais de programação orientada a objetos em C#, com ênfase em persistência de dados e separação de responsabilidades.

---

## 📝 Descrição

Este projeto é uma aplicação de console desenvolvida em **C#**, com foco em simular um sistema de **CRUD** (Criar, Ler, Atualizar e Deletar) para o gerenciamento de filmes em uma locadora. As informações são armazenadas em um banco de dados **MySQL**, permitindo persistência e consulta estruturada dos dados.

---

## ✨ Funcionalidades

-   **Gerenciamento Completo de Filmes:**
    -   [✔️] Incluir novos filmes no acervo.
    -   [✔️] Alterar informações de filmes existentes (por campo).
    -   [✔️] Excluir filmes do catálogo por ID.
    -   [✔️] Listar todos os filmes cadastrados de forma organizada.

-   **Busca e Filtros Detalhados:**
    -   [✔️] Pesquisar filmes por **ID, Título, Diretor, Gênero, Ano de Lançamento, Classificação Indicativa e Duração**.

---

## 🛠️ Tecnologias Utilizadas

As seguintes tecnologias e ferramentas foram utilizadas no desenvolvimento do projeto:

- **Linguagem:** C#
- **Plataforma:** .NET Console Application
- **Banco de Dados:** MySQL
- **Gerenciador de Pacotes:** NuGet
  - `MySql.Data`

---

## 🧱 Arquitetura do Projeto

O sistema segue uma estrutura baseada em **camadas**, facilitando a manutenção e compreensão do código:

- **Model (Modelo):** Representa as entidades do sistema (como Filme).
- **DAO (Data Access Object):** Responsável por todas as operações no banco de dados.
- **Controller:** Realiza a lógica de negócios e orquestra a comunicação entre as camadas.
- **View (Apresentação):** Interface via terminal, interagindo com o usuário por meio de menus e mensagens.

---

## 👨‍💻 Autores

| [<img src="https://github.com/kayoweiber.png" width="100px;" /><br /><sub><b>Kayo Weiber</b></sub>](https://github.com/kayoweiber) | [<img src="https://github.com/JohnWeslley01.png" width="100px;" /><br /><sub><b>John Weslley</b></sub>](https://github.com/JohnWeslley01) |
| :---: | :---: |

**Grupo 5 – Programação 1**
