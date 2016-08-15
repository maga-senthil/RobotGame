using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotBaseDerived
{
    class Plane : Robot 
    {
        
        public Plane()
        {
            this.name = "Plane";
            this.recharge = 4000;
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
            Console.WriteLine("You are now ready for a adventure ride");



        }
    }
}
