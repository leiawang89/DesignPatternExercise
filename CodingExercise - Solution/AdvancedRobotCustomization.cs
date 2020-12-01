using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercise
{
    /// <summary>
    /// This is an advanced class for robot customization which implements 
    /// the robot custiomzation.
    /// </summary>
    public class AdvancedRobotCustomization : RobotCustomization
    {
        // take an object of company interface as an parameter and pass it to the 
        //constructor of base class.
        public AdvancedRobotCustomization(ICompany company)
            : base(company)
        { }

        // a method for providng the speech recognition ability.
        public void provideSpeechRecognitionAbility(string language)
        {
            company.provideSpeechRecognitionAbility(language);   
        }
    }
}
