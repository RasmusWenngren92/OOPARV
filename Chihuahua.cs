
namespace OOP_Arv
{
    public class Chihuahua(string color, int age, bool isVenomous, string diet, bool isDomesticated, bool seesOtherDog)
        : Dog(color, age, isVenomous, diet, isDomesticated, isAGoodBoy) //new class from dog
    {
        private static bool isAGoodBoy = true;

        private bool SeesOtherDog { get; set; } = seesOtherDog; //unique boolean property
        
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

        public override string UniqueFeature(bool seesOtherDog)
        {
             return SeesOtherDog ? "You meet another dog! The Chihuahua throws a tantrum." : "Just a lovely walk with the dog.";
        }
        public override string Fetch()
        {
            return $"The {GetType().Name} is happily returning the stick that you threw and is now waiting for you to throw it again.";
        }
        
    }
}