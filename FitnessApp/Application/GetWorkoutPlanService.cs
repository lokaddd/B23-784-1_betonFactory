public class GetWorkoutPlanService
{
    public List<Workout> GetWorkoutPlan(string userId)
    {
        // Пример: возвращение тренировочного плана
        return new List<Workout>
        {
            new Workout { Name = "Cardio", Date = DateTime.Now.AddDays(1) },
            new Workout { Name = "Strength Training", Date = DateTime.Now.AddDays(2) }
        };
    }
}