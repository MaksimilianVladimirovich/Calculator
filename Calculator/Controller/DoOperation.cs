using Calculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Controller
{
    public class DoOperation
    {
        public static double Sum(ElementsOfOperation operation)
        {
            return operation.FirstNumber + operation.SecondNumber;
        }

        public static double Minus(ElementsOfOperation operation)
        {
            return operation.FirstNumber - operation.SecondNumber;
        }

        public static double Multiplication(ElementsOfOperation operation)
        {
            return operation.FirstNumber * operation.SecondNumber;
        }

        public static double Division(ElementsOfOperation operation)
        {
            return operation.FirstNumber / operation.SecondNumber;
        }

        public static double Root(ElementsOfOperation operation)
        {
            return Math.Sqrt(operation.FirstNumber);
        }

        public static double Square(ElementsOfOperation operation)
        {
            return Math.Pow(operation.FirstNumber, 2);
        }

        public static double Division1ToX(ElementsOfOperation operation)
        {
            return 1 / operation.FirstNumber;
        }

        public static double Percent(ElementsOfOperation operation)
        {
            return ((operation.SecondNumber * 100) / operation.FirstNumber) / 100;
        }
    }
}
