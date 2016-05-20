using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_FortuneTeller
{
    internal enum DifficultyOptions { easy,medium,hard};

    abstract class Services
    {
        //Properties
        //services have costs
        //I want this to be overrideable.
        public abstract decimal Price { get; set; }
        //all services have a name.
        public abstract string Name { get; set; }
        //Let's make a property to store some result. Let's just say it's a single result and it's a string.
        public abstract string Result { get; set; }
        //We might want to track other things too, but we can add on later if we'd like
        //public List<string> ServiceChoice { get; set; } = new List<string>();
        //internal virtual List<string> MagicList { get; set; } = new List<string>();
        //internal virtual List<string> DatingList { get; set; } = new List<string>();
        public virtual Enum Difficulty { get; set; } = DifficultyOptions.medium;

        public virtual void Show()
        {

        }
        public virtual void Work()
        {

        }
        //public void ServiceListAdd()
        //{
        //    ServiceChoice.Add("Magic");
        //    ServiceChoice.Add("Dating");
        //}

        //public void MagicListAdd()
        //{
        //    MagicList.Add("Crystal Ball");
        //    MagicList.Add("Tarrot Cards");
        //}

        //public void DatingListAdd()
        //{
        //    DatingList.Add("Online Dating");
        //}


        //WHEN I HAVE THIS UP, THE DATING PART DOESN'T WORK IN MAIN?  
        //public Services(List<string> serviceChoice)
        //{
        //    this.ServiceChoice = serviceChoice;
        //}
    }
}
