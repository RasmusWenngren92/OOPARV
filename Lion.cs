
namespace OOP_Arv
{
    public class Lion(
        int age = 12, 
        bool isVenomous = false, 
        string diet = "Carnivore", 
        bool isDomesticated = false, 
        bool hasMane = true, 
        string color = "Orange")
        : Animal(color, age, isVenomous, diet, isDomesticated) //new class from animal
    {
        private bool HasMane { get; } = hasMane; //unique boolean property
     
    
        public override string MakeSound()
        {
             return "Roar!";
        }

        public override string Eat()
        {
            return "The Lion eats a juicy pieces of meat.";
        }

        private string UniqueFeature()
        {
            return HasMane ? "The Lion shakes its mane graciously!" : "This lion doesn't have a mane";
        }
        public override string Sleep()
        {
            return "The Lion is sound asleep beneath a tree.";
        }
        public override string ToString()
        {
            return base.ToString() + $"\n\tDoes it have a mane? : {HasMane}" +
                   $"\n\t{UniqueFeature()}";
        }
    }
}