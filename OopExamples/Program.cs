//var internationalPizzaDay23 = new DateTime(2023, 2, 9);

//Console.WriteLine("Year is " + internationalPizzaDay23.Year);
//Console.WriteLine("Month is " + internationalPizzaDay23.Month);
//Console.WriteLine("Day is " + internationalPizzaDay23.Day);
//Console.WriteLine("Day of week is " + internationalPizzaDay23.DayOfWeek);

//var internationalPizzaDay24 = internationalPizzaDay23.AddYears(1);

//Console.WriteLine();
//Console.WriteLine("Year is " + internationalPizzaDay24.Year);
//Console.WriteLine("Month is " + internationalPizzaDay24.Month);
//Console.WriteLine("Day is " + internationalPizzaDay24.Day);
//Console.WriteLine("Day of week is " + internationalPizzaDay24.DayOfWeek);





//var rectangle1 = new Rectangle(5, 10);
//var rectangle2 = new Rectangle(10, 8);

//Console.WriteLine("Count of Rectangle object is " + Rectangle.CountOfInstances);

////Console.WriteLine(Rectangle.DescribeGenerally());
////Console.WriteLine("width is " + rectangle1.Width);
////Console.WriteLine("height is " + rectangle1.GetHeight());
////Console.WriteLine("Area is " + rectangle2.CalculateRectangleArea(rectangle1));
////Console.WriteLine("Circumference is " + rectangle2.CalculateRectangleCircumference(rectangle1));

////Console.WriteLine($"1 + 2 is {Calculator.Add(1, 2)}");
////Console.WriteLine($"1 - 2 is {Calculator.Substract(1, 2)}");
////Console.WriteLine($"1 * 2 is {Calculator.Multiply(1, 2)}");

//Console.ReadKey();

//static class Calculator
//{
//    public static int Add(int a, int b) => a + b;
//    public static int Substract(int a, int b) => a - b;
//    public static int Multiply(int a, int b) => a * b;
//}

//class Rectangle
//{
//    public static int CountOfInstances { get; private set; }
//    private static DateTime _firstUsed;

//    static Rectangle()
//    {
//            _firstUsed = DateTime.Now;
//    }

//    public Rectangle(int width, int height)
//    {
//        Width = GetLenthOrDefault(width, nameof(Width));
//        _height = GetLenthOrDefault(height, nameof(_height));
//        ++CountOfInstances;
//    }

//    public int Width { get; }
//    private int _height;
//    public int GetHeight() => _height;

//    public void SetHeight(int value, int _height)
//    {
//        if (value > 0)
//        {
//            _height = value;
//        }
//    }

//    private int GetLenthOrDefault(int lenght, string name)
//    {
//        const int DefaultValueIfNonPoositive = 1;

//        if (lenght <= 0)
//        {
//            Console.WriteLine($"{name} must be a positive number.");
//            return DefaultValueIfNonPoositive;
//        }

//        return lenght;
//    }

//    public int CalculateRectangleCircumference(Rectangle rectangle) => 2 * Width + 2 * _height;
//    public int CalculateRectangleArea(Rectangle rectangle) => Width * _height;
//    public string Description => $"A rectangle with width {Width} " + $"and height {_height}";
//    public static string DescribeGenerally() => $"A plane figure with four straights sides and four right angles";
//    public static string NotUsingAnyState() => "abc";
//    public const int NumberOfSides = 4;
//}





//using System;

//namespace Coding.Exercise
//{
//    public class HotelBooking
//    {
//        public string GuestName;
//        public DateTime StartDate;
//        public DateTime EndDate;
//        public int LengthOfStayInDays;

//        public HotelBooking(string guestName, DateTime startDate, int lengthOfStayInDays)
//        {
//            GuestName = guestName;
//            StartDate = startDate;
//            LengthOfStayInDays = lengthOfStayInDays;
//            EndDate = startDate.AddDays(lengthOfStayInDays);
//        }
//    }
//}




//using System;

//namespace Coding.Exercise
//{
//    public class Triangle
//    {
//        private int _base;
//        private int _height;

//        public Triangle(int @base, int height)
//        {
//            _base = @base;
//            _height = height;
//        }

//        public int CalculateArea()
//        {
//            return (_base * _height) / 2;
//        }

//        public string AsString()
//        {
//            return $"Base is {_base}, height is {_height}";
//        }
//    }
//}




//var medicalAppointment = new MedicalAppointment("John Smith", new DateTime(2023, 4, 3));

//Console.ReadKey();

////owerrite month and day
//medicalAppointment.OverwriteMonthAndDay(5, 1);

////adds given nuber and days
//medicalAppointment.MoveByMonthsAndDays(1, 2);

//class MedicalAppointment
//{
//    private string _patientName;
//    private DateTime _date;

//    public MedicalAppointment(string patientName, DateTime date)
//    {
//        _patientName = patientName;
//        _date = date;
//    }

//    public void Reshedule(DateTime date)
//    {
//        _date = date;
//    }

//    public void OverwriteMonthAndDay(int month, int day)
//    {
//        _date = new DateTime(_date.Year, month, day);
//    }

//    public void MoveByMonthsAndDays(int monthsToAdd, int daysToAdd)
//    {
//        _date = new DateTime(_date.Year, _date.Month + monthsToAdd, _date.Day + daysToAdd);
//    }
//}





//var medicalAppointment = new MedicalAppointment("John Smith", new DateTime(2023, 4, 3));
//var appointmentTwoWeeksFromNow = new MedicalAppointment("Bob Smith", 14);
//var appointmentOneWeeksFromNow = new MedicalAppointment("Margaret Smith");
//var appointmentUnknownPatient = new MedicalAppointment();
//var nameOnly = new MedicalAppointment("Name only");
//medicalAppointment.Reshedule(new DateTime(2023, 5, 30));

//Console.ReadKey();

////owerrite month and day
//medicalAppointment.OverwriteMonthAndDay(5, 1);

////adds given nuber and days
//medicalAppointment.MoveByMonthsAndDays(1, 2);

//class MedicalAppointmentPrinter
//{
//    public void Print(MedicalAppointment medicalAppointment)
//    {
//        Console.WriteLine("Appointment will take place on " + medicalAppointment.GetDate());
//    }
//}

//class MedicalAppointment
//{
//    private string _patientName;
//    private DateTime _date;

//    public DateTime GetDate() => _date;

//    public MedicalAppointment(string patientName, DateTime date)
//    {
//        _patientName = patientName;
//        _date = date;
//    }

//    public void Reshedule(DateTime date)
//    {
//        _date = date;
//        var printer = new MedicalAppointmentPrinter();
//        printer.Print(this);
//    }

//    //public MedicalAppointment(string patientName) : this(patientName, 7)
//    //{
//    //}

//    public MedicalAppointment(string patientName = "Unknown", int daysFromNow = 7)
//    {
//        _patientName = patientName;
//        _date = DateTime.Now.AddDays(daysFromNow);
//    }

//    public void OverwriteMonthAndDay(int month, int day)
//    {
//        _date = new DateTime(_date.Year, month, day);
//    }

//    public void MoveByMonthsAndDays(int monthsToAdd, int daysToAdd)
//    {
//        _date = new DateTime(_date.Year, _date.Month + monthsToAdd, _date.Day + daysToAdd);
//    }
//}





//using System;

//namespace Coding.Exercise
//{
//    public class Dog
//    {
//        private string _name;
//        private string _breed;
//        private int _weight;

//        public Dog(string name, string breed, int weight)
//        {
//            _name = name;
//            _breed = breed;
//            _weight = weight;
//        }

//        public Dog(string name, int weight) : this (name, "mixed-breed",  weight)
//        {
//        }

//        public string Describe()
//        {
//            return $"This dog is named {_name}, it's a {_breed}, and it weighs {_weight} kilograms, so it's a {GetSize()} dog.";
//        }

//        private string GetSize()
//        {
//            if (_weight < 5)
//            {
//                return "tiny";
//            }

//            if (_weight < 30)
//            {
//                return "medium";
//            }

//            return "large";

//        }
//    }
//}





//using System;
//using static System.Runtime.InteropServices.JavaScript.JSType;

//namespace Coding.Exercise
//{
//    public class Order
//    {
//        private DateTime _date;

//        public DateTime Date
//        {
//            get { return _date; }
//            set 
//            {
//                if (value.Year == DateTime.Now.Year)
//                {
//                    _date = value;
//                }
//            }
//        }

//        public string Item { get; }


//        public Order(string item, DateTime date)
//        {
//            Item = item;
//            Date = date;
//        }
//    }
//}





//var person = new Person("John", 1981);
//var person = new Person
//{
//    Name = "John",
//    YearOfBirth = 1981
//};

//Console.ReadKey();

//class Person
//{
//    public string Name { get; set; }
//    public int YearOfBirth { get; init; }

//public Person(string name )
//{
//    Name = name;
//}

//public Person(string name, int yearOfBirth)
//{
//    Name = name;
//    YearOfBirth = yearOfBirth;
//}
//}





//using System;

//namespace Coding.Exercise
//{
//    public class DailyAccountState
//    {
//        public int InitialState { get; }

//        public int SumOfOperations { get; }

//        public DailyAccountState(
//            int initialState,
//            int sumOfOperations)
//        {
//            InitialState = initialState;
//            SumOfOperations = sumOfOperations;
//        }

//        public int EndOfDayState => InitialState + SumOfOperations;
//        public string Report => $"Day: {DateTime.Now.Day}, month: {DateTime.Now.Month}, year: {DateTime.Now.Year}, initial state: {InitialState}, end of day state: {EndOfDayState}";
//    }
//}





//using System;

//namespace Coding.Exercise
//{
//    public static class NumberToDayOfWeekTranslator
//    {
//        public static string Translate(int number)
//        {
//            switch (number)
//            {
//                case 1:
//                    return "Monday";
//                case 2:
//                    return "Tuesday";
//                case 3:
//                    return "Wednesday";
//                case 4:
//                    return "Thursday";
//                case 5:
//                    return "Friday";
//                case 6:
//                    return "Saturday";
//                case 7:
//                    return "Sunday";
//                default:
//                    return "Invalid day of the week";
//            }
//        }
//    }
//}





//using System;

//namespace Coding.Exercise
//{
//    public static class StringsTransformator
//    {
//        public static string TransformSeparators(
//            string input,
//            string originalSeparator,
//            string targetSeparator)
//        {
//            string[] result = input.Split(originalSeparator);
//            return string.Join(targetSeparator, result);
//        }
//    }
//}





//using System.Diagnostics;

//var stopwath = Stopwatch.StartNew();
//for (int i = 0; i < 1000; i++)
//{
//    Console.WriteLine($"Loop number {i}");
//}
//stopwath.Stop();
//Console.WriteLine("Time in ms: " + stopwath.ElapsedMilliseconds);
//Console.ReadLine();





//var pizza = new Pizza();
//Console.WriteLine(pizza.number);
//Console.WriteLine(pizza.date);
//Console.WriteLine(pizza.ingredient);
//pizza.AddIngredient(new Cheddar());
//pizza.AddIngredient(new Mozzarella());
//pizza.AddIngredient(new TomatoSause());

//Console.WriteLine(pizza.ToString());

//var ingredient = new Ingredient(1);
//ingredient.PublicField = 10;

//Console.WriteLine("Variable of type Cheddar");
//Cheddar chedar = new Cheddar(); 
//Console.WriteLine(chedar.Name);
//Console.WriteLine();
//Console.WriteLine("Variable of type Ingredient");
//Ingredient ingredient = new Cheddar();
//Console.WriteLine(ingredient.Name);

//chedar.PublicField = 20;

//Console.WriteLine("Value in igredient: " + ingredient.PublicField);
//Console.WriteLine("Value in igredient: " + chedar.PublicField);
//Console.WriteLine(chedar.PublicMethod());
//Console.WriteLine(chedar.PrivateMethod());
//Console.WriteLine(chedar.ProtectedMethod());

//var ingredients = new List<Ingredient>
//{
//    new Cheddar(),
//    new Mozzarella(),
//    new TomatoSause()
//};

//Console.WriteLine();
//foreach (var ingredient in ingredients)
//{
//    Console.WriteLine(ingredient.Name);
//}

//var cheddar = new Cheddar(1, 4);

//Console.WriteLine(cheddar);
//Console.WriteLine(new TomatoSause());
//Console.WriteLine(cheddar);

//Ingredient ingredient = new Cheddar(2, 12);

//using System.Threading.Channels;

//Ingredient ingredient = GenerateRandomIngredient();
//Console.WriteLine("Ingredient is" + ingredient);
//Cheddar cheddar = ingredient as Cheddar;
//if (cheddar is not null)
//{
//    Console.WriteLine(cheddar.Name);
//}

//else
//{
//    Console.WriteLine("Conversion failed");
//}
//if (randomIngredient is Cheddar)
//{
//    Cheddar cheddar = (Cheddar)randomIngredient;
//    Console.WriteLine("cheddar object: " + cheddar);
//}

//Console.WriteLine("Random ingredirnt is" + randomIngredient);
//Cheddar chedar = (Cheddar)randomIngredient;

//var cheddar = new Cheddar(2, 12);
//var tomatoSause = new TomatoSause(1);
//cheddar.Prepare();
//tomatoSause.Prepare();

//var ingredients = new List<Ingredient>
//{
//    new Cheddar(2,10),
//    new Mozzarella(2),
//    new TomatoSause(1),
//};

//foreach (var ingredient in ingredients)
//{
//    ingredient.Prepare();
//}

//var pizza = RandomPizzaGenerator.Generate(3);

//var multilineText = @"aaa
//bbb
//ccc
//ddd";

//Console.WriteLine("Count of lines is " + CountLines(multilineText));

//Console.ReadKey();

//int CountLines(string input) => input.Split(Environment.NewLine).Length;

//public static class RandomPizzaGenerator
//{

//    public static Pizza Generate(int hoqManyIngredients)
//    {
//        var pizza = new Pizza();
//        for (int i = 0; i < hoqManyIngredients; i++)
//        {
//            var randomIngredient = GenerateRandomIngredient();
//            pizza.AddIngredient(randomIngredient);
//        }

//        return pizza;
//    }

//    private static Ingredient GenerateRandomIngredient()
//    {
//        var random = new Random();
//        var number = random.Next(1, 4);
//        if (number == 1) { return new Cheddar(2, 12); }
//        if (number == 2) { return new TomatoSause(1); }
//        else return new Mozzarella(2);
//    }
//}

//public class Pizza
//{
//    public int number;
//    public DateTime date;
//    public Ingredient ingredient;

//    private List<Ingredient> _ingredients = new List<Ingredient>();

//    public void AddIngredient(Ingredient ingredient) => _ingredients.Add(ingredient);

//    public override string ToString() => $"This is a pizza with  {string.Join(", ", _ingredients)}";
//}

//public abstract class Ingredient
//{
//    public Ingredient(int priceIfExtraTopping)
//    {
//        Console.WriteLine("CONSRUCTOR FROM THE INGREDIENT CLASS");
//        PriceIfExtraTopping = priceIfExtraTopping;
//    }

//    public int PriceIfExtraTopping { get; }

//    public override string ToString() => Name;

//    public virtual string Name { get; } = "Some ingredient";

//    public abstract void Prepare();

//    public int PublicField;

//    public string PublicMethod() => "This method PUBLIC in the Ingredient class.";

//    protected string ProtectedMethod() => "This method PROTECTED in the Ingredient class.";

//    private string PrivateMethod() => "This method PRIVATE in the Ingredient class.";
//}

//public abstract class Cheese : Ingredient
//{
//    public Cheese(int priceIfExtraTopping) : base(priceIfExtraTopping)
//    {
//    }
//}
//public class Cheddar : Ingredient
//{
//    public Cheddar(int priceIfExtraTopping, int agedForMonth) : base(priceIfExtraTopping)
//    {
//        AgedForMonth = agedForMonth;
//        Console.WriteLine("Constructor from the Cheddar class");
//    }
//    public override string Name => $"{base.Name}, more specifically, a Cheddar cheese aged for {AgedForMonth} month";
//    public int AgedForMonth { get; }

//    public override void Prepare() => Console.WriteLine("Grate anf spinkle over pizza.");

//    public void UseMethodsFromBaseClass()
//    {
//        Console.WriteLine(PublicMethod());
//        Console.WriteLine(ProtectedMethod());
//        //Console.WriteLine(PrivateMethod());
//    }
//}

//public class ItalianFoodItem
//{

//}

//public class Mozzarella : Cheese
//{
//    public Mozzarella(int priceIfExtraTopping) : base(priceIfExtraTopping)
//    {
//    }

//    public override string Name => "Mozzarella";
//    public int IsLight { get; }

//    public override void Prepare() => Console.WriteLine("Slice thinly and plase on top of the pizza.");
//}

//public class TomatoSause : Ingredient
//{
//    public TomatoSause(int priceIfExtraTopping) : base(priceIfExtraTopping)
//    {
//    }

//    public override string Name => "Tomato sause";
//    public int TomatosIn100Grams { get; }

//    public override void Prepare() => Console.WriteLine("Cook tomatos with basil, garlic and salt. Spread on pizza.");
//}





//using System.Globalization;

//var numbers = new List<int> { 1, 4, 6, -1, 12, 44, -8, -19 };
//bool shallAddPositiveOnly = true;
//NumbersSumCalculator calculator =
//    shallAddPositiveOnly ?
//    new PositveNumbersSumCalculator() :
//    new NumbersSumCalculator();

//int sum =calculator.Calculate(numbers);
//Console.WriteLine( "Sum is: " + sum);
//Console.ReadKey();

//internal class NumbersSumCalculator
//{
//    public int Calculate(List<int> numbers)
//    {
//        int sum = 0;
//        foreach (var number in numbers)
//        {
//            if (ShallBeAdded(number))
//            {
//                sum += number; 
//            }
//        }
//        return sum;
//    }

//    protected virtual bool ShallBeAdded(int number)
//    {
//        return true;
//    }
//}

//internal class PositveNumbersSumCalculator
//    : NumbersSumCalculator
//{
//    protected override bool ShallBeAdded(int number)
//    {
//        return number > 0;
//    }
//}






//using System;

//namespace Coding.Exercise
//{
//    public class Exercise
//    {
//        public List<int> GetCountsOfAnimalsLegs()
//        {
//            var animals = new List<Animal>
//            {
//                new Lion(),
//                new Tiger(),
//                new Duck(),
//                new Spider()
//            };

//            var result = new List<int>();
//            foreach (var animal in animals)
//            {
//                result.Add(animal.NumberOfLegs);
//            }
//            return result;
//        }
//    }

//    public class Animal
//    {
//        public virtual int NumberOfLegs { get;  } = 4;
//    }

//    public class Lion : Animal
//    {
//    }

//    public class Tiger : Animal
//    {
//    }    

//    public class Duck : Animal
//    {
//        public override int NumberOfLegs { get; } = 2;
//    }    

//    public class Spider : Animal
//    {
//        public override int NumberOfLegs { get; } = 8;
//    }
//}






//using System;

//namespace Coding.Exercise
//{
//    public class Exercise
//    {
//        public List<string> ProcessAll(List<string> words)
//        {
//            var stringsProcessors = new List<StringsProcessor>
//                {
//                    new StringsTrimmingProcessor(),
//                    new StringsUppercaseProcessor()
//                };

//            List<string> result = words;
//            foreach (var stringsProcessor in stringsProcessors)
//            {
//                result = stringsProcessor.Process(result);
//            }
//            return result;
//        }
//    }

//    public class StringsProcessor
//    {
//        public List<string> Process(List<string> strings)
//        {
//            var result = new List<string>();
//            foreach (var text in strings)
//            {
//                result.Add(ProcessSingle(text));
//            }
//            return result;
//        }

//        protected virtual string ProcessSingle(string input) => input;
//    }

//    public class StringsTrimmingProcessor : StringsProcessor
//    {
//        protected override string ProcessSingle(string input) => input.Substring(0, input.Length / 2);
//    }

//    public class StringsUppercaseProcessor : StringsProcessor
//    {
//        protected override string ProcessSingle(string input) => input.ToUpper();
//    }
//}


//int integer = 10;
//decimal b = integer;

//decimal c = 1000000000000000000000000000.01m;
//int d = (int)c;

//Console.ReadKey();


//using System;

//namespace Coding.Exercise
//{
//    public class HotelBooking
//    {
//        public string GuestName;
//        public DateTime StartDate;
//        public DateTime EndDate;

//        public HotelBooking(string guestName, DateTime startDate, int lengthOfStayInDays)
//        {
//            GuestName = guestName;
//            StartDate = startDate;
//            EndDate = startDate.AddDays(lengthOfStayInDays);
//        }
//    }
//}





//using System;

//namespace Coding.Exercise
//{
//    public static class NumericTypesDescriber
//    {
//        public static string Describe(object someObject)
//        {

//            if (someObject is int)
//            {
//                return $"Int of value {someObject}";
//            }
//            else if (someObject is double)
//            {
//                return $"Double of value {someObject}";
//            }
//            else if (someObject is decimal)
//            {
//                return $"Decimal of value {someObject}";
//            }
//            return null;
//        }
//    }
//}






//using System;

//namespace Coding.Exercise
//{
//    public static class ExerciseShapes
//    {
//        public static List<double> GetShapesAreas(List<Shape> shapes)
//        {
//            var result = new List<double>();

//            foreach (var shape in shapes)
//            {
//                result.Add(shape.CalculateArea());
//            }

//            return result;
//        }
//    }

//    public abstract class Shape
//    {
//        public abstract double CalculateArea();
//    }

//    public class Square : Shape
//    {
//        public double Side { get; }

//        public Square(double side)
//        {
//            Side = side;
//        }

//        public override double CalculateArea() => Side * Side;
//    }


//    public class Rectangle : Shape
//    {
//        public double Width { get; }
//        public double Height { get; }

//        public Rectangle(double width, double height)
//        {
//            Width = width;
//            Height = height;
//        }

//        public override double CalculateArea() => Width * Height;
//    }

//    public class Circle : Shape
//    {
//        public double Radius { get; }

//        public Circle(double radius)
//        {
//            Radius = radius;
//        }

//        public override double CalculateArea() => Radius * Radius * Math.PI;
//    }
//}


//using System;

//namespace Coding.Exercise
//{
//    public static class EverySecond
//    {
//        public static List<int> TakeEverySecond(this List<int> input)
//        {
//            List<int> output = new List<int>();
//            for (int i = 0; i < input.Count; i += 2)
//            {
//                output.Add(input[i]);
//            }

//            return output;
//        }
//    }
//}



//namespace Polimorphism.Flyables
//{
//    public interface IFlyable
//    {
//        void Fly();
//    }

//    public interface IFuelable
//    {
//        void Fuel();
//    }

//    public class Bird : IFlyable
//    {
//        public void Tweet() => Console.WriteLine("Tweet, tweet!");

//        public void Fly() => Console.WriteLine("Flying using its wings.");
//    }

//    public class Kite : IFlyable
//    {
//        public void Fly() => Console.WriteLine("Flying carried by the wind.");
//    }

//    public class Plane : IFlyable, IFuelable
//    {
//        public void Fly() => Console.WriteLine("Flying using jet propulsion");

//        public void Fuel() => Console.WriteLine("Filling tank with jet fuel.");
//    }
//}







//using System;

//namespace Coding.Exercise
//{
//    public static class Exercise
//    {
//        public static int Transform(
//            int number)
//        {
//            var transformations = new List<INumericTransformation>
//            {
//                new By1Incrementer(),
//                new By2Multiplier(),
//                new ToPowerOf2Raiser()
//            };

//            var result = number;
//            foreach (var transformation in transformations)
//            {
//                result = transformation.Transform(result);
//            }
//            return result;
//        }
//    }

//    public interface INumericTransformation
//    {
//        int Transform(int number);
//    }

//    public class By1IncrementerBy1Incrementer : INumericTransformation
//    {
//        public int Transform(int number) => ++number;
//    }

//    public class By2Multiplier : INumericTransformation
//    {
//        public int Transform(int number) => number * 2;
//    }

//    public class ToPowerOf2Raiser : INumericTransformation
//    {
//        public int Transform(int number) => number * number;
//    }
//}





//using Microsoft.VisualBasic;
//using System.Globalization;
//using System.Text.Json;

//var person = new Person
//{
//    FirstName = "John",
//    LastName = "Smith",
//    YearOfBirth = 1972
//};

//var asJson = JsonSerializer.Serialize(person);
//Console.WriteLine("As JSON:");
//Console.WriteLine(asJson);

//var personJson = "{\"FirstName\":\"John\",\"LastName\":\"Smith\",\"YearOfBirth\":1972}";

//var personFromJson = JsonSerializer.Deserialize<Person>(personJson);

//Console.ReadKey();

//public class Person
//{
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//    public int YearOfBirth { get; set;}
//}






//using System;

//namespace Coding.Exercise
//{
//    public class Exercise
//    {
//        public List<string> GetOnlyUpperCaseWords(List<string> words)
//        {
//            var result = new List<string>();
//            foreach (var word in words)
//            {
//                bool isWordUpperCase = true;

//                if (result.Contains(word))
//                {
//                    continue;
//                }

//                foreach (char letter in word)
//                {
//                    if (!char.IsUpper(letter))
//                    {
//                        isWordUpperCase = false;
//                    }
//                }

//                if (isWordUpperCase)
//                {
//                    result.Add(word);
//                }
//            }
//            return result;
//        }
//    }
//}
