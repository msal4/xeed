using System.ComponentModel.DataAnnotations.Schema;

namespace ExceedConsultancy.Models
{
    public class Leadership
    {
        public Guid LeadershipId { get; set; }
        public string Description { get; set; }

        public string Description_Ar { get; set; }


        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public string Image { get; set; }

    }
}
