using Features.Clients;
using System;
using Xunit;

namespace Features.Tests
{
    [CollectionDefinition(nameof(ClienteCollection))]
    public class ClienteCollection : ICollectionFixture<ClienteTestsFixture> { }

    public class ClienteTestsFixture : IDisposable
    {
        public Cliente GerarClienteValido()
        {
            var cliente = new Cliente(
                Guid.NewGuid(),
                "Evelym",
                "Pereira",
                DateTime.Now.AddYears(-30),
                DateTime.Now,
                "evelym@edu.com",
                true);

            return cliente;
        }

        public Cliente GerarClienteInvalido()
        {
            var cliente = new Cliente(
                Guid.NewGuid(),
                "Evelym",
                "Pereira",
                DateTime.Now,
                DateTime.Now,
                "evelym@edu.com",
                true);

            return cliente;
        }

        public void Dispose()
        {
        }
    }
}
