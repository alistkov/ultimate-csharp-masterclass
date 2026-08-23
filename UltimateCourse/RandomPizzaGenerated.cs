namespace UltimateCourse;

public static class RandomPizzaGenerated
{
     public static Pizza Generate(int howManyIngredients)
     {
          var pizza = new Pizza();
          for (int i = 0; i < howManyIngredients; i++)
          {
               var randomIngredient = GenerateRandomIngredient();
               pizza.AddIngredient(randomIngredient);
          }

          return pizza;
     }
    
     public static Ingredient GenerateRandomIngredient()
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
    
}