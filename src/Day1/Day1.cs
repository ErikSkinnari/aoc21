using static aoc21.Helpers;

namespace aoc21
{

public class Day1
{
  private List<int> numbers;

  public Day1()
  {
    numbers = GetNumbers();      
  }
  public void Run()
  {
    Console.WriteLine(Part1());
    Console.WriteLine(Part2());
  }
  private string Part1()
  {
    int counter = 0;
    for (int i = 1; i < numbers.Count(); i++) counter = numbers[i] > numbers[i - 1] ? counter + 1 : counter;

    return counter.ToString();
  }

  private string Part2()
  {
    List<int> numbers = GetNumbers();
    int counter = 0;
    for (int i = 3; i < numbers.Count(); i++) 
    {
      var a = numbers[i] + numbers[i-1] + numbers[i-2];
      var b = numbers[i-1] + numbers[i-2] + numbers[i-3];
      counter = a > b ? counter + 1 : counter;
    }

    return counter.ToString();
  }

  private static List<int> GetNumbers()
  {
    string path = @"C:\src\aoc21\src\day1\input.txt";
    string[] input = GetInput(path);
    List<int> numbers = new();

    foreach (string s in input) numbers.Add(Convert.ToInt32(s));
    return numbers;
  }
}
}