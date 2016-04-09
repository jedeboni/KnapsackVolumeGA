### KnapsackGA
Este programa resolve com a técnica de algoritmos genéticos o problema da mochila (knapsack) masi especificamente o problema da mochila 0-1. Onde se deve escolher de uma lista de itens com pesos e valores diferentes quais os itens que vão ser colocados na mochila de modo a maximizar o valor, mas sem ultrapassar um peso máximo final.Existem várias alternativas e variações. Neste caso o problema é chamado de 0-1 Knapsack porque ou o produto está na mochila ou não.

O problema do Knapsack (mochila) é um problema de otimização combinatória, e é um dos 21 problemas NP-Complexos de [Richard Karp](https://en.wikipedia.org/wiki/Karp%27s_21_NP-complete_problems).

Este programa foi escrito no MS-Visual Studio na linguagem c#. Permite a leitura da lista de um arquivo CSV e a variação dos parâmetros do algoritmo genético.

### Versões
- KnapsackGA - considera o peso e o valor dos itens na sacola
- KnapsackGAVol - considera o peso, o valor e o volume da sacola.

- Project status badge
[![Build status](https://ci.appveyor.com/api/projects/status/eanb0rmid5tbgoio?svg=true)](https://ci.appveyor.com/project/jedeboni/knapsackga)

### Componentes principais do programa fonte (versão KnapsackGA)
   - [Form1.Designer](KnapsackGA/KnapsackGA/Form1.Designer.cs) - componentes da interface gráfica (GUI) do programa. 
   - [Form1](KnapsackGA/KnapsackGA/Form1.cs) - Código do programa principal, controla o algoritmo genético.
   - [Individuo](KnapsackGA/KnapsackGA/Individuo.cs) - Descreve a sacola e as operações básicas de criação e avaliação.
   - [Item](KnapsackGA/KnapsackGA/Item.cs) - Descreve um item da mochila.
   - [DemoRoseta](KnapsackGA/dados/DemoRoseta.csv) - dados para testar o software, de uma demo no [rosettacode](http://rosettacode.org/wiki/Knapsack_problem/0-1)
   
### Exemplo da Interface
   ![](KnapsackGA/imagem/knapsackGA.JPG)

### Uso do Programa
- File > Read List - Permite ler uma lista (CSV) dos itens disponíveis para compor a sacola
- File > Clear Log - Lista a lista de Log (só pra facilitar a leitura)
- File > Exit - saída do programa
- Run > Setup- ajuste inicial da sacola, opcional para mudar os parâmetros e reiniciar o estudo
- Run > Single Step - executa uma única geração, para estudar a evolução da composição da sacola
- Run > Run - executa automaticamente o estudo. Os critérios de parada são definidos pelo MAXGEN e GSTOP
- Help - vai conter um HELP para este programa (no momento está vazio)
- Read..  - idem ao File > Read List
- Lista de Itens - (saida) mostra o nome do arquivo dos os dados da sacola
- N = (saida) número de itens da sacola
- Peso Sacola (Entrada) define o peso inicial da sacola valr default 4.0 (real)
- Run - idem ao Run > Run
- POPSIZE - (entrada) - tamanho da população gerada a cada geração (def. 1024)
- ELITE - (entrada) - porcentagem da população que sobrevive e se reproduz a cada geração (def. 0.2)
- MUTATE - (entrada) - porcentagem da população reproduzida que recebe uma mutação no gene
- MAXGEN - (entrada) - critério de parada, número máximo de gerações (def. 512)
- GSTOP - (entrada) - critério de parada, número de vezes que se a mesma solução se repetir indica que se chegou a uma solução final.
- LogList - (saida) - mostra os principais passos executados no programa
- ListaSacola (saida) - lista de itens da sacola e no final indica as escolhas 
