// See https://aka.ms/new-console-template for more information
Add();

var result = Add2(10);
Console.WriteLine(result);
static void Add ()
{
    Console.WriteLine("added!");
}
static int Add2 (int x ,int number1=10,int number2=20)
{
    var result = number1 + number2+ x;
    return result;
}
Console.ReadLine();
