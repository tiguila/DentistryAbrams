namespace abrams.DentalOffice.webApp.Models
{
    public class InformationCardViewModel
    {
        public List<InformationCard> CardOne { get; set; }
        public List<InformationCard> CardTwo { get; set; }
        public List<InformationCard> CardThree { get; set; }
    

        

        public InformationCardViewModel()
        {
            CardOne = new List<InformationCard>();
            CardTwo = new List<InformationCard>();
            CardThree = new List<InformationCard>();
        }
    }
}
