using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using WolvesAndRabbitsSimulation.Engine;

namespace WolvesAndRabbitsSimulation.Simulation
{
    class Rabbit : GameObject
    {
        private int DEATH_AGE = 1500;//edad de muerte
        private int ADULTHOOD = 100;//edad adulta
        private int FOOD_TO_BREED = 100;//comida para hijo
        private int FOOD_CONSUMPTION = 25; //comida consumida
        private int MAX_CHILDREN = 30;//max hijos 
        private double BREED_PROBABILITY = 0.3;//probabilidad de tener hijos 
        private double DEATH_PROBABILITY = 0.5;//Probabilidad de morir

        private int age = 0; //edad inicial
        private int food = 500; //comida inicial

        public Rabbit()
        {
            Color = Color.White;
        }

        public override void UpdateOn(World forest)
        {
            EatSomeGrass(forest);
            Breed(forest);
            GrowOld(forest);
            ConsumeFood(forest);
            Wander(forest);
        }

        private void EatSomeGrass(World forest)//Come pasto y baja la vida del grass
        {
            Grass grass = forest.ObjectsAt(Position).Select(o => o as Grass).First(o => o != null);
            int amount = FOOD_CONSUMPTION * 2;
            if (grass.Growth < amount)
            {
                amount = grass.Growth;
            }
            grass.Growth -= amount;
            food += amount;
        }

        private void Breed(World forest)//mira si tiene un hijo o no 
        {
            if (age < ADULTHOOD || food < FOOD_TO_BREED) return;//si su edad es muy alta o no tiene suficiente comida, no hago nada 
            if (forest.ObjectsAt(Position).Any(o => o is Rabbit && o != this))
            {
                for (int i = 0; i < MAX_CHILDREN; i++)
                {
                    if (forest.Random(1, 10) <= 10 * BREED_PROBABILITY)
                    {
                        Rabbit bunny = new Rabbit();
                        bunny.Position = Position;
                        forest.Add(bunny);
                    }
                }
            }
        }

        private void GrowOld(World forest)//mato a los conejos adultos
        {
            age++;
            if (age >= DEATH_AGE) { Die(forest); }
        }

        private void ConsumeFood(World forest)//mato a los conejos sin comida
        {
            food -= FOOD_CONSUMPTION;
            if (food <= 0) { Die(forest); }
        }

        private void Die(World forest)//revisar
        {
            if (forest.Random(1, 10) <= 10 * DEATH_PROBABILITY)
            {
                forest.Remove(this);
            }
        }

        private void Wander(World forest)//camina x ahi
        {
            Forward(forest.Random(1, 5));
            Turn(forest.Random(-100, 100));
        }
    }
}
