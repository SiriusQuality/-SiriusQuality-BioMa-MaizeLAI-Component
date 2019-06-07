using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiriusQuality_MaizeLAI.Utilities
{
    static public class BasicMathUtilities
    {

        static public double divide(double dividend, double divisor, double default_value = 0)
        //===========================================================================

/*Definition
*   Returns (dividend / divisor) if the division can be done
*   without overflow or underflow.  If divisor is zero or
*   overflow would have occurred, a specified default is returned.
*   If underflow would have occurred, zero is returned.
*Assumptions
*   largest/smallest real number is 1.0e+/-30
*Parameters
*   dividend:     dividend
*   divisor:      divisor
*   defaultValue: default value to return if overflow
*Calls
*   reals_are_equal
*/
        {
            //Constant Values
            double LARGEST = 1.0e30;    //largest acceptable no. for quotient
            double SMALLEST = 1.0e-30;  //smallest acceptable no. for quotient
            double nought = 0.0;

            //Local Varialbes
            double quotient;

            //Implementation
            if (isEqual(dividend, 0.0))      //multiplying by 0
            {
                quotient = 0.0;
            }
            else if (isEqual(divisor, 0.0))  //dividing by 0
            {
                quotient = default_value;
            }
            else if (Math.Abs(divisor) < 1.0)            //possible overflow
            {
                if (Math.Abs(dividend) > Math.Abs(LARGEST * divisor)) //overflow
                {
                    quotient = default_value;
                }
                else
                {
                    quotient = dividend / divisor;         
                }
            }
            else if (Math.Abs(divisor) > 1.0)             //possible underflow
            {
                if (Math.Abs(dividend) < Math.Abs(SMALLEST * divisor))    //underflow
                {
                    quotient = nought;
                }
                else
                {
                    quotient = dividend / divisor;                
                }
            }
            else
            {
                quotient = dividend / divisor;                   
            }
            return quotient;
        }
        static public bool isEqual(double A, double B) { return (Math.Abs(A - B) < 1.0E-6); }

    }
}
