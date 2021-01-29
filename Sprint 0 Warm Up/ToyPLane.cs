using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up
{
    class ToyPlane : Airplane
    {
        public bool isWoundUP;

        public ToyPlane()
        {
            MaxAltitude = 50;
            isWoundUP = false;
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

        public void StartEngine()
        {
            if (isWoundUP)
            {
                Engine.isStarted = true;
            }
        }

        public string TakeOff()
        {
            string message;

            if (isWoundUP)
            {
                message = "OOPFlyingVehicleMidterm.ToyPlane is flying";
            } else
            {
                message = "OOPFlyingVehicleMidterm.ToyPlane can't fly it's engine is not started.";
            }
            return message;
        }
    }
}
