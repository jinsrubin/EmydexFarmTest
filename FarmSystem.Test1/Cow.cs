﻿using FarmSystem.Test2;
using System;

namespace FarmSystem.Test1
{
    public class Cow : Animal, IMilkableAnimal
    {
       public Cow()
            :base()
        {
           
        }
        public string NameOfAnimal
        {
            get;
            set;
        }
        public override void Talk()
        {
            Console.WriteLine("Cow says Moo!");
        }

        public override void Walk()
        {
            Console.WriteLine("Cow is walking");
        }

        public new void ProduceMilk()
        {
            Console.WriteLine("Cow was milked");
        }

        public override void Run()
        {
            Console.WriteLine("Cow is running");
        }

    }
}