namespace NetUnderTheHoodAssignment.NewSolution;

public class FastRow(Dictionary<string, object> data)
{
    public object GetAtColumn(string columnName)
    {
        return data.ContainsKey(columnName) ? data[columnName] : null;
    }
}