
namespace OOP_Arv
{
    public class Chihuahua(string color = "Brown", 
        int age = 5, 
        bool isVenomous = false, 
        string diet = "Omnivore", 
        bool isDomesticated = true, 
        bool seesOtherDog = true)
        : Dog(isVenomous, diet, isDomesticated, isAGoodBoy, color, age) //new class from dog
    {
        private const bool isAGoodBoy = true;

        private bool SeesOtherDog { get; } = seesOtherDog; //unique boolean property
        
        public override string MakeSound()
        {
            return "Yip yip";
        }

        public override string Eat()
        {
            return "The Chihuahua is chewing on a treat.";
        }

        public override string Sleep()
        {
            return "The Chihuahua is sound asleep on the couch.";
        }

        public override string UniqueFeature()
        {
             return SeesOtherDog ? "You meet another dog! The Chihuahua throws a tantrum." : "Just a lovely walk with the dog.";
        }
        public override string Fetch()
        {
            return $"The {GetType().Name} is happily returning the stick that you threw and is now waiting for you to throw it again.";
        }
        
    }
}