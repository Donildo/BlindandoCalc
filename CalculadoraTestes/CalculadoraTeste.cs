using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTeste
{
    private CalculadoraImp _calc;
    public CalculadoraTeste()
    {
        _calc = new CalculadoraImp();
    }
    [Fact]
    public void DeveSomar5com10ERetornar15()
    {
        //Arrange
        int num1 =5;
        int num2 = 10;

        //Act
        int Resultado = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(15, Resultado);

    }
    [Fact]
    public void DeveSomar10com10ERetornar20()
    {
        //Arrange
        int num1 =10;
        int num2 = 10;

        //Act
        int Resultado = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(20, Resultado);

    }

    [Fact]
    public void DeveVerificarSe4EhParERetornarVerdadeiro()
    {
        //Arrange
        int numero = 4;

        //Act
        bool resultado = _calc.EhPar(numero);

        //Assert
        Assert.True(resultado);

    }

    //Metodo Theory
    [Theory]
    // [InlineData(2)]
    // [InlineData(4)]
    // [InlineData(6)]
    // [InlineData(8)]
    // [InlineData(10)]
    [InlineData(new int[] {2,4})]
    [InlineData(new int[] {6,8,10})]


    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numeros)
    {
        //Arrange, no caso do metodo theory, não precisa de arrange. Theory é um conjunto de cenario para testes
        //Act / Assert
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
        //  bool resultado = _calc.EhPar(numero);
        //Assert
       // Assert.True(resultado);
    }   
    //2,4,6,8,10
}

