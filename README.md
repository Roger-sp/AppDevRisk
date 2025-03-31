# 						AppDevRisk

Teste técnico - Categorizar operações em um portifólio

## ⚠️ Problema | Categorizar as operações em um portifólio 

Questão 1: Construa uma Aplicação Console em C# utilizando programação orientada a objeto que 
consiga classificar todas as operações do portifólio. 
Tenha em mente que uma aplicação real poderia ter dezenas de categorias. Dado isso, espera-se que a 
aplicação apresentada permita que novas categorias sejam facilmente adicionadas, removidas ou 
modificadas no futuro. 
O código pode ser enviado por link do GitHub. 
 
**Entradas**
     - A primeira linha de entrada é composta pela data de referência (referenceDate). 
A segunda linha de entrada indica o número de operações (n). 
Cada linha seguinte representa uma operação, composta por 3 componentes, o valor negociado, o setor 
do cliente e a data do próximo pagamento previsto, os elementos são separados por espaço 
Todos os valores são double e todas as datas estão no formato MM/dd/yyyy. 
 
**Saída** 
     - N linhas com a categoria de cada operação, em ordem. 
 
**Exemplo de entrada**
	12/11/2020  
	4  
	2000000 Private 12/29/2025  
	400000  Public  07/01/2020  
	5000000 Public  01/02/2024  
	3000000 Public  10/26/2023  
 
**Exemplo de saída**  
	HIGHRISK  
	EXPIRED  
	MEDIUMRISK  
	MEDIUMRISK

## 🚀 Começando

Para resolver este problema, vamos criar uma aplicação console em C# que, além de classificar as operações, 
permita realizar operações CRUD (Criar, Ler, Atualizar, Deletar) para as categorias de classificação de operações.
O código será baseado em princípios de Programação Orientada a Objetos (POO), Clean Code e SOLID.

## ✅ Estrutura do Projeto

1. Interface ITrade: Define as propriedades de uma operação.
2. Classe Trade: Implementa a interface ITrade e armazena as propriedades.
3. Classe Categorization: Uma classe base para as regras de classificação.
4. Regras de Categoria: Expired, HighRisk, MediumRisk.
5. Classe Portfolio: Contém as regras de categorização, além de permitir o CRUD de categorias.
6. Classe Program: Gerencia a entrada de dados, a lógica de categorização e o CRUD de categorias
 
Consulte **[Implantação](#-implanta%C3%A7%C3%A3o)** para saber como implantar o projeto.

### 🛠️ Pré-requisitos

* Visual Studio 2019+
* .NET 8.0

## 📣 Explicação da solução

1. Interface ITrade define a estrutura de uma operação.
2. Classe Trade implementa a interface ITrade e representa uma operação.
3. Classe Categorization serve como base para as regras de categorização das operações.
4. Regras específicas: Expired, HighRisk e Medium são implementações das regras de categorização.
5. Classe Portfolio gerencia a lista de regras de categorização e permite a manipulação dessas regras (CRUD).
6. Classe Program gerencia a entrada de dados e oferece um menu interativo para que o usuário possa adicionar, remover, ou atualizar regras de categorização.

> [!NOTE] 
> Como funciona o CRUD de Categorias (categorias existentes, a saber: Expired, HighRisk e  MediumRisk)

Adicionar categoria: O usuário pode adicionar novas categorias especificando o nome da classe da regra (exemplo: Expire).
Remover categoria: O usuário pode remover uma categoria fornecendo o índice da regra.
Atualizar categoria: O usuário pode atualizar uma categoria existente, substituindo-a por outra.

> [!WARNING]
🚨🚨🚨 Como adicionar novas categorias no futuro:

1. Criar uma nova classe que herda de CategoryCategorization e implementar o método Category.
2. Adicionar a nova regra à lista de regras na classe Portfolio.

### 🔧 Instalação

Clonar ou baixar o projeto zip no GitHub.

Clonar:

```
https://github.com/Roger-sp/AppDevRisk.git
```

Baixar o zip do Projeto:

```
https://github.com/Roger-sp/AppDevRisk/archive/refs/heads/Develop.zip
```

## 🛠️ Construído com

* [Visual Studio Community](https://visualstudio.microsoft.com/pt-br/vs/)"

## 📌 Versão

Versão corrente: [V1](https://github.com/Roger-sp/AppDevRisk/tree/Develop)

## ✒️ Autor

Rogério Santos

* **Roger Santos** - *Trabalho Inicial* - [Roger-sp](https://github.com/Roger-sp/AppDevRisk/tree/Develop)
* **Roger Santos** - *Documentação* - [Roger-sp](https://github.com/Roger-sp/AppDevRisk/blob/Develop/README.md)

## 📄 Licença

Este projeto é open source/Teste de candidatura.

## Thank you 🙏

* Conte a outras pessoas sobre este projeto 📢;
* Convide alguém da equipe para uma cerveja 🍺;

---
⌨️ com ❤️ por [Roger Santos](https://github.com/Roger-sp) 😊
