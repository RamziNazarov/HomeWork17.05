using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork17._05.SOLID.L
{
    abstract class Birds
    { 
        protected int Wings { get; set; }
        protected int Eyes { get; set; }
        public void Eat()
        {
            Console.WriteLine("eat");
        }
    }
    abstract class FlightlessBirds : Birds
    {
        public void Walk()
        {
            Console.WriteLine("walk");
        }
    }
    abstract class FlyingBirds : FlightlessBirds
    {
        public void Fly()
        {
            Console.WriteLine("Fly");
        }
    }
    class Dove : FlyingBirds
    {
        public int ViewingAngle = 360;
    }
    class Penguin : FlightlessBirds
    {
        public void Swim()
        {
            Console.WriteLine("Swim");
        }
    }
}
