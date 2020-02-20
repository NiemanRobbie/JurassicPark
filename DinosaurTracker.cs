using System;
using System.Collections.Generic;
using System.Linq;

namespace JurassicPark
{
    public class DinosaurTracker
    {
        public List<Dinosaurs> Dinosaurs { get; set; } = new List<Dinosaurs>();

        public void AddANewAnimal(string what, string diet, string weight, string number)
        {
            var Animal = new Dinosaurs
            {
                DinoName = what,
                DietType = diet,
                DinoWeight = weight,
                EnclosureNumber = number,
                DateAcquired = DateTime.Now
            };

            Dinosaurs.Add(Animal);
        }

        public void RemoveDinosaurs(string what)
        {
            // Removing a dinosaur if more than one of the same species is found
            var thingToRemove = Dinosaurs.Where(Dinosaurs => Dinosaurs.DinoName == what).ToList();
            if (thingToRemove.Count() > 1)
            {
                Console.WriteLine($"We found multiple {what}, which do you want to remove");
                for (int i = 0; i < thingToRemove.Count; i++)
                {
                    var creature = thingToRemove[i];
                    Console.WriteLine($"{i + 1}: {creature.DietType} at ${creature.DateAcquired}");
                }

                var index = int.Parse(Console.ReadLine());
                Dinosaurs.Remove(thingToRemove[index - 1]);

            }
            else
            {
                // remove the only instance found
                Dinosaurs.Remove(thingToRemove.First());
            }
            // Transfer a dinosaur to a different enclosure
            // Total number of each diet type
            var dietTotal = Dinosaurs.Sum(Dinosaurs => Dinosaurs.DietType);

            // Display the 3 heaviest dinosaurs
            var heaviestDinos = Dinosaurs.Max(Dinosaurs => Dinosaurs.DinoWeight);

        }
    }
}