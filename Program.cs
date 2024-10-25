
namespace OOP_Arv
{
    internal class Program
    {
        // Programmer   : Rasmus Wenngren
        // Program      : Fullstack .NET
        // Course       : Promgrammering med C# och .NET
        // Lab 6        : OOP ARV
        
        private static void Main(string[] args)
        {

            // Create a list of animals using collection expression
            List<Animal> animalList =
            [
                new Lion(15, false, "Carnivore", false, true, "Orange"),
                new Dog(false, "Omnivore", true, true, "Brown", 12), 
                new Snake(2, true, "Carnivore", false, true, "Golden"), 
                new Amstaff("Black", 6, false, "Omnivore", true, true),
                new Chihuahua("Beige", 3, false, "Omnivore", true, true)
            ];
            //Display how all the animals sound
            Console.WriteLine("This is how all the animals sounds: ");
            foreach (var animal in animalList)
            {
                Console.WriteLine(
                    $"The {animal.GetType().Name} sounds like this: {animal.MakeSound()}"); //printing the sound
            }
            Console.WriteLine("Press enter to see domesticated animals.");
            Console.ReadLine();

            //Checking if the animal is Domesticated
            Console.WriteLine("This is all the animals that are domesticated: ");
            foreach (var animal in animalList.Where(animal => animal.IsDomesticated == true))
            {
                Console.WriteLine($"{animal.GetType().Name}"); //Prints out the domesticated animals
            }
            Console.ReadLine();
            
            Console.WriteLine("This is all the animals.");
            foreach (var animal in animalList)
            {
                Console.WriteLine(animal);
            }
        }
    }
}