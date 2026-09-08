namespace UltimateCourse.GenericTypes;

public static class TupleSwapExercise
{
    public static Tuple<TSecond, TFirst> SwapTupleItems<TFirst, TSecond>(Tuple<TFirst, TSecond> pair)
    {
        return new Tuple<TSecond, TFirst>(pair.Item2, pair.Item1);
    }
}