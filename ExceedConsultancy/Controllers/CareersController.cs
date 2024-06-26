﻿using ExceedConsultancy.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Text;
using Newtonsoft.Json;
using System.Globalization;

namespace ExceedConsultancy.Controllers
{
    public class CareersController : BaseController
    {
        private readonly IConfiguration _config;

        public CareersController(AppDbContext context, IConfiguration config) : base(context)
        {
            _config = config;
        }

        //public List<CapabilitiesViewModel> GetCapabilitieData()
        //{
        //    var capabilitieData = _context.Capabilities.ToList();
        //    return capabilitieData;
        //}

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(CareersModel model)
        {
            StringBuilder sb = new StringBuilder();


            sb.Append("Full Name: " + model.Name);
            sb.AppendLine("<br/>Email: " + model.Email);
            sb.AppendLine("<br/>Subject: " + model.Subject);
            sb.AppendLine("<br/>Message: " + model.Message);
            sb.AppendLine("<br/>CV: ");

            var response = Request.Form["g-Recaptcha-Response"];
            var test = _config.GetSection("recaptchaPrivateKey").Value;
            using (var client = new HttpClient())
            {
                var testData = string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}", test, response);
                var responseData = client.PostAsync(testData, new StringContent("test", Encoding.UTF8, "application/json")).Result;
                if (responseData.IsSuccessStatusCode)
                {
                    var jsonString = responseData.Content.ReadAsStringAsync().Result;
                    var result = JsonConvert.DeserializeObject<CaptchaResponseModel>(jsonString);

                    if (result.Success)
                    {
                        //info @xeed-consulting.com,ahmadghadder @gmail.com
                        /*contact@xeed-consulting.com,*/
                        sendemail(sb.ToString(), "Contact Message", "ahmadghadder@gmail.com", model.CVFile);
                        if (CultureInfo.CurrentCulture.Name.StartsWith("ar"))
                        {
                            TempData["Success"] = "شكرا لك على الاتصال بنا!  سوف نعود اليكم في أقرب وقت ممكن.";
                        }
                        else
                        {
                            TempData["Success"] = "Thank you for contacting us! We will get back to you as soon as possible.";
                        }
                        return RedirectToAction("Index", "Careers");
                    }
                }


                if (CultureInfo.CurrentCulture.Name.StartsWith("ar"))
                {
                    TempData["Success"] = "يرجى التحقق من أنك لست روبوت";
                }
                else
                {
                    TempData["Success"] = "Please validate that you are not a robot";
                }

                return RedirectToAction("Index", "Careers");
            }
        }

        public ActionResult sendemail(string msg, string subject, string email, IFormFile CVFile)
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



                // Attach the CV CVFile
                if (CVFile != null && CVFile.Length > 0)
                {
                    string fileName = Path.GetFileName(CVFile.FileName);
                    mail.Attachments.Add(new Attachment(CVFile.OpenReadStream(), fileName));
                }



                SmtpServer.Host = "smtp.office365.com";
                SmtpServer.Port = 587;

                SmtpServer.Credentials = new System.Net.NetworkCredential(_config.GetSection("ApiKey").Value, _config.GetSection("ApiKeyPass").Value, "xeediq.com");
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

                return RedirectToAction("Index", "Careers");

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

                return RedirectToAction("Index", "Careers");
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
