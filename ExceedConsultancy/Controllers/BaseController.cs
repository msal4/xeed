using ExceedConsultancy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace ExceedConsultancy.Controllers
{
    public class BaseController : Controller
    {
        public readonly AppDbContext _context;
        public BaseController(AppDbContext context)
        {
            _context = context;
          
        }



     

            public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // Load capabilities data and set it in ViewBag for all views
            var capabilitiesItems = _context.Capabilities.OrderBy(item => item.Order).ToList();
            ViewBag.CapabilitiesItems = capabilitiesItems;


            var addressInfo = _context.AddressInfo.FirstOrDefault();
            ViewBag.AddressInfo = addressInfo;

            var footer = _context.Footer.FirstOrDefault();
            ViewBag.Footer = footer;


            base.OnActionExecuting(filterContext);
        }

    }
}
