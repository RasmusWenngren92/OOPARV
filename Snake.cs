﻿using System.Collections;

namespace OOP_Arv
{
    public class Snake(
        int age = 1, 
        bool isVenomous = true,
        string diet = "Carnivore",
        bool isDomesticated = false,
        bool rattels = true,
        string color = "Unknown")
        : Animal(color, age, isVenomous, diet, isDomesticated) //new class from animal
    {
        private bool Rattels { get; } = rattels; //unique boolean property

        public override string MakeSound()
        {
            return "Sssssssh";
        }

        public override string Eat()
        {
            return "The Snake eats a little mouse.";
        }

        public static string UniqueFeature(bool rattels)
        {
            return rattels ? "You step on it's tail and it has now bitten your ankle." : "All is calm.";
        }
        public override string Sleep()
        {
            return "The Snake is curled up in the tall grass in the sun.";
        }

        public override string ToString()
        {
            return base.ToString() + $"\n\tDoes it rattle? : {Rattels}" +
                   $"\n\t{UniqueFeature}";
        }
       
    }
}