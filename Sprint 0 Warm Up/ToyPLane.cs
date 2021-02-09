using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up
{
    public class ToyPlane : Airplane
    {
        private bool isWoundUP;

        public ToyPlane()
        {
            this.MaxAltitude = 50;
            isWoundUP = false;
            Engine.isStarted = false;
        }

        public string getWindUpString()
        {
            return "";
        }

        public void WindUp()
        {
            isWoundUP = true;
        }

        public void UnWind()
        {
            isWoundUP = false;
        }

        public override void StartEngine()
        {
            if (isWoundUP)
            {
                CurrentAltitude = 0;
                Engine.isStarted = true;
            }
        }

        public override string TakeOff()
        {
            string message;

            if (isWoundUP)
            {
                message = $"This {this.ToString()} is flying";
            } else
            {
                message = $"This {this.ToString()} can't fly it's engine is not started.";
            }
            return message;
        }
    }
}
