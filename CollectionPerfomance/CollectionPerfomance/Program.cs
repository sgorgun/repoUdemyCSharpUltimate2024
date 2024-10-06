using System.Diagnostics;

var input = Enumerable.Range(0, 100_000_000).ToArray();

Stopwatch sw = Stopwatch.StartNew();

var list = new List<int>(input); // input as parameter of constructor - 200 ms
//foreach (var item in input)// list iteration - 600 ms
//{
//    list.Add(item);
//}

sw.Stop();
Console.WriteLine($"Took: {sw.ElapsedMilliseconds} ms");

list.Clear(); // clean the list
list.TrimExcess(); // trim the list if we don't need a big size anymore

list.AddRange(input); //add elements into the end of list
list.RemoveRange(5, 10); //for removing some elements
list.RemoveAt(7); // remove element at special index
list.Remove(99); // remove first found element 

Console.ReadKey();