using Xunit;

namespace Demo.Tests
{
    public class AssertStringsTests
    {
        [Fact]
        public void StringsTools_UnirNomes_RetornarNomeCompleto()
        {
            //Arrange
            var sut = new StringTools();

            //Act 
            var nomeCompleto = sut.Unir("Evelym", "Pereira");

            // Assert
            Assert.Equal("Evelym Pereira", nomeCompleto);
        }

        [Fact]
        public void StringsTools_UnirNomes_DeveIgnorarCasesensitive()
        {
            // Arrange
            var sut = new StringTools();

            // Act
            var nomeCompleto = sut.Unir("Evelym", "Pereira");

            // Assert
            Assert.Equal("EVELYM PEREIRA", nomeCompleto, ignoreCase: true);
        }

        [Fact]
        public void StringsTools_UnirNomes_DeveConterTrecho()
        {
            // Arrange
            var sut = new StringTools();

            // Act
            var nomeCompleto = sut.Unir(nome: "Evelym", sobrenome: "Pereira");

            // Assert
            Assert.Contains(expectedSubstring: "elym", actualString: nomeCompleto);
        }

        [Fact]
        public void StringsTools_UnirNomes_DeveComecarCom()
        {
            // Arrange
            var sut = new StringTools();

            // Act
            var nomeCompleto = sut.Unir(nome: "Evelym", sobrenome: "Pereira");

            // Assert
            Assert.StartsWith("Eve", nomeCompleto);
        }

        [Fact]
        public void StringsTools_UnirNomes_DeveAcabarCom()
        {
            // Arrange
            var sut = new StringTools();

            // Act
            var nomeCompleto = sut.Unir(nome: "Evelym", sobrenome: "Pereira");

            // Assert
            Assert.EndsWith("ira", nomeCompleto);
        }

        [Fact]
        public void StringsTools_UnirNomes_ValidarExpressaoRegular()
        {
            // Arrange
            var sut = new StringTools();

            // Act
            var nomeCompleto = sut.Unir(nome: "Evelym", sobrenome: "Pereira");

            // Assert
            Assert.Matches(expectedRegexPattern:"[A-Z]{1}[a-z]+ [A-z]{1}[a-z]+", nomeCompleto);
        }

    }
}
