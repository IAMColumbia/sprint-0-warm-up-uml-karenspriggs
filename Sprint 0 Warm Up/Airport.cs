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
            Vehicles = new List<AerialVehicle>();
        }

        public Airport(string code, int MaxVehicles)
        {
            AirportCode = code;
            this.MaxVehicles = MaxVehicles;
            Vehicles = new List<AerialVehicle>();
        }

        public string AllTakeOff()
        {
            foreach (AerialVehicle a in Vehicles)
            {
                TakeOff(a);
            }
            
            return "All of the vehicles have taken off";
        }

        public string Land(AerialVehicle a)
        {
            a.FlyDown(a.CurrentAltitude);
            a.IsFlying = false;

            if (Vehicles.Count < MaxVehicles)
            {
                Vehicles.Add(a);
            }

            return "An aerial vehicle has landed";
        }

        public string Land(List<AerialVehicle> landing)
        {
            foreach (AerialVehicle a in landing)
            {
                Land(a);
            }
            return "All of the vehicles have landed";
        }

        public string TakeOff(AerialVehicle a)
        {
            a.StartEngine();
            a.TakeOff();
            return "An aerial vehicle has taken off";
        }
    }
}
