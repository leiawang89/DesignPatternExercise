using System;

namespace CodingExercise
{
    public class TestRobot
    {
        static void Main(string[] args)
        {
            IRobotBuilder exampleRobotBuilder = new ExampleRobotBuilder();
            RobotDirector robotDirector = new RobotDirector(exampleRobotBuilder);
            robotDirector.ConstructRobot();
            Robot robot = robotDirector.GetRobot();

            Console.WriteLine("Robot Head: " + robot.RobotHead);
            Console.WriteLine("Robot Torso: " + robot.RobotTorso);
            Console.WriteLine("Robot Arms: " + robot.RobotArms);
            Console.WriteLine("Robot Legs: " + robot.RobotLegs);
        }
    }
}
