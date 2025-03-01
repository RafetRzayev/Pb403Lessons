namespace FitnesTrackerPractise
{
    class Running : Activity
    {
        private int _caloryPerMinute = 10;

        public Running(string name, int duration) : base(name, duration)
        {
        }

        public override void CalculateCalories()
        {
            CaloriesBurned = _caloryPerMinute * Duration;

            Console.WriteLine($"Running '{Name}' burned {CaloriesBurned} calories in {Duration} minutes.");
        }
    }
}
