/*Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica, e informe-o expresso no formato horas:minutos:segundos.

Entrada
O arquivo de entrada contém um valor inteiro N.

Saída
Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme exemplo fornecido.*/

using System; 

class URI {

    static void Main(string[] args) { 

        int valor = int.Parse(Console.ReadLine());
        
        int horas = valor / 3600;
        int minutos = (valor % 3600) / 60;
        int segundos = valor % 60;
        
        Console.WriteLine($"{horas}:{minutos}:{segundos}");
        


    }

}