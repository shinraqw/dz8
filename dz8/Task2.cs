using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz8
{
    struct DecimalNumber
    {
        private int decimalValue;

        public DecimalNumber(int decimalValue)
        {
            this.decimalValue = decimalValue;
        }

        public string ToBinary()
        {
            return Convert.ToString(decimalValue, 2);
        }

        public string ToOctal()
        {
            return Convert.ToString(decimalValue, 8);
        }

        public string ToHexadecimal()
        {
            return Convert.ToString(decimalValue, 16);
        }
    }
}