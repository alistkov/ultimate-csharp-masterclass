using CookieCookbook;

const FileFormat format = FileFormat.Json;
IStringsRepository stringsRepository = format == FileFormat.Json
    ? new StringJsonRepository()
    : new StringsTextualRepository();

const string fileName = "recipe";
var fileMetadata = new FileMetadata(fileName, format);

var ingredientsRegister = new IngredientRegister();

var cookiesRecipesApp = new CookiesRecipesApp(
    new RecipesRepository(
        stringsRepository,
        ingredientsRegister),
    new RecipesConsoleUserInteraction(
        ingredientsRegister)
);

cookiesRecipesApp.Run(fileMetadata.ToPath());