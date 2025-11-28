using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CrudMoura.Models;


namespace CrudMoura.Controllers
{

    public class FrutasController : Controller
    {
        private readonly ILogger<FrutasController> _logger;

        public static List<Fruta> ListaDeFrutas = new List<Fruta>
        {
            new Fruta{ id = 1, Nome = "Morango", Preco = 5.99f, Quantidade = 10, Categoria = "Tropical" },
            new Fruta{ id = 2, Nome = "Abacate", Preco = 5.90f, Quantidade = 12, Categoria = "Tropical" },
            new Fruta{ id = 3, Nome = "Limão", Preco = 2.95f, Quantidade = 100, Categoria = "Citrica" }
        };

        public FrutasController(ILogger<FrutasController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }




        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult SalvarFruta(Fruta frutaCadastrada)
        {
            //cria um novo id
            frutaCadastrada.id = ListaDeFrutas.Max(f => f.id) + 1;
            //salvar dados da fruta na listaDeFrutas
            ListaDeFrutas.Add(frutaCadastrada);
            //salvar os dados da fruta na lista de frutas
            return RedirectToAction(nameof(ListarFrutas));
        }


        public IActionResult ListarFrutas()
        {

            ViewBag.Fruta = ListaDeFrutas;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}