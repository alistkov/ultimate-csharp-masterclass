namespace BasicObjectOrientedProgramming;

public static class StringsTransformator
{
    public static string TransformSeparators(
        string input,
        string originalSeparator,
        string targetSeparator)
    {
        //your code goes here
        return string.Join(targetSeparator, input.Split(originalSeparator));
    }
}