using System;
namespace Inheritance
{
	public class Reptile : Animal
	{
		public Reptile()
		{
		}

        public string Scales { get; set; }
        public bool canSwim { get; set; }
        public string Land_Water { get; set; }
        public bool hasForelegs { get; set; }
    }
}

