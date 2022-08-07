namespace ConsoleApp;

class Dollar
{
    public decimal Sum { get; set; }

    public static implicit operator Euro(Dollar dollar)
    {
        return new Euro() {  Sum = dollar.Sum / 1.12M };
    }
    public static implicit operator Dollar(Euro euro)
    {
        return new Euro() { Sum = euro.Sum * 1.12M };
    }
}
class Euro
{
    public decimal Sum { get; set; }
    
}