
using System;


namespace FarmSystem.Test1
{
    public class Animal
    {

        public Animal()
        {
           
        }
      
        public virtual void Talk()
        {
            Console.WriteLine("Animal says Moo!");
        }


        public virtual void Walk()
        {
            Console.WriteLine("Animal is walking");
        }


        public virtual void ProduceMilk()
        {
            Console.WriteLine("Animal produced milk");
        }

        public virtual void Run()
        {
            Console.WriteLine("Animal is running");
        }
      
    }
}
