using System;
using System.Globalization;

namespace Secao4{

    class Triangulo {
        private double ladoX;
        private double ladoY;
        private double ladoZ;

        public Triangulo(double x, double y, double z){
            this.setX(x);
            this.setY(y);
            this.setZ(z);
        }
        
        private void setX(double x){
            this.ladoX = x;
        }

        private void setY(double y){
            this.ladoY = y;
        }

        private void setZ(double z){
            this.ladoZ = z;
        }

        public double getX(){
            return this.ladoX;
        }

        public double getY(){
            return this.ladoY;
        }

        public double getZ(){
            return this.ladoZ;
        }

        public double CalcArea (){
            double p = (this.getX() + this.getY() + this.getZ())/2;
            return Math.Sqrt(p*(p-this.getX())*(p-this.getY())*(p-this.getZ()));
        }
    }

    class Program {

        private static List<double> toDouble(string[] argsString){
            List<double> argsDouble = new List<double>(argsString.Length);
            for(int i = 0; i < argsString.Length; i++){
                try{
                    argsDouble.Add(double.Parse(argsString[i], CultureInfo.InvariantCulture));
                }
                catch (FormatException){
                    Console.WriteLine($"O input '{argsString[i]}' nao e um numero valido.");
                    break;
                } 
            }
            return argsDouble;
        }

        static void Main(string[] args) {
            if(args.Length != 6)
            {
                Console.WriteLine("Erro de entrada, por favor insira uma entrada correta (QUANTIDADE INSUFICIENTE DE ENTRADAS).\nPrograma finalizando.");
                return;
            }

            List<double> argsDouble = toDouble(args);
            
            if(argsDouble.Count < args.Length){
                Console.WriteLine("Erro de entrada, por favor insira uma entrada correta (APENAS NUMEROS).\nPrograma finalizando.");
                return;
            }
            
            Triangulo x = new Triangulo(argsDouble[0], argsDouble[1], argsDouble[2]);
            Triangulo y = new Triangulo(argsDouble[3], argsDouble[4], argsDouble[5]);
            
            double a = x.CalcArea();
            double b = y.CalcArea();
            
            Console.WriteLine("AREA DE X = " + a.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("AREA DE Y = " + b.ToString("F4", CultureInfo.InvariantCulture));
            
            if(a > b) {
                Console.WriteLine("X E MAIOR.");
            }
            if(a < b){
                Console.WriteLine("Y E MAIOR.");
            }
            else{
                Console.WriteLine("MESMO TAMANHO.");
            }
        }
    }
}