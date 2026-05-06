/*Leia 5 valores Inteiros. A seguir mostre quantos valores digitados foram pares, quantos valores digitados foram ímpares, quantos valores digitados foram positivos e quantos valores digitados foram negativos.

Entrada
O arquivo de entrada contém 5 valores inteiros quaisquer.

Saída
Imprima a mensagem conforme o exemplo fornecido, uma mensagem por linha, não esquecendo o final de linha após cada uma.*/

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.trim().split('\n');

let pares = 0;
let impares = 0;
let positivos = 0;
let negativos = 0;

for (let i = 0; i < 5; i++) {

    let valor = parseInt(lines[i]);

    if (valor % 2 === 0) {
        pares++;
    }
    else {
        impares++;
    }

    if (valor > 0) {
        positivos++;
    }
    else if (valor < 0) {
        negativos++;
    }

}

console.log(pares + " valor(es) par(es)");
console.log(impares + " valor(es) impar(es)");
console.log(positivos + " valor(es) positivo(s)");
console.log(negativos + " valor(es) negativo(s)");