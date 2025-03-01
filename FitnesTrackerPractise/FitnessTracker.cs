using System;

namespace FitnesTrackerPractise;

class FitnessTracker
{
    public FitnessTracker(string deviceName)
    {
        DeviceName = deviceName;
        BatteryLife = 24;
        TotalSteps = 0;
        Users = new string[3];
    }

    public string DeviceName { get; set; }
    public int BatteryLife { get; set; }
    public int TotalSteps { get; set; }
    public string[] Users { get; set; }

    public Activity CurrentActiviy { get; set; }

    public int Size = 0;

    public virtual void TrackSteps(int steps)
    {
        if (steps < 0 || steps > 50000)
        {
            Console.WriteLine("Invalid number of steps. Please enter a value between 1 and 50,000.");

            return;
        }

        TotalSteps += steps;
        Console.WriteLine($"Tracked {steps} steps. Total steps: {TotalSteps}.");
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"FitTrack is called '{DeviceName}', it has {BatteryLife} hours of battery life, {TotalSteps} total steps, and {Size} users.");
    }

    public void AddUser(string name)
    {
        if (Size >= Users.Length)
        {
            Console.WriteLine($"Cannot add more users. The limit of {Users.Length} users has been reached.");

            return;
        }

        Users[Size++] = name;
        Console.WriteLine($"User {name} has been added.");
    }

    public void SetCurrentActivity(Activity activiy)
    {
        CurrentActiviy = activiy;
    }

    public virtual void DeleteUser(string username)
    {
        for (int i = 0; i < Users.Length; i++)
        {
            if (Users[i] == username)
            {
                for (int j = i; j < Users.Length - 1; j++)
                {
                    Users[j] = Users[j + 1];
                }
                Users[Users.Length - 1] = null;
                Console.WriteLine("User " + username + " has been deleted");
                Size -= 1;
                return;
            }
        }
    }

    public void PrintUsers()
    {
        foreach (var item in Users)
        {
            if (item == null) continue;

            Console.WriteLine(item);
        }
    }
}
