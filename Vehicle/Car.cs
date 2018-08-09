﻿namespace Vehicle
{
    public class Car
    {
        public IEngine Engine {get; private set;}
        public byte PetrolLitresConsumed { get; private set; }
        public double MetresTraveled { get; private set; }

        public Car()
        {
            MetresTraveled = 0;
            PetrolLitresConsumed = 0;

            // TODO: Refactor this to practice the 'Dependency Inversion' Principle
            Engine = new BigEngine();
        }

        public void Start()
        {
            Engine.Start();
        }

        public void Stop()
        {
            Engine.Stop();
        }

        public void MoveForward()
        {
            if (!Engine.Started)
            {
                throw new CarNotStartedException();
            }

            MetresTraveled +=0.1;
            PetrolLitresConsumed++;
        }

        public void MoveBackward()
        {
            if (!Engine.Started)
            {
                throw new CarNotStartedException();
            }

            MetresTraveled-=0.1;
            PetrolLitresConsumed++;
        }

        public void Service()
        {
            Engine.Replace();
        }
    }
}
