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
        public IActionResult Cadastro_Produto(Produto produto)
        {
            //verifica se os dados do usuário são válidos (de acordo com as regras de validação definidas na classe Usuario).
            if (ModelState.IsValid)
            {
                // Se os dados forem válidos, ele usa _usuarioRepositorio.
                // AdicionarUsuario(usuario) para adicionar o novo usuário ao banco de dados e redireciona para a página de login.
                _produtoRepositorio.AdicionarProduto(produto);

                return RedirectToAction("Login");
            }
            return View(produto);
        }
    }
}