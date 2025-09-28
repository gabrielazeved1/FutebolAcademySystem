# FutebolAcademySystem - C#

## Descrição

Este é um sistema de gestão para uma **escolinha de futebol**, desenvolvido em **C#** utilizando **Windows Forms**. O objetivo do projeto é aplicar os conceitos de **Programação Orientada a Objetos (POO)**, incluindo **herança**, **polimorfismo**, **encapsulamento**, entre outros. O sistema permite o **cadastro**, **edição** e **gestão** de **alunos**, **treinadores** e **modalidades** de futebol, além de gerar **relatórios financeiros** sobre custos, gastos e novos clientes.

A aplicação é conectada a um **banco de dados PostgreSQL** para armazenar as informações cadastradas e possibilitar o gerenciamento automatizado desses dados.

## Funcionalidades

### Cadastro de Alunos
Os alunos podem ser cadastrados no sistema, com informações como **nome**, **CPF**, **telefone**, **endereço**, entre outros. A modalidade escolhida pelo aluno é associada ao valor da **mensalidade**, que é calculado automaticamente com base na modalidade escolhida (iniciante, intermediário ou avançado).

### Cadastro de Treinadores
Os treinadores são cadastrados com informações como **nome**, **CPF**, **salário** e **modalidade** de ensino. O salário do treinador é calculado com base na modalidade de ensino atribuída, sendo ajustado automaticamente.

### Modalidades
O sistema permite o cadastro de **modalidades** de futebol, onde cada modalidade é associada a um **nível técnico** e um valor de **mensalidade**.

### Edição de Registros
Além do cadastro, o sistema também permite a **edição** de registros de alunos, treinadores e modalidades. As informações podem ser atualizadas conforme necessário.

### Relatórios
O sistema gera relatórios sobre:
- **Gastos** com treinadores e alunos,
- **Custos operacionais** da escolinha,
- **Novos clientes** e alterações nos cadastros.

### Banco de Dados
O sistema utiliza um banco de dados **PostgreSQL** para armazenar os dados de alunos, treinadores e modalidades. A conexão com o banco de dados é realizada automaticamente por meio de uma string de conexão configurada.

## Estrutura do Código

O projeto é estruturado em diversas classes que representam os componentes principais do sistema. Cada uma delas é implementada para garantir a **organização**, **modularidade** e **reutilização de código**.

### `Pessoa.cs`
Classe base para os objetos **Aluno** e **Treinador**, contendo informações comuns como **nome**, **CPF**, **idade**, **telefone**, **endereço**, entre outros. As classes derivadas (Aluno e Treinador) herdam essas propriedades.

### `Treinador.cs`
Representa um **treinador** na escolinha de futebol. Herda de **Pessoa** e adiciona funcionalidades específicas, como o cálculo do **salário**, que é determinado pela modalidade de ensino atribuída.

### `Aluno.cs`
Representa um **aluno** na escolinha de futebol. Herda de **Pessoa** e contém informações específicas como **mensalidade**, que é calculada de acordo com a modalidade de futebol escolhida.

### `Modalidade.cs`
Representa uma **modalidade** oferecida pela escolinha. Cada modalidade tem um **nome**, **nível técnico** e **mensalidade** associados.

### `ConexaoString.cs`
Esta classe gerencia a **conexão** com o banco de dados PostgreSQL. Ela cria e retorna a string de conexão necessária para que a aplicação se conecte ao banco de dados e execute operações de leitura e escrita.

## Como Executar o Projeto


1. **Clonar o repositório**:
   Caso deseje baixar o projeto, basta clonar o repositório com o seguinte comando:

   ```bash
   git clone https://github.com/gabrielazeved1/FutebolAcademySystem.git
   ```
   
2. **Instalar as dependências**:  
   Certifique-se de ter o **Npgsql** instalado para permitir a conexão com o banco de dados PostgreSQL. Se necessário, instale o pacote com o seguinte comando:

   `Install-Package Npgsql`

3. **Configurar o Banco de Dados**:  
   - Instale o **PostgreSQL** e crie o banco de dados `bdEscolinha`.  
   - Configure a string de conexão na classe `ConexaoString.cs` com os dados corretos do seu banco de dados PostgreSQL.  
   - Importe o esquema necessário no banco de dados para garantir que as tabelas de **alunos**, **treinadores** e **modalidades** sejam criadas corretamente.

4. **Executar o Projeto**:  
   Abra o projeto no **Visual Studio**, compile e execute. O sistema estará pronto para ser usado.

## Conclusão

Este projeto é uma aplicação prática de **Programação Orientada a Objetos** em C#, implementando conceitos essenciais como **herança**, **polimorfismo** e **encapsulamento**. A aplicação gerencia uma escolinha de futebol e proporciona uma interface fácil de usar para cadastrar, editar e gerar relatórios sobre alunos, treinadores e modalidades.

## Link Apresentação
```bash
https://youtu.be/Cc35mN2HEf4
```
