using Xunit;

public class CalculadoraTests
{


[Fact]
    public void TesteMultiplicacao()
    {
        double resultado = Calculadora.Multiplicacao(2, 3);

        Assert.Equal(6, resultado);
    }
}