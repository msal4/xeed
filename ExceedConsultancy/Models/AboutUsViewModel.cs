using System.ComponentModel.DataAnnotations.Schema;


namespace ExceedConsultancy.Models
{
    public class AboutUsViewModel
    {
         public Guid Id { get; set; } 

        public string Title { get; set; }
        public string Title_Ar { get; set; }


        public string Description { get; set; }
        public string Description_Ar { get; set; }


   
        public string Mission { get; set; }
        public string Mission_Ar { get; set; }

        public string Vision { get; set; }
        public string Vision_Ar { get; set; }

     


        [NotMapped]
        public IFormFile Image1Id { get; set; }
        public string Image1 { get; set; }


        [NotMapped]
        public IFormFile Image2Id { get; set; }
        public string Image2 { get; set; }
        
    }


}
