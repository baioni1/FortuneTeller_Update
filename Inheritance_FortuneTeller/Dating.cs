using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_FortuneTeller
{
    class Dating:Services
    {
        

        //create some properties
        public override string Name { get; set; }
        public virtual int ApprovalRating { get; set; }
        public virtual string LevelExpertise { get; set; }
        public virtual string UserProfile { get; set; }
        //create another property that has features the user is looking for
        public virtual string Hair { get; set; }
        public virtual int Height { get; set; }
        public virtual string EyeColor { get; set; }
        
        public override decimal Price { get; set; }

        public override string Result { get; set; }
        

        //method that shows user rating of the online dating service 
        public virtual void Approval()       
        {
            Console.WriteLine($"{Name} has a {ApprovalRating} approval rating!");
        }
        //method that tells the user what type of experience that is recommended for online dating
        public virtual void ExpertLevel()
        {
            Console.WriteLine($"For maximum dating experience,\n{Name} recommends you have {LevelExpertise} dating skills!");
        }
        
        
           
        
    }
}
