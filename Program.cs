namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your preferred choice:");
            Console.WriteLine("\n1. Cat \n2. Dog \n3. Rabbit");
            int choice = Convert.ToInt32(Console.ReadLine());
            if(choice == 1)
            {
                Console.WriteLine("\nYou have chosen a Cat. What would you like to name your pet?");
            } else if (choice == 2)
            {
                Console.WriteLine("\nYou have chosen a Dog. What would you like to name your pet?");
            } else if (choice == 3)
            {
                Console.WriteLine("\nYou have chosen a Rabbit. What would you like to name your pet?");
            }
            string name = Console.ReadLine();
            Console.WriteLine($"\nWelcome, {name}! Let's take good care of him.");
            bool exit = false;
            int hunger = 5; 
            int health = 6;
            int happiness = 5;
            while(!exit)
            {
                Console.WriteLine($"\nMain Menu: \n1. Feed {name} \n2. Play with  {name} \n3. Let {name} Rest. \n4. Check {name}'s Status \n5. Exit");
                int action = Convert.ToInt32(Console.ReadLine());
                if (action == 1)
                {
                    
                    hunger--;
                    health++;
                    Console.WriteLine($"\nYou fed {name}. His hunger decreases, and health improves slightly.");
                    
                } else if(action == 2)
                {
                    if(hunger >= 9)
                    {
                        Console.WriteLine($"\n{name} is too hungry to play right now and refuses to play.");
                    } else
                    {
                        happiness = happiness+2;
                        hunger++;
                        Console.WriteLine($"\nYou played with {name}. His happiness increases, but his bit hungrier.");
                    }
                }
                else if (action == 3)
                {
                    health = health++;
                    happiness--;
                    Console.WriteLine($"\n{name} took a rest, his health improves but feels a bit bored.");

                }
                else if (action == 4)
                {
                    Console.WriteLine($"\n{name}'s Status:");
                    Console.WriteLine($"- Hunger: {hunger}");
                    Console.WriteLine($"- Happiness: {happiness}");
                    Console.WriteLine($"- Health: {health}");

                }
                else if (action == 5)
                {
                    exit = true;
                    Console.WriteLine($"\nThank you for playing with {name}. GoodBye!");
                    break;
                } else
                {
                    Console.WriteLine("\nInvalid Choice. Please select from the main menu options.");
                    continue;
                }

               

                if (hunger >= 9 || happiness <= 2)
                {
                    health = health - 2;
                    Console.WriteLine($"{name}'s health is decreasing due to neglect.");
                }
                else if (hunger >= 7 || happiness <= 3)
                {
                    health = health--;
                    Console.WriteLine($"{name} is not feeling well.");
                }

                if (hunger >= 10 || happiness <= 1 || health <= 1)
                {
                    Console.WriteLine($"\n{name}'s condition is very poor. Please take immediate care!\n");
                }

                hunger = hunger++;
                happiness = happiness--;
            }


        }
    }
}
