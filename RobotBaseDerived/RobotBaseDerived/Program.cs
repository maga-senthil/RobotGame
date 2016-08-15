using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotBaseDerived
{
    class Program
    {
        static void Main(string[] args)
        {
            Car newRobotcar = new Car();
            newRobotcar.powerInput();
            newRobotcar.getInput();
            newRobotcar.powerRecharge();
            newRobotcar.printOutput();
            Plane newRobotplane = new Plane();
            newRobotplane.powerInput();
            newRobotplane.getInput();
            newRobotplane.powerRecharge();
            newRobotplane.printOutput();
            Drone newRobotDrone = new Drone();
            newRobotDrone.powerInput();
            newRobotDrone.getInput();
            newRobotDrone.powerRecharge();
            newRobotDrone.printOutput();
            Console.ReadLine();


        }
    }
}
