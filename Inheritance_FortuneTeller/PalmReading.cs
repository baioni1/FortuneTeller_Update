using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_FortuneTeller
{
    class PalmReading:Magic,IRandomPhrases
    {
        //straight up field. I really don't need a property. Just using globally so random behaves well.
        //  private Random random 
        public Random Random { get; set; } = new Random();
        //properties
        public List<string> Phrases { get; set; } = new List<string>();
        public override string Name { get; set; } = "Palm Reading";
        public override Enum Difficulty { get; set; } = DifficultyOptions.hard;

        public override void Work()
        {
            
            //now let's call a method that will get a result for the crystal ball
            Result = GetPhrase();
        }
        public void CreatePhrases()
        {
            Phrases.Add(" your lifeline is short, but has amazing adventures in your future. ");
            Phrases.Add(" your lifeline is long and prosperous.");
            Phrases.Add(" your lifeline is grand in scale and is awed by many.");
        }
        //let's create an overloaded method now
        protected void CreatePhrases(string phrase)
        {
            Phrases.Add(phrase);
        }
        public string GetPhrase()
        {
            //local variable
            int randomNumber = Random.Next(Phrases.Count);
            return Phrases.ElementAt(randomNumber);
        }
        //constructor
        //let's override some of the properties of what we inherited from magic and service here.
        public PalmReading()
        {
            Price = 45.00M;
            PercentEffective = 65;
            BlackMagic = false;
            Difficulty = DifficultyOptions.hard;
            Program.AvailableServices.Add((Services)this);
            //I want to call my initializer for phrases.
            CreatePhrases();
        }
    }
}
