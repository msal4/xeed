using ExceedConsultancy.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Text;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.RegularExpressions;

namespace ExceedConsultancy.Controllers
{
   public class QuoteArController : BaseController
        {
            private readonly IConfiguration _config;

            public QuoteArController(AppDbContext context, IConfiguration config) : base(context)
            {
                _config = config;
            }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(QuoteArModel model)
        {
            StringBuilder sb = new StringBuilder();


            sb.Append("Full Name: " + model.Name);
            sb.AppendLine("<br/>Email: " + model.Email);
            sb.AppendLine("<br/>Subject: " + model.Subject);
            sb.AppendLine("<br/>Phone: " + model.Phone);
            sb.AppendLine("<br/>Message: " + model.Message);

            var response = Request.Form["g-Recaptcha-Response"];
            var test = _config.GetSection("reCAPTCHA:SecretKey").Value;
            using (var client = new HttpClient())
            {

                string culture = HttpContext.Features.Get<IRequestCultureFeature>().RequestCulture.Culture.Name;
                var testData = string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}", test, response);
                var responseData = client.PostAsync(testData, new StringContent("test", Encoding.UTF8, "application/json")).Result;
                if (responseData.IsSuccessStatusCode)
                {


                    var jsonString = responseData.Content.ReadAsStringAsync().Result;
                    var result = JsonConvert.DeserializeObject<CaptchaResponseModel>(jsonString);

                    if (result.Success)
                    {
                       
                        sendemail(sb.ToString(), "Contact Message", "contact@xeed-consulting.com,1997jihad@gmail.com", culture);
                        TempData["SuccessQuote"] = "شكرا لك على الاتصال بنا! ونحن سوف نعود اليكم في أقرب وقت ممكن.";
                        return RedirectToAction("Index", "Quote", new { culture = "ar" });
                    }
                }

                TempData["Success"] = "يرجى التحقق من أنك لست روبوت";
                return RedirectToAction("Index", "Quote", new { culture = "ar" });
            }
        }

        public ActionResult sendemail(string msg, string subject, string email, string culture)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient();
                mail.From = new MailAddress("al-salama@outlook.com");

                mail.To.Add(email);

                mail.Subject = subject;
                mail.Body = msg;
                mail.IsBodyHtml = true;

                SmtpServer.Host = "smtp.office365.com";
                SmtpServer.Port = 587;

                SmtpServer.Credentials = new System.Net.NetworkCredential(_config.GetSection("ApiKey").Value, _config.GetSection("ApiKeyPass").Value, "xeed-consulting.com");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);

                TempData["Success"] = "شكرا لك على الاتصال بنا! ونحن سوف نعود اليكم في أقرب وقت ممكن.";

                return RedirectToAction("Index", "Quote", new { culture = "ar" });
            }
            catch (Exception ex)
            {
                TempData["Success"] = "آسف لم يتم إرسال البريد ، يرجى المحاولة مرة أخرى!";
                return RedirectToAction("Index", "Quote", new { culture = "ar" });
            }
        }
    }


}
