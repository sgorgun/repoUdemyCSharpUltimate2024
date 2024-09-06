using System;
using System.Collections.Generic;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int> { 5, 9, 2, 12, 6, 2 };

        var doubleNumbers = numbers.Select(x => x * 2);
        Printer.Print(doubleNumbers, nameof(doubleNumbers));

        var numbersAsStrings = numbers.Select(x => x.ToString());

        //var numbersWithoutDuplicate = numbers.Distinct();
        //Printer.Print(numbersWithoutDuplicate, nameof(numbersWithoutDuplicate));

        //var evenNumbers = numbers.Where(number => number % 2 == 0);
        //Printer.Print(evenNumbers, nameof(evenNumbers));

        //bool areAllLargerThanZero = numbers.Any(number => number > 10);
        //Printer.Print(areAllLargerThanZero, nameof(areAllLargerThanZero));

        //var differentNumbers = new[] { 16, 8, 9, -1, 2 };
        //var firstNumber = differentNumbers.First();
        //Printer.Print(firstNumber, nameof(firstNumber));

        //var firstOddNumber = differentNumbers.First(number => number % 2 == 1);
        //Printer.Print(firstOddNumber, nameof(firstOddNumber));

        //var isSevenPresent = differentNumbers.Contains(7);
        //Printer.Print(isSevenPresent, nameof(isSevenPresent));

        var words = new[] { "lion", "tiger", "snow leopard" };
        var toUpperCase = words.Select(x => x.ToUpper());

        var numberedWords = words.Select((word, index) => $"{index + 1}. {word}");

        //bool isTgerPresent = words.Contains("tiger");
        //Printer.Print(isTgerPresent, nameof(isTgerPresent));

        var pets = new[]
        {
            new Pet(1, "Hannibal", PetType.Fish, 1.1f),
            new Pet(2, "Anthony", PetType.Cat, 2f),
            new Pet(3, "Ed", PetType.Cat, 0.7f),
            new Pet(4, "Taiga", PetType.Dog, 35f),
            new Pet(5, "Rex", PetType.Dog, 40f),
            new Pet(6, "Lucky", PetType.Dog, 5f),
            new Pet(7, "Storm", PetType.Cat, 0.9f),
            new Pet(8, "Nyan", PetType.Cat, 2.2f)
        };

        var weights = pets.Select(pet => pet.Weight);

        var heavyPetTypes = pets
            .Where(pet => pet.Weight > 4)
            .Select(pet => pet.Type)
            .Distinct();

        var petsInitials = pets
            .OrderBy(pet => pet.Name)
            .Select(pet => $"{pet.Name.First()}."); //First will select first letter from string.

        var petsData = pets.Select(pet =>
            $"Pet named {pet.Name}, of type {pet.Type} " +
            $"and weight {pet.Weight}");

        //var petsHavierThan10Kg = pets.Where(pet => pet.Weight > 10);
        //Printer.Print(petsHavierThan10Kg, nameof(petsHavierThan10Kg));
        
        //var petsHavierThan100Kg = pets.Where(pet => pet.Weight > 100);
        //Printer.Print(petsHavierThan100Kg, nameof(petsHavierThan100Kg));

        //var indexesSelectedByUser = new[] { 1, 6, 7 };
        //var petsSelectedByUserAndLighterThan5Kilos = pets.Where((pet, index) => pet.Weight < 5 && indexesSelectedByUser.Contains(index));
        //Printer.Print(petsSelectedByUserAndLighterThan5Kilos, nameof(petsSelectedByUserAndLighterThan5Kilos));

        //var lastDog = pets.Last(pet => pet.Type == PetType.Dog);
        //Printer.Print(lastDog.Name, nameof(lastDog));

        //var lastPetHavierThan100 = pets.LastOrDefault(pet => pet.Weight > 100);
        //Printer.Print(lastPetHavierThan100, nameof(lastPetHavierThan100));

        //var haviestPetInCollections = pets.
        //    OrderByDescending(pet => pet.Weight)
        //    .First();
        //Printer.Print(haviestPetInCollections.Name, nameof(haviestPetInCollections));

        ////OrderBy creates a copy of the collection,
        ////which is ordered by the given criteria
        //var petsOrderedByName = pets.OrderBy(pet => pet.Name);
        //Printer.Print(petsOrderedByName, nameof(petsOrderedByName));

        //var petsOrderedByIdDescending = pets.OrderByDescending(pet => pet.Number);
        //Printer.Print(petsOrderedByIdDescending, nameof(petsOrderedByIdDescending));

        ////numbers of words we can simply order by themselves
        //var numbers = new[] { 16, 8, 9, -1, 2 };
        //var orderedNumbers = numbers.OrderBy(number => number);
        //Printer.Print(orderedNumbers, nameof(orderedNumbers));

        //var words = new[] { "lion", "tiger", "snow leopard" };
        //var orderedWords = words.OrderBy(word => word);
        //Printer.Print(orderedWords, nameof(orderedWords));

        ////we can order by some criteria, and then by other criteria
        //var petsOrderedByTypeThenName = pets
        //    .OrderBy(pet => pet.Type)
        //    .ThenBy(pet => pet.Name);
        //Printer.Print(petsOrderedByTypeThenName, nameof(petsOrderedByTypeThenName));

        //var petsOrderedByTypeDescendingThenIdDescending = pets
        //    .OrderByDescending(pet => pet.Type)
        //    .ThenByDescending(pet => pet.Number);
        //Printer.Print(petsOrderedByTypeDescendingThenIdDescending,
        //    nameof(petsOrderedByTypeDescendingThenIdDescending));

        ////we can use the Reverse method to Reverse the order of the collection
        //var petsReversed = pets.Reverse();
        //Printer.Print(petsReversed, nameof(petsReversed));



        //var countOfDogs = pets.Count(pet => pet.Type == PetType.Dog);
        //Console.WriteLine(countOfDogs);

        //var countOfPetsNamedBruce = pets.Count(pet => pet.Name == "Bruce");
        //Console.WriteLine("Bruce: " + countOfPetsNamedBruce);

        //var allSmallDogs = pets.Count(pet => pet.Type == PetType.Dog && pet.Weight < 10);
        //Console.WriteLine("Small dogs: " + allSmallDogs);

        //var allPetsCount = pets.Count();
        //Console.WriteLine("All pets: " + allPetsCount);

        //var doAllHaveNoneEmptyNames = pets.All(pet => !string.IsNullOrWhiteSpace(pet.Name));
        //Printer.Print(doAllHaveNoneEmptyNames, nameof(doAllHaveNoneEmptyNames));

        //var doAllPetsAreCats = pets.All(pet => pet.Type == PetType.Cat);
        //Printer.Print(doAllPetsAreCats, nameof(doAllPetsAreCats));

        //var isAnyPetNamedBruce = pets.Any(pet => pet.Name == "Bruce");
        //Printer.Print(isAnyPetNamedBruce, nameof(isAnyPetNamedBruce));

        //var isAnyFish = pets.Any(pet => pet.Type == PetType.Fish);
        //Printer.Print(isAnyFish, nameof(isAnyFish));

        //var isThereVerySpecificPet = pets.Any(pet => pet.Name.Length > 6 && pet.Number % 2 == 0);
        //Printer.Print(isThereVerySpecificPet, nameof(isThereVerySpecificPet));

        //var isNotEmpty = pets.Any();
        //Printer.Print(isNotEmpty, nameof(isNotEmpty)); //Return true if collection is not empty.

        Console.ReadKey();
    }
}

class Pet
{
    public int Number { get; set; }
    public string Name { get; set; }
    public PetType Type { get; set; }
    public float Weight { get; set; }

    public Pet(int number, string name, PetType type, float weight)
    {
        Number = number;
        Name = name;
        Type = type;
        Weight = weight;
    }
}

public enum PetType
{
    Fish,
    Cat,
    Dog
}

public static class Printer
{
    public static void Print<T>(T item, string itemName)
    {
        Console.WriteLine($"{itemName}: {item}");
    }

    public static void Print<T>(IEnumerable<T> collection, string collectionName)
    {
        Print(collection, collectionName, "collection");
    }

    public static void Print<T>(IOrderedEnumerable<T> collection, string collectionName)
    {
        Print(collection as IEnumerable<T>, collectionName, "collection");
    }

    public static void Print<T>(List<T> collection, string collectionName)
    {
        Print(collection as IEnumerable<T>, collectionName, "collection");
    }

    public static void Print<T>(HashSet<T> hashSet, string hashSetName)
    {
        Print(hashSet, hashSetName, "HashSet");
    }

    private static void Print<T>(IEnumerable<T> collection, string collectionName, string collectionType)
    {
        Console.WriteLine($"{collectionName}:");
        if (collection.Any())
        {
            Console.WriteLine(string.Join("\n", collection.Select(elem => elem.ToString())));
        }
        else
        {
            Console.WriteLine($"The {collectionType} is empty!");
        }
    }

    public static void Print<TKey, TValue>(Dictionary<TKey, TValue> dictionary, string dictionaryName)
    {
        Console.WriteLine($"{dictionaryName}:");
        if (dictionary.Any())
        {
            Console.WriteLine(string.Join("\n", dictionary.Select(
                elem => $"Key: {elem.Key}, Value: {elem.Value}")));
        }
        else
        {
            Console.WriteLine("The dictionary is empty!");
        }
    }

    public static void Print<TKey, TValue>(ILookup<TKey, TValue> lookup, string lookupName)
    {
        Console.WriteLine($"{lookupName}:");
        if (lookup.Any())
        {
            Console.WriteLine(string.Join("\n", lookup.Select(
                elem => $"Key: {elem.Key}, Values (count: {lookup[elem.Key].Count()}): {string.Join(", ", lookup[elem.Key])}")));
        }
        else
        {
            Console.WriteLine("The lookup is empty!");
        }
    }
}
