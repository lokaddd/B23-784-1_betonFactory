using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Fitness App!");
        
        var userService = new UserManagementService();
        userService.RegisterUser(new User { Id = "1", Name = "John Doe", Email = "john@example.com", Role = "Client" });

        var workoutService = new AddWorkoutService();
        workoutService.AddWorkout("1", new Workout { Name = "Morning Run", Date = DateTime.Now });

        Console.WriteLine("Application finished!");
    }
}