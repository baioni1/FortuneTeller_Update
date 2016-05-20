using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_FortuneTeller
{
    class OnLineDating:Dating
    {   //overriding name for online dating service
        public override string Name { get; set; } =  "Julie's Online Dating";
        //overriding approval rating set up in dating class
        public override int ApprovalRating { get; set; } = 99;
        //overriding level experience from dating class
        public override string LevelExpertise { get; set; } = "Expert";
        public override string Hair { get; set; }
        public override int Height { get; set; }
        public override string EyeColor { get; set; }
        //constructor for fields initialized in dating class
        //work in progress, trying to make these fields relay chances the user has to finding a match online
        public OnLineDating()
        {
            Hair = "brown";
            Height = 6;
            EyeColor = "green";
        }
        //this is work in progress to use this method to relay chances of match
        public void DatingProbability()
        {
            Console.WriteLine($"Your profile of {Hair} hair indicates a high probability of success!");
            Console.WriteLine($"Your profile of {Height}' tall indicates a medium probability of success");
            Console.WriteLine($"Your profile of {EyeColor} eyes indicates a low probability of success");
        }
        
        


    }
}