using System;
namespace Inheritance
{
	public class Bird : Animal
	{
		public Bird()
		{
		}

        public string Feathers { get; set; }
        public bool canFly { get; set; }
        public string Nest { get; set; }
        public bool hasWings { get; set; }
    }
}

