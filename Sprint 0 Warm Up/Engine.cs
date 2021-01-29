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
            return "";
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