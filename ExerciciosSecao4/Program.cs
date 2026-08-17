using System;
using System.Globalization;

namespace ExerciciosSecao4 {
    class Program{
        static void Main(string[] args){
            
            PrimeiroExercicio prim = new PrimeiroExercicio();
            PrimeiroExercicio[] entidades = prim.ReadInput();
            Console.WriteLine("Pessoa mais velha: " + prim.CompareAges(entidades[0], entidades[1]));
        
        
            SegundoExercicio sec = new SegundoExercicio();
            SegundoExercicio[] funcionarios = sec.ReadInput();
            Console.WriteLine("Salario Medio = " + sec.getAverage(funcionarios).ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}