using Calculadora.Services;

CalculadoraImp c = new CalculadoraImp();

int a = 20;
int b = 3;
Console.WriteLine($"{a} + {b} = {c.Somar(a, b)}");
