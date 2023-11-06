using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System;
namespace ExceedConsultancy.Models
{
    
    public class Purpose
    {
        public Guid Id { get; set; }

        public string Text { get; set; }

        public string Text_Ar { get; set; }


        [NotMapped]
        public IFormFile ImageId { get; set; }
        public string Image { get; set; }
   
    }

}
