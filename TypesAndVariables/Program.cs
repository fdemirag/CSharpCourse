﻿// See https://aka.ms/new-console-template for more information
//value types
//Console.WriteLine("Hello, World!");
bool condition = true;

//bool condition = false;
char character = 'A';
double number5 = 10.4;


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
Console.WriteLine("Character is {0};", character);

Console.WriteLine("Character is {0};", (int)character);
Console.ReadLine();