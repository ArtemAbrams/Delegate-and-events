using ConsoleApp;

/*Sum sum = delegate(int x, int y)
{
    return x + y;
};
Print("Your debt", 45, delegate(string message, int debt)
{
  Console.WriteLine(message + " " + debt );
});

void Print(string message, int debt, Printt print)
{
    print(message, debt);
}

delegate void Printt(string message, int debt);
delegate int Sum(int x, int y);*/
/*int[] arr = new int[10];
    Lumbda lumbda = new Lumbda(arr ,(int x) =>
    {
        return x > 500;
    });
lumbda.PrintArray();
int result = lumbda.Sum();
Console.WriteLine(result);*/
Events events = new Events(200);
void PrintRed(string message)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message);
    Console.ResetColor();
}

void PrintGreen(string message)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(message);
    Console.ResetColor();
}
events.AddEvent(PrintGreen);
events.Add(1000);
events.RemoveEvent(PrintGreen);
events.AddEvent(PrintRed);
events.Take(300);