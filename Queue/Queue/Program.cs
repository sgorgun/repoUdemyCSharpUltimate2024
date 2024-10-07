var queue = new Queue<string>();
queue.Enqueue("a");
queue.Enqueue("b");
queue.Enqueue("c");
queue.Enqueue("d");

var first = queue.Dequeue();
var second = queue.Peek();

Console.WriteLine(first);
Console.WriteLine();
Console.WriteLine(second);
Console.WriteLine();

foreach (var item in queue)
{
    Console.WriteLine(item);
}

var priorityQueue = new PriorityQueue<string,int>();
priorityQueue.Enqueue("a", 5);
priorityQueue.Enqueue("b", 5);
priorityQueue.Enqueue("c", 2);
priorityQueue.Enqueue("d", 3);

var firstPriority = priorityQueue.Dequeue();


Console.ReadKey();