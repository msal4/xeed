using System.ComponentModel.DataAnnotations.Schema;

namespace ExceedConsultancy.Models
{
    public class Team
    {
        public Guid TeamId { get; set; }
        public string Description { get; set; }

        public string Description_Ar { get; set; }


        [NotMapped]
        public IFormFile Image1Id { get; set; }
        public string Image1 { get; set; }

        [NotMapped]
        public IFormFile Image2Id { get; set; }
        public string Image2 { get; set; }

    }
}
