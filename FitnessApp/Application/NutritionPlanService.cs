public class NutritionPlanService
{
    public NutritionPlan GetPlan(string userId)
    {
        // Пример: возвращение плана питания
        return new NutritionPlan
        {
            UserId = userId,
            Meals = new List<string> { "Breakfast: Oatmeal", "Lunch: Chicken Salad", "Dinner: Grilled Salmon" }
        };
    }
}