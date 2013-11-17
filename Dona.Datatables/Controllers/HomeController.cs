using Dona.Datatables.DAL;
using Dona.Datatables.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dona.Datatables.Controllers
{
    public class HomeController : Controller
    {
        private FakeDbContext _db = new FakeDbContext();

        public ActionResult Index()
        {
            return View(_db.Pessoas.ToList());
        }

        public ActionResult Segunda()
        {
            return View();
        }

        public JsonResult GetDados(string profissao)
        {
            return Json(_db.Pessoas
                .Where(x =>
                    x.Cargo.Equals(profissao, StringComparison.InvariantCultureIgnoreCase)
                    ||
                    profissao.Equals("TODOS", StringComparison.InvariantCultureIgnoreCase)
                )
                .Select(x => new PessoaViewModel
                {
                    Id = x.Id,
                    Nome = x.Nome,
                    Cargo = x.Cargo,
                    DtNascStr = x.DtNasc.ToShortDateString()
                })
                .ToList()
            );
        }
    }
}