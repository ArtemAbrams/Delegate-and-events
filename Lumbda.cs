namespace ConsoleApp;
class Lumbda
{
  public int[] arr
  {
    get
    {
      return arr;
    }
    set
    {
      arr = value;
    }
  }
  public Checked check;

  public Lumbda(int[] arr, Checked check)
  {
    this.arr = arr;
    this.check = check;
  }
  public int Sum()
  {
    var sum = 0;
    foreach (var i in arr)
    {
      if (check(i))
      {
        sum += i;
      }
    }

    return sum;
  }
  public delegate bool Checked(int i);
}