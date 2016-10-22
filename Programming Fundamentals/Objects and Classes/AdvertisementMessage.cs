using System;

namespace AdvertisementMessage
{
    public class AdvertisementMessage
    {
        public static void Main(string[] args)
        {
            string[] phrases = new[]
            {
                "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can’t live without this product."
            };

            string[] events = new[]
            {
                "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
            };

            string[] authors = new[]
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };

            string[] cities = new[]
            {
                "Burgas", "Sofia", "Varna", "Ruse", "Plovdiv"
            };

            int advertisementCount = int.Parse(Console.ReadLine());
            Random rand = new Random();

            for (int i = 0; i < advertisementCount; i++)
            {
                string currentPhrase = phrases[rand.Next(0, phrases.Length)];
                string currentEvent = events[rand.Next(0, events.Length)];
                string currentAuthor = authors[rand.Next(0, authors.Length)];
                string currentTown = cities[rand.Next(0, cities.Length)];
                Console.WriteLine("{0} {1} {2} - {3}", currentPhrase,
                                                        currentEvent,
                                                        currentAuthor,
                                                        currentTown);
            }
        }
    }
}
