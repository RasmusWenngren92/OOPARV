
namespace OOP_Arv
{
    public class Dog : Animal  //creating a Dog class that inherits from Animal
    {
        public Dog(string color, int age, bool isVenomous, string diet, bool isDomesticated, bool isAGoodBoy) : base(color, age, isVenomous, diet, isDomesticated)
        {
             IsAGoodBoy = isAGoodBoy;
        }

        protected bool IsAGoodBoy { get; set; } //unique boolean property
        
        public override string MakeSound()
        {
            return "Voff Voff";
        }

        public override string Eat()
        {
            return $"The {GetType().Name} is chewing on a bone.";
        }

        public override string Sleep()
        {
            return $"The {GetType().Name} is sound asleep in it's basket.";
        }

        public virtual string UniqueFeature(bool isAGoodBoy)
        {
            return IsAGoodBoy ? "Gets a good belly rub!" : "Do NOT bite the pillows!";
        }
        
        public virtual string Fetch()
        {
            return $"The {GetType().Name} is happily returning the stick that you threw and is now waiting for you to throw it again.";
        }
        
        public override string ToString()
        {
            return base.ToString() + $"\n\tIs it a good boy? : {IsAGoodBoy}" +
                   $"\n\t{UniqueFeature(IsAGoodBoy)}" + $"\n\t{Fetch()}";
        }
    }
}