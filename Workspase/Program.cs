using System;

class Program
{
    static void Main()
    {
        int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        int k = RemoveDuplicates(nums);
        foreach (var item in nums)
        {
            Console.Write(item + " |");
        }
        Console.WriteLine();
        Console.WriteLine(k);
        Console.ReadKey();
    }

    public static int RemoveDuplicates(int[] nums)
    {
        int k = 1;
        int previouse = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != previouse)
            {
                nums[k] = nums[i];
                k++;
            }
            previouse = nums[i];
        
        }
        return k;
    }
}
