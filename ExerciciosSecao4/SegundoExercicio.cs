namespace ExerciciosSecao4;
using System.Globalization;

public class SegundoExercicio {
    private string name;
    private double salary;

    public SegundoExercicio(){}
    
    private void setName(string name){
        this.name = name;
    }

    private void setSal(double salary){
        this.salary = salary;
    }

    public string getName(){
        return this.name;
    }

    public double getSal(){
        return this.salary;
    }

    public SegundoExercicio[] ReadInput(){
        SegundoExercicio[] Lista = new SegundoExercicio[2];

        SegundoExercicio first = new SegundoExercicio();
        SegundoExercicio second = new SegundoExercicio();

        Console.WriteLine("Dados do primeiro funcionario:");
        Console.Write("Nome:");
        first.setName(Console.ReadLine());
        Console.Write("Salario:");
        first.setSal(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

        Console.WriteLine("Dados do segundo funcionario:");
        Console.Write("Nome:");
        second.setName(Console.ReadLine());
        Console.Write("Salario:");
        second.setSal(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

        Lista[0] = first;
        Lista[1] = second;

        return Lista;
    }

    public double getAverage(SegundoExercicio[] Lista){
        double sum = 0;

        foreach(SegundoExercicio aux in Lista){
            sum = sum + aux.getSal();
        }

        return sum/Lista.Length;
    }
}
