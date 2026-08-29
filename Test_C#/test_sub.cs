using Xunit;

public class CalculadoraSubTests
{


[Fact]
    public void TestSubtracao()
    {
        double resultado = Calculadora.Subtracao(5, 3);

        Assert.Equal(2, resultado);
    }
}