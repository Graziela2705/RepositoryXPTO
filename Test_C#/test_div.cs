using Xunit;

public class CalculadoraDivTests
{


[Fact]
    public void TesteDivisao()
    {
        double resultado = Calculadora.Divisao(6, 3);

        Assert.Equal(2, resultado);
    }
}