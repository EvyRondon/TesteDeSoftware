using Features.Clients;
using System;
using Xunit;

namespace Features.Tests
{
    public class ClienteTests
    {
        [Fact(DisplayName = "Novo Cliente Válido")]
        [Trait("Categoria", "Cliente Trait Testes")]
        public void Cliente_NovoCliente_DeveEstarValido()
        {
            // Arrange
            var cliente = new Cliente(
                Guid.NewGuid(),
                "Evelym",
                "Pereira",
                DateTime.Now.AddYears(-30),
                DateTime.Now,
                "eve@gmail.com.br",
                true);

            // Act
            var result = cliente.EhValido();

            // Assert
            Assert.True(result);
            Assert.Empty(cliente.ValidationResult.Errors);
        }

        [Fact(DisplayName = "Novo Cliente Inválido")]
        [Trait("Categoria", "Cliente Trait Testes")]
        public void Cliente_NovoCliente_DeveEstarInalido()
        {
            // Arrange
            var cliente = new Cliente(
                Guid.NewGuid(),
                "Evelym",
                "Pereira",
                DateTime.Now,
                DateTime.Now,
                "eve@gmail.com.br",
                true);

            // Act
            var result = cliente.EhValido();

            // Assert
            Assert.False(result);
            Assert.Single(cliente.ValidationResult.Errors);
        }
    }
}
