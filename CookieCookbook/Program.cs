using CookieCookbook;

const FileFormat Format = FileFormat.Json;
IStringsRepository stringsRepository = Format == FileFormat.Json
    ? new StringJsonRepository()
    : new StringsTextualRepository();

const string FileName = "recipe";
var fileMetadata = new FileMetadata(FileName, Format);

var ingredientsRegister = new IngredientRegister();

var cookiesRecipesApp = new CookiesRecipesApp(
    new RecipesRepository(
        stringsRepository,
        ingredientsRegister),
    new RecipesConsoleUserInteraction(
        ingredientsRegister)
);

cookiesRecipesApp.Run(fileMetadata.ToPath());