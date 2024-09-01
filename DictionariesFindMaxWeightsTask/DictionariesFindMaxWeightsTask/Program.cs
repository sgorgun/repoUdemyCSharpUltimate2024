using System;

namespace Coding.Exercise
{
    public static class Exercise
    {
        public static void Main()
        {
            // Create some pets
            var pets = new List<Pet>
                {
                    new Pet(PetType.Dog, 10.5),
                    new Pet(PetType.Cat, 7.2),
                    new Pet(PetType.Fish, 0.5),
                    new Pet(PetType.Dog, 15.3),
                    new Pet(PetType.Cat, 5.1),
                    new Pet(PetType.Fish, 0.8)
                };

            // Find the maximum weights per pet type
            var maxWeights = FindMaxWeights(pets);

            // Print the results
            foreach (var kvp in maxWeights)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} kilos");
            }
        }

        public static Dictionary<PetType, double> FindMaxWeights(List<Pet> pets)
        {
            var petsPerPetTypes = new Dictionary<PetType, List<Pet>>();

            foreach (var pet in pets)
            {
                if (!petsPerPetTypes.ContainsKey(pet.PetType))
                {
                    petsPerPetTypes[pet.PetType] = new List<Pet>();
                }
                petsPerPetTypes[pet.PetType].Add(pet);
            }

            var result = new Dictionary<PetType, double>();

            foreach (var petPerPetsType in petsPerPetTypes)
            {
                double maxWeight = 0;

                foreach (var pet in petPerPetsType.Value)
                {
                    if (pet.Weight > maxWeight)
                    {
                        maxWeight = pet.Weight;
                    }
                }

                result[petPerPetsType.Key] = maxWeight;
            }

            return result;
        }
    }

    public class Pet
    {
        public PetType PetType { get; }
        public double Weight { get; }

        public Pet(PetType petType, double weight)
        {
            PetType = petType;
            Weight = weight;
        }

        public override string ToString() => $"{PetType}, {Weight} kilos";
    }

    public enum PetType { Dog, Cat, Fish }
}