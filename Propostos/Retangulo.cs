namespace Propostos;
using System.Globalization;

public class Retangulo
{
    public double length;
    public double height;

    public Retangulo(){

    }

    private void setLength(double length){
        this.length = length;
    }

    private void setHeight(double height){
        this.height = height;
    }

    public double getLength(){
        return this.length;
    }

    public double getHeight(){
        return this.height;
    }

    public double CalcArea(){
        return this.getHeight() * this.getLength();
    }

    public double CalcPerimetro(){
        return this.getHeight() * 2 + this.getLength() * 2;
    }

    public double CalcDiagonal(){
        return Math.Sqrt(Math.Pow(this.getHeight(),2) + Math.Pow(this.getLength(), 2));
    }

    public void ReadInput(){

        Console.WriteLine("Entre a Largura e a Altura do Retangulo:");
        this.setHeight(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
        this.setLength(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

    }

    public void WriteCalcs(){
        Console.WriteLine("Area: " + this.CalcArea().ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("Perimetro: " + this.CalcPerimetro().ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("Diagonal: " + this.CalcDiagonal().ToString("F4", CultureInfo.InvariantCulture));
    }
}
