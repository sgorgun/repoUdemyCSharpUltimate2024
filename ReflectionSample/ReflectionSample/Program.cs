
using System.ComponentModel.DataAnnotations;
using System.Reflection;

var validPerson = new Person("John", 1981);
var invalidDog = new Dog("R");
var validator = new Validator();

Console.WriteLine(validator.Validate(validPerson) ?
    "Valid person" :
    "Invalid person");

Console.WriteLine(validator.Validate(invalidDog) ?
    "Valid dog" :
    "Invalid dog");

Console.ReadKey();

public class Dog
{
    [StringLengthValidate(2, 10)]
    public string Name { get; } // length must be betwin 2 and 10
    public Dog(string name) => Name = name;
}

public class Person
{
    [StringLengthValidate(2, 25)]
    public string Name { get; } // length must be betwin 2 and 25
    public int YearOfBirth { get; }

    public Person(string name, int yearOfBirth)
    {
        Name = name;
        YearOfBirth = yearOfBirth;
    }

    public Person(string name) => Name = Name; // length must be betwin 2 and 25
}


[AttributeUsage(AttributeTargets.Property)]
class StringLengthValidateAttribute : Attribute
{
    public int Min { get; }
    public int Max { get; }

    public StringLengthValidateAttribute(int min, int max)
    {
        Min = min;
        Max = max;
    }
}

class Validator
{
    public bool Validate(object obj)
    {
        var type = obj.GetType();
        var prppertiesToValidate = type
            .GetProperties()
            .Where(property => Attribute.IsDefined(
                property, typeof(StringLengthValidateAttribute)));

        foreach (var property in prppertiesToValidate)
        {
            object propertyValue = property.GetValue(obj);
            if (propertyValue is not string)
            {
                throw new InvalidOperationException(
                    $"Attribute {nameof(StringLengthValidateAttribute)}" +
                    $" can only be applied to strings");
            }

            var value = (string)propertyValue;
            var attribute = (StringLengthValidateAttribute)property
                .GetCustomAttributes(
                typeof(StringLengthValidateAttribute), true)
                .First();
            if (value.Length < attribute.Min || value.Length > attribute.Max)
            {
                Console.WriteLine($"Property {property.Name} is invalid" +
                    $"Value is {value}");
                return false;
            }
        }
        return true;
    }
}
