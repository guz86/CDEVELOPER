using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character();
            character.Hit(80);
            character.ShowInfo();
            Console.WriteLine(character.Health);
            // 6

            Console.WriteLine("Площадь трегольника");
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.CalcTriangeSquare(2, 3, 4));
            Console.WriteLine(calculator.CalcTriangeSquare(1, 4) ); 




        }
    }
}
