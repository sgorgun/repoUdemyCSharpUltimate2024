using System;

Console.WriteLine("Hello!");
List<string> todoTasks = new List<string>();
bool shallExit = false;

while(!shallExit)
{
    Console.WriteLine("\nWhat do you want to do?\n");
    Console.WriteLine("[S]e all TODOs.");
    Console.WriteLine("[A]dd a TODO.");
    Console.WriteLine("[R]emove a TODO.");
    Console.WriteLine("[E]xit.");

    var userChoice = Console.ReadLine();
    switch (userChoice)
    {
        case "E":
        case "e":
            shallExit = true;
            break;
        case "S":
        case "s":
            SeeAllTodo();
            break;
        case "A":
        case "a":
            AddTodo();
            break;
        case "R":
        case "r":
            RemoveTodo();
            break;
        default:
            Console.WriteLine("Invalid choice.");
            break;
    }
}

void SeeAllTodo()
{
    if (IfTodoIsEmpty()) return;

    ViewTodoList();
}

bool IfTodoIsEmpty()
{
    if (todoTasks.Count == 0)
    {
        Console.WriteLine("No TODOs have been added yet.");
        return true;
    }

    return false;
}

void ViewTodoList()
{
    for (int i = 0; i < todoTasks.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {todoTasks[i]}");
    }
}

void AddTodo()
{
    string todoUserInput;

    do
    {
        Console.WriteLine("\nEnter the TODO description:");
        todoUserInput = Console.ReadLine();
    } while (!TodoDescriptionValid(todoUserInput));

    todoTasks.Add(todoUserInput);
    Console.WriteLine($"TODO successfully added: {todoUserInput}");
}

bool TodoDescriptionValid(string description)
{
    if (description == "")
    {
        return false;
    }

    if (!todoTasks.Contains(description)) return true;
    Console.WriteLine("Description must be unique");
    return false;
}

void RemoveTodo()
{
    if (IfTodoIsEmpty()) return;

    int index;
    do
    {
        Console.WriteLine("Select the index of the TODO you want to remove:");
        ViewTodoList();
    } while (!TryReadIndex(out index));

    RemoveTodoAtIndex(index - 1);
}

;
bool TryReadIndex(out int index)
{
    var userInput = Console.ReadLine();
    if (userInput == "")
    {
        index = 0;
        Console.WriteLine("Selected index cannot be empty");
        return false;
    }
    if (int.TryParse(userInput, out index) &&
        index >= 1 &&
        index <= todoTasks.Count)
    {
        return true;
    }
    Console.WriteLine("The given index is not valid.");
    return false;
}

void RemoveTodoAtIndex(int index)
{
    var todoToBeRemoved = todoTasks[index];
    todoTasks.RemoveAt(index);
    Console.WriteLine("TODO removed: " + todoToBeRemoved);
}