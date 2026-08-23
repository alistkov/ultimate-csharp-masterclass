using UltimateCourse;

var cheddar = new Cheddar(1, 12);
var tomatoSauce = new TomatoSauce(2);
cheddar.Prepare();
tomatoSauce.Prepare();

Ingredient GenerateRandomIngredient()
{
    var random = new Random();
    var number = random.Next(1, 4);
    
    if (number == 1)
    {
        return new Cheddar(2, 12);
    }

    if (number == 2)
    {
        return new TomatoSauce(1);
    }

    return new Mozzarella(2);
}