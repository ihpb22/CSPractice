namespace ExerciciosSecao4;

 
public class PrimeiroExercicio
{

    private string name;
    private int age;

    public PrimeiroExercicio(){
    }

    private void setName(string input){
        this.name = input;
    }

    private void setAge(int input){
        this.age = input;
    }

    public string getName(){
        return this.name;
    }

    public int getAge(){
        return this.age;
    }

    public string CompareAges(PrimeiroExercicio x, PrimeiroExercicio y){
        if(x.getAge() > y.getAge())
            return x.getName();
        if(x.getAge() < y.getAge())
            return y.getName();
        return "Mesma idade";
    }

    public PrimeiroExercicio[] ReadInput(){

        PrimeiroExercicio[] Lista = new PrimeiroExercicio[2];

        PrimeiroExercicio first = new PrimeiroExercicio();
        PrimeiroExercicio second = new PrimeiroExercicio();

        Console.WriteLine("Dados da primeira pessoa:\nNome:");
        first.setName(Console.ReadLine());
        Console.Write("Idade:");
        first.setAge(int.Parse(Console.ReadLine()));


        Console.WriteLine("Dados da segunda pessoa:\nNome:");
        second.setName(Console.ReadLine());
        Console.Write("Idade:");
        second.setAge(int.Parse(Console.ReadLine()));

        Lista[0] = first;
        Lista[1] = second;

        return Lista;        
    }
}
