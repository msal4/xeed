using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System;
namespace ExceedConsultancy.Models
{
    
    public class WhyUsViewModel
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Title_Ar { get; set; }

        public string Description { get; set; }

        public string Description_Ar { get; set; }


        [NotMapped]
        public IFormFile ImageId { get; set; }
        public string Image { get; set; }
   
    }

}
