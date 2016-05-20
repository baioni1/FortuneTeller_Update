using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_FortuneTeller
{
    class Program
    {
        public static List<Services>AvailableServices {get;set;} = new List<Services>();
        static void Main(string[] args)
        {
            
            FortuneTeller fortuneTeller = new FortuneTeller();
            FortuneTeller fortuneTeller1 = new FortuneTeller("Anjanie", "journeyman");
            CrystalBall crystalBall = new CrystalBall();
            PalmReading palmReader = new PalmReading();
            Tarrot tarrotRead = new Tarrot();

            fortuneTeller.Greet(); //say hi
            do
            {
                fortuneTeller.ListServices();
                int selection = int.Parse(Console.ReadLine());
                Magic selectedServices = (Magic)AvailableServices[0];
                try
                {
                    selectedServices = (Magic)AvailableServices[selection - 1];
                }
                catch (Exception e)
                {
                    Console.WriteLine("Since I was unable to read your response, I going to start with");
                }
                fortuneTeller.StartService(selectedServices);
                selectedServices.Work();
                selectedServices.Show();
                selectedServices.StateEffectiveness();
                fortuneTeller.PlayAgain();
                //Console.WriteLine("Enter an object that has significance to you.");
                //string treasuredObject = Console.ReadLine();
                //crystalBall.Work(); //run it (do the service)
                //crystalBall.Show(treasuredObject); //display it (state results of the service)
                //crystalBall.StateEffectiveness(); //state effectiveness of service.
                //fortuneTeller.Farewell(); //say goodbye.

                ////Services mySevices = new Services();

                //Console.WriteLine("How old are you?");
                //int age = int.Parse(Console.ReadLine());
                //Tarrot tarrotRead = new Tarrot(age);
                //tarrotRead.AgeCard(age);

                //OnLineDating myOnlineDating = new OnLineDating();
                //myOnlineDating.Approval();
                //myOnlineDating.ExpertLevel();
                //myOnlineDating.DatingProbability();
            }
            while (Console.ReadLine() == "Y");
        }
    }
}
