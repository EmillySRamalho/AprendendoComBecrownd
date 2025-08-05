/*Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
a) a área do triângulo retângulo que tem A por base e C por altura.
b) a área do círculo de raio C. (pi = 3.14159)
c) a área do trapézio que tem A e B por bases e C por altura.
d) a área do quadrado que tem lado B.
e) a área do retângulo que tem lados A e B.

Entrada
O arquivo de entrada contém três valores com um dígito após o ponto decimal.

Saída
O arquivo de saída deverá conter 5 linhas de dados. Cada linha corresponde a uma das áreas descritas acima, sempre com mensagem correspondente e um espaço entre os dois pontos e o valor. O valor calculado deve ser apresentado com 3 dígitos após o ponto decimal.*/

using System; 

class URI {

    static void Main(string[] args) { 
        
        string[] valores = Console.ReadLine().Split(' ');
        double A = double.Parse(valores[0]);
        double B = double.Parse(valores[1]);
        double C = double.Parse(valores[2]);

        double triangulo = (A * C) / 2;
        double circulo = 3.14159 * (C * C);
        double trapezio = ((A + B) * C) / 2;
        double quadrado = B * B;
        double retangulo = A * B;

        Console.WriteLine($"TRIANGULO: {triangulo:F3}");
        Console.WriteLine($"CIRCULO: {circulo:F3}");
        Console.WriteLine($"TRAPEZIO: {trapezio:F3}");
        Console.WriteLine($"QUADRADO: {quadrado:F3}");
        Console.WriteLine($"RETANGULO: {retangulo:F3}");
    }
}
