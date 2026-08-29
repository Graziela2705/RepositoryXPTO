public class Calculadora
{
    public static double Soma(double a, double b)
    {
        return a + b;
    }

    public static double Subtracao(double a, double b)
    {
        return a - b;
    }

    public static double Multiplicacao(double a, double b)
    {
        return a * b;
    }

    public static double Divisao(double a, double b)
    {
        if (b == 0)
        {
            throw new ArgumentException("O denominador não pode ser zero.");
        }

        return a / b;
    }
}