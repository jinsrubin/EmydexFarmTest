using System;
using System.Collections.Generic;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {

        //TEST 1

        public void Enter()
        {


            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities




            foreach (var animal in Program.animals)
            {
                Console.WriteLine($"{animal} has entered the farm");
                //test
            }


        }


        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk

            Cow cow = new Cow();
            cow.Talk();

            Hen hen = new Hen();
            hen.Talk();

            Horse horse = new Horse();
            horse.Talk();

            Sheep sheep = new Sheep();
            sheep.Talk();



        }

        //TEST 3
        public void MilkAnimals()
        {

            Cow cow = new Cow();
            cow.ProduceMilk();
        }

        //TEST 4
        public void ReleaseAllAnimals(object animal)
        {

            //Console.WriteLine("There are still animals in the farm, farm is not free");
            Type t = animal.GetType();

            String nameOfAnimal = t.Name;
            Console.WriteLine($"{nameOfAnimal} has left the farm");
        }
        public event EventHandler ReleaseAnimals;

        protected virtual void OnReleaseAnimals(EventArgs e)
        {
            EventHandler handler = ReleaseAnimals;
            handler?.Invoke(this, e);
        }

    }
}