namespace ExceedConsultancy.Models

{
    public class CareersModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        //public string Phone { get; set; }
        public IFormFile CVFile { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }

        //public string GRecaptchaResponse { get; set; }


    }

}