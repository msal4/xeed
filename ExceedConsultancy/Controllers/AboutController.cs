using ExceedConsultancy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;
using System.Text;

namespace ExceedConsultancy.Controllers
{
   
     public class AboutController : BaseController
     {
        public AboutController(AppDbContext context) : base(context)
       {
        }
        private List<AboutUsViewModel> GetAbout1Data()
        {
            var About1Data = _context.AboutUs.ToList();
            return About1Data;
        }
        public List<CapabilitiesViewModel> GetCapabilitieData()
        {
            var capabilitieData = _context.Capabilities.ToList();
            return capabilitieData;
        }
        public List<WhyUsViewModel> GetWhyUSData()
        {
            var WhyUsData = _context.WhyUs.ToList();
            return WhyUsData;
        }
        public List<WhyUsAccordionViewModel> GetWhyUSAccordionData()
        {
            var WhyUsAccordionData = _context.WhyUsAccordion.ToList();
            return WhyUsAccordionData;
        }

        public List<Leadership> GetLeadershipData()
        {
            var response = _context.Leadership.ToList();
            return response;
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

        public List<AccordionCommitment> GetAccodrionThreeData()
        {
            var AccordionThreeData = _context.AccordionThree.ToList();
            return AccordionThreeData;
        }

        public List<Aspiration> GetAspirationData()
        {
            var AspirationData = _context.Aspiration.ToList();
            return AspirationData;
        }

        public List<AccordionAspiration> GetAccodrionFourData()
        {
            var AccordionFourData = _context.AccordionFour.ToList();
            return AccordionFourData;
        }

        public List<Team> GetTeamData()
        {
            var TeamData = _context.Team.ToList();
            return TeamData;
        }
        public List<Purpose> GetPurposeData()
        {
            var PurposeData = _context.Purpose.ToList();
            return PurposeData;
        }

        public List<AccordionPurpose> GetAccodrionFiveData()
        {
            var AccordionFiveData = _context.AccordionFive.ToList();
            return AccordionFiveData;
        }


        public IActionResult Index()
        {
            var capabilitiesData = GetCapabilitieData(); // Load your data
            // Set the capabilities data in HttpContext.Items
            HttpContext.Items["CapabilitiesData"] = capabilitiesData;
            var AboutUs1Models = GetAbout1Data();
            var WhyUsModels = GetWhyUSData();
            var WhyUsAccordionModels = GetWhyUSAccordionData();
            var LeadershipModels = GetLeadershipData();
            var HowWorkModels = GetHowWorkData();
            var AccordionTwoModels = GetAccordionTwoData();
            var CommitmentModels = GetCommitmentData();
            var AccordionCommitmentModels = GetAccodrionThreeData();
            var AspirationModels = GetAspirationData();
            var AccordionAspirationModels = GetAccodrionFourData();
            var TeamModels = GetTeamData();
            var PurposeModels = GetPurposeData();
            var AccordionPurposeModels = GetAccodrionFiveData();


            var viewModel = new AboutModel
            {
                AboutUs = AboutUs1Models,
                WhyUs = WhyUsModels,
                WhyUsAccordion=WhyUsAccordionModels,
                 Leadership = LeadershipModels,
                HowWork = HowWorkModels,
                AccordionTwo = AccordionTwoModels,
                Commitment = CommitmentModels,
                AccordionThree = AccordionCommitmentModels,
                Aspiration = AspirationModels,
                AccordionFour = AccordionAspirationModels,
                Team = TeamModels,
                Purpose = PurposeModels,
                AccordionFive = AccordionPurposeModels
            };
            return View(viewModel);
        }
     }
}
