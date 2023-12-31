namespace CookAPI.Models;

public class Recipe
{
    public long Id { get; set; }
    public string? Name { get; set; }
}


public class RecipeDto
{
    public long Id { get; set; }
    public string? Name { get; set; }
}