namespace BandsMvc.Models
{
    public class DataService
    { 
        private List<Band> Bands = new List<Band>
        {
            new Band(1, "BestBand" , "Greatest band of all time"),
            new Band(2, "Creator", "German metal band"),
            new Band(3, "Deletor", "Austrian metal band")
        };

        public Band GetBandById(int id)
        {
            return Bands.Where(b => b.Id.Equals(id)).First();
        }

        public Band[] GetAllBands()
        {
            return Bands.OrderBy(b => b.Name).ThenBy(b => b.Id).ToArray();
        }
    }
}
