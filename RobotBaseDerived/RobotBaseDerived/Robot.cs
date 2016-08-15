using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotBaseDerived
{
    public class Robot
    {
        
        
        public float power;
        public float recharge;
        public string getPower;
        public string name;

        
        public virtual void powerInput()
        {
            Console.WriteLine("Your robot type is" + " " + name);
        }
        public virtual  float powerRecharge()
        {
            recharge += power;
            return recharge;
        }

        public virtual void  getInput()
        {
            Console.WriteLine("Enter your robot power:");
           getPower = Console.ReadLine();
            power = float.Parse(getPower);
            
        }

        public virtual void printOutput()
        {
           
            Console.WriteLine("your robot power is" + " " + getPower);
            Console.WriteLine("your robot recharge is"+ " " + recharge );
            Console.WriteLine("your robot status is on");
        }

    }
}
