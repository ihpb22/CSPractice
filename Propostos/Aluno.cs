namespace Propostos;
using System.Globalization;

public class Aluno
{
    private string name;
    private List<double> notas = new List<double>();

    public Aluno(){

    }

    private void setName(string name){
        this.name = name;
    }

    private void setNotas(double nota){
        this.notas.Add(nota);
    }

    public string getName(){
        return this.name;
    }

    public List<double> getNotas(){
        return this.notas;
    }

    public void ReadInput(){

        Console.Write("Nome do aluno: ");
        this.setName(Console.ReadLine());

        Console.WriteLine("Digite as tres notas do aluno:");
        this.setNotas(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
        this.setNotas(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
        this.setNotas(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

        double sum = this.getNotas().Sum();
        Console.WriteLine("NOTA FINAL = " + sum.ToString("F2", CultureInfo.InvariantCulture));
        if(sum < 60){
            Console.WriteLine("REPROVADO");
            sum = (sum - 60) * -1.00;
            Console.WriteLine("FALTARAM " + sum.ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
        }
        else
            Console.WriteLine("APROVADO");
    }
}
