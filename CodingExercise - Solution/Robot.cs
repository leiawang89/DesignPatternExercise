using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercise
{
    public class Robot : IRobotBlueprint
    {
        public string RobotHead { get; set; }

        public string RobotTorso { get; set; }

        public string RobotArms { get; set; }

        public string RobotLegs { get; set; }
    }
}
