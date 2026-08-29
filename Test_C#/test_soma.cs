using Xunit;

public class CalculadoraTests
{
    [Fact]
    public void TesteSoma()
    {
        double resultado = Calculadora.Soma(2, 3);

        Assert.Equal(5, resultado);
    }
}