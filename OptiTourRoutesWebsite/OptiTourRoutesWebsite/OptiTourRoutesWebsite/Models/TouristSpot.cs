namespace OptiTourRoutesWebsite.Models
{
    public class TouristSpot
    {
        public Guid SpotId { get; set; }
        public string SpotName { get; set; }
        public string Description { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public List<Guid> SelectedSpotIds { get; set; }
    }
}
