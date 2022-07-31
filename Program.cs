
/*Print print;
print = Hello;
print += SomeMethod;
print();
print -= Hello;
print();
void Hello() => Console.WriteLine("Hi");
void SomeMethod() => Console.WriteLine("How are you");*/

using System.ComponentModel.Design;

Add? add = SomeMethod_2;
add+=Somemethod_3;
int? result = add(4, 5);
Console.WriteLine(result);
int? result_1 = add.Invoke(5, 6);
Console.WriteLine(result_1);
add -= SomeMethod_2;
add -= Somemethod_3;
if(add != null)
    result = add.Invoke(10,10);
else
    Console.WriteLine("No method");
int SomeMethod_2(int x, int y) => x + y;
int Somemethod_3(int x, int y) => x * y;
delegate void Print();
delegate int Add(int x, int y);