using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int> { 5, 9, 2, 12, 6 };
        bool isLargerThan10 = numbers.Any(number => number > 10);
        Console.WriteLine(isLargerThan10);

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

        var isAnyPetNamedBruce = pets.Any(pet => pet.Name == "Bruce");
        Printer.Print(isAnyPetNamedBruce, nameof(isAnyPetNamedBruce));

        var isAnyFish = pets.Any(pet => pet.Type == PetType.Fish);
        Printer.Print(isAnyFish, nameof(isAnyFish));

        var isThereVerySpecificPet = pets.Any(pet => pet.Name.Length > 6 && pet.Number % 2 == 0);
        Printer.Print(isThereVerySpecificPet, nameof(isThereVerySpecificPet));

        var isNotEmpty = pets.Any();
        Printer.Print(isNotEmpty, nameof(isNotEmpty)); //Return true if collection is not empty.

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

class Printer
{
    public static void Print(bool value, string name)
    {
        Console.WriteLine($"{name}: {value}");
    }
}