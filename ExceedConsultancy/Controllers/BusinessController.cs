using ExceedConsultancy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;
using System.Text;

namespace ExceedConsultancy.Controllers
{
    public class BusinessController : Controller
    {
        //private readonly IConfiguration _config;
        private readonly AppDbContext _context;

        public BusinessController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Business(Guid id)
        {
            // Fetch the Capabilitie item based on the 'id' parameter
            var capabilitie = _context.Capabilities.FirstOrDefault(c => c.Id == id);

            if (capabilitie == null)
            {
                return NotFound(); // Handle the case when the Capabilitie item is not found
            }

            // Create a model to pass to the view
            var model = new CapabilitiesViewModel
            {
                Id = capabilitie.Id,
                Image = capabilitie.Image,
                text = capabilitie.text,
                text_Ar = capabilitie.text_Ar,
                Description = capabilitie.Description,
                Description_Ar = capabilitie.Description_Ar,
                Order = capabilitie.Order
                // Add other properties as needed
            };

            return View("Business", model);
        }
    }



}
