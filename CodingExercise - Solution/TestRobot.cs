using System;

namespace CodingExercise
{
    public class TestRobot
    {
        static void Main(string[] args)
        {
            // Builder Design Pattern application
            Console.WriteLine("Builder Design Pattern application:");
            IRobotBuilder exampleRobotBuilder = new ExampleRobotBuilder();
            RobotDirector exampleRobotDirector = new RobotDirector(exampleRobotBuilder);
            exampleRobotDirector.ConstructRobot();
            Robot robot = exampleRobotDirector.GetRobot();

            Console.WriteLine("Robot Head: " + robot.RobotHead);
            Console.WriteLine("Robot Torso: " + robot.RobotTorso);
            Console.WriteLine("Robot Arms: " + robot.RobotArms);
            Console.WriteLine("Robot Legs: " + robot.RobotLegs);

            Console.WriteLine();

            IRobotBuilder myRobotBuilder = MyRobotBuilder.GetInstance;
            RobotDirector myRobotDirector = new RobotDirector(myRobotBuilder);
            myRobotDirector.ConstructRobot();
            Robot robot2 = myRobotDirector.GetRobot();

            Console.WriteLine("Robot Head: " + robot2.RobotHead);
            Console.WriteLine("Robot Torso: " + robot2.RobotTorso);
            Console.WriteLine("Robot Arms: " + robot2.RobotArms);
            Console.WriteLine("Robot Legs: " + robot2.RobotLegs);

            Console.WriteLine();

            // Memento Pattern application
            Console.WriteLine("Memento Pattern application:");
            var memory = new RobotMemory();
            var history = new MemoryHistory();

            memory.setMemory("My name is IRobot!");
            history.push(memory.createMemory());

            memory.setMemory("I can cook!");
            history.push(memory.createMemory());

            memory.setMemory("I was made by XX company!");
            memory.restoreMemory(history.pop());

            Console.WriteLine(memory.getMemory()); // output: I can cook.
            Console.WriteLine();

            // Bridge Pattern application
            Console.WriteLine("Bridge Pattern application:");
            var robotCustomization = new RobotCustomization(new TeslaRobot());
            robotCustomization.buildRobotArms();
            robotCustomization.buildRobotHead();
            robotCustomization.buildRobotLegs();
            robotCustomization.buildRobotTorso();

            var advancedRobotCustomization = new AdvancedRobotCustomization(new TeslaRobot());
            advancedRobotCustomization.provideSpeechRecognitionAbility("English");
            Console.WriteLine();

            var robotCustomization2 = new RobotCustomization(new AmazonRobot());
            robotCustomization2.buildRobotArms();
            robotCustomization2.buildRobotHead();
            robotCustomization2.buildRobotLegs();
            robotCustomization2.buildRobotTorso();

            var advancedRobotCustomization2 = new AdvancedRobotCustomization(new AmazonRobot());
            advancedRobotCustomization2.provideSpeechRecognitionAbility("Spanish");
            Console.ReadKey();
        }
    }
}
