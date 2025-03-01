namespace FitnesTrackerPractise
{
    class Cycling : Activity
    {
        private int _caloryPerMinute = 8;

        public Cycling(string name, int duration) : base(name, duration)
        {
        }

        public override void CalculateCalories()
        {
            CaloriesBurned = _caloryPerMinute * Duration;

            Console.WriteLine($"Running '{Name}' burned {CaloriesBurned} calories in {Duration} minutes.");
        }
    }
}
