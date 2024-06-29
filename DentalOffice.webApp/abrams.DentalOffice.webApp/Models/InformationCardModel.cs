namespace abrams.DentalOffice.webApp.Models
{
    public class InformationCard
    {
        public string Header { get; set; }
        public List<string> Body { get; set; }
        public bool IsBullet { get; set; }

        public InformationCard()
        {
            Body = [];
        }
    }
}
