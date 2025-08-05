/*Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.

Entrada
O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores, respectivamente dois inteiros e um valor com 2 casas decimais.

Saída
A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando de deixar um espaço após os dois pontos e um espaço após o "R$". O valor deverá ser apresentado com 2 casas após o ponto.*/

using System;

class URI
{
    static void Main(string[] args)
    {
        string[] linha1 = Console.ReadLine().Split(' ');
        int codigoPeca1 = int.Parse(linha1[0]);
        int numeroPecas1 = int.Parse(linha1[1]);
        double valorUnitario1 = double.Parse(linha1[2]);

        string[] linha2 = Console.ReadLine().Split(' ');
        int codigoPeca2 = int.Parse(linha2[0]);
        int numeroPecas2 = int.Parse(linha2[1]);
        double valorUnitario2 = double.Parse(linha2[2]);

        double total = (numeroPecas1 * valorUnitario1) + (numeroPecas2 * valorUnitario2);

        Console.WriteLine($"VALOR A PAGAR: R$ {total:F2}");
    }
}
