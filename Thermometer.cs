namespace ConsoleApp;

class Celcius
{
    public double Gradus { get; set; }

    public Celcius(double Gradus)
    {
        this.Gradus = Gradus;
    }

    public static implicit operator Fahrenheit(Celcius celcius)
    {
        return new Fahrenheit(9.0/5 * celcius.Gradus + 32);
    }
}
class Fahrenheit
{
    public double Gradus { get; set; }

    public Fahrenheit(double Gradus)
    {
        this.Gradus = Gradus;
    }

    public static implicit operator Celcius(Fahrenheit fahrenheit)
    {
        return new Celcius(5.0/9 * (fahrenheit.Gradus - 32));
    }
}