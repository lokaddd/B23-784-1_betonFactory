public class TrackProgressService
{
    public Progress GetUserProgress(string userId)
    {
        // Пример: получение прогресса пользователя
        return new Progress
        {
            UserId = userId,
            WeightLifted = 120, // Example weight
            CaloriesBurned = 2000
        };
    }
}