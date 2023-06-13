<div align="center">
    <img src="./asserts/logo.png" alt="Logo" width="100">
</div>

<h1 align="center">Distributed-ecommerce</h1>

<br>


<div align="center">

![GitHub repo size](https://img.shields.io/github/repo-size/Joaonorr/distributed-ecommerce)
![GitHub language count](https://img.shields.io/github/languages/count/Joaonorr/distributed-ecommerce)
![GitHub top language](https://img.shields.io/github/languages/top/Joaonorr/distributed-ecommerce)
![GitHub last commit](https://img.shields.io/github/last-commit/Joaonorr/distributed-ecommerce)
![GitHub](https://img.shields.io/github/license/Joaonorr/distributed-ecommerce)

</div>

- [Descrição do projeto](#descrição-do-projeto)
- [Requisitos não funcionais](#requisitos-não-funcionais)
- [Tecnologias utilizadas](#tecnologias-utilizadas)
- [Como rodar o projeto](#como-rodar-o-projeto)
    - [Pré-requisitos](#pré-requisitos)
    - [Rodando o projeto](#rodando-o-projeto)
- [Motivos da escolha das tecnologias](#motivos-da-escolha-das-tecnologias)

## Descrição do Projeto

Distributed-ecommerce é um projeto de ecommerce distribuído, onde o cliente pode realizar compras de variados produtos.
o Principal objetivo do projeto é a aplicação de conceitos de sistemas distribuídos, como por exemplo, a utilização de um sistema de mensageria para comunicação entre os serviços.

## Requisitos não funcionais

- Segurança: A aplicação deve ser segura, garantindo que apenas usuários autenticados possam realizar compras.
- Disponibilidade: A aplicação deve estar disponível 24/7.
- Performance: A aplicação deve ser performática, garantindo que o usuário não tenha que esperar muito tempo para realizar uma compra.
- Escalabilidade: A aplicação deve ser escalável, garantindo que o sistema possa suportar um grande número de usuários.
- Persistência: A aplicação deve persistir os dados dos usuários e dos produtos.

## Tecnologias utilizadas

![Spring](https://img.shields.io/badge/spring-%236DB33F.svg?style=for-the-badge&logo=spring&logoColor=white)
![Gradle](https://img.shields.io/badge/Gradle-02303A.svg?style=for-the-badge&logo=Gradle&logoColor=white)
![NodeJS](https://img.shields.io/badge/node.js-6DA55F?style=for-the-badge&logo=node.js&logoColor=white)
![Express.js](https://img.shields.io/badge/express.js-%23404d59.svg?style=for-the-badge&logo=express&logoColor=%2361DAFB)
![Nodemon](https://img.shields.io/badge/NODEMON-%23323330.svg?style=for-the-badge&logo=nodemon&logoColor=%BBDEAD)
![JWT](https://img.shields.io/badge/JWT-black?style=for-the-badge&logo=JSON%20web%20tokens)
![Yarn](https://img.shields.io/badge/yarn-%232C8EBB.svg?style=for-the-badge&logo=yarn&logoColor=white)
![Postgres](https://img.shields.io/badge/postgres-%23316192.svg?style=for-the-badge&logo=postgresql&logoColor=white)
![MongoDB](https://img.shields.io/badge/MongoDB-%234ea94b.svg?style=for-the-badge&logo=mongodb&logoColor=white)
![RabbitMQ](https://img.shields.io/badge/Rabbitmq-FF6600?style=for-the-badge&logo=rabbitmq&logoColor=white)
![Docker](https://img.shields.io/badge/docker-%230db7ed.svg?style=for-the-badge&logo=docker&logoColor=white)
![Docker Compose](https://img.shields.io/badge/docker--compose-%230db7ed.svg?style=for-the-badge&logo=docker&logoColor=white)

## Motivos da escolha das tecnologias

- **Spring**: O Spring é um framework que facilita o desenvolvimento de aplicações Java, além de ser um framework muito utilizado no mercado.

- **Gradle**: O Gradle é uma ferramenta de automação de compilação, que permite a criação e gerenciamento de projetos Java.

- **NodeJS**: O NodeJS é uma plataforma que permite a execução de código JavaScript fora do navegador, sendo muito utilizado para a criação de APIs.

- **Express**: O Express é um framework para NodeJS que facilita a criação de APIs.

- **Nodemon**: O Nodemon é uma ferramenta que permite a reinicialização automática de uma aplicação NodeJS sempre que um arquivo for alterado.

- **JWT**: O JWT é um padrão de token que permite a autenticação de usuários em APIs.

- **Yarn**: O Yarn é um gerenciador de pacotes para NodeJS.

- **Postgres**: O Postgres é um banco de dados relacional muito utilizado no mercado.

- **MongoDB**: O MongoDB é um banco de dados não relacional que além de ser muito utilizado no mercado, é uma ótima opção para utilização de serviços node.

- **RabbitMQ**: O RabbitMQ é um sistema de mensageria que permite a comunicação entre serviços.

- **Docker**: O Docker é uma plataforma que permite a criação e execução de containers.

- **Docker Compose**: O Docker Compose é uma ferramenta responsável por gerenciar a execução de múltiplos containers.



## Como rodar o projeto

### Pré-requisitos

Antes de começar, você vai precisar ter instalado em sua máquina as seguintes ferramentas:

- [Docker](https://docs.docker.com/engine/install/)
- [Docker Compose](https://docs.docker.com/compose/install/)

### Rodando o projeto

Na raiz do projeto onde se encontra o arquivo `docker-compose.yml`, execute o seguinte comando:

```bash
docker-compose up 
```

Com isso, todos os serviços serão iniciados e estarão disponíveis nas seguintes portas:

<table align="center" style="border: 1px solid black;">
    <tr>
        <th>Serviço</th>
        <th>Porta</th>
    </tr>
    <tr>
        <td>Auth API</td>
        <td>8082</td>
    </tr>
    <tr>
        <td>Product API</td>
        <td>8081</td>
    </tr>
    <tr>
        <td>Sales API</td>
        <td>8083</td>
    </tr>
    <tr>
        <td>Auth DB</td>
        <td>5432</td>
    </tr>
    <tr>
        <td>Product DB</td>
        <td>5433</td>
    </tr>
    <tr>
        <td>Sales DB</td>
        <td>27017<br>28017</td>
    </tr>
    <tr>
        <td>RabbitMQ</td>
        <td>15672<br>25676<br>5672</td>
    </tr>
</table>




