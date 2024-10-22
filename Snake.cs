using System.Collections;

namespace OOP_Arv
{
    public class Snake(string color, int age, bool isVenomous, string diet, bool isDomesticated, bool rattels)
        : Animal(color, age, isVenomous, diet, isDomesticated) //new class from animal
    {
        private bool Rattels { get; set; } = rattels; //unique boolean property

        private string UniqeFeature { get; set; } = uniqueFeature(rattels);
        
        public override string MakeSound()
        {
            return "Sssssssh";
        }

        public override string Eat()
        {
            return "The Snake eats a little mouse.";
        }

        private static string uniqueFeature(bool rattels)
        {
            return rattels ? "You stept on it's tail and it has now bitten your ankel." : "All is calm.";
        }
        public override string Sleep()
        {
            return "The Snake is curled up in the tall grass in the sun.";
        }

        public override string ToString()
        {
            return base.ToString() + $"\n\tDoes it rattle? : {Rattels}" +
                   $"\n\t{UniqeFeature}";
        }
       
    }
}