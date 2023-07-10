using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Прямоугольник
            int SIZE_RL = 5;
            int SIZE_RW = 10;
            for (int i = 0;i < SIZE_RL; i++)
            {
                Console.Write("*");
                for (int j = 0; j < SIZE_RW; j++)
                {
                    if (i > 0 && i < SIZE_RL-1)
                    {
                        Console.Write(" ");
                    }
                    else
                        Console.Write("*");
                }
                Console.Write("*");
                Console.Write("\n");
            }
            Console.Write("\n");
            //Прямоугольный треугольник
            int SIZE_T = 10; 
            for (int i = 0; i < SIZE_T; i++)
            {
                
                Console.Write("*");
                for (int j = 0; j < i; j++)
                {
                    if (i > 0 && i < SIZE_T-1)
                    {
                        Console.Write(" ");
                    }
                    else
                        Console.Write("*");
                    
                }
                if (i > 0)
                { 
                    Console.Write("*"); 
                }               
                Console.Write("\n");
            }
            //Равносторонний треугольник
            int SIZE_U = 9;
            Console.Write("\n");
            for (int i = 0; i <= SIZE_U; i++)
            {
                Console.Write("*");
                for (int j = 0; j < SIZE_U; j++)
                {
                    
                        Console.Write("*");
                    
            
                    
                }
                Console.Write("*");
                Console.Write("\n");
            }
        }
    }
}
