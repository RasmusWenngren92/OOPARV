using System.Collections;

namespace OOP_Arv
{
    public abstract class Animal // creating a abstract class
        (string color, int age, bool isVenomous, string diet, bool isDomesticated)//Primary Constructor
    {   //Creating properties
        public string? Color { get; set; } = color;
        public int? Age { get; set; } = age;

        public bool? IsVenomous { get; set; } = isVenomous;
        public string? Diet { get; set; } = diet;
        public bool? IsDomesticated { get; set; } = isDomesticated;

        //Creating abstract methods
        public abstract string MakeSound();

        public abstract string Eat();

        public abstract string Sleep();

        
        //Constructor with 5 different parameters


        public override string ToString()//Override method that returns a string representation of an object
        {
            return $"\n\tThe {GetType().Name} has the colour: {Color}. " +
                   $"\n\tIt is {Age} years old." +
                   $"\n\tIts diet is {Diet}." +
                   $"\n\tIs it Venomous? : {IsVenomous}." +
                   $"\n\tIs it a domesticated animal? : {IsDomesticated}." +
                   $"\n\tIt sounds like this: {MakeSound()}" +
                   $"\n\t{Eat()}" +
                   $"\n\t{Sleep()}";
        }
        
    }
}