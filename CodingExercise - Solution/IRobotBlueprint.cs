using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercise
{
    /// <summary>
    /// This is the interface that will be returned from the builder.
    /// </summary>
    public interface IRobotBlueprint
    {
        public string RobotHead { get; set; }

        public string RobotTorso { get; set; }

        public string RobotArms { get; set; }

        public string RobotLegs { get; set; }
    }
}
