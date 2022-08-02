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
int[] arr = new int[10];
    Lumbda lumbda = new Lumbda(arr ,(int x) => x > 500);
lumbda.PrintArray();
int result = lumbda.Sum();
Console.WriteLine(result);