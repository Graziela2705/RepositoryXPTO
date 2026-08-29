using Xunit;

public class CalculadoraSomaTests
{
    [Fact]
    public void TesteSoma()
    {
        double resultado = Calculadora.Soma(2, 3);

        Assert.Equal(5, resultado);
    }
}