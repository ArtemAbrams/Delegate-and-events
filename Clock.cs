namespace ConsoleApp;

public class Clock
{
    public int Hours { get; set; }

    public Clock(int hours) 
    {
        this.Hours = hours;
    }

    public static implicit operator Clock(int k)
    {
        return new Clock(k);
    }
    public static explicit operator int(Clock clock)
    {
        return clock.Hours;
    }
}