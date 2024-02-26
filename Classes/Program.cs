namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Creating a new instance of the Car class
            var myCar = new Car();

            // Set values in the properties for the object
            myCar.Year = 2012;
            myCar.Make = "Volkswagen";
            myCar.Model = "Golf TDI";
            myCar.Transmission = "6-Speed Manual";

            // Print the values of each property to the Console
            myCar.PrintCar();
        }
    }
}
