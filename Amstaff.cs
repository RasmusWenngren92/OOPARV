
namespace OOP_Arv
{
    public class Amstaff(string color, int age, bool isVenomous, string diet, bool isDomesticated, bool isAgressive)
        : Dog(color, age, isVenomous, diet, isDomesticated, isAGoodBoy)
    {
        private static bool isAGoodBoy = true;

        private bool IsAgressive { get; set; } = isAgressive; //unique boolean property
       
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

        public override string UniqueFeature(bool isAgressive)
        {
            return IsAgressive? "Chasing away the intruders!" : "Guarding the house";
        }
        
    }
}