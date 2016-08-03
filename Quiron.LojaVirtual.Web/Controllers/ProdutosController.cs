using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Dominio.Respositorio;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class ProdutosController : Controller
    {
        private ProdutosRepositorio _repositorioProduto;
        // GET: Produto
        public ActionResult Index()
        {
            _repositorioProduto = new ProdutosRepositorio();
            var produtos = _repositorioProduto.Produtos.Take(10);
            return View(produtos);
        }
    }
}