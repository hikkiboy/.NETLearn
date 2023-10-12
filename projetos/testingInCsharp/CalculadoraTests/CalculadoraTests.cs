using Calculadora.Services;

namespace CalculadoraTests;

public class CalculadoraTests
{

    private CalculadoraImp _calc;
    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        //Arange
        int nu1 = 5;
        int nu2 = 10;
        //Act
        int resultado = _calc.Somar(nu1, nu2);
        //Assert
        Assert.Equal(15, resultado);
    }
     [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        //Arange
        int nu1 = 10;
        int nu2 = 10;
        //Act
        int resultado = _calc.Somar(nu1, nu2);
        //Assert
        Assert.Equal(20, resultado);
    }
    [Fact]
    public void DeveVerificarSe4EhParERetornarVerdadeiro()
    {
        //Arange
        int n = 4;
        //Act
        bool resultado = _calc.EhPar(n);
        //Assert
        Assert.True(resultado);
    }
    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(9)]
    [InlineData(11)]
    public void DeveVerificarSeOsNumerosSaoPares(int numero)
    {
        //Assert

        //Act
        bool resultado = _calc.EhPar(numero);
        //Arrange
        Assert.True(resultado);
    }
}