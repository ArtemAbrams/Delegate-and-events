﻿using  ConsoleApp;
using System.ComponentModel.Design;
/*Add? add = SomeMethod_2;
add+=Somemethod_3;
int? result = add(4, 5);
Console.WriteLine(result);
int? result_1 = add.Invoke(5, 6);
Console.WriteLine(result_1);
add -= SomeMethod_2;
if (add != null)
{
    Console.ForegroundColor = ConsoleColor.Green;
    result = add.Invoke(10,10);
    Console.WriteLine(result);
    Console.ResetColor();
}
else
    Console.WriteLine("No method");
int SomeMethod_2(int x, int y) => x + y;
int Somemethod_3(int x, int y) => x * y;

delegate void Print();

delegate int Add(int x, int y);*/
DelegateClass dlgcls = new DelegateClass(200);

void PrintGreenColour(string message, int sum)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(message + " " + sum);
    Console.ResetColor();
}

void PrintRedColour(string message, int sum)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message + " "+sum);
    Console.ResetColor();
}
dlgcls.AddMethod(PrintGreenColour);
dlgcls.Add(500);
dlgcls.DeleteMethod(PrintGreenColour);
dlgcls.AddMethod(PrintRedColour);
dlgcls.Taken(600);