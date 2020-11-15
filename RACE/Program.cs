using System;
using RACE.Classic;

namespace RACE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE MOST EXTREME RACING EVER!!!");
            Console.WriteLine("Please a select a game mode"); // Classic or Heavinly
            string choice=Console.ReadLine();
            if (choice.Equals("Classic"))
            {
                Console.WriteLine("Enter your name");
                Game game = new Game(User.Player.name, new ClassicRacing());
                Console.WriteLine("Enter name of car");
                string NameOfCar = Console.ReadLine();
                Console.WriteLine("Do you want to mofidy the car?");
                string answer = Console.ReadLine();
                if (answer.Equals("Yes"))
                {
                    Console.WriteLine("Select a car"); //JustCar or SportCar
                    string answer2 = Console.ReadLine();
                    if (answer2.Equals("Just car"))
                    {
                       
                        Car car = new JustCar(NameOfCar);
                        Console.WriteLine("Do you want to change a color of car?");
                        string answer3 = Console.ReadLine();
                        if (answer3.Equals("No"))
                        {
                           
            
                        }
                        if (answer3.Equals("Yes"))
                        {
                            
                            car = new TunedCar(car);
                            car.ChooseColour();
                            car.Painting();
                            car.PrintCharacteristics();
                        }
                        Console.WriteLine("Do you want to put a new engine?");
                        string answer4 = Console.ReadLine();
                        if (answer4.Equals("Yes"))
                        {
                            car = new UpgradedCar(car);
                            car.PutNewEngine();
                            car.PrintCharacteristics();
                        }
                        if (answer4.Equals("No"))
                        {
                            car.PrintCharacteristics();
                        }


                    }
                    if (answer2.Equals("Sport car"))
                    {
                        
                        
                        Car car = new SportCar(NameOfCar);
                        Console.WriteLine("Do you want to change a color of car?");
                        string answer3 = Console.ReadLine();
                        if (answer3.Equals("No"))
                        {
                            


                        }
                        if (answer3.Equals("Yes"))
                        {
                            car = new TunedCar(car);
                            car.ChooseColour();
                            car.Painting();
                            car.PrintCharacteristics();
                        }
                        Console.WriteLine("Do you want to put a new engine?");
                        string answer4 = Console.ReadLine();
                        if (answer4.Equals("Yes"))
                        {
                            car = new UpgradedCar(car);
                            car.PutNewEngine();
                            car.PrintCharacteristics();
                        }
                        if (answer4.Equals("No"))
                        {
                            car.PrintCharacteristics();
                        }

                    }
                    Console.WriteLine("Please, wait, game is about to start");
               
                }
                else
                {
                    Car car = new JustCar(NameOfCar);
                    car.PrintCharacteristics();
                    Console.WriteLine("Please, wait, game is about to start");
                   
                }
               
                game.Start();
            }
            if (choice.Equals("Heavinly"))
            {
                Console.WriteLine("Enter your name");
                Game game = new Game(User.Player.name, new HeavinlyRacing());
                game.Start();
            }
            
        }
    }
}
