using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercise
{
    /// <summary>
    /// the director or engineer class creates a Robot using the builder interface that is defined()
    /// </summary>
    public class RobotDirector
    {
        private IRobotBuilder robotBuilder;

        public RobotDirector(IRobotBuilder robotBuilder)
        {
            this.robotBuilder = robotBuilder;
        }

        public Robot GetRobot()
        {
            return this.robotBuilder.GetRobot();
        }

        public void ConstructRobot()
        {
            this.robotBuilder.BuildRobotHead();
            this.robotBuilder.BuildRobotTorso();
            this.robotBuilder.BuildRobotArms();
            this.robotBuilder.BuildRobotLegs();
        }
    }
}
