using System;
using System.Runtime.CompilerServices;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b = 255;

            System.Console.WriteLine("\nByte:");
            System.Console.WriteLine("Min = {0} Max = {1}", Byte.MinValue, Byte.MaxValue);

            sbyte sb = -128;
            sbyte sb2 = 127;

            System.Console.WriteLine("\nSByte:");
            System.Console.WriteLine("Min = {0} Max = {1}", SByte.MinValue, SByte.MaxValue);

            short sh = 32767, sh2 = -32768;

            System.Console.WriteLine("\nShort:");
            System.Console.WriteLine("Min = {0} Max = {1}", Int16.MinValue, Int16.MaxValue);

            ushort ush = 65535;

            System.Console.WriteLine("Min = {0} Max = {1}", UInt16.MinValue, UInt16.MaxValue);

            int i = -2147483648, j = 2147483647;

            uint Ui = 4294967295;

            System.Console.WriteLine("\nInteger:");
            System.Console.WriteLine("Min = {0} Max = {1}", Int32.MinValue, Int32.MaxValue);

            System.Console.WriteLine("\nUinteger:");
            System.Console.WriteLine("Min = {0} Max = {1}", UInt32.MinValue, UInt32.MaxValue);

            long l = 9223372036854775807;
            long l2 = -9223372036854775808;

            ulong Ul = 18223372036854775808ul;

            System.Console.WriteLine("\nLong");
            System.Console.WriteLine("Min = {0} Max = {1}", Int64.MinValue, Int64.MaxValue);


            System.Console.WriteLine("\nULong:");
            System.Console.WriteLine("Min = {0} Max = {1}", UInt64.MinValue, UInt64.MaxValue);   

            float f1 = 123456.5F;
            float f2 = 1.123456f;

            Console.WriteLine("\nFloat:");
            Console.WriteLine("Min={0} , Max={1}", float.MinValue, float.MaxValue);
          

            //double
            double d1 = 12345678912345.5d;
            double d2 = 1.123456789123456d;

            Console.WriteLine("\nDouble:");
            Console.WriteLine("Min={0} , Max={1}", double.MinValue, double.MaxValue);


            decimal d3 = 123456789123456789123456789.5m;
            decimal d4 = 1.1234567891345679123456789123m;

            Console.WriteLine("\nDecimal:");
            Console.WriteLine("Min={0} , Max={1}", decimal.MinValue, decimal.MaxValue);

            double d = 0.12e2;
            Console.WriteLine(d);  // 12;

            float f = 123.45e-2f;
            Console.WriteLine(f);  // 1.2345

            decimal m = 1.2e6m;
            Console.WriteLine(m);// 1200000


            int hex = 0x2F;
            int binary = 0b_0010_1111;

            Console.WriteLine(hex);
            Console.WriteLine(binary);         

        }
    }
}