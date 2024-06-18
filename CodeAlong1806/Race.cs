using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlong1806
{
    internal class Race
    {
        private List<Car> participants;
        private int length = 10000;

        public Race()
        {
            participants = new List<Car>();
        }

        public void AddParticipant(Car car)
        {
            participants.Add(car);
        }

        public bool HasFinished()
        {
            foreach (var car in participants)
            {
                if (car.GetDistance() >= length)
                {
                    Console.WriteLine($"{car.GetName()} har vunnet!");
                    return true;
                }
            }
            return false;
        }
        public List<Car> GetParticipants()
        {
            return participants;
        }
    }
}
