using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System;
namespace ExceedConsultancy.Models
{
    
    public class AccordionHowWork
    {
        public Guid Id { get; set; }
        public int Order { get; set; }

        //public int AccordionId { get; set; }
        public string TitleAccordion { get; set; }
        public string TitleAccordion_Ar { get; set; }
        public string Description { get; set; }
        public string Description_Ar { get; set; }

    }


}
