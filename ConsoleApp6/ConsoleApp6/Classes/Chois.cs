using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp6.Classes
{
    internal class Chois
    {
        public int ReadNums()
        {
           

            int UserUse = Convert.ToInt32(Console.ReadLine());
            Console.Clear();   
            return UserUse;                  
        }
    }
}
