using System.ComponentModel.DataAnnotations.Schema;


namespace ExceedConsultancy.Models
{
    public class WhyUsHomeModel
    {
         public Guid Id { get; set; } 

        public string Title { get; set; }
        public string Title_Ar { get; set; }


        public string Description { get; set; }
        public string Description_Ar { get; set; }



        [NotMapped]
        public IFormFile ImageFile1 { get; set; }
        public string Image1 { get; set; }


        [NotMapped]
        public IFormFile ImageFile2 { get; set; }
        public string Image2 { get; set; }


        [NotMapped]
        public IFormFile ImageFile3{ get; set; }
        public string Image4 { get; set; }

    }


}
