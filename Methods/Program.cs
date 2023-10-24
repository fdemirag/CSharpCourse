// See https://aka.ms/new-console-template for more information
Add();

var result = Add2(10);
Console.WriteLine(result);

int number1 = 100;
int number2 = 20;
var result2= Add3(ref number1,number2);
Console.WriteLine(result2);
Console.WriteLine(number1);

static void Add ()
{
    Console.WriteLine("added!");
}
static int Add2 (int x ,int number1=10,int number2=20)
{
    var result = number1 + number2+ x;
    return result;
}
static int Add3 (ref int number1 ,int number2)
{
    number1 = 30;
    return number1 + number2;
}
Console.ReadLine();
