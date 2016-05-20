using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_FortuneTeller
{
    interface IRandomPhrases
    {   /// <summary>
    /// interface makes it required to have a random in it
    /// </summary>
        Random Random { get; set; }//property set for random needs in the class
        List<string> Phrases { get; set; }
        void CreatePhrases();//method with no body or modifiers or params
        string GetPhrase();
    }
}
