using Dominio.Modelo.Entidades;

namespace Dominio.Contratos.Interfaces
{
    public interface IProdutoRepositorio : IRepositorio<Produto>
    {
        Produto ObterProdutoPeloNome(string nome);
    }
}
