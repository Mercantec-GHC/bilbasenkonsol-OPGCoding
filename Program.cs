using Class_Domain_Models;

namespace BilbasenKonsol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Eksempel med rigtige biler, lavet af ChatGPT ud fra jeres standart klasse
            Car fordMustang1963 = new Car("Ford", "Mustang", 1963, "Red", 430);
            Car toyotaCamry2020 = new Car("Toyota", "Camry", 2020, "Blue", 200);
            Car chevyCorvette2022 = new Car("Chevrolet", "Corvette", 2022, "Silver", 650);

            Console.WriteLine(fordMustang1963.Brand);
            Console.WriteLine(toyotaCamry2020.Brand);
            Console.WriteLine(chevyCorvette2022.Brand);
            //Det er vigtigt at I finder en god datatype til at opbevare jeres biler / Objekter!
        }
    }
}
