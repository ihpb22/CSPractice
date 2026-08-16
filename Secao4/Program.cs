using System;
using System.Globalization;

namespace Secao4{

    class Triangulo {
        public double ladoX;
        public double ladoY;
        public double ladoZ;

        public Triangulo(double x, double y, double z){
            ladoX = x;
            ladoY = y;
            ladoZ = z;
        }
        
        public double CalcArea (){
            double p = (this.ladoX + this.ladoY + this.ladoZ)/2;
            return Math.Sqrt(p*(p-this.ladoX)*(p-this.ladoY)*(p-this.ladoZ));
        }
    }

    class Program {

        private List<double> toDouble(string[] argsString){
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

        static void Main(string[] args) {
            Program k = new Program();
            List<double> argsDouble = k.toDouble(args);
            Triangulo x = new Triangulo(argsDouble[0], argsDouble[1], argsDouble[2]);
            Triangulo y = new Triangulo(argsDouble[3], argsDouble[4], argsDouble[5]);
            double a = x.CalcArea();
            double b = y.CalcArea();
            Console.WriteLine("AREA DE X = " + a.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("AREA DE Y = " + b.ToString("F4", CultureInfo.InvariantCulture));
            if(a > b) {
                Console.WriteLine("X E MAIOR.");
                return;
            }
            if(a < b){
                Console.WriteLine("Y E MAIOR.");
                return;
            }
            else{
                Console.WriteLine("MESMO TAMANHO.");
                return;
            }
        }
    }
}