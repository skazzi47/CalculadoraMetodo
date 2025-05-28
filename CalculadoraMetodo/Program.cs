using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculadora Simples");
        Console.WriteLine("Digite o primeiro número:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Escolha a operação (+, -, *, /):");
        string operacao = Console.ReadLine() ?? string.Empty;

        double resultado = 0;
        bool operacaoValida = true;

        switch (operacao)
        {
            case "+":
                resultado = Somar(num1, num2);
                break;
            case "-":
                resultado = Subtrair(num1, num2);
                break;
            case "*":
                resultado = Multiplicar(num1, num2);
                break;
            case "/":
                if (num2 != 0)
                    resultado = Dividir(num1, num2);
                else
                {
                    Console.WriteLine("Erro: Divisão por zero!");
                    operacaoValida = false;
                }
                break;
            default:
                Console.WriteLine("Operação inválida!");
                operacaoValida = false;
                break;
        }

        if (operacaoValida)
            Console.WriteLine($"Resultado: {resultado}");
    }

    static double Somar(double a, double b)
    {
        return a + b;
    }

    static double Subtrair(double a, double b)
    {
        return a - b;
    }

    static double Multiplicar(double a, double b)
    {
        return a * b;
    }

    static double Dividir(double a, double b)
    {
        return a / b;
    }
}
