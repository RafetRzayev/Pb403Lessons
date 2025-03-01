namespace FitnesTrackerPractise;

class FitnessTrackerPro : FitnessTracker
{
    public FitnessTrackerPro(string deviceName) : base(deviceName)
    {
        BatteryLife = 48;
        Users = new string[5];
    }

    public override void TrackSteps(int steps)
    {
        if (steps < 0 || steps > 100000)
        {
            Console.WriteLine("Invalid number of steps. Please enter a value between 1 and 100,000.");

            return;
        }

        TotalSteps += steps;
        Console.WriteLine($"Tracked {steps} steps. Total steps: {TotalSteps}.");
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"FitTrack Pro is called '{DeviceName}', it has {BatteryLife} hours of battery life, {TotalSteps} total steps, and {Size} users.");

        if (CurrentActiviy != null)
            Console.WriteLine($"Current activity: {CurrentActiviy.Name}");
    }
}