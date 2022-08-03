namespace ConsoleApp;
public delegate void Print(string message);
public class Events
{
    private int sum;
    private event Print? print;

    public Events(int sum)
    {
        this.sum = sum;
    }

    public void AddEvent(Print? print)
    {
        this.print += print;
    }

    public void RemoveEvent(Print? print)
    {
        if (this.print != null)
        {
            this.print -= print;
        }
        else
        {
           Console.WriteLine("No method");
        }
    }

    void Add(int sum)
    {
        this.sum += sum;
        print.Invoke($"You add money your balance: {sum}");
    }

    void Take(int sum)
    {
        if (this.sum < sum)
        {
            print.Invoke($"You don`t have enough money your balance: {sum}");
        }
        else
        {
            this.sum -= sum;
            print.Invoke($"You take money your balance: {sum}");
        }
    }
}