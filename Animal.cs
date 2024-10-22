using System.Collections;

namespace OOP_Arv
{
    public abstract class Animal// creating a abstract class
    {   //Creating propperties
        public string? Color { get; set; }
        public int? Age { get; set; }

        public bool? IsVenomous { get; set; }
        public string? Diet { get; set; }
        public bool? IsDomesticated { get; set; }
        
        //Creating abstract methods
        public abstract string MakeSound();

        public abstract string Eat();

        public abstract string Sleep();

        
        //Constructor with 5 different parameters
        public Animal(string color, int age, bool isVenomous, string diet, bool isDomesticated) 
        {
            Color = color;
            Age = age;
            IsVenomous = isVenomous;
            Diet = diet;
            IsDomesticated = isDomesticated;
        }
        

        public override string ToString()//override method that returns a string representation of an object
        {
            return $"\n\tThe {GetType().Name} has the colour: {Color}. " +
                   $"\n\tIt is {Age} years old." +
                   $"\n\tIts diet is {Diet}." +
                   $"\n\tIs it Venomus? : {IsVenomous}." +
                   $"\n\tIs it a domesticated animal? : {IsDomesticated}." +
                   $"\n\tIt sounds like this: {MakeSound()}" +
                   $"\n\t{Eat()}" +
                   $"\n\t{Sleep()}";
        }
        
    }
}