# Jogo de xadrez no console

## Aula-160
### Criando primeira classe do projeto

* Padrão camadas

* Criando a classe Posicao

* Técnica de orientação a objeto aplicado:
  * Encapsulamento
  * Construtor
  * Sobreposição (ToString)

Acessar repositório [Aula-160](https://github.com/abnersolivera/XADREZ_CONSOLE/tree/main/Aula-160)


## Aula-161
### Começando a implementar o tabuleiro

* Técnica de orientação a objeto aplicado:
  * Tipos enumerados
  * Associações
  * Encapsulamento (protected)
 
* Estruturas de dados aplicado:
  * Matriz
  
  Acessar repositório [Aula-161](https://github.com/abnersolivera/XADREZ_CONSOLE/tree/main/Aula-161)
  
## Aula-162
### Começando a implementar um método que imprime o tabuleiro

* Técnica de orientação a objeto aplicado:
  * elementos estáticos
  * Encapsulamento (método de acesso a um elemento da matriz)
  
  Acessar repositório [Aula-162](https://github.com/abnersolivera/XADREZ_CONSOLE/tree/main/Aula-162)
  
  ## Aula-163
  ### Começando a colocar peças no tabuleiro
  
  * Técnica de orientação a objeto aplicado:
   * herança (Rei é uma Peca, Torre é uma Peca)
   * associações (a Peca tem um Tabuleiro, o Tabuleiro tem várias Pecas)
   * construtor
   * :base

Acessar repositório [Aula-163](https://github.com/abnersolivera/XADREZ_CONSOLE/tree/main/Aula-163)

## Aula-164
### Criando uma exceção personalizada de tabuleiro

* Técnicas de orientação a objetos aplicadas:
 * Sobrecarga (obter uma peça por Posicao)
 * Exceções

Acessar repositório [Aula-164](https://github.com/abnersolivera/XADREZ_CONSOLE/tree/main/Aula-164)

## Aula-165
### Testando a exceção personalizada de tabuleiro

* Técnicas de orientação a objetos aplicadas:
  * Exceções
 
Acessar repositório [Aula-165](https://github.com/abnersolivera/XADREZ_CONSOLE/tree/main/Aula-165)

## Aula-166
### Criando a classe PosicaoXadrez

* Criamos a classe
* Incluímos um método que a converte para Posicao

* Técnicas de orientação a objetos aplicadas:
 * Encapsulamento
 * Construtores
 * Sobreposição (ToString)

Acessar repositório [Aula-166](https://github.com/abnersolivera/XADREZ_CONSOLE/tree/main/Aula-166)

## Aula-166
### Criando a classe PosicaoXadrez

* Criamos a classe
* Incluímos um método que a converte para Posicao

* Técnicas de orientação a objetos aplicadas:
 * Encapsulamento
 * Construtores
 * Sobreposição (ToString)

Acessar repositório [Aula-166](https://github.com/abnersolivera/XADREZ_CONSOLE/tree/main/Aula-166)

## Aula-167
### Melhorando a impressão do tabuleiro

* Técnicas de orientação a objetos aplicadas:
 * EElementos estáticos (método ImprimirPeca)
 
Acessar repositório [Aula-167](https://github.com/abnersolivera/XADREZ_CONSOLE/tree/main/Aula-167)

## Aula-168 - 169
### Preparando o programa para teste iniciais

* Classe PartidaDeXadrez
* Começamos a implementar o método RealizarJogada
* Delegamos a instaciação das peças para a PartidaDeXadrez

* Técnicas de orientação a objetos aplicadas:
 * Encapsulamento (método privada ColocarPecas)
 
Acessar repositório [Aula-168 - 169](https://github.com/abnersolivera/XADREZ_CONSOLE/tree/main/Aula-168)

## Aula-170 - 171 - 172 - 173
### Projetando o método que diz quais movimentos possíveis de uma peça

* Técnicas de orientação a objetos aplicadas:
  * Classe abstrata
  * Herança
  * Sobreposição (movimentosPossiveis)
  * Sobrecarga (ImprimirTabuleiro)

* Estrutura de dados aplicadas:
  * Matriz
 
* Melhorado o ImprimirTabuleiro (deixando ele mais enxuto)
* Melhorado o ImprimirPeca
* Melhorado o programa principal

Acessar repositório [Aula-170 - 171 - 172 - 173](https://github.com/abnersolivera/XADREZ_CONSOLE/tree/main/Aula-170)

## Aula-174 - 175 - 176
### Passando o turno | Validando a posição de origem | Validando a posição de destino

* Começamos o método RealizarJogada
* Aplicação informando o turno e jogador atual
* Método ExisteMovimentosPossiveis(Peca)
* Método ValidarPosicaoDeOrigem (PartidaDeXadrez)
* Tratamento de exceções no programa principal
* Método PodeMoverPara (Peca)
* Método ValidarPosicaoDeDestino (PartidaDeXadrez)

* Técnicas de orientação a objetos aplicadas:
  * Encapsulamento (mudamos as restrições de acesso de alguns atributos)
  * Exceções

* Estrutura de dados aplicadas:
  * Matriz

Acessar repositório [Aula-174-175-176](https://github.com/abnersolivera/XADREZ_CONSOLE/tree/main/Aula-174)

## Aula-177 - 178
### Implementando um controle de peças capturadas | Testando o controle de peças capturadas

* Método ColocarNovaPeca (PartidaDeXadrez)
* Atualizamos o método ExecutaMovimento (PartidaDeXadrez)
* Método: PecasCapturadas e PecasEmJogo
* Método ImprimirPartida e ImprimirConjunto (Tela)


* Técnicas de orientação a objetos aplicadas:
  * Elementos estáticos

* Estrutura de dados aplicadas:
  * Conjuntos

Acessar repositório [Aula-177-178](https://github.com/abnersolivera/XADREZ_CONSOLE/tree/main/Aula-177)

## Aula-179 - 180
### Implementando a lógica de xeque | Testando a lógica de xeque

* Método de PartidaDeXadrez: EstaEmXeque, DefazMovimento
* Atualização do método realiza Jogada (PartidaDeXadrez)
* Método DecrementarQteMovimentos (Peca)


* Técnicas de orientação a objetos aplicadas:
  * Encapsulamento
  * Novo: operador "is"
  * Exceções

* Estrutura de dados aplicadas:
  * Matriz

Acessar repositório [Aula-179-180](https://github.com/abnersolivera/XADREZ_CONSOLE/tree/main/Aula-179)

## Aula-181 - 182
### Implementando a lógica de xequemate - Testando a lógica de xequemate

* Método de PartidaDeXadrez: EstaEmXeque, DefazMovimento
* Atualização do método realiza Jogada (PartidaDeXadrez)
* Método DecrementarQteMovimentos (Peca)
* Método TesteXequemate (PartidaDeXadrez)
* Adaptações na aplicação para mostrar o xequemate
* Correção no método TesteXequeMate

* Técnicas de orientação a objetos aplicadas:
  * Encapsulamento
  * Novo: operador "is"
  * Exceções

* Estrutura de dados aplicadas:
  * Matriz

Acessar repositório [Aula-181-182](https://github.com/abnersolivera/XADREZ_CONSOLE/tree/main/Aula-181)