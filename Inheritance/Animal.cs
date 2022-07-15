using System;
namespace Inheritance
{
	public class Animal
	{
		public Animal()
		{
		}

        // 4 members that all animals have in common: Skin, Habitat, Vore, Transport; 

        public string Skin { get; set; }
        public bool canMove { get; set; }
        public string Dwelling { get; set; }
        public bool hasLimbs { get; set; }
    }
}

