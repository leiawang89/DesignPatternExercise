using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercise
{
    /// <summary>
    /// The TeslaRobot implements the ICompany interface. 
    /// It is a concrete implementation of the interface.
    /// </summary>
    public class TeslaRobot : ICompany
    {
        public void buidRobotHead()
        {
            Console.WriteLine("Tesla Robot: Aluminum Head");
        }

        public void buildRobotArms()
        {
            Console.WriteLine("Tesla Robot: Aluminum Arms");
        }

        public void buildRobotLegs()
        {
            Console.WriteLine("Tesla Robot: Aluminum legs");
        }

        public void buildRobotTorso()
        {
            Console.WriteLine("Tesla Robot: Aluminum torso");
        }

        public void provideSpeechRecognitionAbility(string language)
        {
            Console.WriteLine("Tesla Robot: I can understand and speak " + language);
        }
    }
}
