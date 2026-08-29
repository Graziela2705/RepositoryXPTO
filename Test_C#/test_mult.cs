using Xunit;

public class app
{


[Fact]
    public void TestMultiplicacao()
    {
        double resultado = Calculadora.Multiplicacao(2, 3);

        Assert.Equal(6, resultado);
    }
}