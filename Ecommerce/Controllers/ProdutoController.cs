using Ecommerce.Models;
using Ecommerce.Repositorio;
using Ecommerce.Repositorio.Ecommerce.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{

    public class ProdutoController : Controller
    {
        //Declara uma variavel privada somento leitura
        private readonly ProdutoRepositorio _produtoRepositorio;
      
        //Construtor
        public ProdutoController(ProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        public IActionResult Cadastro_Produto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro_Produto()
        {
            return View();
        }
    }
}