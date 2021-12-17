using Xunit;

namespace Demo.Tests
{
    public class AssertingCollectionsTests
    {
        [Fact]
        public void Funcionario_Habilidades_NãoDevePossuirHabilidadesVazias()
        {
            // Arrange & Act
            var funcionario = FuncionarioFactory.Criar(nome: "Evelym", salario: 10000);

            // Assert
            Assert.All(funcionario.Habilidades, action: habilidade => Assert.False(string.IsNullOrWhiteSpace(habilidade)));
        }

        [Fact]
        public void Funcionadio_Habilidades_JuniorDevePossuirHabilidadeBasica()
        {
            // Arrange & Act
            var funcionario = FuncionarioFactory.Criar(nome: "Eduardo", salario: 1000);

            //Assert
            Assert.Contains("OOP", funcionario.Habilidades);
        }

        [Fact]
        public void Funcionadio_Habilidades_JuniorNaoDevePossuirHabilidadeAvancadas()
        {
            // Arrange & Act
            var funcionario = FuncionarioFactory.Criar(nome: "Eduardo", salario: 1000);

            //Assert
            Assert.DoesNotContain("Microservices", funcionario.Habilidades);
        }

        [Fact]
        public void Funcionadio_Habilidades_SeniorDevePossuirTodasHabilidades()
        {
            // Arrange & Act
            var funcionario = FuncionarioFactory.Criar(nome: "Eduardo", salario: 15000);

            var habilidadesBasicas = new[]
            {
                "Lógica de Programação",
                "OOP",
                "Testes",
                "Microservices"
            };

            //Assert
            Assert.Equal(habilidadesBasicas, funcionario.Habilidades);
        }
    }
}
