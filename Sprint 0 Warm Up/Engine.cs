namespace Sprint_0_Warm_Up
{
    public class Engine
    {
        public bool isStarted;

        public Engine()
        {
            isStarted = false;
        }

        public string About()
        {
            string message = "";

            if (isStarted)
            {
                message = "This engine has been started";
            }
            else
            {
                message = "This engine has not been started";
            }

            return message;
        }
        
        public void Start()
        {
            isStarted = true;
        }

        public void Stop()
        {
            isStarted = false;
        }
    }
}