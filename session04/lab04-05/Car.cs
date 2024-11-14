using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04_05
{
    public class Car : IMovable
    {
        //declare the underlying field used by the 
        //Started property of the IDrivable interface 
        private bool started = false;
        //implement the Start() methor of the IDrivable interface 
        public void Start()
        {
            Console.WriteLine("Car started");
            started = true;
        }

        //Implement the Stop() methodef the IDrivable interface 
        public void Stop()
        { 
             Console.WriteLine("Car Stopped");
            started = false;
        }

        //implement the Started property of the IDrivable interface 
        public bool Started
        { 
            get { return started; }
        }
        //implement the TurnLeft() method of the ISteerable interface
        public void TurnLeft()
        { 
            Console.WriteLine("car_turning left");
        }

        //implement the TurnRight() method of the ISteerable interface 
        public void TurnRight()
        {
            Console.WriteLine("car_turning right");
        }

        //implement the Accelerate() methor of the IMovable interface 
        public void Accelerate()
        {
            Console.WriteLine("car acclerating");
        }

        //implement the Brake() method of the IMovable interface 
        public void Break() {
            Console.WriteLine("car braking");
        }
    }
}
