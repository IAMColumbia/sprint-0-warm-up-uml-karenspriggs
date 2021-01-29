using System;

namespace Sprint_0_Warm_Up
{
    public abstract class AerialVehicle
    {
        public int CurrentAltitude { get; set; }
        public int MaxAltitude { get; set; }
        public bool IsFlying { get; set; }
        Engine Engine { get; set; }

        public AerialVehicle()
        {
            IsFlying = false;
            this.Engine = new Engine();
        }

        public string About()
        {
            string message = "";

            message += $"\nThis OOPFlyingVehicle.Airplane has a max altitude of {MaxAltitude} ft.";
            message += $"\nIt's current altitude is {CurrentAltitude} ft.";

            if (Engine.isStarted)
            {
                message += "\nOOPFlyingVehicleMidterm.Airplane engine has been started";
            } else
            {
                message += "\nOOPFlyingVehicleMidterm.Airplane engine is not started";
            }

            return message;
        }

        public string TakeOff()
        {
            string message;
            if (!Engine.isStarted)
            {
                message = "OOPFlyingVehicleMidterm.Airplane can't fly it's engine is not started.";
            } else
            {
                message = "OOPFlyingVehicleMidterm.Airplane is flying";
                CurrentAltitude = 0;
                IsFlying = true;
            }

            return message;
        }

        public void StartEngine()
        {
            Engine.Start();
        }

        public void FlyDown()
        {
            int defaultHeight = 1000;

            if (CurrentAltitude - defaultHeight >= 0)
            {
                CurrentAltitude -= defaultHeight;
            }
        }

        public void FlyDown(int howMuch)
        {
            int newHeight = CurrentAltitude- howMuch;

            if (newHeight >= 0)
            {
                CurrentAltitude = newHeight;
            }
        }

        internal void FlyUp()
        {
            int defaultHeight = 1000;

            if (CurrentAltitude + defaultHeight < MaxAltitude)
            {
                CurrentAltitude += defaultHeight;
            }
        }

        internal void FlyUp(int HowMuch)
        {
            int newHeight = HowMuch + CurrentAltitude;

            if (newHeight < MaxAltitude)
            {
                CurrentAltitude = newHeight;
            }
        }

        public string getEngineStartedString()
        {
            return "";
        }

        public void StopEngine()
        {
            Engine.Stop();
        }
    }
}