using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercise
{
    public interface IRobotBuilder
    {
        public void BuildRobotHead();

        public void BuildRobotTorso();

        public void BuildRobotArms();

        public void BuildRobotLegs();

        public Robot GetRobot();
    }
}
