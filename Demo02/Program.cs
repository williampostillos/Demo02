// See https://aka.ms/new-console-template for more information
using Demo02;
using System;

Console.WriteLine("Hello, World!");



Console.Write("Ingresa el valor de x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingresa el valor de y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingresa el valor de x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingresa el valor de y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingresa el valor de x3: ");
int x3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingresa el valor de y3: ");
int y3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingresa el valor de x4: ");
int x4 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingresa el valor de y4: ");
int y4 = Convert.ToInt32(Console.ReadLine());

int primeraParte = (x2 - x1) * (x2 - x1);
int segundaParte = (y2 - y1) * (y2 - y1);
int terceraParte = primeraParte + segundaParte;
Math.Sqrt(terceraParte);
int area = terceraParte * 2;

int valor1 = x2 - x1;
valor1 = valor1 * valor1;
int valor2 = y2 - y1;
valor2 = valor2 * valor2;
int valor3 = valor1 + valor2;
int Base = (int)Math.Sqrt(valor3);

int valor4 = x4 - x1;
valor4 = valor4 * valor4;
int valor5 = y4 - y1;
valor5 = valor5 * valor5;
int valor6 = valor4 + valor5;
int Altura = (int)Math.Sqrt(valor6);

int perimetro = 2*(Base + Altura);

Console.WriteLine("Base: ");
Console.WriteLine(Base);
Console.WriteLine("Altura: ");
Console.WriteLine(Altura);
Console.WriteLine("area: ");
Console.WriteLine(area);
Console.WriteLine("Perimetro: ");
Console.WriteLine(perimetro);




Console.Read();
