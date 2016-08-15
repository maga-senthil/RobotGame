using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotBaseDerived
{
   public class Car : Robot 
    {

       

        public Car ()
        {
            this.name = "car";
            this.recharge = 300;

        }
        public override void powerInput()
        {
            base.powerInput();
        }
       
        public override void getInput()
        {
            base.getInput();
        }
        public override float  powerRecharge()
        {
            base.powerRecharge();
            return recharge;
        }


        public override void printOutput()
        {
            
            base.printOutput ();
            Console.WriteLine("How is your robot car do you like it");
            
           
            
            
        }
        
    }
}
