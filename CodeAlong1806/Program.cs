namespace CodeAlong1806
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var race = new Race();
            race.AddParticipant(new Car("Bil1"));
            race.AddParticipant(new Car("Bil2"));

            while (!race.HasFinished())
            {
                foreach (var car in race.GetParticipants())
                {
                    car.Drive();
                }
            }
        }
    }
}
