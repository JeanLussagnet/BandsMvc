namespace BandsMvc.Models
{
    public class DataService
    {
        private List<Band> Bands = new List<Band>
        {
            
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
