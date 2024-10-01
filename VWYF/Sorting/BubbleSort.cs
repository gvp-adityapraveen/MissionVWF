using System;

namespace Sorting
{
    public class BubbleSort
{
    private int[] numbers;

    public BubbleSort()
    {
        numbers = new int[5];
        numbers[0] = 10;
        numbers[1] = 8;
        numbers[2] = 18;
        numbers[3] = 4;
        numbers[4] = 8;
    }
    public void Sort()
    {
        for(int i=numbers.Length-1; i>0; i--)
        {
            int temp;
            for(int j=0;j<i; j++)
            {
                if(numbers[j] > numbers[j+1])
                {
                    temp = numbers[j+1];
                    numbers[j+1] = numbers[j];
                    numbers[j] = temp;
                }
            }
        }
        for(int i=0;i<numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}
}