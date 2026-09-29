using GerenciamentoDePessoas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

// Este controller é responsável por gerenciar as páginas principais da aplicação,
// incluindo a página inicial, a página de privacidade e a página de tratamento de erros,
// além de carregar as imagens disponíveis na pasta de arquivos públicos.

namespace GerenciamentoDePessoas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            string caminhoPasta = Path.Combine(_webHostEnvironment.WebRootPath, "Imagens");

            var nomeImagens = Directory
                .EnumerateFiles(caminhoPasta)
                .Select(Path.GetFileName)
                .ToList();

            return View(nomeImagens);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
