using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorPrivateAssemblyy
{
    public class BasicComputation
    {

        public static float Addition(float num1,float num2)
        {
            float result = num1 + num2;
            return result;
        }
        public static float Subtraction(float num1, float num2)
        {
            float result = num1 - num2;
            return result;
        }
        public static float Multiplaction(float num1, float num2)
        {
            float result = num1 * num2;
            return result;
        }
        public static float Division(float num1, float num2)
        {
            float result = num1 / num2;
            return result;
        }
    }
}
