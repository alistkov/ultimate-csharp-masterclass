using CookieCookbook;

var ingredientsRegister = new IngredientRegister();

var cookiesRecipesApp = new CookiesRecipesApp(
    new RecipesRepository(
        new StringsTextualRepository(),
        ingredientsRegister),
    new RecipesConsoleUserInteraction(
        ingredientsRegister)
);

cookiesRecipesApp.Run("recipes.txt");