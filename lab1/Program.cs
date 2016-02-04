using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
                string[] number = Console.ReadLine().Split(); //вводим числа через пробел
                for (int i = 0; i < number.Length; i++)
                {
                    int cnt = 0; //создаем счетчик который будет считать число делителей
                    int a = int.Parse(number[i]); //каждый элемент строки записываем как тип int
                    for (int j = 1; j <= a; j++)     //пробегаемся по циклу с 1 до а числа                    
                    {
                        if (a % j == 0)
                        {
                            cnt++; //прибавляем счетчику один
                        }
                    }
                    if (cnt < 3)//если число делителей меньше 3 то это простое число 
                    {
                        Console.WriteLine(a);
                    }
                Console.ReadKey();


            }
        }
    }
}
