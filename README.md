# Projeto de Estacionamento .NET 6

Bem-vindo ao projeto de estacionamento utilizando .NET 6! Este projeto foi desenvolvido como parte do Bootcamp **Programação C# com CRM Dynamics**, com o objetivo de criar um sistema simples de gerenciamento de estacionamento.

## Funcionalidades

O projeto inclui as seguintes funcionalidades:

- **Cadastro de Entrada de Veículos:** Permite adicionar veículos ao estacionamento, registrando a placa do veículo.

- **Cadastro de Saída de Veículos:** Possibilita remover veículos do estacionamento, calculando o custo com base no tempo de permanência.

- **Relatórios de Veículos no Pátio:** Exibe a lista de veículos atualmente estacionados.

## Tecnologias Utilizadas

- .NET 6

## Configuração do Ambiente

Certifique-se de ter as seguintes ferramentas instaladas em seu ambiente de desenvolvimento:

- **.NET 6 SDK**
- **Visual Studio 2022** (ou Visual Studio Code)

## Observações

- **Cadastro de Placas Duplicadas:** Se tentar cadastrar a mesma placa duas vezes, receberá uma mensagem de erro indicando que o veículo já está estacionado.

- **Formato Decimal Flexível:** Não importa se você utilizar decimais separados por "." ou ",", o sistema é flexível em relação a ambos os formatos para configurar os preços iniciais e por hora.

## Como Usar

1. Clone o repositório:

```bash
git clone https://github.com/seu-usuario/Estacionamento-BootcampDIO
```

2. Navegue até o diretório do projeto:

```bash
cd Estacionamento-BootcampDIO
```

3. Execute o projeto:

```bash
dotnet run
```

4. Siga as instruções no console para interagir com o estacionamento (adicionar/remover/listar veículos).

## Contribuição

Sinta-se à vontade para contribuir com melhorias, correções de bugs ou novos recursos. Abra uma issue para discutir grandes alterações antes de enviar um pull request.

## Licença

Este projeto está licenciado sob a [Licença MIT](LICENSE).
