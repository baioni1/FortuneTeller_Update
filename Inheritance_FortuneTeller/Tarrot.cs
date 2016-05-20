using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_FortuneTeller
{
    class Tarrot: Magic
    {
        //create properties
        public int Age { get; set; }
        public override string Name { get; set; }
        
        internal void AgeCard(int age)
        {
            if (age < 20)
            {
                Console.WriteLine( "You are young and beautiful! Life is full of possibilities!"); 
            }
            else if (age < 35)
            {
                Console.WriteLine("You have a strong life line, continue on your path!");
            }
            else if (age < 45)
            {
                Console.WriteLine("You are a spring chicken with many years of love and happiness!");
            }
            else if(age > 55)
            {
                Console.WriteLine("You have wonderful stories to tell, be proud to share your knowledge");
            }
            Console.WriteLine("Life is great no matter what age you are!");
        }
        public Tarrot(int age)
        {
            this.Age = age;


        }
        public Tarrot()
        {
            Name = "Tarrot Cards";
            Age = 33;
            Program.AvailableServices.Add((Services)this);
        }

    }
    
    

    
}
