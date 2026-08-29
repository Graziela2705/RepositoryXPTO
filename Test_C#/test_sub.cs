using Xunit;

public class CalculadoraTests
{


[Fact]
    public void TesteSubtracao()
    {
        double resultado = Calculadora.Subtracao(5, 3);

        Assert.Equal(2, resultado);
    }
}