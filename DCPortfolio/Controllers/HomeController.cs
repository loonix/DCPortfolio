using DCPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using static DCPortfolio.Models.Portfolios;

namespace DCPortfolio.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var vm = new IndexVM();

            var Dbase = new DCDBEntities1();

            Dbase.Portfolio.ToList();

            vm.PortfolioList = Dbase.Portfolio
                //.Where( o => o.Nome == "Daniel" )
                .Select(o => new Portfolios
                {
                    PFid = o.PortfolioId,
                    PFTitle = o.Title,
                    PFDescription = o.Description,
                    PFCategory = o.Categories.Name,
                    PFImage = o.Image,
                    PFImagedescription = o.Imagedescription,
                    PFContent = o.pContent,
                })
                .Take(6)
                .OrderBy(o => o.PFTitle)
                .ToList();

            return View(vm);
        }
        [HttpPost]
        public ActionResult Index(ExampleClass model)
        {

           
            
            return View();
        }
    }
}