using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace Text_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You are in a forest, its getting dark and you have to get back, infront of you there are two paths. ");
            Console.WriteLine(" both seem the same, the left path goes deeper into the woods, and the right path takes you towards a lake, ");
            Console.WriteLine("which path Do you choose?");
            Console.WriteLine("Left | Right");
            String input = Console.ReadLine();
            if (input == "Left")
            {
                Console.WriteLine("You take the left path, it takes you deeper into the woods, as you go down, you see some smoke coming up through the trees on the left, on the right, more woods.");
                Console.WriteLine(" Left | Right");
                input = Console.ReadLine();
                if (input == "Left")
                {
                    Console.WriteLine("you follow the smoke and eventally, find a destroyed campsite, with claw and scratch marks everywhere, you turn around to find a pack of very angry wolves behind you.");
                    Console.WriteLine("you are mauled to death by the pack");
                }
                else if (input == "Right")
                {
                    Console.WriteLine("You take the path that leads deeper into the woods, eventually find a clearing with a map on it, you can either go the long way back to your camp, or take a short route to a campsite nearby. what do you want to do?");
                    Console.WriteLine("Short | Long");
                    input = Console.ReadLine();
                    if (input == "Short")
                    {

                    }
                    else if (input == "Long")
                    {

                    }
                }
            }
            else if (input == "Right")
            {
                Console.WriteLine("You take the Right path, which heads towards the lake, but right before the lake, there is a path that splits off and goes left, what do you want to do?");
                Console.WriteLine("Continue | Left");
                input = Console.ReadLine();
                if (input == "Continue")
                {
                    Console.WriteLine("You continue forward and manage to make it to the lake, it is full of fresh water, and there are some paths up ahead, do you want to stay and get some water, or continue?");
                    Console.WriteLine("Stay | Foward");
                    input = Console.ReadLine();
                    if (input == "Stay")
                    {

                    }
                    else if (input == "Foward")
                    {

                    }
                }
                else if (input == "Left")
                {
                    Console.WriteLine("You take the left path, and after a while, run into a mama bear, you try to escape, but you are attacked and mauled");
                    Console.WriteLine("You die");
                }
            }
        
        
        }

    }
}
