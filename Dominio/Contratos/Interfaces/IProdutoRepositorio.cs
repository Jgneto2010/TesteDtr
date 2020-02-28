using Dominio.Modelo.Entidades;
using System.Threading.Tasks;

namespace Dominio.Contratos.Interfaces
{
    public interface IProdutoRepositorio : IRepositorio<Produto>
    {
        Produto ObterProdutoPeloNome(string nome);
    }
}
