﻿namespace OptiTourRoutesWebsite.Models
{
    public class TouristSpot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
