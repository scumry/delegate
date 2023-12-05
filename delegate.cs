class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();
        Tachies tack = new Tachies(calculator.Min);
        tack = new Tachies(calculator.Plus);
        Tachies tacs = new Tachies(calculator.Del);
        tacs = new Tachies(calculator.Ymn);
        Console.WriteLine("Вычитание - :"+tack(10, 2));
        Console.WriteLine("Вычитание - :"+tack(10,2));
        Console.WriteLine("Деление / :"+tacs(10,2));
        Console.WriteLine("Деление / :"+tacs(10, 2));
    }
}
class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();
        Tachies tack = new Tachies(calculator.Add);
        tack = new Tachies(calculator.Subtract);
        Tachies tacs = new Tachies(calculator.Multiply);
        tacs = new Tachies(calculator.Divide);
        Console.WriteLine("Уаначале + :"+tack(15, 11));
        Console.WriteLine("Потоме - :"+tack(151,555));
        Console.WriteLine("Усередине * :"+tacs(231,151));
        Console.WriteLine("Уконце / :"+tacs(123, 151));
    }
}
///___
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;



public delegate int Tachies(int x, int y); 

public class Calculator {

        public int Plus(int x, int y)
    {
        return x + y;
    }

        public int Min(int x, int y)
    {
        return x - y;
    }

        public int Ymn(int x, int y)
    {
        return x * y;
    }

        public int Del(int x, int y)
    {
        return x / y;
    }


}



class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();
        Tachies tack = new Tachies(calculator.Min);
        tack = new Tachies(calculator.Plus);
        Tachies tacs = new Tachies(calculator.Del);
        tacs = new Tachies(calculator.Ymn);
        Console.WriteLine("Вычитание - :"+tack(214, 12));
        Console.WriteLine("Сложение + :"+tack(10,2));
        Console.WriteLine("Деление / :"+tacs(521,7));
        Console.WriteLine("Умножение * :"+tacs(15, 12));
    }
}