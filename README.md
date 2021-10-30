# HeronSeTriangulo
Receba três números decimais maiores que zero. Valide se estes números correspondem aos lados de um triângulo (a). Exiba o tipo do triângulo (b). Exiba a sua área (c).  a. Condição de existência de um triângulo:  Para que se possa construir um triângulo é necessário que a medida de qualquer um dos lados seja menor que a soma das medidas dos outros dois e maior que o valor absoluto da diferença entre essas medidas.  Ou seja, todas as condições abaixo devem ser atendidas:  
a < (b + c)
a > Math.Abs(b - c)
b < (a + c)
b > Math.Abs(a - c)
c < (a + b)
c > Math.Abs(a - b)
Tipo do triângulo:  
Equilátero: três lado com medidas iguais;
Escaleno: três lados com medidas diferentes; 
Isósceles: demais triângulos. 
c. Área do triângulo pelo Teorema de Heron:
s = (a+b+c) / 2
a = Math.Sqrt(s*(s-a)*(s-b)*(s-c))
