using Calculadora.Services;

CalculadoraImp c = new CalculadoraImp();

int num1 = 10;
int num2 = 7;

Console.WriteLine($"{num1} + {num2} = {c.Somar(num1, num2)}");
Console.WriteLine($"{num1} - {num2} = {c.Subtrair(num1, num2)}");
Console.WriteLine($"{num1} * {num2} = {c.Multiplicar(num1, num2)}");

try
{
    Console.WriteLine($"{num1} / {num2} = {c.Dividir(num1, num2)}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Erro: " + ex.Message);
}
