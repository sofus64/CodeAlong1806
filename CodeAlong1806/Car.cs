using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlong1806
{
    internal class Car
    {
        private string name;
        private int speed = 10;
        private int distanceDriven;

        public Car(string name)
        {
            this.name = name;
        }

        //public bool HasFinished()
        //{
        //    if (distanceDriven >= 0000)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        private void ChangeSpeed()
        {
            speed = RandomSpeed();
        }

        private int RandomSpeed()
        {
            var random = new Random();
            return random.Next(60, 200);
        }

        //private void DecreaseSpeed()
        //{
        //    speed -= 10;
        //}

        //private void IncreaseSpeed()
        //{
        //    speed += 10;
        //}

        public void Drive()
        {
            distanceDriven += speed;
            ChangeSpeed();
            ShowInfo();
        }

        public int GetSpeed()
        {
            return speed;
        }

        public int GetDistance()
        {
            return distanceDriven;
        }

        public string GetName()
        {
            return name;
        }

        private void ShowInfo()
        {
            Console.WriteLine($"{GetName()}");
            Console.WriteLine($"Fart: {GetSpeed()}");
            Console.WriteLine($"Distance {GetDistance()}");
        }

    }
}
