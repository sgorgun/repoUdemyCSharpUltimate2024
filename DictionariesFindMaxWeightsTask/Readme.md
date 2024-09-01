Dictionaries - FindMaxWeights of pets
Implement the FindMaxWeights method, which takes a collection of Pets (each having PetType and Weight properties) and returns a dictionary with a mapping from the PetType to the maximal weight of pets of this type.

For example, for the following input List:

Dog, 10 kilos
Cat, 5 kilos
Fish, 0.9 kilos
Dog, 45 kilos
Cat, 2 kilos
Fish, 0.02 kilos 
The result shall be a Dictionary like this:

Key: Dog, Value: 45
Key: Cat, Value: 5
Key: Fish, Value: 0.9 
Because the max weight for dogs is 45, for cats is 5, and for fish is 0.9 kilos.