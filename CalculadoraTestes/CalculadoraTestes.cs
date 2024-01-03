using Calculadora.Services;

namespace CalculadoraTestes;
public class CalculadoraTestes
{
    private CalculadoraImp _calc;

    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15() // mande de uma forma descritiva, sem deixar genérico
    {
        // me diz o que tem que fazer, o que ele está passando e o que tem que me retornar
        
        //Arrange - montar seu cenário
        int num1 = 5;
        int num2 = 10;
        //Act - o que ele tem que fazer, ação: somar
        int  resultado = _calc.Somar(num1, num2);
        //Assert - validar se o final tem o resultado esperado, no caso 15
        Assert.Equal(15,resultado);
    }

    [Fact]
    public void Devesomar4Com5ERetornar9()
    {
        // Given
        int num = 4;
        int numb = 5;
        // When
        int res = _calc.Somar(num, numb);
        // Then
        Assert.Equal(9, res);
    }

    [Fact]
    public void DeveMultiplicar3com4ERetornar12()
    {
        // Given
        int a = 3;
        int b = 4;
        // When
        int result = _calc.Multiplicar(3, 4);
        // Then
        Assert.Equal(12, result);
    }

    [Fact]
    public void DeveVerificarSe4EhParERetornarVerdadeiro()
    {
        // Given - Arrange
        int num = 4;
        // When - Act
        bool result = _calc.Ehpar(num);
        //bool result2 = _calc.Ehpar(5);
        // Then - Assert
        Assert.True(result);
    }

    [Theory] //conjunto de cenários
    [InlineData(new int[] { 2, 8, 11} )]
    [InlineData(new int[] { 12, 14 })]// passar paramêtros, para cada inlinedata é um teste diferente
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numeros) //valor dos inline datas
    {
        //uma unica linha
        Assert.All(numeros, num => Assert.True(_calc.Ehpar(num)));

        // foreach (var num in numeros)
        // {
        //     Assert.True(_calc.Ehpar(num));
        // }
    }
    //2, 4, 6, 8, 10
}