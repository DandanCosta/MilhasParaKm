using System.Diagnostics;

const float Fator = 1.609f;
double valorMilhas = 0.0, valoremKm = 0.0;

Console.Write("Insira a medida em Milhas: ");
valorMilhas = double.Parse(Console.ReadLine()!);

valoremKm = valorMilhas * (double)Fator;

Console.Write(valoremKm.ToString("0.000 km"));