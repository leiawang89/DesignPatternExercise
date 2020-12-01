using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercise
{
    /// <summary>
    /// This is a inteface that contains several operations. 
    /// </summary>
    public interface ICompany
    {
        void buidRobotHead();
        void buildRobotTorso();
        void buildRobotArms();
        void buildRobotLegs();
        void provideSpeechRecognitionAbility(string language);

    }
}
