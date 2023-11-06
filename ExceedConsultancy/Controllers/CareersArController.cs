using ExceedConsultancy.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Text;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;


namespace ExceedConsultancy.Controllers
{
    public class CareersArController : BaseController
    {
        private readonly IConfiguration _config;

        public CareersArController(AppDbContext context, IConfiguration config) : base(context)
        {
            _config = config;
        }

        public IActionResult Index()
        {
            return View();
        }

      
        [HttpPost]
        public IActionResult Index(CareersArModel model)
        {
            StringBuilder sb = new StringBuilder();


            sb.Append("Full Name: " + model.Name);
            sb.AppendLine("<br/>Email: " + model.Email);
            sb.AppendLine("<br/>Subject: " + model.Subject);
            sb.AppendLine("<br/>Message: " + model.Message);
            sb.AppendLine("<br/>CV: ");

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
                        //sendemail(sb.ToString(), "Contact Message", "contact@xeed-consulting.com,ahmadghadder@gmail.com",model.CVFile, culture);
                        sendemail(sb.ToString(), "Contact Message", "contact@xeed-consulting.com,1997jihad@gmail.com", model.CVFile, culture);
                        TempData["Success"] = "شكرا لك على الاتصال بنا! ونحن سوف نعود اليكم في أقرب وقت ممكن.";
                        return RedirectToAction("Index", "Careers", new { culture = "ar" });
                    }
                }

                TempData["Success"] = "يرجى التحقق من أنك لست روبوت";
                return RedirectToAction("Index", "Careers", new { culture = "ar" });
            }
        }

        public ActionResult sendemail(string msg, string subject, string email, IFormFile CVFile, string culture)
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

                // Attach the CV CVFile
                if (CVFile != null && CVFile.Length > 0)
                {
                    string fileName = Path.GetFileName(CVFile.FileName);
                    mail.Attachments.Add(new Attachment(CVFile.OpenReadStream(), fileName));
                }


                SmtpServer.Host = "smtp.office365.com";
                SmtpServer.Port = 587;

                SmtpServer.Credentials = new System.Net.NetworkCredential(_config.GetSection("ApiKey").Value, _config.GetSection("ApiKeyPass").Value, "xeed-consulting.com");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                TempData["Success"] = "شكرا لك على الاتصال بنا! ونحن سوف نعود اليكم في أقرب وقت ممكن.";
                return RedirectToAction("Index", "Careers", new { culture = "ar" });

            }
            catch (Exception ex)
            {
                TempData["Success"] = "آسف لم يتم إرسال البريد ، يرجى المحاولة مرة أخرى!";
                return RedirectToAction("Index", "Careers", new { culture = "ar" });
                throw;
            }

        }
        //[HttpPost]
        //public IActionResult Subscribe(NewsletterModel model, string gRecaptchaResponse)
        //{
        //    var response = Request.Form["g-Recaptcha-Response"];
        //    var test = _config.GetSection("reCAPTCHA:SecretKey").Value;
        //    using (var client = new HttpClient())
        //    {
        //        var testData = string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}", test, response);
        //        var responseData = client.PostAsync(testData, new StringContent("test", Encoding.UTF8, "application/json")).Result;
        //        if (responseData.IsSuccessStatusCode)
        //        {
        //            var jsonString = responseData.Content.ReadAsStringAsync().Result;
        //            var result = JsonConvert.DeserializeObject<CaptchaResponseModel>(jsonString);
        //            if (result.Success)
        //            {
        //                try
        //                {
        //                    string email = model.Email;
        //                    MailMessage mail = new MailMessage();
        //                    SmtpClient smtpServer = new SmtpClient();
        //                    mail.From = new MailAddress("al-salama@outlook.com");
        //                    mail.To.Add("contact@xeed-consulting.com,ahmadghadder@gmail.com");
        //                    mail.Subject = "Newsletter Subscription";
        //                    mail.Body = "Email: " + email;
        //                    mail.IsBodyHtml = true;
        //                    smtpServer.Host = "smtp.office365.com";
        //                    smtpServer.Port = 587;
        //                    smtpServer.Credentials = new System.Net.NetworkCredential(
        //                        _config.GetSection("ApiKey").Value,
        //                        _config.GetSection("ApiKeyPass").Value,
        //                        "alsalamaademo1.appshyve.com"
        //                    );
        //                    smtpServer.EnableSsl = true;
        //                    smtpServer.Send(mail);
        //                    TempData["SubscribeSuccess"] = "Thank you for subscribing to our newsletter!";
        //                    return RedirectToAction("Index", "Contact");
        //                }
        //                catch (Exception ex)
        //                {
        //                    TempData["SubscribeSuccess"] = "Sorry, an error occurred while subscribing. Please try again!";
        //                    return RedirectToAction("Index", "Contact");
        //                }
        //            }
        //        }
        //        TempData["SubscribeSuccess"] = "Please validate that you are not a robot";
        //        return RedirectToAction("Index", "Contact");
        //    }
        }


    }
