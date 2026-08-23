using UltimateCourse;

var bakedDishes = new List<IBakeable>
{
    new Pizza(),
    new Panettone()
};

foreach (var bakedDish in bakedDishes)
{
    Console.WriteLine(bakedDish.GetInstruction());
}