// See https://aka.ms/new-console-template for more information
//value types
//Console.WriteLine("Hello, World!");
bool condition = true;

//bool condition = false;
char character = 'A';
double number5 = 10.4;
decimal number6 = 10.4m;
var number7 = 10;
number7 = 'A';
//number7 = "A"; ilk atanan veri tipi geçerlidir.


byte number4 = 255;

//short number3 = 32767;
short number3 = -32768;

int number1 = 2147483647;
//long number2 = -9223372036854775808;
long number2 = 9223372036854775807;
Console.WriteLine("Number1 is {0}", number1);
Console.WriteLine("Number2 is {0}", number2);
Console.WriteLine("Number3 is {0}", number3);
Console.WriteLine("Number4 is {0}", number4);
Console.WriteLine("Number5 is {0}", number5);
Console.WriteLine("Number6 is {0}", number6);
Console.WriteLine("Number7 is {0}", number7);
Console.WriteLine("Character is {0};", character);
Console.WriteLine(Days.Friday);
Console.WriteLine((int)Days.Friday);

Console.WriteLine("Character is {0};", (int)character);
Console.ReadLine();

enum Days
{
    Monday=10, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
}