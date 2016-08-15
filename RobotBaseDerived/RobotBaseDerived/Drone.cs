using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotBaseDerived
{
    class Drone : Robot
    {
        
        

        public Drone()
        {
            this.name = "Drone";
             this.recharge = 200;

        }
        public override void powerInput()
        {
            base.powerInput();
        }
        
        public override void getInput()
        {
            base.getInput();
        }
        public override float powerRecharge()
        {
            base.powerRecharge();
            return recharge;
        }
        public override void printOutput()
        {
           
            base.printOutput();
            Console.WriteLine("Hi, I am a power full drone next time give me more power");
         }

    }
}
