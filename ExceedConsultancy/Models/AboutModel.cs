using Microsoft.EntityFrameworkCore;

namespace ExceedConsultancy.Models

{
    public class AboutModel
    {
        public List<HomeSliderViewModel> Slider { get; set; }
        public List<IndustriesViewModel> Industrie { get; set; }
        public List<CapabilitiesViewModel> Capabilitie { get; set; }

        public List<AboutUsViewModel> AboutUs { get; set; }

        public List<WhyUsViewModel> WhyUs { get; set; }
        public List<WhyUsAccordionViewModel> WhyUsAccordion { get; set; }
        public List<Leadership> Leadership { get; set; }
        public List<Team> Team { get; set; }
        public List<HowWork> HowWork { get; set; }
        public List<AccordionHowWork> AccordionTwo { get; set; }
        public List<Commitment> Commitment { get; set; }
        public List<AccordionCommitment> AccordionThree { get; set; }

        public List<Aspiration> Aspiration { get; set; }
        public List<AccordionAspiration> AccordionFour { get; set; }

        public List<Purpose> Purpose { get; set; }
        public List<AccordionPurpose> AccordionFive { get; set; }



    }

}