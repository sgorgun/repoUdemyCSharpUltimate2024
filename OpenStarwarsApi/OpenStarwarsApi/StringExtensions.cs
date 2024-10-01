public static class StringExtensions
{
    public static int? ToIntOrNull(this string? input)
    {
        int? result = null;

        if (int.TryParse(input, out int resultParsed))
        {
            result = resultParsed;
        }

        return result;
    }
}