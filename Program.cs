
Print print;
print = Hello;
print += SomeMethod;
print();
print -= Hello;
print();
void Hello() => Console.WriteLine("Hi");
void SomeMethod() => Console.WriteLine("How are you");
delegate void Print();