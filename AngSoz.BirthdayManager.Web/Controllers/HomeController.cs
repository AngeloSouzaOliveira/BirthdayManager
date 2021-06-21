using AngSoz.BirthdayManager.Web.Date;
using AngSoz.BirthdayManager.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AngSoz.BirthdayManager.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly Contexto _contexto;

        public HomeController(Contexto contexto)
        {
            _contexto = contexto;
        }

        //var listar = _contexto.Pessoas;
        //    return View(listar.OrderByDescending(x => x.DataNascimento).ToList());
      

        [HttpGet]
        public IActionResult Index( ) {

            var model = new PessoasViewModel();

            //Lista dos aniversário do dia
            model.AniversarioDia = _contexto.Pessoas.Where(x =>
            (x.DataNascimento.Day == DateTime.Now.Day) &&
            (x.DataNascimento.Month == DateTime.Now.Month)).ToList();

            //Lista ordenada por data
            model.AniversarioOrdem = _contexto.Pessoas.OrderByDescending(x =>
            x.DataNascimento).ToList();

            //Lista de presente ordenada
            model.OrdemDatePresente = _contexto.Presentes.OrderByDescending(x =>
            x.Pessoas.DataNascimento).ToList();

            ViewBag.CountPessoa = _contexto.Pessoas.Count();

            ViewBag.CountPresentes = _contexto.Presentes.Count();

            ViewBag.CountAniversarioDia = _contexto.Pessoas.Where(x =>
            (x.DataNascimento.Day == DateTime.Now.Day) &&
            (x.DataNascimento.Month == DateTime.Now.Month)).Count();

            return View(model);
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
