public class AddWorkoutService
{
    public void AddWorkout(string userId, Workout workout)
    {
        // Пример: добавление тренировки в базу данных
        Console.WriteLine($"Workout for user {userId} added: {workout.Name} at {workout.Date}");
    }
}