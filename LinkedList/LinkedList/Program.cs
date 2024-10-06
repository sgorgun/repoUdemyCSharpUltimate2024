var linkedList = new LinkedList<int>();
linkedList.AddFirst(1);
linkedList.AddLast(2);
linkedList.AddLast(3);
linkedList.AddFirst(4);
linkedList.Remove(2);

foreach (var linkedItem in linkedList)
{
    Console.Write(linkedItem + " ");
}

Console.ReadKey();