using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{
    public struct ElementsOfOperation
    {
        /// <summary>
        /// The first number to be operated on
        /// </summary>
        public double FirstNumber { get; set; }
        /// <summary>
        /// Operation between two numbers
        /// </summary>
        public char Operation { get; set; }
        /// <summary>
        /// The second number to be operated on
        /// </summary>
        public double SecondNumber { get; set; }
    }
}
