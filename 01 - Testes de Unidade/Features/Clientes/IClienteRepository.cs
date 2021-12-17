using Features.Core;

namespace Features.Clients
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Cliente ObterPorEmil(string email);
    }
}
