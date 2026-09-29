// Este modelo representa um usuário da aplicação, utilizando os recursos do ASP.NET Core Identity
// para autenticação e gerenciamento de contas, além de armazenar o CPF como informação adicional.

using Microsoft.AspNetCore.Identity;

namespace GerenciamentoDePessoas.Models
{
    public class Usuario : IdentityUser
    {
        public string CPF { get; set; }
    }
}
