using System;

namespace JurassicPark

{
    class Program
    {
        static void Main(string[] args)
        {
            // Greeting to Jurassic Park
            Console.WriteLine("Welcome to Jurassic Park!");
            Console.WriteLine("Here are your current dinosaurs in Jurassic Park.");
            var tracker = new DinosaurTracker();

            // Ask the user what they would like to to do. "see all", "add", "remove", "transfer", "quit"
            var isRunning = true;
            while (isRunning)
            {
                foreach (var d in tracker.Dinosaurs)
                {
                    Console.WriteLine($"{d.DinoName}, {d.DietType}, {d.DateAcquired}, {d.DinoWeight}, {d.EnclosureNumber}");
                }
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("(SEE ALL DINOSAURS), (ADD), (REMOVE), (TRANSFER), (QUIT) ");
                var input = Console.ReadLine().ToLower();
                if (input == "add")
                {
                    Console.WriteLine("What dinosaur do you want to add?");
                    var what = Console.ReadLine();
                    Console.WriteLine("What kind of diet does it have?");
                    var diet = Console.ReadLine();
                    Console.WriteLine("How much does it weigh?");
                    var weight = Console.ReadLine();
                    Console.WriteLine("Where you you want to place the dinosaur");
                    var number = Console.ReadLine();
                    Console.WriteLine($"Dinosaur added at {DateTime.Now}");

                    tracker.AddANewAnimal(what, diet, weight, number);
                }
                else if (input == "remove")
                {
                    Console.WriteLine("what do you want remove");
                    var creature = Console.ReadLine();
                    tracker.RemoveDinosaurs(creature);
                }
                else if (input == "quit")
                {
                    isRunning = false;
                    Console.WriteLine("Thanks for visiting Jurassic Park, We hope you had a great time!");
                }
            }
        }
    }
}
