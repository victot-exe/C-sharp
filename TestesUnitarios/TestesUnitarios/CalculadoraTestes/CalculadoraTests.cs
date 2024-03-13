using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImplementacao _calc;

    public CalculadoraTests()
    {
        _calc = new ();
    }

    [Fact]//Faz considerar o método como um método de teste
    public void DeveSomar5Com10ERetornar15()
    {
        //Arrange
        int a = 5, b = 10;
        //Act
        int resultado = _calc.Somar(a, b);
        //Assert
        Assert.Equal(15, resultado);
    }
    [Fact]
    public void VerificaSe90EhParERetornarTrue()
    {
        // Arrange
        int num = 90;
        // Act
        bool resultado = _calc.isPar(num);
        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void VerificaSe35EhParERetornaFalse()
    {
        // Arrange
        int num = 35;
        // Act
        bool resultado = _calc.isPar(num);
        // Assert
        Assert.False(resultado);
    }

    [Theory]
    [InlineData(new int[] { 2, 4})]
    [InlineData(new int[] { 6, 8, 10})]
    public void VerificaSeOsNumerosSaoParesERetornarVerdadeiro(int[] nums)
    {
        //Act / Assert
        Assert.All(nums, num => Assert.True(_calc.isPar(num)));
    }
}