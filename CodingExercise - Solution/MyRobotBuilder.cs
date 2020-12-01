using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercise
{
    /// <summary>
    /// The concrete Robot class based on the IRobotBlueprint interface
    /// </summary>
    public class MyRobotBuilder : IRobotBuilder
    {
        private Robot robot;

        private MyRobotBuilder()
        {
            this.robot = new Robot();
        }

        public static MyRobotBuilder instance = null;

        public static MyRobotBuilder GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MyRobotBuilder();
                }
                return instance;
            }
        }

        public void BuildRobotHead()
        {
            this.robot.RobotHead = "Steel Head";
        }

        public void BuildRobotTorso()
        {
            this.robot.RobotTorso = "Diamond Torso";
        }

        public void BuildRobotArms()
        {
            this.robot.RobotArms = "Flamethrower Arms";
        }

        public void BuildRobotLegs()
        {
            this.robot.RobotLegs = "Tank Tread Legs";
        }

        public Robot GetRobot()
        {
            return this.robot;
        }
    }
}
