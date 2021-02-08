using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up
{
    class Airport
    {
        private int MaxVehicles;
        private List<AerialVehicle> Vehicles;

        public string AirportCode { get; set; }

        public Airport(string code)
        {
            AirportCode = code;
        }

        public Airport(string code, int MaxVehicles)
        {
            AirportCode = code;
            this.MaxVehicles = MaxVehicles;
        }

        public string AllTakeOff()
        {
            return "";
        }

        public string Land(AerialVehicle a)
        {
            return "";
        }

        public string Land(List<AerialVehicle> landing)
        {
            return "";
        }

        public string TakeOff(AerialVehicle a)
        {
            return "";
        }
    }
}
