using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerClassLibrary
{
    public class Location
    {
        private string _locationName;

        public Location(string ln)
        {
            _locationName = ln;
        }

        public string LocationName
        {
            get => _locationName;
            set => _locationName = value;
        }

        // public void SetLocationName(string value) =>_locationName = value;
        // public string GetLocationName() =>_locationName;
    }
}
