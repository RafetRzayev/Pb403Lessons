namespace FitnesTrackerPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fitnesTracker = new FitnessTracker("DFGH");
            fitnesTracker.TrackSteps(200);
            fitnesTracker.TrackSteps(200);
            fitnesTracker.TrackSteps(99999);

            fitnesTracker.AddUser("Tina1");//Tina1
            fitnesTracker.AddUser("Tina2");//null
            fitnesTracker.AddUser("Tina3");//Kevin

            fitnesTracker.DeleteUser("Tina2");
            fitnesTracker.AddUser("Kevin");
            fitnesTracker.PrintUsers();

            //fitnesTracker.PrintInfo();

            //var fitnessTrackerPro = new FitnessTrackerPro("GHJ");
            //fitnessTrackerPro.AddUser("Kevin");
            //fitnessTrackerPro.TrackSteps(99999);
            //fitnessTrackerPro.TrackSteps(345);

            //fitnessTrackerPro.PrintInfo();

            //Running running = new Running("wefg", 34);
            //running.CalculateCalories();

            //Cycling cycling = new Cycling("fds", 45);
            //cycling.CalculateCalories();

            //fitnessTrackerPro.SetCurrentActivity(cycling);
            //fitnessTrackerPro.PrintInfo();


        }
    }
}
