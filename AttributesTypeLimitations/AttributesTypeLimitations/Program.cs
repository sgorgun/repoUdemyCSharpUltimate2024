[Some(new int[] { 1, 2, 3 })]
public class SoneClass
{

}

public class SomeAttribute : Attribute
{
    public SomeAttribute(int[] numbers)
    {
        Numbers = numbers;
    }

    public int[] Numbers { get; }
}