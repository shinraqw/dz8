using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz8
{
    struct RGBColor
    {
        public int Red;
        public int Green;
        public int Blue;

        public RGBColor(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public string ToHex()
        {
            return "#" + Red.ToString("X2") + Green.ToString("X2") + Blue.ToString("X2");
        }

        public void ToHSL(out double H, out double S, out double L)
        {
            double r = (double)Red / 255.0;
            double g = (double)Green / 255.0;
            double b = (double)Blue / 255.0;
            double max = Math.Max(Math.Max(r, g), b);
            double min = Math.Min(Math.Min(r, g), b);
            double delta = max - min;

            if (delta == 0)
                H = 0;
            else if (max == r)
                H = ((g - b) / delta) % 6;
            else if (max == g)
                H = ((b - r) / delta) + 2;
            else
                H = ((r - g) / delta) + 4;

            H = H * 60;
            if (H < 0)
                H += 360;

            L = (max + min) / 2;

            if (delta == 0)
                S = 0;
            else
                S = delta / (1 - Math.Abs(2 * L - 1));
        }

        public void ToCMYK(out double C, out double M, out double Y, out double K)
        {
            double r = (double)Red / 255.0;
            double g = (double)Green / 255.0;
            double b = (double)Blue / 255.0;
            K = 1 - Math.Max(Math.Max(r, g), b);
            if (K == 1)
            {
                C = 0;
                M = 0;
                Y = 0;
            }
            else
            {
                C = (1 - r - K) / (1 - K);
                M = (1 - g - K) / (1 - K);
                Y = (1 - b - K) / (1 - K);
            }
        }
    }
}