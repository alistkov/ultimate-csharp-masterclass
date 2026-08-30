using UltimateCourse;

var pets = new List<Pet>
{
    new Pet(PetType.Dog, 10),
    new Pet(PetType.Cat, 5),
    new Pet(PetType.Fish, 0.9),
    new Pet(PetType.Dog, 45),
    new Pet(PetType.Cat, 2),
    new Pet(PetType.Fish, 0.02),
};


var t = Exercise.FindMaxWeights(pets);
Console.ReadKey();