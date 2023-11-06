using System.ComponentModel.DataAnnotations.Schema;

namespace ExceedConsultancy.Models
{
    public class HomeSliderViewModel
    {
        public Guid Id { get; set; }
        public string Title_EN { get; set; }
        public string Title_AR { get; set; }
        public int Order { get; set; }


        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public string Image { get; set; }
    }
}
