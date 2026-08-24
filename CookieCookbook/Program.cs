using CookieCookbook;

var cookiesRecipesApp = new CookiesRecipesApp(
    new RecipesRepository(),
    new RecipesConsoleUserInteraction(
        new IngredientRegister()
    )
);

cookiesRecipesApp.Run("recipes.txt");