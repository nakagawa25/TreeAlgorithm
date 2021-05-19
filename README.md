# TreeAlgorithm
Algoritmo em C# que encontra a Raiz (Maior número dentro do Array) e define seus galhos da esquerda e da direita ambos ordenados de forma decrescente.

Exercício:

Dado um array inteiro sem duplicidade, construa um algoritmo de uma árvore a partir das seguintes regras:
•	A raiz da árvore deve ser o maior valor do array
•	Os galhos da esquerda devem ser compostos somente por números à esquerda do valor raiz, na ordem decrescente
•	Os galhos da direita devem ser compostos somente por número à direita do valor raiz, na ordem decrescente

Você pode apresentar um algoritmo em pseudo-código ou em qualquer linguagem de programação moderna.
Seu algoritmo deve ser capaz de resolver os dois cenários abaixo:

Cenario 1

Array de entrada: [3, 2, 1, 6, 0, 5]
Raiz: 6
Galhos da esquerda: 3, 2, 1
Galhos da direita: 5, 0
         6
       /    \
     3       5
    /          \
  2             0
 /
1
	
  
Cenario 2

Array de entrada: [7, 5, 13, 9, 1, 6, 4]
Raiz: 13
Galhos da esquerda: 7, 5
Galhos da direita: 9, 6, 4, 1

       13
     /     \
   7        9
  /           \
5              6
                  \
                    4
                      \
                        1

