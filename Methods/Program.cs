
internal class Program
{
    private static void Main(string[] args)
    {
        //static void Add ()
        //{
        //    Console.WriteLine("added!");
        //}
        //static int Add2 (int x ,int number1=10,int number2=20)
        //{
        //    var result = number1 + number2+ x;
        //    return result;
        //}
        //static int Add3 (out int number1 ,int number2)
        //{
        //    number1 = 30; //out kullanırsak metot içinde set edilmiş olmalı 
        //    return number1 + number2;
        //}

        //Add();

        //var result = Add2(10);
        //Console.WriteLine(result);

        //int number1 ;
        //int number2 = 20;
        //var result2= Add3(out number1,number2);
        //Console.WriteLine(result2);
        //Console.WriteLine(number1);

        Console.WriteLine(Multiply(2,3));
        Console.WriteLine(Multiply(2,3,4));




        Console.ReadLine();

    }
    static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
}