
//var userInput = Console.ReadLine();

//do
//{
//    userInput += 'a';
//    Console.WriteLine(userInput);
//} 
//while (userInput.Length < 15); 

//Console.WriteLine("The loop is the finished");
//string word;
//do
//{
//    Console.WriteLine("Enter a word longer then 10 letters"); 
//    word = Console.ReadLine();
//} 
//while (word.Length <= 10);
//do
//{
//    Console.WriteLine("Enter a word shorter then 3 letters");
//    word = Console.ReadLine();
//} while (word.Length >= 3);

//for (int i = 0; i < 5; ++i)
//{
//    Console.WriteLine("Loop run " + i);
//}

//for (var i = 0; i < 100; ++i)
//{
//    Console.WriteLine("i is " + i);
//    if (i > 25)
//    {
//        break;
//    }
//}



//int userNumber;
//do
//{
//    Console.WriteLine("Enter number lager than 10:");
//    var userInput = Console.ReadLine();

//    if (userInput == "stop")
//    {
//        break;
//    }

//    bool isParsableToInt = userInput.All(char.IsDigit);
//    if (!isParsableToInt)
//    {
//        userNumber = 0;
//        continue;
//    }

//    userNumber = int.Parse(userInput);
//} while (userNumber <= 10);


//for (var i = 0; i < 20; ++i)
//{
//    if (i % 3 != 0)
//    {
//        continue;
//    }
//    Console.WriteLine("i is " + i);
//}


//for (int i = 0; i < 4; ++i)
//{
//    for (int j = 0; j < 3; ++j)
//    {
//        Console.WriteLine($"i is {i}, j is {j}");
//    }
//}
//Console.WriteLine("The loop is the finished");
//Console.ReadKey();



//var numbers = new[] { 2, 6, 1, 6, 19 };

//var sum = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    sum += numbers[i];
//}

//Console.WriteLine("Sum of elements is " + sum);

//var firstFromEnd = numbers[^1];
//var secondFromEnd = numbers[^2];
//Console.WriteLine("First from the end: " +  firstFromEnd);
//Console.WriteLine("Second from the end: " + secondFromEnd);

//Console.WriteLine();
//Console.WriteLine("Element of index 0 is " + numbers[0]);
//Console.WriteLine("Element of index 1 is " + numbers[1]);
//Console.WriteLine("Element of index 2 is " + numbers[2]);


//char[,] letters = new char[2, 3];
//letters[0, 0] = 'A';
//letters[0, 1] = 'B';
//letters[0, 2] = 'C';
//letters[1, 0] = 'D';
//letters[1, 1] = 'E';
//letters[1, 2] = 'F';

//var height = letters.GetLength(0);
//var width = letters.GetLength(1);
//Console.WriteLine("Height is " + height);
//Console.WriteLine("Width is " + width);
//for (int i = 0; i < height; i++)
//{
//    Console.WriteLine("i is " + i);
//    for (int j = 0; j < width; j++)
//    {
//        Console.WriteLine("j is " + j);
//        Console.WriteLine("Element is " + letters[i,j]);
//    }
//}

//var letters2 = new char[,]
//{
//    { 'A', 'B', 'C' },
//    { 'D', 'E', 'F' },
//};



//using System;

//namespace Coding.Exercise
//{
//    public class Exercise
//    {
//        public static int FindMax(int[,] numbers)
//        {
//            if (numbers.Length == 0)
//            {
//                return -1;
//            }

//            var height = numbers.GetLength(0);
//            var width = numbers.GetLength(1);
//            int result = 0;

//            for (int i = 0; i < height; ++i)
//            {
//                for (int j = 0; j < width; ++j)
//                {
//                    if (numbers[i, j] > result)
//                    {
//                        result = numbers[i, j];
//                    }
//                }
//            }

//            return result;
//        }
//    }
//}



//var words = new[,]
//{
//    { "one", "two", "three", "four" },
//    { "five", "six", "seven", "eight"}
//};

//foreach(var word in words)
//{
//    Console.WriteLine(word);
//}



//var words = new List<string>
//{
//    "one",
//    "two",
//} ;
//Console.WriteLine("Count elements is " + words.Count);
//words.Add("hello");
//Console.WriteLine("Count elements is " + words.Count);

//words[0] = "uno";
//words[1] = "due";

//foreach (var word in words)
//{
//    Console.WriteLine(word);
//}

//Console.WriteLine("Removing an item");
//words.Remove("due");
//foreach (var word in words)
//{
//    Console.WriteLine(word);
//}
//Console.WriteLine("Removing an item");
//words.RemoveAt(0);
//foreach (var word in words)
//{
//    Console.WriteLine(word);
//}

//Console.WriteLine("Adding range");
////var newWords = new[] { "three", "four", "five" };
////words.AddRange(newWords);
//words.AddRange(new[] { "three", "four", "five" });
//foreach (var word in words)
//{
//    Console.WriteLine(word);
//}

//Console.WriteLine("Index of element 'four' is " + words.IndexOf("four") );
//Console.WriteLine("Index of element 'seven' is " + words.IndexOf("seven") + " <- not in list");

//words.Clear();
//Console.WriteLine("List after clear " + words.Count);



//using System;
//using System.Collections.Generic;

//namespace Coding.Exercise
//{
//    public class Exercise
//    {
//        public List<string> GetOnlyUpperCaseWords(List<string> words)
//        {
//            var result = new List<string>();
//            foreach (var word in words)
//            {
//                if (result.Contains(word))
//                {
//                    continue;
//                }
//                bool isWordUpperCase = true;
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

//        bool IsUpperCase(string word)
//        {
//            foreach (char letter in word)
//            {
//                if (!char.IsUpper(letter))
//                {
//                    return false;
//                }
//            }
//            return true;
//        }
//    }
//}



//using System;
//using System.Collections.Generic;

//namespace Coding.Exercise
//{
//    public class Exercise
//    {
//        public List<string> GetOnlyUpperCaseWords(List<string> words)
//        {
//            var result = new List<string>();
//            foreach (var word in words)
//            {
//                if (result.Contains(word))
//                {
//                    continue;
//                }
//                bool isWordUpperCase = true;
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

//        bool IsUpperCase(string word)
//        {
//            foreach (char letter in word)
//            {
//                if (!char.IsUpper(letter))
//                {
//                    return false;
//                }
//            }
//            return true;
//        }
//    }
//}



//using System.Xml;
//using System.Xml.XPath;

//var numbers = new[] { 10, -8, 2, 12, -17 };
//int nonPositiveCount;
//var onlyPositive = GetOnlyPositive(numbers, out nonPositiveCount);
//foreach (var positiveNumber in onlyPositive)
//{
//    Console.WriteLine(positiveNumber);
//}

//Console.WriteLine("Count of non positive: " + nonPositiveCount);
//Console.ReadKey();

//List<int> GetOnlyPositive(int[] numbers, out int countOfNonPosotive)
//{
//    countOfNonPosotive = 0;
//    var result = new List<int>();

//    foreach (var number in numbers)
//    {
//        if (number > 0)
//        {
//            result.Add(number);
//        }
//        else
//        {
//            countOfNonPosotive++;
//        }
//    }
//    return result;
//}



//bool isParsingSuccessful;

//do
//{
//    Console.WriteLine("Enter a number:");
//    var userInput = Console.ReadLine();

//    isParsingSuccessful = int.TryParse(userInput, out int number);

//    if (isParsingSuccessful)
//    {
//        Console.WriteLine("Parsing worked, number is " + number);
//    }
//    else
//    {
//        Console.WriteLine("Parsing was not successful.");
//    }
//} while (!isParsingSuccessful);

//Console.ReadKey();