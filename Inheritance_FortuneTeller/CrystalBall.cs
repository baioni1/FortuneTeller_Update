using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_FortuneTeller
{
    class CrystalBall :Magic,IRandomPhrases
    {


        //straight up field. I really don't need a property. Just using globally so random behaves well.
      //  private Random random 
        public Random Random{ get; set; } = new Random();
        //properties
        public List<string> Phrases { get; set; } = new List<string>();
        public override string Name { get; set; } = "Crystal Ball";
        public override Enum Difficulty { get; set; } = DifficultyOptions.easy;
        
        public override void Work()
        {
            base.Work();
            //now let's call a method that will get a result for the crystal ball
            Result = GetPhrase();
        }
        public void CreatePhrases()
        {
            Phrases.Add(" has been to many parts of the world. ");
            Phrases.Add(" was once owned by a white haired man with a beard.");
            Phrases.Add(" will be important to you in a future endeavor.");
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
        public CrystalBall()
        {
            Price = 45.00M;
            PercentEffective = 65;
            BlackMagic = false;
            Difficulty=DifficultyOptions.easy;
            Program.AvailableServices.Add((Services)this);
            //I want to call my initializer for phrases.
            CreatePhrases();
        }
    }
    
}
