using System;
using ConsoleApp6.Classes;
namespace EngCalc
{
    class Program
    {
        public static void ShowMenu(Operation[] operations)
        {
            Console.WriteLine("======== КАЛЬКУЛЯТОР ==========");
            for (int i = 0; i < operations.Length; i++)

            {
                Operation operation = operations[i];
                Console.WriteLine($"{i + 1}. Операция {operation.Name}");
            }
        
                
        }

        public static void Start()
        {
            Boolean buuuuuul = true;
            while(buuuuuul)
            {
                Console.Clear();
                Operation[] massive = new Operation[] {
                new Addition(),
                new Subtraction(),
                new Multiplication(),
                new Division(),
                new Sine(),
                new Cosine(),
                new Tangent(),
                new Cotangent(),
                new Exponentiation(),
                new Square()
            };
                ShowMenu(massive);

                Chois chois = new Chois();
                UserPrint userPrint = new UserPrint();
                Console.WriteLine(massive[chois.ReadNums() - 1].Calculate(userPrint.ReadKeys()));
                Console.ReadLine();
            }

            
            
        }
            static void Main(string[] args)
        {
            try
            {
                Start();
            }
            catch (Exception exep)
            {
                throw (exep);
            };
           
        }

       
    }
}