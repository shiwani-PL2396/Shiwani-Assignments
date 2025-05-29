namespace Events_1
{
    //Create delegates
    public delegate string WelcomeUserDelegate(string username);
    internal class Program
    {
        //Declaring an event using the delegate
        //Eventhandler requires delegate implementation to dispatch event
        event WelcomeUserDelegate WelcomeDelEvent;

        //Attaching the method to the event
        public Program()
        {
            WelcomeDelEvent += new WelcomeUserDelegate(this.WelcomeUser);
        }
        static void Main(string[] args)
        {
            //Subscribe and dispatch(invoking event)
            Program objpro = new Program();
            string s = objpro.WelcomeDelEvent("John Doe");
            Console.WriteLine(s);

        }

        //create a method to publish the event
        public string WelcomeUser(string username)
        {
            return "Welcome " + username + " to the Event Handler!";
        }
    }
}
5:36 pm



