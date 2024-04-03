
using ExceedConsultancy.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Text;
using Newtonsoft.Json;
using System.Globalization;
using System;
using System.Net.NetworkInformation;





namespace ExceedConsultancy.Controllers
{
    public class QuoteController : BaseController
    {
        private readonly IConfiguration _config;

        public QuoteController(AppDbContext context, IConfiguration config) : base(context)
        {
            _config = config;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(QuoteModel model)
        {
            StringBuilder sb = new StringBuilder();


            sb.Append("Full Name: " + model.Name);
            sb.AppendLine("<br/>Email: " + model.Email);
            sb.AppendLine("<br/>Subject: " + model.Subject);
            sb.AppendLine("<br/>Phone: " + model.Phone);
            sb.AppendLine("<br/>Message: " + model.Message);

          
            using (var client = new HttpClient())
            {
              
                        sendemail(sb.ToString(), "Contact Message", "xeed-consulting.com,1997jihad@gmail.com,ahmadghadder @gmail.com");

                        if (CultureInfo.CurrentCulture.Name.StartsWith("ar"))
                        {
                            TempData["SuccessQuote"] = "شكرا لك على الاتصال بنا!  سوف نعود اليكم في أقرب وقت ممكن.";
                        }
                        else
                        {
                            TempData["SuccessQuote"] = "Thank you for contacting us! We will get back to you as soon as possible.";
                        }

                        return RedirectToAction("Index", "Quote");
                    }
        }

        public ActionResult sendemail(string msg, string subject, string email)
        {

            try
            {

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient();
                mail.From = new MailAddress("websitexeediq@outlook.com");

                mail.To.Add(email);

                mail.Subject = subject;
                mail.Body = msg;
                mail.IsBodyHtml = true;

                SmtpServer.Host = "smtp.office365.com";
                SmtpServer.Port = 587;

                SmtpServer.Credentials = new System.Net.NetworkCredential(_config.GetSection("ApiKey").Value, _config.GetSection("ApiKeyPass").Value, "xeed-consulting.com");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);

                if (CultureInfo.CurrentCulture.Name.StartsWith("ar"))
                {
                    TempData["Success"] = "شكرا لك على الاتصال بنا!  سوف نعود اليكم في أقرب وقت ممكن.";
                }
                else
                {
                    TempData["Success"] = "Thank you for contacting us! We will get back to you as soon as possible.";
                }

                return RedirectToAction("Index", "Quote");

            }
            catch (Exception ex)
            {
                if (CultureInfo.CurrentCulture.Name.StartsWith("ar"))
                {
                    TempData["Success"] = "يرجى التحقق من أنك لست روبوت";
                }
                else
                {
                    TempData["Success"] = "Please validate that you are not a robot";
                }
                return RedirectToAction("Index", "Quote");
                throw;
            }

        }
    }
}
