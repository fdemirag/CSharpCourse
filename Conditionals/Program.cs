// See https://aka.ms/new-console-template for more information

var number = 100;
//if (number == 10)
//{
//    Console.WriteLine("number is 10");
//}
//else if (number == 20)
//{
//    Console.WriteLine("number is 20");
//}
//else
//{
//    Console.WriteLine("number is not 10");
//}

//Console.WriteLine(number == 10 ? "number is 10" : "number is not 10");

//switch (number)
//{
//    case 10:
//        Console.WriteLine("number is 10");
//        break;

//    case 20:
//        Console.WriteLine("number is 20");
//        break;
//    default:
//        Console.WriteLine("number is not 10 or 20");
//        break;
//}

if (number >= 0 && number  <=100)
{
    Console.WriteLine("number is between 0-100");
}
else if (number >=101 && number <=200)
{
    Console.WriteLine("number is between 101-200");
}
else if (number >= 201 || number < 0)
{
    Console.WriteLine("number is less than 0 or greater than 200");
}
Console.ReadLine();

