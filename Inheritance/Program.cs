using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // DONE - Create a class Animal
            // DONE - give this class 4 members that all Animals have in common


            // DONE - Create a class Bird
            // DONE - give this class 4 members that are specific to Bird
            // DONE - Set this class to inherit from your Animal Class

            // DONE - Create a class Reptile
            // DONE - give this class 4 members that are specific to Reptile
            // DONE - Set this class to inherit from your Animal Class




            /* DONE - Create an object of your Bird class
             * DONE - give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird cardinal = new Bird();
            cardinal.Skin = "feathers";
            cardinal.canMove = true;
            cardinal.Dwelling = "nest";
            cardinal.hasLimbs = true;
            cardinal.Feathers = "red";
            cardinal.canFly = true;
            cardinal.Nest = "sticks";
            cardinal.hasWings = true;

            Console.WriteLine($"Cardinals have {cardinal.Feathers} feathers. They dwell in nests made of {cardinal.Nest}. To say they can fly is {cardinal.canFly} and to say they have wings is {cardinal.hasWings}.");


            /* DONE - Create an object of your Reptile class
             * DONE - give values to your members using the object of your Reptile class
             *  
             * DONE - Creatively display the class member values 
             */

            Reptile crocodile = new Reptile();
            crocodile.Skin = "scales";
            crocodile.canMove = true;
            crocodile.Dwelling = "swamp";
            crocodile.hasLimbs = true;
            crocodile.Scales = "green";
            crocodile.canSwim = true;
            crocodile.Land_Water = "land and water";
            crocodile.hasForelegs = true;

            Console.WriteLine($"Crocodiles have {crocodile.Scales} scales. They dwell in {crocodile.Land_Water}. To say they can swim is {crocodile.canSwim} and to say they have forelegs is {crocodile.hasForelegs}.");
        }
    }
}
