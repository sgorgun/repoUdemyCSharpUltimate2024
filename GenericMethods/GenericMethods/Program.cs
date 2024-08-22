var ints = new List<int> { 1, 2, 3 };
ints.AddToFront(10);
ints.AddToFront<int>(11);

Console.ReadKey();

static class ListExtensions
{
    public static void AddToFront<T>(this List<T> list, T item)
    {
        list.Insert(0, item);
    }
}