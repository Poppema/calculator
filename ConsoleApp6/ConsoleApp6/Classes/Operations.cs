using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Classes
{
    public abstract class Operation
    {
        public abstract string Name { get; }
        public abstract double Calculate(double[] massive);

    }
    public class Addition : Operation 
    {
        public override string Name=>"Сложение";
        public override double Calculate(double[] massive)
        {
            return massive[0] + massive[1];
        }
    }
    public class Subtraction : Operation
    {
        public override string Name => "Вычитание";
        public override double Calculate(double[] massive)
        {
            return massive[0] - massive[1];
        }
    }
    public class Multiplication : Operation
    {
        public override string Name => "Умножение";
        public override double Calculate(double[] massive)
        {
            return massive[0] * massive[1];
        }
    }
    public class Division : Operation
    {
        public override string Name => "Деление";
        public override double Calculate(double[] massive)
        {
            return massive[0] / massive[1];
        }
    }
    public class Sine : Operation
    {
        public override string Name => "Синус";
        public override double Calculate(double[] massive)
        {
            double angleRadians = massive [0] * Math.PI / 180;
            return Math.Sin(massive[0]);
        }
    }
    public class Cosine : Operation
    {
        public override string Name => "Косинус";
        public override double Calculate(double[] massive)
        {
            double angleRadians = massive[0] * Math.PI / 180;
            return Math.Cos(massive[0]);
        }
    }

    public class Tangent : Operation
    {
        public override string Name => "Тангенс";
        public override double Calculate(double[] massive)
        {
            double angleRadians = massive[0] * Math.PI / 180;
            return Math.Tan(massive[0]);
        }
    }
    public class Cotangent : Operation
    {
        public override string Name => "Котангенс";
        public override double Calculate(double[] massive)
        {
            double angleRadians = massive[0] * Math.PI / 180;
            return 1 / Math.Tan(angleRadians);
        }
    }
    public class Exponentiation : Operation
    {
        public override string Name => "Возведение в степень";
        public override double Calculate(double[] massive)
        {
            return Math.Pow(massive[0], massive[1]);
        }
    }
    public class Square : Operation
    {
        public override string Name => "Квадратный корень";
        public override double Calculate(double[] massive)
        {
            if (massive[0] < 0)
            {
                throw new ArithmeticException("Невозможно вычеслить корень из отрицательного числа");
            }
            return Math.Sqrt(massive [0] );
        }
    }
    //rjvvbn
