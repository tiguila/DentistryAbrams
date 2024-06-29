using abrams.DentalOffice.webApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace abrams.DentalOffice.webApp.Controllers
{

    public class PatientEducationController : Controller
    {
        private readonly ILogger<PatientEducationController> _logger;

        public PatientEducationController(ILogger<PatientEducationController> logger)
        {
            _logger = logger;
        }

        public IActionResult SleepApnea()
        {
            ViewData["CurrentTimestamp"] = DateTime.Now;
            return View();
        }

        public IActionResult OralHygieneBasics()
        {
            ViewData["CurrentTimestamp"] = DateTime.Now;
            return View();
        }


        public IActionResult RootCanal()
        {
            ViewData["CurrentTimestamp"] = DateTime.Now;
            return View();
        }

        
        public IActionResult RecedingGums()
        {
            ViewData["CurrentTimestamp"] = DateTime.Now;
            return View();
        }

        public IActionResult ReplacingMissingTeeth()
        {
            ViewData["CurrentTimestamp"] = DateTime.Now;
            return View();
        }


        public IActionResult AlternativeToBraces()
        {
            ViewData["CurrentTimestamp"] = DateTime.Now;
            return View();
        }


        public IActionResult DentalAnxiety()
        {
            ViewData["theTitle"] = "Dental Anxiety";
            ViewData["theBody"] = "At Elliott Abrams Dental Office, we can perform dental work on patients that are struggling with dental anxiety. If you avoid the dentist due to fear of what a procedure may be like or simply do not enjoy dental work, give us a call. In our Los Angeles, dental office, we can ensure that you are comfortable and relaxed, regardless of the dental procedure. When you visit our office, we will meet with you to discuss what treatments you need and create a plan for how to keep your mouth healthy while easing any fears that you have about dentistry in general. We will keep you informed about the entire process so that you can make decisions regarding dental care without experiencing any anxiety.";

            var cardOne = new List<InformationCard>
            {
                new()
                {
                    Header = "How can I ease my fears about dental care without medication?",
                    Body = ["When you visit our dental office, we can discuss ways that you can prevent experiencing anxiety while receiving dental care. Give us a call to go over any and all methods for dealing with dental anxiety that we can offer. In some cases, all a patient needs to do is play music on headphones during the appointment. In other cases, we may need medication or another method to deal with dental anxiety."],
                    IsBullet = false
                },
                new ()
                {
                    Header = "How can I prepare for my dentist appointment?",
                    Body = ["Another easy way to calm your fears is to visit our Los Angeles dental office and meet with Dr. Elliott Abrams prior to the actual appointment. Taking the time to tour our office, where you can sit in the dentist chair and have a conversation, will allow you to become familiar with our staff and office environment. After this meeting, when you do have your teeth cleaned, you are doing so in an atmosphere that you feel comfortable in with friendly and familiar faces. During your consultation, we can also discuss what you can expect from a teeth cleaning or a specific procedure. This will help you to mentally prepare for how long it will take, what dental tools we will use, what you may feel during the process and what the recovery period will be, if any. At Elliott Abrams Dental Office, we find that the more informed our patients are the more comfortable and relaxed they feel. This one appointment can help to alleviate the fear of dentists that you are experiencing."],
                    IsBullet = false
                }
            };




            var cardTwo = new List<InformationCard>
            {
                new() {
                    Header = "Sedation Dentistry Can Reduce Your Dental Anxiety",
                    Body = ["In our Los Angeles dental office, we practice sedation dentistry that can be used to reduce and prevent dental anxiety. Here are some of the questions we are regularly answer about sedation dentistry."],
                    IsBullet = false
                },

                new() {
                    Header = "Will I be asleep when sedated?",
                    Body = ["Typically not. Sleep dentistry is usually reserved for oral surgery and lengthy procedures. Sedation dentistry will help you relax and can make you drowsy, so some patients do nod off. However, with our sedation methods, you are still in control of your body and are technically not put to sleep."],
                    IsBullet = false
                },

                new() {
                    Header = "Can everyone use sedation dentistry?",
                    Body = ["To determine if you are healthy enough for sedation (most people are), we recommend that you schedule an appointment with our California dental office. We will meet with you to discuss the type of sedation that will be best for your procedure and the level of dental anxiety that you are experiencing."],
                    IsBullet = false
                },

                new() {
                    Header = "How is sedation dentistry administered?",
                    Body = ["The most common form of sedation is taking a pill an hour before the procedure begins. One pill can help you to feel entirely relaxed and eliminate your fear of dentists. Most procedures, like teeth cleaning or fixing a simple cavity, do not necessarily hurt. With sedation, many people do not require additional medication. However, if you would like pain medication as well, we can give it to you after the sedation has taken effect."],
                    IsBullet = false
                },

                new() {
                    Header = "Will I be able to move around like normal?",
                    Body = ["Yes, with sedation dentistry you can continue to engage in conversation and respond to commands; but your response times may be slightly delayed and your mind not as clear as normal. This is why we recommend that you either have someone drive you home or wait until it has worn off completely before driving home after the appointment."],
                    IsBullet = false
                },

                new() {
                    Header = "Are there any side effects of sedation dentistry?",
                    Body = ["Most of the time, the sedation goes away within an hour of your procedure being complete. If you are more heavily sedated or put to sleep for oral surgery, it can take a couple of hours to feel normal but this is rare. In our Los Angeles dental office, we use the least amount of sedation to help you to feel completely relaxed and comfortable. Thus, it is effective without staying in your system for too long."],
                    IsBullet = false
                },

                new() {
                    Header = "Can children benefit from sedation dentistry?",
                    Body = ["Yes, children may need sedation when going through large amounts of dental work so that they can hold still long enough for a dentist to complete the dental work. This is a unique specialty and not offered at every dentist office."],
                    IsBullet = false
                },

                new() {
                    Header = "Are there other ways to make dental work more comfortable?",
                    Body = ["Yes. Laser dentistry is transforming how professionals complete dental procedures. When you visit our dental office, you can be confident that we will use the latest technology available to make your procedure more comfortable. Lasers allow us to do so because the laser energy is fine and can target small spaces without irritating the surrounding tissue. We can also reduce discomfort and the recovery time thanks to dental lasers. The dental lasers are also less invasive than traditional dental tools. With the dental laser, there will be less bleeding and swelling than normal. Dental lasers can also help treat tooth decay, gum disease, and has applications in restorative procedures. If you want a more comfortable experience and to reduce your dental anxiety, we highly recommend visiting a laser dentistry office. To learn about the procedures that we perform using lasers, call (213) 353-4723 and schedule an appointment. At Elliott Abrams Dental Office, we find that many of our patients no longer need sedation or pain medication because the common factors that create fear of dentists are eliminated. For example, the noise, heat, and vibration that is traditionally associated with the dental drill is not present when using lasers."],
                    IsBullet = false
                }
            };






            var cardThree = new List<InformationCard>
            {
                new ()
                {
                    Header = "Cosmetic Dentistry",
                    Body = new List<string> {"Cosmetic dentistry is generally used to refer to any dental work that improves the appearance (though not necessarily the function) of a person’s teeth, gums and/or bite." },
                    IsBullet = false
                },
                new ()
                {
                    Header = "Dental Caries",
                    Body = ["Dental caries is also known as cavities and result from a lack of proper oral hygiene leaving plaque that forms tiny holes in the teeth."],
                    IsBullet = false
                },
                new ()
                {
                    Header = "Dental Filling",
                    Body = ["A dental filling involves restoring the structure of the tooth by using metal, alloy, porcelain or plastic to fill the tooth."],
                    IsBullet = false
                },
                new ()
                {
                    Header = "Dental Sealants",
                    Body = ["Dental sealants contain a resinous material that we apply to the chewing surfaces of the posterior teeth to prevent dental caries."],
                    IsBullet = false
                },
                new ()
                {
                    Header = "Gingivitis",
                    Body = ["Gingivitis is the inflammation of gum tissue that results from plaque, other infections in the mouth and poor oral hygiene."],
                    IsBullet = false
                },
                new ()
                {
                    Header = "Tartar",
                    Body = ["Tartar forms when plaque builds up on the surface of the teeth and calcifies into a hard surface that is much more difficult to remove and will require professional treatment."],
                    IsBullet = false
                },
                new ()
                {
                    Header = "Decay",
                    Body = ["Tooth decay is when the enamel of the tooth begins to decay and cause erosion from plaque and tartar on the teeth."],
                    IsBullet = false
                },
                new ()
                {
                    Header = "Dental Checkup",
                    Body = ["A dental checkup is an appointment that involves cleaning the teeth, identifying any signs of infection and removing said signs of infection at least once every six months in the office."],
                    IsBullet = false
                },
                new ()
                {
                    Header = "Dental Prophylaxis",
                    Body = ["A dental prophylaxis is a professional and detailed cleaning that involves the removal of plaque, calculus and stains from the teeth."],
                    IsBullet = false
                },
                new ()
                {
                    Header = "Dentist",
                    Body = ["A dentist, also known as a dental surgeon, is a doctor who specializes in the diagnosis, prevention, and treatment of diseases and conditions of the oral cavity."],
                    IsBullet = false
                },
                new ()
                {
                    Header = "Preventive Dentistry",
                    Body = ["Preventive dentistry is the dentistry that focuses on maintaining oral health in order to prevent the spread of plaque, the formation of tartar and infections in the mouth."],
                    IsBullet = false
                },
                new ()
                {
                    Header = "Tooth Enamel",
                    Body = ["Tooth enamel is the protective visible outer surface of a tooth that contains the dentin and dental pulp."],
                    IsBullet = false
                }
            };

            var viewModel = new InformationCardViewModel
            {
                CardOne = cardOne,
                CardTwo = cardTwo,
                CardThree = cardThree
            };
            ViewData["CurrentTimestamp"] = DateTime.Now;
            return View(viewModel);
        }

        public IActionResult ImproveMySmile()
        {
            ViewData["CurrentTimestamp"] = DateTime.Now;
            return View();
        }


        public IActionResult ChippedTooth()
        {
            ViewData["CurrentTimestamp"] = DateTime.Now;
            return View();
        }


        public IActionResult ToothExtractionNecessary()
        {
            ViewData["CurrentTimestamp"] = DateTime.Now;
            return View();
        }

        public IActionResult InvisalignOrBraces()
        {
            ViewData["CurrentTimestamp"] = DateTime.Now;
            return View();
        }

        public IActionResult BleedingGums()
        {
            ViewData["CurrentTimestamp"] = DateTime.Now;
            return View();
        }

        public IActionResult BoneGraftForDentalImplants()
        {
            ViewData["CurrentTimestamp"] = DateTime.Now;
            return View();
        }
        
        public IActionResult WisdomTeethExtraction()
        {
            ViewData["CurrentTimestamp"] = DateTime.Now;
            return View();
        }

        public IActionResult OralCancerScreening()
        {
            ViewData["CurrentTimestamp"] = DateTime.Now;
            return View();
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
