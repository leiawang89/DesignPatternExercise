using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercise
{
    public class ExampleRobotBuilder : IRobotBuilder
    {
        private Robot robot;

        public ExampleRobotBuilder()
        {
            this.robot = new Robot();
        }

        public void BuildRobotHead()
        {
            this.robot.RobotHead = "Aluminum Head";
        }

        public void BuildRobotTorso()
        {
            this.robot.RobotTorso = "Aluminum Torso";
        }

        public void BuildRobotArms()
        {
            this.robot.RobotArms = "Aluminum Arms";
        }

        public void BuildRobotLegs()
        {
            this.robot.RobotLegs = "Aluminum Legs";
        }

        public Robot GetRobot()
        {
            return this.robot;
        }
    }
}
