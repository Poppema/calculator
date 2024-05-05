using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Classes
{
    public class UserPrint
    {
        public double[] ReadKeys() {
            string[] stringOfNums = (Console.ReadLine()
    .Split(' '));
            double[] UserUse= new double[stringOfNums.Length];
            for (int i = 0; i < stringOfNums.Length; i++)
            {
                UserUse[i] = Convert.ToDouble(stringOfNums[i]);
            } 
            return UserUse;
            
        }
    }
}
