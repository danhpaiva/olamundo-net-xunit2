using MeuPrimeiroTeste.App;

namespace MeuPrimeiroTeste.Tests;

public class HelloWorldServiceTest
{
    [Fact]
    public void GerarSaudacao_DeveRetornarSaudacaoPadrao_QuandoNomeForNuloOuVazio()
    {
        // Arrange (Preparação)
        var service = new HelloWorldService();
        // Act (Ação)
        var resultado = service.GerarSaudacao(null);
        // Assert (Verificação)
        Assert.Equal("Olá, mundo!", resultado);
    }
}
