// See https://aka.ms/new-console-template for more information
Add();

var result = Add2(10,20);
Console.WriteLine(result);
static void Add ()
{
    Console.WriteLine("added!");
}
static int Add2 (int number1,int number2)
{
    var result = number1 + number2;
    return result;
}
Console.ReadLine();
