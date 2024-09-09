namespace CookiesCookbook.Recipes.Ingredients;

/// <summary>
/// Base of all ingredients.
/// </summary>
public class IngredientsRegister : IIngredientsRegister
{
    public IEnumerable<Ingredient> All { get; } = new List<Ingredient>()
{
    new WheatFlour(),
    new CoconutFlour(),
    new Butter(),
    new Chocolate(),
    new Sugar(),
    new Cardamom(),
    new Cinnamon(),
    new CocoaPowder()
};

    /// <summary>
    /// Get recipe ID
    /// </summary>
    /// <param name="id">recipe ID</param>
    /// <returns>ingredient from All(Base of all ingredients) or null if it cant find</returns>
    public Ingredient GetById(int id)
    {
        var allIngredientsWithGivenId = All
            .Where(ingredient => ingredient.Id == id);

        if (allIngredientsWithGivenId.Count() > 1)
        {
            throw new InvalidOperationException(
                $"More than one ingredients have ID equal to {id}.");
        }

        //if (All.Select(ingredients => ingredients.Id).Distinct().Count() != All.Count())
        //{
        //    throw new InvalidOperationException(
        //        $"Some ingredients have duplicates IDs.");
        //}

        return allIngredientsWithGivenId.FirstOrDefault();
    }
}
