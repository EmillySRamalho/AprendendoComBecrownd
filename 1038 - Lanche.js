/*Com base na tabela, escreva um programa que leia o código de um item e a quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.

Entrada
O arquivo de entrada contém dois valores inteiros correspondentes ao código e à quantidade de um item conforme tabela acima.

Saída
O arquivo de saída deve conter a mensagem "Total: R$ " seguido pelo valor a ser pago, com 2 casas após o ponto decimal.*/

const fs = require('fs');
const input = fs.readFileSync(0, 'utf8').trim();

const valores = input.split(' ');

let codigo = Number(valores[0]);
let quantidade = Number(valores[1]);

const tabela = {
  1: 4.00,
  2: 4.50,
  3: 5.00,
  4: 2.00,
  5: 1.50
};

let total = tabela[codigo] * quantidade;

console.log(`Total: R$ ${total.toFixed(2)}`);