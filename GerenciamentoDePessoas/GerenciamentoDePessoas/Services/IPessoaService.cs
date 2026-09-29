using GerenciamentoDePessoas.Models;
// Esta interface define as operações de negócio relacionadas às pessoas,
// estabelecendo os métodos utilizados pelo serviço para consultar, cadastrar,
// editar e excluir registros, além de realizar buscas e obter a quantidade de pessoas.

namespace GerenciamentoDePessoas.Services
{
    public interface IPessoaService
    {
        Task<List<Pessoa>> BuscarTodos();
        Task<int> BuscarTotal();
        Task<List<string>> BuscarPessoasNome(string termo);
        Task<Pessoa> Criar(Pessoa pessoa);
        Task<Pessoa> BuscarPorId(int id);
        Task<Pessoa> Editar(Pessoa pessoa);
        Task Apagar(int id);
    }
}
