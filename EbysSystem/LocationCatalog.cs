using System;
using System.Collections.Generic;
using System.Text;

namespace EbysSystem
{
    class LocationCatalog
    {
        private Dictionary<int,Location> locationList;
        public LocationCatalog()
        {
            locationList = new Dictionary<int, Location>();
        }
        public void AddLocation(int id, Location loc)
        {
            locationList.Add(id,loc);
        }
        public Location GetLocation(int id)
        {
            return locationList[id];
        }
        public bool CheckAvailable(int id)
        {
            if (locationList.ContainsKey(id)) return false;
            else return true;
        }

        public Dictionary<int, Location> GetLocationList()
        {
            return locationList;
        }

        public void ShowLocations()
        {
            Console.WriteLine("-----------------------------------------------");

            foreach (int item in locationList.Keys)
            {
                Console.WriteLine("Location Id: "+locationList[item].Id + ", \nBuilding: " + locationList[item].Building + " \nClass no: " +
                    locationList[item].ClassroomNo);
            }
        }
    }
}
