using ExceedConsultancy.Migrations;
using ExceedConsultancy.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ExceedConsultancy.Controllers
{
    [Authorize]

    public class CPanelController : BaseController
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public CPanelController(AppDbContext context, IWebHostEnvironment webHostEnvironment) : base(context)
        {
            _webHostEnvironment = webHostEnvironment;
        }
  
        private List<HomeSliderViewModel> GetSliderData()
        {
            var sliderData = _context.Sliders.ToList();
            return sliderData;
        }


        private List<IndustriesViewModel> GetIndustrieData()
        {

            var industrieData = _context.Industries.ToList();
            return industrieData;
        }


        public List<CapabilitiesViewModel> GetCapabilitieData()
        {
            var capabilitieData = _context.Capabilities.ToList();
            return capabilitieData;
        }

        public List<WhyUsViewModel> GetWhyUSAboutData()
        {
            var WhyUSAboutData = _context.WhyUs.ToList();
            return WhyUSAboutData;
        }

        public List<WhyUsAccordionViewModel> GetWhyUsAccordionData()
        {
            var WhyUsAccordionData = _context.WhyUsAccordion.ToList();
            return WhyUsAccordionData;
        }

        public List<HowWork> GetHowWorkData()
        {
            var HowWorkData = _context.HowWork.ToList();
            return HowWorkData;
        }

        public List<AccordionHowWork> GetAccordionTwoData()
        {
            var GetAccordionTwoData = _context.AccordionTwo.ToList();
            return GetAccordionTwoData;
        }

        public List<Commitment> GetCommitmentData()
        {
            var CommitmentData = _context.Commitment.ToList();
            return CommitmentData;
        }

        public List<Aspiration> GetAspirationData()
        {
            var AspirationData = _context.Aspiration.ToList();
            return AspirationData;
        }


        public List<Purpose> GetPurposeData()
        {
            var PurposeData = _context.Purpose.ToList();
            return PurposeData;
        }



        public List<AccordionCommitment> GetAccodrionThreeData()
        {
            var AccordionThreeData = _context.AccordionThree.ToList();
            return AccordionThreeData;
        }
        public List<AccordionAspiration> GetAccodrionFourData()
        {
            var AccordionFourData = _context.AccordionFour.ToList();
            return AccordionFourData;
        }

        public List<AccordionPurpose> GetAccodrionFiveData()
        {
            var AccordionFiveData = _context.AccordionFive.ToList();
            return AccordionFiveData;
        }




        public IActionResult Home()
        {
            var sliderModels = GetSliderData();
            var viewModel = new HomeModel
            {
                Slider = sliderModels,
            };
            return View(viewModel);
        }


        public IActionResult About()
        {
            var response = _context.AboutUs.FirstOrDefault();
            return View(response);
        }


        public IActionResult WhyUsAbout()
        {

            var WhyUsAboutModels = GetWhyUSAboutData();
            var WhyUsAccordionModels= GetWhyUsAccordionData();

            var viewModel = new AboutModel
            {
                WhyUs = WhyUsAboutModels,
                WhyUsAccordion= WhyUsAccordionModels
            };

            return View(viewModel);

        }

        public IActionResult HowWork()
        {
            var HowWorkModels= GetHowWorkData();
            var AccordionTwoModels= GetAccordionTwoData();

            var viewModel = new AboutModel
            {
                HowWork = HowWorkModels,
                AccordionTwo = AccordionTwoModels
            };

            return View(viewModel);

        }


        public IActionResult OurCommitment()
        {

            var CommitmentModels = GetCommitmentData();
            var AccordionThreeModels = GetAccodrionThreeData();

            var viewModel = new AboutModel
            {
                Commitment = CommitmentModels,
                AccordionThree = AccordionThreeModels
            };

            return View(viewModel);

        }
        public IActionResult Aspiration()
        {

            var AspirationModels = GetAspirationData();
            var AccordionFourModels = GetAccodrionFourData();

            var viewModel = new AboutModel
            {
                Aspiration = AspirationModels,
                AccordionFour = AccordionFourModels
            };

            return View(viewModel);

        }

        public IActionResult Purpose()
        {

            var PurposeModels = GetPurposeData();
            var AccordionFiveModels = GetAccodrionFiveData();

            var viewModel = new AboutModel
            {
                Purpose = PurposeModels,
                AccordionFive = AccordionFiveModels
            };

            return View(viewModel);

        }




        public IActionResult Industrie()
        {
            var IndustrieModels = GetIndustrieData();

            var viewModel = new HomeModel
            {
                Industrie = IndustrieModels
            };

            return View(viewModel);
        }


        public IActionResult capabilitie()
        {

            var capabilitieModels = GetCapabilitieData();

            var viewModel = new HomeModel
            {
                Capabilitie = capabilitieModels
            };

            return View(viewModel);
        }


        public IActionResult CreateSlider()
        {
            return View();
        }

        public IActionResult CreateIndustrie()
        {
            return View();
        }


        public IActionResult CreateCapabilitie()
        {
            return View();
        }


        public IActionResult CreateAccordionOne()
        {
            return View();
        }

   

        public IActionResult AboutCompany()
        {
            var response = _context.AboutCompany.FirstOrDefault();
            return View(response);
        }

        public IActionResult Leadership()
        {
            var response = _context.Leadership.FirstOrDefault();
            return View(response);
        }
        public IActionResult Team()
        {
            var response = _context.Team.FirstOrDefault();
            return View(response);
        }


        public IActionResult WhyUsHome()
        {
            var response = _context.WhyUsHome.FirstOrDefault();
            return View(response);
        }


        public IActionResult EditWhyUsAbout()
        {
            var response =  _context.WhyUs.FirstOrDefault();
            return View(response);
        }

        public IActionResult EditHowWork()
        {
            var response = _context.HowWork.FirstOrDefault();
            return View(response);
        }
        public IActionResult EditCommitment()
        {
            var response = _context.Commitment.FirstOrDefault();
            return View(response);
        }

        public IActionResult EditAspiration()
        {
            var response = _context.Aspiration.FirstOrDefault();
            return View(response);
        }
        public IActionResult EditPurpose()
        {
            var response = _context.Purpose.FirstOrDefault();
            return View(response);
        }

        public IActionResult CreateAccordionTwo()
        {
                return View();
        }
        public IActionResult CreateAccordionThree()
        {
            return View();
        }

        public IActionResult CreateAccordionFour()
        {
            return View();
        }


        public IActionResult CreateAccordionFive()
        {
            return View();
        }


   
       public IActionResult EditAccordionTwo(Guid id)
        {
                var response = _context.AccordionTwo.Find(id);


                if (response == null)
                {
                    return NotFound();
                }

                return View(response);
     }



        public IActionResult EditAccordionThree(Guid id)
        {
            var response = _context.AccordionThree.Find(id);


            if (response == null)
            {
                return NotFound();
            }

            return View(response);
        }


        public IActionResult EditAccordionFour(Guid id)
        {
            var response = _context.AccordionFour.Find(id);


            if (response == null)
            {
                return NotFound();
            }

            return View(response);
        }


        public IActionResult EditAccordionFive(Guid id)
        {
            var response = _context.AccordionFive.Find(id);


            if (response == null)
            {
                return NotFound();
            }

            return View(response);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateSlider(HomeSliderViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (model.ImageFile != null && model.ImageFile.Length > 0)
                    {
                        var uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ImageFile.FileName;

                        var uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "assets/images");

                        var filePath = Path.Combine(uploadFolder, uniqueFileName.Replace("\\", "/"));


                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            model.ImageFile.CopyTo(stream);
                        }


                        model.Image = uniqueFileName;
                    }

                    var sliders = _context.Sliders.OrderBy(s => s.Order).ToList();
                    _context.Sliders.Add(model);
                    _context.SaveChanges();

                    return RedirectToAction("Home");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while saving the slider.");
                }
            }

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateIndustrie(IndustriesViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (model.ImageFile != null && model.ImageFile.Length > 0)
                    {
                        var uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ImageFile.FileName;

                        var uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "assets/images");

                        var filePath = Path.Combine(uploadFolder, uniqueFileName.Replace("\\", "/"));


                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            model.ImageFile.CopyTo(stream);
                        }


                        model.Image = uniqueFileName;
                    }
                    _context.Industries.Add(model);
                    _context.SaveChanges();

                    return RedirectToAction("Industrie");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while saving the slider.");
                }
            }

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateCapabilitie(CapabilitiesViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (model.ImageFile != null && model.ImageFile.Length > 0)
                    {
                        var uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ImageFile.FileName;

                        var uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "assets/images");

                        var filePath = Path.Combine(uploadFolder, uniqueFileName.Replace("\\", "/"));


                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            model.ImageFile.CopyTo(stream);
                        }


                        model.Image = uniqueFileName;
                    }

                    _context.Capabilities.Add(model);
                    _context.SaveChanges();

                    return RedirectToAction("Capabilitie");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while saving the slider.");
                }
            }

            return View(model);
        }





        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult About(Guid id, AboutUsViewModel model)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var response = _context.AboutUs.Find(id);

                    if (response == null)
                    {
                        return NotFound();
                    }
                    response.Title = model.Title;
                    response.Title_Ar = model.Title_Ar;
                    response.Description = model.Description;
                    response.Description_Ar = model.Description_Ar;

                    response.Mission = model.Mission;
                    response.Vision = model.Vision;
                    response.Mission_Ar = model.Mission_Ar;
                    response.Vision_Ar = model.Vision_Ar;


                    if (model.Image2Id != null && model.Image2Id.Length > 0)
                    {
                        var uniqueFileName2 = Guid.NewGuid().ToString() + "_" + model.Image2Id.FileName;

                        var uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "assets/images");

                        var filePath2 = Path.Combine(uploadFolder, uniqueFileName2.Replace("\\", "/"));

                        using (var stream2 = new FileStream(filePath2, FileMode.Create))
                        {
                            model.Image2Id.CopyTo(stream2);
                        }
                        response.Image2 = uniqueFileName2;
                    }


                    if (model.Image1Id != null && model.Image1Id.Length > 0)
                    {
                        var uniqueFileName1 = Guid.NewGuid().ToString() + "_" + model.Image1Id.FileName;


                        var uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "assets/images");

                        var filePath1 = Path.Combine(uploadFolder, uniqueFileName1.Replace("\\", "/"));

                        using (var stream1 = new FileStream(filePath1, FileMode.Create))
                        {
                            model.Image1Id.CopyTo(stream1);
                        }
                        response.Image1 = uniqueFileName1;
                    }

                    

                    _context.SaveChanges();

                    TempData["success"] = "About Company has been updated.";
                    return View(response);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while updating the slider.");
                }
            }

            return RedirectToAction("About");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Leadership(Guid LeadershipId, Leadership model)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var response = _context.Leadership.Find(LeadershipId);

                    if (response == null)
                    {
                        return NotFound();
                    }
                  
                    response.Description = model.Description;
                    response.Description_Ar = model.Description_Ar;

                    if (model.ImageFile != null && model.ImageFile.Length > 0)
                    {
                        var uniqueFileName2 = Guid.NewGuid().ToString() + "_" + model.ImageFile.FileName;

                        var uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "assets/images");

                        var filePath2 = Path.Combine(uploadFolder, uniqueFileName2.Replace("\\", "/"));

                        using (var stream2 = new FileStream(filePath2, FileMode.Create))
                        {
                            model.ImageFile.CopyTo(stream2);
                        }
                        response.Image = uniqueFileName2;
                    }
                  

                    _context.SaveChanges();

                    TempData["success"] = "Leadership has been updated.";
                    return View(response);
                
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while updating the slider.");
                }
            }
            return RedirectToAction("Leadership");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Team(Guid TeamId, Team model)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var response = _context.Team.Find(TeamId);

                    if (response == null)
                    {
                        return NotFound();
                    }

                    response.Description = model.Description;
                    response.Description_Ar = model.Description_Ar;

                    if (model.Image2Id != null && model.Image2Id.Length > 0)
                    {
                        var uniqueFileName2 = Guid.NewGuid().ToString() + "_" + model.Image2Id.FileName;

                        var uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "assets/images");

                        var filePath2 = Path.Combine(uploadFolder, uniqueFileName2.Replace("\\", "/"));

                        using (var stream2 = new FileStream(filePath2, FileMode.Create))
                        {
                            model.Image2Id.CopyTo(stream2);
                        }
                        response.Image2 = uniqueFileName2;
                    }


                    if (model.Image1Id != null && model.Image1Id.Length > 0)
                    {
                        var uniqueFileName1 = Guid.NewGuid().ToString() + "_" + model.Image1Id.FileName;


                        var uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "assets/images");

                        var filePath1 = Path.Combine(uploadFolder, uniqueFileName1.Replace("\\", "/"));

                        using (var stream1 = new FileStream(filePath1, FileMode.Create))
                        {
                            model.Image1Id.CopyTo(stream1);
                        }
                        response.Image1 = uniqueFileName1;
                    }


                    _context.SaveChanges();
                    TempData["success"] = "Our Team has been updated.";
                    return View(response);

                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while updating the slider.");
                }
            }
            return RedirectToAction("Team");
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditWhyUsAbout(Guid id , WhyUsViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var response = _context.WhyUs.Find(id);

                    if (response == null)
                    {
                        return NotFound();
                    }
                    response.Title = model.Title;
                    response.Title_Ar = model.Title_Ar;
                    response.Description = model.Description;
                    response.Description_Ar = model.Description_Ar;

                    if (model.ImageId != null && model.ImageId.Length > 0)
                    {

                        var uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ImageId.FileName;

                        var uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "assets/images");

                        var filePath = Path.Combine(uploadFolder, uniqueFileName.Replace("\\", "/"));


                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            model.ImageId.CopyTo(stream);
                        }

                        response.Image = uniqueFileName;
                    }
                    _context.SaveChanges();

                    return RedirectToAction("WhyUsAbout");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while saving the slider.");
                }
            }

            return RedirectToAction("WhyUsAbout");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditAspiration(Guid id, Aspiration model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var response = _context.Aspiration.Find(id);

                    if (response == null)
                    {
                        return NotFound();
                    }

                    response.Text = model.Text;
                    response.Text_Ar = model.Text_Ar;
                    response.Text1 = model.Text1;
                    response.Text1_Ar = model.Text1_Ar;
              
           
                    if (model.ImageId != null && model.ImageId.Length > 0)
                    {

                        var uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ImageId.FileName;

                        var uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "assets/images");

                        var filePath = Path.Combine(uploadFolder, uniqueFileName.Replace("\\", "/"));


                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            model.ImageId.CopyTo(stream);
                        }

                        response.Image = uniqueFileName;
                    }
                    _context.SaveChanges();

                    return RedirectToAction("Aspiration");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while saving the slider.");
                }
            }

            return RedirectToAction("Aspiration");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditPurpose(Guid id, Purpose model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var response = _context.Purpose.Find(id);

                    if (response == null)
                    {
                        return NotFound();
                    }
                          
                    response.Text = model.Text;
                    response.Text_Ar = model.Text_Ar;

                    if (model.ImageId != null && model.ImageId.Length > 0)
                    {

                        var uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ImageId.FileName;

                        var uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "assets/images");

                        var filePath = Path.Combine(uploadFolder, uniqueFileName.Replace("\\", "/"));


                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            model.ImageId.CopyTo(stream);
                        }

                        response.Image = uniqueFileName;
                    }
                    _context.SaveChanges();

                    return RedirectToAction("Purpose");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while saving the slider.");
                }
            }

            return RedirectToAction("Purpose");
        }







        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateAccordionOne(WhyUsAccordionViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.WhyUsAccordion.Add(model);
                    _context.SaveChanges();
                    return RedirectToAction("WhyUsAbout");

                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while saving the data.");
                }
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateAccordionTwo(AccordionHowWork model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.AccordionTwo.Add(model);
                    _context.SaveChanges();
                    return RedirectToAction("HowWork");

                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while saving the data.");
                }
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateAccordionThree(AccordionCommitment model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.AccordionThree.Add(model);
                    _context.SaveChanges();
                    return RedirectToAction("OurCommitment");

                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while saving the data.");
                }
            }
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateAccordionFour(AccordionAspiration model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.AccordionFour.Add(model);
                    _context.SaveChanges();
                    return RedirectToAction("Aspiration");

                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while saving the data.");
                }
            }
            return View(model);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateAccordionFive(AccordionPurpose model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.AccordionFive.Add(model);
                    _context.SaveChanges();
                    return RedirectToAction("Purpose");

                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while saving the data.");
                }
            }
            return View(model);
        }





        public IActionResult EditSlider(Guid id)
        {
            var slider = _context.Sliders.Find(id);

            if (slider == null)
            {
                return NotFound(); // Slider not found
            }

            return View(slider);
        }
        public IActionResult EditIndustries(Guid id)
        {
            var Industrie = _context.Industries.Find(id);

            if (Industrie == null)
            {
                return NotFound();
            }

            return View(Industrie);
        }


        public IActionResult EditCapabilitie(Guid id)
        {
            var Capabilitie = _context.Capabilities.Find(id);

            if (Capabilitie == null)
            {
                return NotFound();
            }

            return View(Capabilitie);
        }


        public IActionResult EditAccordionOne(Guid id)
        {
            var AccordionOne = _context.WhyUsAccordion.Find(id);

            if (AccordionOne == null)
            {
                return NotFound();
            }

            return View(AccordionOne);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditSlider(Guid id, HomeSliderViewModel model)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var slider = _context.Sliders.Find(id);

                    if (slider == null)
                    {
                        return NotFound();
                    }


                    slider.Title_AR = model.Title_AR;
                    slider.Title_EN = model.Title_EN;
                    slider.Order = model.Order;

                    if (model.ImageFile != null && model.ImageFile.Length > 0)
                    {

                        var uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ImageFile.FileName;


                        var uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "assets/images");


                        var filePath = Path.Combine(uploadFolder, uniqueFileName.Replace("\\", "/"));


                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            model.ImageFile.CopyTo(stream);
                        }


                        slider.Image = uniqueFileName;
                    }
                    _context.SaveChanges();

                    return RedirectToAction("Home");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while updating the slider.");
                }
            }
            return View(model);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AboutCompany(Guid id, AboutCompanyModel model)
        {

            if (ModelState.IsValid)
            {
                try
                {

                    var response = _context.AboutCompany.Find(id);

                    if (response == null)
                    {
                        return NotFound();
                    }

                    response.Title = model.Title;
                    response.Title_Ar = model.Title_Ar;
                    response.Description = model.Description;
                    response.Description_Ar = model.Description_Ar;

                    response.Mission = model.Mission;
                    response.Vision = model.Vision;

                    response.Mission_Ar = model.Mission_Ar;
                    response.Vision_Ar = model.Vision_Ar;



                    if (model.ImageFile != null && model.ImageFile.Length > 0)
                    {

                        var uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ImageFile.FileName;
                        var uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "assets/images");
                        var filePath = Path.Combine(uploadFolder, uniqueFileName.Replace("\\", "/"));
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            model.ImageFile.CopyTo(stream);
                        }
                        response.Image = uniqueFileName;
                    }
                    _context.SaveChanges();

                    TempData["success"] = "About Company has been updated.";
                    return View(response);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while updating the slider.");
                }
            }

            return RedirectToAction("AboutCompany");
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult WhyUsHome(Guid id, WhyUsHomeModel model)
        {

            if (ModelState.IsValid)
            {
                try
                {

                    var response = _context.WhyUsHome.Find(id);

                    if (response == null)
                    {
                        return NotFound();
                    }

                    response.Title = model.Title;
                    response.Title_Ar = model.Title_Ar;
                    response.Description = model.Description;
                    response.Description_Ar = model.Description_Ar;


                    if (model.ImageFile2 != null && model.ImageFile2.Length > 0)
                    {
                        var uniqueFileName2 = Guid.NewGuid().ToString() + "_" + model.ImageFile2.FileName;

                        var uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "assets/images");

                        var filePath2 = Path.Combine(uploadFolder, uniqueFileName2.Replace("\\", "/"));

                        using (var stream2 = new FileStream(filePath2, FileMode.Create))
                        {
                            model.ImageFile2.CopyTo(stream2);
                        }
                        response.Image2 = uniqueFileName2;
                    }


                    if (model.ImageFile1 != null && model.ImageFile1.Length > 0)
                    {
                        var uniqueFileName1 = Guid.NewGuid().ToString() + "_" + model.ImageFile1.FileName;


                        var uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "assets/images");

                        var filePath1 = Path.Combine(uploadFolder, uniqueFileName1.Replace("\\", "/"));

                        using (var stream1 = new FileStream(filePath1, FileMode.Create))
                        {
                            model.ImageFile1.CopyTo(stream1);
                        }
                        response.Image1 = uniqueFileName1;
                    }
                    if (model.ImageFile3 != null && model.ImageFile3.Length > 0)
                    {
                        var uniqueFileName3 = Guid.NewGuid().ToString() + "_" + model.ImageFile3.FileName;


                        var uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "assets/images");

                        var filePath3 = Path.Combine(uploadFolder, uniqueFileName3.Replace("\\", "/"));

                        using (var stream3 = new FileStream(filePath3, FileMode.Create))
                        {
                            model.ImageFile3.CopyTo(stream3);
                        }
                        response.Image4 = uniqueFileName3;
                    }

                    _context.SaveChanges();

                    TempData["success"] = "Why Us Home has been updated.";
                    return View(response);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while updating the slider.");
                }
            }

            return RedirectToAction("AboutCompany");
        }








        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditIndustries(Guid id, IndustriesViewModel model)
        {

            if (ModelState.IsValid)
            {
                try
                {


                    var industrie = _context.Industries.Find(id);

                    if (industrie == null)
                    {
                        return NotFound();
                    }

                    industrie.text = model.text;
                    industrie.text_Ar = model.text_Ar;
                    industrie.Order = model.Order;



                    if (model.ImageFile != null && model.ImageFile.Length > 0)
                    {
                        var uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ImageFile.FileName;
                        var uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "assets/images");
                        var filePath = Path.Combine(uploadFolder, uniqueFileName.Replace("\\", "/"));
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            model.ImageFile.CopyTo(stream);
                        }
                        industrie.Image = uniqueFileName;
                    }
                    _context.SaveChanges();

                    return RedirectToAction("Industrie");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while updating the slider.");
                }
            }

            return RedirectToAction("Industrie");
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditCapabilitie(Guid id, CapabilitiesViewModel model)
        {

            if (ModelState.IsValid)
            {
                try
                {


                    var Capabilitie = _context.Capabilities.Find(id);

                    if (Capabilitie == null)
                    {
                        return NotFound();
                    }
                    Capabilitie.text = model.text;
                    Capabilitie.text_Ar = model.text_Ar;
                    Capabilitie.Order = model.Order;



                    if (model.ImageFile != null && model.ImageFile.Length > 0)
                    {
                        var uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ImageFile.FileName;
                        var uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "assets/images");
                        var filePath = Path.Combine(uploadFolder, uniqueFileName.Replace("\\", "/"));
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            model.ImageFile.CopyTo(stream);
                        }
                        Capabilitie.Image = uniqueFileName;
                    }
                    _context.SaveChanges();

                    return RedirectToAction("Capabilitie");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while updating the slider.");
                }
            }

            return RedirectToAction("Capabilitie");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditAccordionOne(WhyUsAccordionViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.WhyUsAccordion.Add(model);
                    _context.SaveChanges();
                    return RedirectToAction("WhyUsAbout");

                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while saving the data.");
                }
            }
            return View(model);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditHowWork(Guid id, HowWork model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var response = _context.HowWork.Find(id);
                    if (response == null)
                    {
                        return NotFound();
                    }
           
                    response.Description = model.Description;
                    response.Description_Ar = model.Description_Ar;

                    _context.SaveChanges();

                    TempData["success"] = "The Data has been updated.";

                    return RedirectToAction("HowWork");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while updating the slider.");
                }
            }

            return RedirectToAction("HowWork");
        }







        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditCommitment(Guid id, Commitment model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var response = _context.Commitment.Find(id);
                    if (response == null)
                    {
                        return NotFound();
                    }

                    response.Description = model.Description;
                    response.Description_Ar = model.Description_Ar;

                    _context.SaveChanges();

                    TempData["success"] = "The Data has been updated.";
                    return View(response);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while saving the data.");
                }
            }
            return View(model);
        }







        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditAccordionTwo(Guid id, AccordionHowWork model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var response = _context.AccordionTwo.Find(id);
                    if (response == null)
                    {
                        return NotFound();
                    }
                    response.Order = model.Order;
                    response.TitleAccordion = model.TitleAccordion;
                    response.TitleAccordion_Ar = model.TitleAccordion_Ar;
                    response.Description = model.Description;
                    response.Description_Ar = model.Description_Ar;

                    _context.SaveChanges();

                    TempData["success"] = "The Data has been updated.";
                    return View(response);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while saving the data.");
                }
            }
            return View(model);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditAccordionThree(Guid id, AccordionCommitment model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var response = _context.AccordionThree.Find(id);
                    if (response == null)
                    {
                        return NotFound();
                    }
                    response.Order = model.Order;
                    response.TitleAccordion = model.TitleAccordion;
                    response.TitleAccordion_Ar = model.TitleAccordion_Ar;
                    response.Description = model.Description;
                    response.Description_Ar = model.Description_Ar;

                    _context.SaveChanges();

                    TempData["success"] = "The Data has been updated.";
                    return View(response);

                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while saving the data.");
                }
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditAccordionFour(Guid id, AccordionAspiration model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var response = _context.AccordionFour.Find(id);
                    if (response == null)
                    {
                        return NotFound();
                    }
                    response.Order = model.Order;
                    response.TitleAccordion = model.TitleAccordion;
                    response.TitleAccordion_Ar = model.TitleAccordion_Ar;
                    response.Description = model.Description;
                    response.Description_Ar = model.Description_Ar;

                    _context.SaveChanges();

                    TempData["success"] = "The Data has been updated.";
                    return View(response);

                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while saving the data.");
                }
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditAccordionFive(Guid id, AccordionPurpose model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var response = _context.AccordionFive.Find(id);
                    if (response == null)
                    {
                        return NotFound();
                    }
                    response.Order = model.Order;
                    response.TitleAccordion = model.TitleAccordion;
                    response.TitleAccordion_Ar = model.TitleAccordion_Ar;
                    response.Description = model.Description;
                    response.Description_Ar = model.Description_Ar;

                    _context.SaveChanges();

                    TempData["success"] = "The Data has been updated.";
                    return View(response);

                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while saving the data.");
                }
            }
            return View(model);
        }



        [HttpPost]
        [Route("[controller]/[action]/{DeleteType}/{id?}")]
        public async Task<IActionResult> Delete(string DeleteType, Guid id)
        {
            var item = GetItemByDeleteType(DeleteType, id);

            if (item == null)
            {
                return NotFound();
            }

            try
            {
                _context.Remove(item);
                _context.SaveChanges();

                // Redirect based on industry (example: Home for both industries)
                return RedirectToAction(DeleteType);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, $"An error occurred while deleting the {DeleteType}.");
                return View(item);
            }
        }


        private object GetItemByDeleteType(string DeleteType, Guid id)
        {


            switch (DeleteType)
            {
                case "Home":
                    return _context.Sliders.FirstOrDefault(i => i.Id == id);
                case "Industrie":
                    return _context.Industries.FirstOrDefault(i => i.Id == id);
                case "Capabilitie":
                    return _context.Capabilities.FirstOrDefault(i => i.Id == id);
                case "WhyUsAbout":
                    return _context.WhyUsAccordion.FirstOrDefault(i => i.Id == id);
                case "HowWork":
                    return _context.AccordionTwo.FirstOrDefault(i => i.Id == id);
                case "OurCommitment":
                    return _context.AccordionThree.FirstOrDefault(i => i.Id == id);

                case "Aspiration":
                    return _context.AccordionFour.FirstOrDefault(i => i.Id == id);
                case "Purpose":
                    return _context.AccordionFive.FirstOrDefault(i => i.Id == id);

                //return _context.AboutUs1.FirstOrDefault(i => i.Id == id);
                default:
                    return null;
            }
        }


        public async Task<IActionResult> AddressInfo()
        {
            var response = await _context.AddressInfo.FirstOrDefaultAsync();
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> AddressInfo(AddressInfo model)
        {
            if (string.IsNullOrEmpty(model.Location))
            {
                TempData["fail"] = "Location is required.";
                return View(model);
            }
            if (string.IsNullOrEmpty(model.Location_Ar))
            {
                TempData["fail"] = "Arabic Location is required.";
                return View(model);
            }
            if (string.IsNullOrEmpty(model.Email))
            {
                TempData["fail"] = "Email is required.";
                return View(model);
            }
            var response = _context.AddressInfo.FirstOrDefault(s => s.AddressInfoId == model.AddressInfoId);
            if (response != null)
            {
                response.Location = model.Location;
                response.Location_Ar = model.Location_Ar;
                response.Email = model.Email;
                _context.AddressInfo.Update(response);
                await _context.SaveChangesAsync();
            }

            TempData["success"] = "Address Info has been updated.";
            return View(response);
        }

        public async Task<IActionResult> Footer()
        {
            var response = await _context.Footer.FirstOrDefaultAsync();
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Footer(Footer model)
        {
            if (string.IsNullOrEmpty(model.Description))
            {
                TempData["fail"] = "Description is required.";
                return View(model);
            }
            if (string.IsNullOrEmpty(model.Description_Ar))
            {
                TempData["fail"] = "Arabic Description is required.";
                return View(model);
            }
            var response = _context.Footer.FirstOrDefault(s => s.FooterId == model.FooterId);
            if (response != null)
            {
                response.Description = model.Description;
                response.Description_Ar = model.Description_Ar;
                _context.Footer.Update(response);
                await _context.SaveChangesAsync();
            }

            TempData["success"] = "Footer has been updated.";
            return View(response);
        }

    }
}
