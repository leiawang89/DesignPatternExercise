using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercise
{
    /// <summary>
    /// The AmazonRobot implements the ICompany interface. 
    /// It is a concrete implementation of the interface.
    /// </summary>
    public class AmazonRobot : ICompany
    {
        public void buidRobotHead()
        {
            Console.WriteLine("Amazon Robot: Steel Head");
        }

        public void buildRobotArms()
        {
            Console.WriteLine("Amazon Robot: Steel Arms");
        }

        public void buildRobotLegs()
        {
            Console.WriteLine("Amazon Robot: Steel legs");
        }

        public void buildRobotTorso()
        {
            Console.WriteLine("Amazon Robot: Steel torso");
        }

        public void provideSpeechRecognitionAbility(string language)
        {
            Console.WriteLine("Amazon Robot: I can understand and speak " + language);
        }
    }
}
