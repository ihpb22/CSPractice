using System;
using System.Globalization;

namespace Secao4{
    class Aula1 {
        public Aula1(){

        }
        
        public List<double> toDouble(string[] argsString){
            List<double> argsDouble = new List<double>(argsString.Length);
            for(int i = 0; i < argsString.Length; i++){
                try{
                    argsDouble.Add(double.Parse(argsString[i], CultureInfo.InvariantCulture));
                }
                catch (FormatException){
                    Console.WriteLine($"O input '{argsString[i]}' nao e um numero valido.");
                } 
            }
            return argsDouble;
        }
        
        public double CalcArea (double x, double y, double z){
            double p = (x + y + z)/2;
            return Math.Sqrt(p*(p-x)*(p-y)*(p-z));
        }
    }

    class Program {
        static void Main(string[] args) {
            Aula1 k = new Aula1();
            List<double> argsDouble = k.toDouble(args);
            double a = new Double();
            double b = new Double();
            try{
                a = k.CalcArea(argsDouble[0], argsDouble[1], argsDouble[2]);
                b = k.CalcArea(argsDouble[3], argsDouble[4], argsDouble[5]);
            }
            catch(ArgumentOutOfRangeException){
                return;
            }
            Console.WriteLine("AREA DE X = " + a.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("AREA DE Y = " + b.ToString("F4", CultureInfo.InvariantCulture));
            if(a > b) {
                Console.WriteLine("X E MAIOR.");
                return;
            }
            Console.WriteLine("Y E MAIOR.");
            return;
        }
    }
}