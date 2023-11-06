using ExceedConsultancy.Models;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Reflection.Metadata;
using System.Web;

namespace ExceedConsultancy.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(AppDbContext context) : base(context)
        {

        }



        private List<HomeSliderViewModel> GetSliderData()
        {
            var sliderData = _context.Sliders.ToList();
            return sliderData;
        }

        public List<IndustriesViewModel> GetIndustrieData()
        {
            var industrieData = _context.Industries.ToList();
            return industrieData;
        }


        public List<CapabilitiesViewModel> GetCapabilitieData()
        {
            var capabilitieData = _context.Capabilities.ToList();
            return capabilitieData;
        }


        public List<WhyUsHomeModel> GetWhyUsHomeData()
        {
            var WhyUsHomeData = _context.WhyUsHome.ToList();
            return WhyUsHomeData;
        }


        public List<AboutCompanyModel> GetAboutCompanyData()
        {
            var AboutCompanyData = _context.AboutCompany.ToList();
            return AboutCompanyData;
        }


        public IActionResult Index()
        {
            var capabilitiesData = GetCapabilitieData(); // Load your data

            // Set the capabilities data in HttpContext.Items
            HttpContext.Items["CapabilitiesData"] = capabilitiesData;

            var sliderModels = GetSliderData();
            var IndustrieModels = GetIndustrieData();
            var capabilitieModels = GetCapabilitieData();
            var AboutCompanyModels = GetAboutCompanyData();
            var WhyUsHomeModels = GetWhyUsHomeData();


            var viewModel = new HomeModel
            {
                Slider = sliderModels,
                Industrie = IndustrieModels,
                Capabilitie = capabilitieModels,
                AboutCompany = AboutCompanyModels,
                WhyUsHome = WhyUsHomeModels
            };

            return View(viewModel);

        }


        public IActionResult Business(Guid id)
        {
            // Fetch the Capabilitie item based on the 'id' parameter
            var capabilitie = _context.Capabilities.FirstOrDefault(c => c.Id == id);
            var capabilitieModels = GetCapabilitieData();

            if (capabilitie == null)
            {
                return NotFound(); // Handle the case when the Capabilitie item is not found
            }

            // Create a model to pass to the view
            var combinedModel = new CombinedModel
            {
                Capabilities = new CapabilitiesViewModel
                {
                    Id = capabilitie.Id,
                    Image = capabilitie.Image,
                    text = capabilitie.text,
                    text_Ar = capabilitie.text_Ar,
                    Description = capabilitie.Description,
                    Description_Ar = capabilitie.Description_Ar,
                    Order = capabilitie.Order
                },

                Home = new HomeModel
                {
                    Capabilitie = capabilitieModels
                }

            };
            return View("Business", combinedModel);
        }

        public IActionResult Industries()
        {
            var IndustrieModels = GetIndustrieData();

            var viewModel = new HomeModel
            {
                Industrie = IndustrieModels
            };

            return View(viewModel);
        }

        public IActionResult Services()
        {
            var CapabilitieModels = GetCapabilitieData();

            var viewModel = new HomeModel
            {
                Capabilitie = CapabilitieModels
            };

            return View(viewModel);
        }




        [Route("change")]
        public IActionResult Change(string culture)
        {
            // Set the desired culture in a cookie
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            // Get the referring URL without the culture parameter
            string returnUrl = Request.Headers["Referer"].ToString();
            var uriBuilder = new UriBuilder(returnUrl);
            var queryParams = HttpUtility.ParseQueryString(uriBuilder.Query);
            queryParams.Remove("culture");
            uriBuilder.Query = queryParams.ToString();
            returnUrl = uriBuilder.Uri.ToString();

            // Redirect to the modified URL
            return Redirect(returnUrl);
        }
    }
}
