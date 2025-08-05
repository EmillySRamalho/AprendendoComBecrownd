/*Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, p1(x1,y1) e p2(x2,y2) e calcule a distância entre eles, mostrando 4 casas decimais, segundo a fórmula:

Distancia =

Entrada
O arquivo de entrada contém duas linhas de dados. A primeira linha contém dois valores de ponto flutuante: x1 y1 e a segunda linha contém dois valores de ponto flutuante x2 y2.

Saída
Calcule e imprima o valor da distância segundo a fórmula fornecida, considerando 4 casas decimais.*/

using System;

class Program
{
    static void Main()
    {
        string[] linha1 = Console.ReadLine().Split(' ');
        double x1 = double.Parse(linha1[0]);
        double y1 = double.Parse(linha1[1]);

        string[] linha2 = Console.ReadLine().Split(' ');
        double x2 = double.Parse(linha2[0]);
        double y2 = double.Parse(linha2[1]);

        double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        Console.WriteLine(distancia.ToString("F4"));
    }
}