// Este modelo é responsável por armazenar informações relacionadas a erros da aplicação,
// permitindo identificar a requisição que originou o erro e controlar sua exibição na página.

namespace GerenciamentoDePessoas.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
