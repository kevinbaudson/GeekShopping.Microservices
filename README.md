# 🛒 GeekShopping Microservices

Projeto desenvolvido com o objetivo de **aprender e aplicar arquitetura de microserviços**
utilizando **.NET 6**, **Entity Framework Core**, **MySQL** e **mensageria com RabbitMQ**.

Este repositório representa minha evolução prática no desenvolvimento de back-end moderno,
seguindo boas práticas, padrões de projeto e conceitos de sistemas distribuídos.

---

## 🚀 Tecnologias Utilizadas

- **.NET 6 (ASP.NET Core Web API)**
- **Entity Framework Core**
- **MySQL**
- **RabbitMQ**
- **Swagger / OpenAPI**
- **AutoMapper**
- **Docker** (em breve)
- **Arquitetura de Microserviços**

---

## 🧩 Arquitetura

O projeto é composto por microserviços independentes, cada um responsável por um contexto específico do domínio.

📦 **Product API**
- Gerenciamento de produtos
- Persistência com MySQL
- Migrations com Entity Framework Core
- Documentação automática via Swagger

📡 **Mensageria**
- Comunicação assíncrona com RabbitMQ
- Preparado para integração entre serviços

---

## 📂 Estrutura do Projeto

```text
GeekShopping.Microservices
│
├── FrontEnd
│   └── GeekShopping.Web
│       ├── Dependencias
│       ├── Properties
│       ├── Controllers
│       ├── Models
│       ├── Views
│       ├── appsettings.json
│       └── Program.cs
│
├── Services (em desenvolvimento)
 └── GeekShopping.ProductAPI
│       ├── Properties
│       ├── Migrations
│       ├── Model
│       ├── appsettings.json
│       └── Program.cs
└── README.md
```

##🛠️ Pré-requisitos

.NET SDK 6.0+

MySQL

RabbitMQ

Visual Studio 2022+


## 📖 Objetivos de Aprendizado

Entender na prática microserviços

Trabalhar com mensageria assíncrona

Aplicar Entity Framework Core corretamente

Evoluir em arquitetura back-end

Preparar base para Docker e Cloud (Azure)

## 🔮 Próximos Passos

 Implementar RabbitMQ entre serviços

 Criar novos microserviços (Order, Payment)

 Dockerizar a aplicação

 Adicionar autenticação JWT

 Deploy em Cloud

