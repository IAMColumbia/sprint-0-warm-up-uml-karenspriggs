using System;

namespace Sprint_0_Warm_Up
{
    public abstract class AerialVehicle
    {
        public int CurrentAltitude { get; set; }
        public int MaxAltitude { get; set; }
        public bool IsFlying { get; set; }
        public Engine Engine { get; set; }

        public AerialVehicle()
        {
            IsFlying = false;
            this.Engine = new Engine();
        }

        public virtual string About()
        {
            string message = "";

            message += $"\nThis {this.ToString()} has a max altitude of {MaxAltitude} ft.";
            message += $"\nIt's current altitude is {CurrentAltitude} ft.";

            if (Engine.isStarted)
            {
                message += $"\nThis {this.ToString()}'s engine has been started";
            } else
            {
                message += $"\nThis {this.ToString()}'s engine is not started";
            }

            return message;
        }

        public virtual string TakeOff()
        {
            string message;
            if (!Engine.isStarted)
            {
                message = $"This {this.ToString()} can't fly it's engine is not started.";
            } else
            {
                message = $"This {this.ToString()} is flying";
                CurrentAltitude = 0;
                IsFlying = true;
            }

            return message;
        }

        public virtual void StartEngine()
        {
            Engine.Start();
        }

        public virtual void FlyDown()
        {
            int defaultHeight = 1000;

            if (CurrentAltitude - defaultHeight >= 0)
            {
                FlyDown(defaultHeight);
            }
        }

        public virtual void FlyDown(int howMuch)
        {
            int newHeight = CurrentAltitude- howMuch;

            if (newHeight >= 0)
            {
                CurrentAltitude = newHeight;
            }
        }

        public void FlyUp()
        {
            int defaultHeight = 1000;

            if (CurrentAltitude + defaultHeight < MaxAltitude)
            {
                FlyUp(defaultHeight);
            }
        }

        public void FlyUp(int HowMuch)
        {
            int newHeight = HowMuch + CurrentAltitude;

            if (newHeight < MaxAltitude)
            {
                CurrentAltitude = newHeight;
            }
        }

        public virtual string getEngineStartedString()
        {
            return "";
        }

        public virtual void StopEngine()
        {
            Engine.Stop();
        }
    }
}