using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace ExceedConsultancy.Controllers
{
    public class ErrorController : Controller
    {
        [Route("[controller]/{statusCode}")]
        public IActionResult Error(int statusCode)
        {
            var statusCodeResult = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
            ViewBag.Code = statusCode;

            switch(statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "404 the page you are looking for was not found.";
                    break;

                case 500:
                    ViewBag.ErrorMessage = "500 the server has a terrible error.";
                    break;

                default:
                    ViewBag.ErrorMessage = $"{statusCode} error.";
                    break;
            }

            ViewBag.OriginalPathBase = statusCodeResult.OriginalPathBase;
            ViewBag.OriginalPath = statusCodeResult.OriginalPath;
            ViewBag.OriginalQueryString = statusCodeResult.OriginalQueryString;
            return View("Error");
        }
    }
}
