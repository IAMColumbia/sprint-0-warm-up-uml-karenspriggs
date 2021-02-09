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
            if (Vehicles.Count < MaxVehicles)
            {
                a.FlyDown(a.CurrentAltitude);
                a.IsFlying = false;
                Vehicles.Add(a);
            } else
            {
                return "The airport is full so the vehicle could not land";
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
           Vehicles.Remove(a);
            return "An aerial vehicle has taken off";
        }
    }
}
