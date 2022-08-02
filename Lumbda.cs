namespace ConsoleApp;

class Lumbda
{
  public int[] arr;
  public Checked check;

  public Lumbda(int[] arr, Checked check)
  {
    try
    {
      Random random = new Random();
      this.arr = arr;
      for (int i = 0; i < arr.Length; i++)
      {
        arr[i] = random.Next(0, 1000);
      }
       this.check = check;
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.TargetSite);
      Console.WriteLine(ex.Message);
    }
  }

  public void PrintArray()
  {
    foreach (var i in arr)
    {
      Console.Write(i + " ");
    }
    Console.WriteLine();
  }
  public int Sum()
  {
    var sum = 0;
    foreach (var i in arr)
    {
      if (check(i))
      {
        Console.Write(i + " + ");
        sum += i;
      }
    }
    Console.WriteLine();
    return sum;
  }
  public delegate bool Checked(int i);
}