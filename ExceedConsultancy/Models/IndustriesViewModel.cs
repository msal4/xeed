using System.ComponentModel.DataAnnotations.Schema;

namespace ExceedConsultancy.Models
{
    public class IndustriesViewModel
    {
        public Guid Id { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public string Image { get; set; }

        public string text { get; set; }
        public string text_Ar { get; set; }

        public int Order { get; set; }

    }

}
