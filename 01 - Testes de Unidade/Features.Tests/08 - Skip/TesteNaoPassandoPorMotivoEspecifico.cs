using Xunit;

namespace Features.Tests
{
    public class TesteNaoPassandoPorMotivoEspecifico
    {
        [Fact(DisplayName = "Novo Cliente 2.0", Skip = "Nova Versão 2.0 Quebrando")]
        [Trait("Categoria", "Escapando dos Testes")]
        public void Teste_NaoEstaPassando_VersaoNovaNaoCompativel()
        {
            Assert.True(false);
        }
    }
}
