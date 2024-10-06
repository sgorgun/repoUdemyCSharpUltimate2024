bool Contains<T> (T itemToCheck, IEnumerable<T> input) // O(N) linear complexity
{
    foreach (var item in input)
    {
        if (item.Equals(itemToCheck))
        {
            return true;
        }
    }

    return false;
}

void Quadratic<T> (IEnumerable<T> input) // O(N*N) quadratic complexity
{
    foreach (var itemA in input)
    {
        foreach (var itemB in input)
        {
            //do something
        }
    }
}

T GetAtIndex<T> (List<T> input, int index) // O(1) constant complexity
{
    return input[index];
}

// O(log N) logarithmic complexity - binary search algorithm

void SomeMethod<T> (IEnumerable<T> inputA, IEnumerable<T> inputB) // O(N*M) - two different collections
{
    foreach (var itemA in inputA)
    {
        foreach (var itemB in inputB)
        {
            //do something
        }
    }
}
