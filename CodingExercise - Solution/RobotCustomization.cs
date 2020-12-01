using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercise
{
    /// <summary>
    /// This is a basic class for robot customization.
    /// </summary>
    public class RobotCustomization
    {
       // this field is the bridge between the two separate hierarchies.
        protected ICompany company;

        // constrcutor
        public RobotCustomization(ICompany company)
        {
            this.company = company;
        }

        public void buildRobotHead()
        {
            company.buidRobotHead();
        }

        public void buildRobotTorso()
        {
            company.buildRobotTorso();
        }

        public void buildRobotArms()
        {
            company.buildRobotArms();
        }

        public void buildRobotLegs()
        {
            company.buildRobotLegs();
        }
    }
}
