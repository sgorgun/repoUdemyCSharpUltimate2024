using CookiesCookbook.DataAccess;
using CookiesCookbook.Recipes.Ingredients;

namespace CookiesCookbook.Recipes;

/// <summary>
/// All recirpes repository.
/// </summary>
public class RecipesRepository : IRecipesRepository
{
    private readonly IStringsRepository _stringsRepository;
    private readonly IIngredientsRegister _ingredientsRegister;
    private const string Separator = ",";

    public RecipesRepository(IStringsRepository stringsRepository, IIngredientsRegister ingredientsRegister)
    {
        _stringsRepository = stringsRepository;
        _ingredientsRegister = ingredientsRegister;
    }

    /// <summary>
    /// Read the Recpies from the file.
    /// </summary>
    /// <param name="filePath"></param>
    /// <returns></returns>
    public List<Recipe> Read(string filePath)
    {
       return _stringsRepository.Read(filePath)
            .Select(RecipeFromString)
            .ToList();
    }

    /// <summary>
    /// This method accept the string with ingredirnt IDs as a parameter an use them to build a recipe object.
    /// </summary>
    /// <param name="recipeFromFile"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    private Recipe RecipeFromString(string recipeFromFile)
    {
        var ingredients = recipeFromFile
            .Split(Separator)
            .Select(int.Parse)
            .Select(_ingredientsRegister.GetById);

        return new Recipe(ingredients);
    }

    /// <summary>
    /// Make recipes list (IDs are saparated by comma.)
    /// </summary>
    /// <param name="filePath"></param>
    /// <param name="allRecipes"></param>
    public void Write(string filePath, List<Recipe> allRecipes)
    {
        var recipesAsStrings = allRecipes
            .Select(recipe =>
            {
                return string.Join(Separator, recipe.Ingredients
                .Select(ingridient => ingridient.Id));
            });

        _stringsRepository.Write(filePath, recipesAsStrings.ToList());
    }
}
