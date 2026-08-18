namespace Propostos;
using System.Globalization;

public class Funcionario
{
    private string name;
    private double salary;
    private double tax;

    public Funcionario(){

    }

    private void setName(string name){
        this.name = name;
    }

    private void setSalary(double salary){
        this.salary = salary;
    }

    private void setTax(double tax){
        this.tax = tax;
    }

    public string getName(){
        return this.name;
    }

    public double getSalary(){
        return this.salary;
    }

    public double getTax(){
        return this.tax;
    }

    public void ReadInput(){

        Console.Write("Nome:");
        this.setName(Console.ReadLine());
        Console.Write("Salario:");
        this.setSalary(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
        Console.Write("Imposto:");
        this.setTax(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

        double taxed = this.getSalary() - this.getTax(); 

        Console.WriteLine("Funcionario: " + this.getName() + ", $ " + taxed.ToString("F2", CultureInfo.InvariantCulture));

        Console.Write("Digite a porcentagem para aumentar o salario: ");
        double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        this.setSalary(this.getSalary() + this.getSalary() * (percentage/100));

        taxed = this.getSalary() - this.getTax();
        Console.WriteLine("Dados atualizados: " + this.getName() + ", $ " + taxed.ToString("F2", CultureInfo.InvariantCulture));

    }
}
