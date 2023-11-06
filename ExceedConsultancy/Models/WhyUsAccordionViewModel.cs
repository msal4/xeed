using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System;
namespace ExceedConsultancy.Models
{
    
    public class WhyUsAccordionViewModel
    {
        public Guid Id { get; set; }
        public int Order { get; set; }

        public int AccordionId { get; set; }
        public string TitleAccordion { get; set; }
        public string TitleAccordion_Ar { get; set; }
        public string SubTitleAccordion { get; set; }
        public string SubTitleAccordion_Ar { get; set; }

    }


}
