public class Car{
    string color = "red";
    int carNumber = 7482;
    public int tires = 4;

   public void Stop() { 

    }
   public void Drive() {

    }
   public void Fly() {
        this.color = "transparent";
    }
    public void CarColor() {
        Console.WriteLine(this.color);
    }
}
internal class Program
{  
    private static void Main(string[] args)
    {
        Car minicar = new Car();
        minicar.CarColor();
        minicar.Fly();
        minicar.CarColor();
        minicar.tires = 2;
    }
}