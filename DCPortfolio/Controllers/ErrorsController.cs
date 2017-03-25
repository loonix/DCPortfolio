using System.Web.Mvc;

namespace DCPortfolio
{
  

        public sealed class ErrorsController : Controller
        {
            public ActionResult NotFound()
            {
                ActionResult result;

                object model = Request.Url.PathAndQuery;

                if (!Request.IsAjaxRequest())
                    result = View(model);
                else
                    result = PartialView("_NotFound", model);

                return result;
            }
        }

    }
