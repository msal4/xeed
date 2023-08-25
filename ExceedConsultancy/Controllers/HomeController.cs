using ExceedConsultancy.Models;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace ExceedConsultancy.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _config;

        public HomeController(IConfiguration config)
        {
            _config = config;
        }

        public IActionResult Index()
        {
            return View();
        }


        //[Route("change")]
        //public IActionResult Change(string culture)
        //{
        //    Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
        //        new CookieOptions { Expires = DateTime.UtcNow.AddDays(14) });
        //    return RedirectToAction("index", "Home");
        //}
        [Route("change")]
        public IActionResult Change(string culture)
        {
            // Get the current URL
            string currentUrl = Request.Headers["Referer"].ToString();

            // Remove the culture parameter from the query string if present
            var uriBuilder = new UriBuilder(currentUrl);
            var queryParams = HttpUtility.ParseQueryString(uriBuilder.Query);
            queryParams.Remove("culture");
            uriBuilder.Query = queryParams.ToString();
            currentUrl = uriBuilder.ToString();

            // Append the new culture parameter to the URL
            if (currentUrl.Contains("?"))
            {
                currentUrl += $"&culture={culture}";
            }
            else
            {
                currentUrl += $"?culture={culture}";
            }

            return Redirect(currentUrl);
        }




        [HttpPost]
        public IActionResult Index(QuoteModel model, ViewContext viewContext)
        {
            

            // Get the current culture
            var currentCulture = viewContext.HttpContext.Features.Get<IRequestCultureFeature>().RequestCulture.Culture.Name;

            if (currentCulture.StartsWith("ar"))
            {
                // If the current culture is Arabic, redirect to QuoteArController
                return RedirectToAction("Index", "QuoteAr", model); 
            }
            else
            {
                // For other cultures, use the regular QuoteController
                return RedirectToAction("Index", "Quote", model);
            }
        }


        [HttpPost]
        public IActionResult Index(ContactModel model, ViewContext viewContext)
        {
           

            // Get the current culture
            var currentCulture = viewContext.HttpContext.Features.Get<IRequestCultureFeature>().RequestCulture.Culture.Name;

            if (currentCulture.StartsWith("ar"))
            {
                // If the current culture is Arabic, redirect to QuoteArController
                return RedirectToAction("Index", "QuoteAr", model);
            }
            else
            {
                // For other cultures, use the regular QuoteController
                return RedirectToAction("Index", "Quote", model); 
            }
        }


    }


}
