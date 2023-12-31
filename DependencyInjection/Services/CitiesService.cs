﻿using ServicesContract;

namespace Services
{
    public class CitiesService : ICitiesService
    {
        private List<string> _cities;

        public Guid InstanceID { get; }
      

        public CitiesService()
        {
            InstanceID = Guid.NewGuid();
            _cities = new List<string>()
            {
                "Paris", "London", "Delhi", "Sacramento", "Auckland", "Tokyo"
            };
        }

        public List<string> GetCities()
        {
            return _cities;
        }

    }
}