﻿using System.Drawing;
using System.Net;
using System.Runtime.Intrinsics.X86;

Console.WriteLine("1- Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor");

int idade = 35;
Console.WriteLine(idade);
Console.WriteLine();

Console.WriteLine("2- Crie uma variável chamada nome e atribua o valor \"Maria\" e exiba o seu valor");

string nome1 = "Maria";
Console.WriteLine(nome1);
Console.WriteLine();

Console.WriteLine("3- Crie uma variável chamada altura e atribua a ela o valor 3.45");
double altura = 3.45;
Console.WriteLine(altura);
Console.WriteLine();

Console.WriteLine("4- Crie uma variável chamada data e atribua a ela a data 04/09/1999 e exiba o seu valor");
DateTime dataDefinida = new DateTime(1999, 09, 04);
Console.WriteLine(dataDefinida);
Console.WriteLine();

Console.WriteLine("5- Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor");
const int ano = 12;
Console.WriteLine(ano);
Console.WriteLine();

Console.WriteLine("6- Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o valor 7.80 e exiba o seu valor");
double? nota = 7.80;
Console.WriteLine(nota);
Console.WriteLine();

Console.WriteLine("Questões 07-12, 14 e 15");
Console.WriteLine("Resposta Notebook Canva");
Console.WriteLine();

Console.WriteLine("13- Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a \r\nseguir imprima o valor da soma de x com y. (Use o operador aritmético + para realizar a operação de soma)");
int x = 77;
int y = 66;
Console.WriteLine(x + y);

