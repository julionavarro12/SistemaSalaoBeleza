 💇‍♀️ Sistema de Gestão para Salão de Beleza

Este projeto é um sistema de gestão para salão de beleza, desenvolvido com o objetivo de organizar e automatizar os principais processos do dia a dia, como cadastro de clientes, agendamento de serviços, controle de profissionais e serviços oferecidos.

O sistema está sendo desenvolvido como parte do meu processo de aprendizado e evolução na área de desenvolvimento de software, aplicando boas práticas, organização de código e arquitetura.

---

## 🎯 Objetivo do Projeto

O principal objetivo deste projeto é:

- Facilitar a gestão de um salão de beleza
- Centralizar informações de clientes, serviços e agendamentos
- Praticar desenvolvimento backend com arquitetura organizada
- Aplicar conceitos de CRUD, regras de negócio e persistência de dados

---

## 🧩 Funcionalidades

Atualmente o sistema conta (ou contará) com as seguintes funcionalidades:

- Cadastro de clientes
- Cadastro de profissionais
- Cadastro de serviços
- Agendamento de horários
- Controle de status do agendamento (agendado, concluído, cancelado)
- Consulta de agenda por data e profissional

---

## 🛠️ Tecnologias Utilizadas

- Backend: **C# / ASP.NET Core**
- ORM: **Entity Framework Core**
- Banco de Dados: **PostgreSQL**
- Arquitetura: **MVC / Camadas (Controller, Service, Data)**
- Versionamento: **Git e GitHub**

---

## 🗂️ Estrutura do Projeto

```bash
SalaoBeleza/
├── Controllers/   # Recebo e mando (controle das requisições)
├── Services/      # Penso e resolvo (regras de negócio)
├── Models/        # Entidades do sistema
├── Data/          # Contexto e acesso ao banco
└── Program.cs
🚀 Como Executar o Projeto
Clone o repositório:

bash
Copiar código
git clone https://github.com/seu-usuario/seu-repositorio.git
Configure a string de conexão com o banco de dados no appsettings.json

Execute as migrations:

bash
Copiar código
dotnet ef database update
Inicie a aplicação:

bash
Copiar código
dotnet run
📚 Aprendizados
Durante o desenvolvimento deste projeto, estou praticando:

Organização de projetos backend

Separação de responsabilidades

Implementação de regras de negócio

Persistência de dados com EF Core

Versionamento e documentação com README

🔮 Próximos Passos
Implementar autenticação de usuários

Criar relatórios básicos

Implementar integração com frontend

Melhorar validações e regras de negócio

👨‍💻 Autor
Desenvolvido por Júlio Navarro
Estudante e desenvolvedor em formação, buscando oportunidades na área de desenvolvimento e tecnologia 🚀