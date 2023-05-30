namespace dz8
{
    internal class Program
    {
        static void Main()
        {
            //1
            Vector3D vector1 = new Vector3D(1, 2, 3);
            Vector3D vector2 = new Vector3D(4, 5, 6);

            Console.WriteLine("Vector1: ({0}, {1}, {2})", vector1.X, vector1.Y, vector1.Z);
            Console.WriteLine("Vector2: ({0}, {1}, {2})", vector2.X, vector2.Y, vector2.Z);

            Vector3D scaledVector = vector1 * 2;
            Console.WriteLine("Scaled vector1: ({0}, {1}, {2})", scaledVector.X, scaledVector.Y, scaledVector.Z);

            Vector3D sumVector = vector1 + vector2;
            Console.WriteLine("Sum of vector1 and vector2: ({0}, {1}, {2})", sumVector.X, sumVector.Y, sumVector.Z);

            Vector3D diffVector = vector1 - vector2;
            Console.WriteLine("Difference between vector1 and vector2: ({0}, {1}, {2})", diffVector.X, diffVector.Y, diffVector.Z);

            //2
            DecimalNumber number = new DecimalNumber(42);

            string binary = number.ToBinary();
            Console.WriteLine($"Binary: {binary}"); // 101010

            string octal = number.ToOctal();
            Console.WriteLine($"Octal: {octal}"); // 52

            string hexadecimal = number.ToHexadecimal();
            Console.WriteLine($"Hexadecimal: {hexadecimal}"); // 2A

            //3
            RGBColor color = new RGBColor(255, 0, 0);
            string hex = color.ToHex();
            double h, s, l, c, m, y, k;
            color.ToHSL(out h, out s, out l);
            color.ToCMYK(out c, out m, out y, out k);
            Console.WriteLine("RGB: ({0}, {1}, {2})", color.Red, color.Green, color.Blue);
            Console.WriteLine("HEX: {0}", hex);
            Console.WriteLine("HSL: ({0:F2}, {1:F2}, {2:F2})", h, s, l);
            Console.WriteLine("CMYK: ({0:F2}, {1:F2}, {2:F2}, {3:F2})", c, m, y, k);
        }
    }
}