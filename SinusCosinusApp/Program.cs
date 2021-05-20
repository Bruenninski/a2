using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace SinusCosinusApp
{
    class Program
    {

        [DllImport("\\..\\..\\..\\..\\..\\Asses2\\x64\\Debug\\Asses2.dll", EntryPoint = "cppSinCos")]
        public static extern IntPtr CppSinCos(double radiant);

        [DllImport("\\..\\..\\..\\..\\..\\Asses2\\x64\\Debug\\Asses2.dll", EntryPoint = "releaseMemory")]
        public static extern int ReleaseMemory(IntPtr ptr);

        static void Main(string[] args)
        {
            double radiant;
            try
            {
                radiant = Convert.ToDouble(args[0]);
            }
            catch(FormatException)
            {
                Console.WriteLine("Wrong Input, the Programm will be closed");
                return;
            }
            double[] result = new double[2];

            var sol = CppSinCos(radiant);
            Marshal.Copy(CppSinCos(radiant), result, 0, 2);

            Console.WriteLine("sin: " + result[0] + "\ncos: " + result[1]);
            ReleaseMemory(sol);
        }
    }
}
