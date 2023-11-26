# Projeto de Estacionamento .NET 6

Bem-vindo ao projeto de estacionamento utilizando .NET 6! Este projeto foi desenvolvido como parte do Bootcamp **Programa��o C# com CRM Dynamics**, com o objetivo de criar um sistema simples de gerenciamento de estacionamento.

## Funcionalidades

O projeto inclui as seguintes funcionalidades:

- **Cadastro de Entrada de Ve�culos:** Permite adicionar ve�culos ao estacionamento, registrando a placa do ve�culo.

- **Cadastro de Sa�da de Ve�culos:** Possibilita remover ve�culos do estacionamento, calculando o custo com base no tempo de perman�ncia.

- **Relat�rios de Ve�culos no P�tio:** Exibe a lista de ve�culos atualmente estacionados.

## Tecnologias Utilizadas

- .NET 6

## Configura��o do Ambiente

Certifique-se de ter as seguintes ferramentas instaladas em seu ambiente de desenvolvimento:

- **.NET 6 SDK**
- **Visual Studio 2022** (ou Visual Studio Code)

## Observa��es

- **Cadastro de Placas Duplicadas:** Se tentar cadastrar a mesma placa duas vezes, receber� uma mensagem de erro indicando que o ve�culo j� est� estacionado.

- **Formato Decimal Flex�vel:** N�o importa se voc� utilizar decimais separados por "." ou ",", o sistema � flex�vel em rela��o a ambos os formatos para configurar os pre�os iniciais e por hora.

## Como Usar

1. Clone o reposit�rio:

```bash
git clone https://github.com/seu-usuario/estacionamento-dotnet
```

2. Navegue at� o diret�rio do projeto:

```bash
cd estacionamento-dotnet
```

3. Execute o projeto:

```bash
dotnet run
```

4. Siga as instru��es no console para interagir com o estacionamento (adicionar/remover/listar ve�culos).

## Contribui��o

Sinta-se � vontade para contribuir com melhorias, corre��es de bugs ou novos recursos. Abra uma issue para discutir grandes altera��es antes de enviar um pull request.

## Licen�a

Este projeto est� licenciado sob a [Licen�a MIT](LICENSE).