
namespace Builder;

public class MealDirector : IMeal
{
    private Meal meal = new Meal();

    public void AddMomo(string momo)
    {
        meal.Momo = momo;
    }
    public void AddRice(string rice)
    {
        meal.Rice = rice;
    }
    public void AddTea(string tea)
    {
        meal.Tea = tea;
    }
    public Meal Build()
    {
        return meal;
    }
}

