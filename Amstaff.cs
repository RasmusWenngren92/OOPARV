
namespace OOP_Arv
{
    public class Amstaff(string color = "Grey", 
        int age = 8, 
        bool isVenomous = false, 
        string diet = "Omnivore", 
        bool isDomesticated = true, 
        bool isAgressive = true)
        : Dog(isVenomous, diet, isDomesticated, isAGoodBoy, color, age) //new class from dog
    {

        private const bool isAGoodBoy = true; 
        
        private bool IsAgressive { get; } = isAgressive; //unique boolean property
       
        public override string MakeSound()
        {
           return IsAgressive ? "Growl!" : base.MakeSound();
        }
        
        public override string Eat()
        {
            return IsAgressive ? "The Amstaff is chewing on your leg." : base.Eat();
        }
        public override string Sleep()
        {
            return "The Amstaff is sound asleep in your bed."; 
        }

        public override string Fetch()
        {
            return $"The {GetType().Name} is brining back a log, good luck throwing that.";
        }

        public override string UniqueFeature()
        {
            return IsAgressive? "Chasing away the intruders!" : "Guarding the house";
        }
        
    }
}