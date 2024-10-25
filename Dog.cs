
namespace OOP_Arv
{
    public class Dog(
        bool isVenomous = false,
        string diet = "Omnivore",
        bool isDomesticated = true,
        bool isAGoodBoy = true,
        string color = "Brown",
        int age = 15)
        : Animal(color, age, isVenomous, diet, isDomesticated) //creating a Dog class that inherits from Animal with a primary constructor
    {
        protected bool IsAGoodBoy { get; } = isAGoodBoy; //unique boolean property

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

        public virtual string UniqueFeature()
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
                   $"\n\t{UniqueFeature()}" + $"\n\t{Fetch()}";
        }
    }
}