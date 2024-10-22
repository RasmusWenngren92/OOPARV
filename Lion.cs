
namespace OOP_Arv
{
    public class Lion(string color, int age, bool isVenomous, string diet, bool isDomesticated, bool hasMane)
        : Animal(color, age, isVenomous, diet, isDomesticated) //new class from animal
    {
        private bool HasMane { get; set; } = hasMane; //unique boolean property
     
    
        public override string MakeSound()
        {
             return "Roar!";
        }

        public override string Eat()
        {
            return "The Lion eats a juciy pieces of meat.";
        }

        private string UniqueFeature(bool hasMane)
        {
            return HasMane ? "The Lion shakes its mane gracioulsly!" : "This lion doesn't have a mane";
        }
        public override string Sleep()
        {
            return "The Lion is sound asleep benethe a tree.";
        }
        public override string ToString()
        {
            return base.ToString() + $"\n\tDoes it have a mane? : {HasMane}" +
                   $"\n\t{UniqueFeature(HasMane)}";
        }
    }
}