﻿using Calculadora.Services;

CalculadoraImplementacao c = new();

int a = 5;
int b = 10;

Console.WriteLine($"{a} + {b} = {c.Somar(a, b)}");