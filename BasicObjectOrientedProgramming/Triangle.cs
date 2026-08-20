namespace BasicObjectOrientedProgramming;

public class Triangle(int triangleBase, int height)
{
    public int CalculateArea()
    {
        return (triangleBase * height) / 2;
    }

    public string AsString()
    {
        return $"Base is {triangleBase}, height is {height}";
    }
}