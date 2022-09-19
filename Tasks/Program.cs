using System;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            //1.
            int y = 0;
            Console.WriteLine("Введите х:");
            int x = Convert.ToInt32(Console.ReadLine());
            y = 7 * x * x + 3 * x + 6;
            Console.WriteLine(y);


            //2.
            //int b = 0;
            //Console.WriteLine("Введите a:");
            //int a = Convert.ToInt32(Console.ReadLine());
            //b = 12 * a * a + 7 * a + 12;
            //Console.WriteLine(b);


            //3.
            //Console.WriteLine("Введите длину стороны квадрата: ");
            //int side = Convert.ToInt32(Console.ReadLine());
            //int perimeter = side * 4;
            //Console.WriteLine(perimeter);


            //4.
            //Random num = new Random();
            //int NumberOne = num.Next(100);

            //int NumberTwo = num.Next(100);

            //double AverageNum = (NumberOne + NumberTwo)/2;
            //Console.WriteLine("Среднее aрифметическое " + NumberOne + " и " + NumberTwo + " = " + AverageNum);
            //double GeometricAverage = Math.Sqrt(NumberOne * NumberTwo);
            //Console.WriteLine("Среднее геометрическое " + NumberOne + " и " + NumberTwo + " = " + GeometricAverage);


            //5.
            //int MonitorPrice = 200;
            //int SystemUnitPrice = 1000;
            //int KeyboardPrice = 120;
            //int MousePrice = 50;

            //int WholeComputerCost = MonitorPrice + SystemUnitPrice + KeyboardPrice + MousePrice;
            //Console.WriteLine("Стоимость одного компьютера: " + WholeComputerCost);
            //Console.WriteLine("Стоимость трех компьютеров: " + 3 * WholeComputerCost);
            //Console.WriteLine("Стоимость n компьютеров: " + "n * 1370");



            //6.
            //int FirstCarSpeed = 90;
            //int SecondCarSpeed = 70;
            //int s = 50;

            //double theDistance = s + (FirstCarSpeed/2 - SecondCarSpeed/2);
            //Console.WriteLine("Скорость первой машины: " + FirstCarSpeed);
            //Console.WriteLine("Скорость второй машины: " + SecondCarSpeed);
            //Console.WriteLine("Расстояние между машинами: " + theDistance);
        }
    }
}