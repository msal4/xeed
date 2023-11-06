using System.ComponentModel.DataAnnotations.Schema;

namespace ExceedConsultancy.Models
{
    public class CapabilitiesViewModel
    {
        public Guid Id { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public string Image { get; set; }

        public string text { get; set; }

        public string text_Ar { get; set; }


        public string Description { get; set; }

        public string Description_Ar { get; set; }

        public int Order { get; set; }

        
    }

    public class CombinedModel 
    {
        public CapabilitiesViewModel Capabilities { get; set; }
        public HomeModel Home { get; set; }

        //public AboutUs1ViewModel About { get; set; }

    }
  

}
