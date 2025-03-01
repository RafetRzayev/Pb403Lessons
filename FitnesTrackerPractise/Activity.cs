namespace FitnesTrackerPractise;

abstract class Activity
{
    protected Activity(string name, int duration)
    {
        Name = name;
        Duration = duration;
    }

    public string Name { get; set; }
    public int Duration { get; set; }
    public int CaloriesBurned { get; set; }

    public abstract void CalculateCalories();
}
