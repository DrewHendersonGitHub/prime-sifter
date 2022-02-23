using System;
using System.Collections.Generic;

class Prime
{
  static void Main()
  {
    List<int> numberList = new List<int> {};
    Console.WriteLine("Enter a number:");
    int max = int.Parse(Console.ReadLine());
    
    for (int i = 2; i <= max; i++) 
    {
      numberList.Add(i);
    }
    for (int i = 2; i < max / 2; i++)
    {
      for (int g = 2 * i; g <= max; g += i)
      {
        for(int p = numberList.Count - 1; p > -1; p--)
        {
          if(numberList[p] == g)
          {
            numberList.RemoveAt(p);
          }
        }
      }
    }
    foreach (int number in numberList)
    {
      Console.WriteLine(number.ToString());
    }
  }
}