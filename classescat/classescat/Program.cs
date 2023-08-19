// See https://aka.ms/new-console-template for more information

using classescat;

Cat pet = new Cat();
pet.petName = "Rocket";
pet.Speak();
//pet.a
Console.WriteLine($"{pet.petName} is {pet.GetAge()} years old.");


Lynx wildPet = new Lynx();
wildPet.petName = "Fred";
wildPet.Growl();