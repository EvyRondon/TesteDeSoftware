﻿using Features.Core;
using Xunit;
using FluentAssertions;

namespace Features.Tests
{
    public class CpfValidationTests
    {
        [Theory(DisplayName = "CPF Validos")]
        [Trait("Categoria", "CPF Validation Tests")]
        [InlineData("15231766607")]
        [InlineData("78246847333")]
        [InlineData("64184957307")]
        [InlineData("21681764423")]
        [InlineData("13830803800")]
        public void Cpf_ValidaMultiplosNumeros_TodosDevemSerValidos(string cpf)
        {
            // Assert
            var cpfValidadion = new CpfValidation();

            // Act & Assert
            cpfValidadion.EhValido(cpf).Should().BeTrue();
        }

        [Theory(DisplayName = "CPF Invalidos")]
        [Trait("Categoria", "CPF Validation Tests")]
        [InlineData("15231766607213")]
        [InlineData("528781682082")]
        [InlineData("35555868512")]
        [InlineData("36014132822")]
        [InlineData("72186126500")]
        [InlineData("23775274811")]
        public void Cpf_ValidarMultiplosNumeros_TodosDevemSerInvalidos(string cpf)
        {
            // Assert
            var cpfValidation = new CpfValidation();

            // Act & Assert
            cpfValidation.EhValido(cpf).Should().BeFalse();
        }
    }
}
