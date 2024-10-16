using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace Text_Adventure
{
    internal class Program
    {
        static void MainLeftRightShort()
        {
            Console.WriteLine("you decide to take the short path towards the campsite, when you make it there,");
            Console.WriteLine("you dont find anybody, but there is a community area with some food and water");
            Console.WriteLine("you restoke, refuel, and try and get some rest, you find a nice little spot to rest,");
            Console.WriteLine("eventually you awake still alive at the crack of dawn");
            Console.WriteLine("you begin your journay again, you head back the way you came, and start taking the long");
            Console.WriteLine("way home, as you are heading back to camp, you begin to hear noises, Continue | Get in a Bush");
            string input = Console.ReadLine();
            if (input == "Continue")
            {
                Console.WriteLine("");
            }
            else if (input == "Get in a Bush")
            {
                Console.WriteLine("");
            }
            else
            {
                MainLeftRightShort();
            }
        }
        static void MainLeftRight()
        {
            Console.WriteLine("You take the path that leads deeper into the woods, eventually find a clearing with a map on it,");
            Console.WriteLine("you can either go the long way back to your camp, or take a short route to a campsite nearby. what do you want to do?");
            Console.WriteLine("Short Route | Long Route");
            string input = Console.ReadLine();
            if (input == "Short Route")
            {
                MainLeftRightShort();
            }
            else if (input == "Long Route")
            {
                Console.WriteLine("You decide to take no rest, you move to begin your long walk back to your camp");
                Console.WriteLine("At this point, its pitch black, you can barely see the floor, as you take a turn, you stumble and fall into a deep ravine");
                Console.WriteLine("you fall in and can no longer move, you very quickly black out, and you never wake back up");
                Console.WriteLine("You are dead");
                MainMenu();
            }
            else
            {
                Console.WriteLine("Try Again");
                MainLeftRight();
            }
        }
        static void MainRightContinue()
        {
            Console.WriteLine("You continue forward and manage to make it to the lake, it is full of fresh water, and there are some paths up ahead,");
            Console.WriteLine("do you want to stay and get some water, or continue?");
            Console.WriteLine("Stay | Foward");
            string input = Console.ReadLine();
            if (input == "Stay")
            {

            }
            else if (input == "Foward")
            {

            }
            else
            {
                Console.WriteLine("Try again");
                MainRightContinue();
            }
        }
        static void MainRight()
        {
            Console.WriteLine("You take the Right path, which heads towards the lake, but right before the lake, there is a path that splits off and goes left, what do you want to do?");
            Console.WriteLine("Continue | Left");
            string input = Console.ReadLine();
            if (input == "Continue")
            {
                MainRightContinue();
            }
            else if (input == "Left")
            {
                Console.WriteLine("You take the left path, and after a while, run into a mama bear, you try to escape, but you are attacked and mauled");
                Console.WriteLine("You die");
                MainMenu();
            }
            else
            {
                Console.WriteLine("Try again");
                MainRight();
            }
        }
        static void MainLeft()
        {
            Console.WriteLine("You take the left path, it takes you deeper into the woods, as you go down, you see some smoke coming up through the trees"); 
            Console.WriteLine("on the left, and on the right, more woods.");
            Console.WriteLine(" Left | Right");
            string input = Console.ReadLine();
            if (input == "Left")
            {
                Console.WriteLine("you follow the smoke and eventally, find a destroyed campsite, with claw and scratch marks everywhere, you turn around to");
                Console.WriteLine("find a pack of very angry wolves behind you.");
                Console.WriteLine("you are mauled to death by the pack");
                MainMenu();
            }
            else if (input == "Right")
            {
                MainLeftRight();
            }
            else 
            {
                Console.WriteLine("Try Again");
                MainLeft();
            }
        }
        static void Begin() 
        {
            Console.WriteLine("You are in a forest, its getting dark and you have to get back, infront of you there are two paths. ");
            Console.WriteLine(" both seem the same, the left path goes deeper into the woods, and the right path takes you towards a lake, ");
            Console.WriteLine("which path Do you choose?");
            Console.WriteLine("Left | Right");
            string input = Console.ReadLine();
            if (input == "Left")
            {
                MainLeft();
            }
            else if (input == "Right")
            {
                MainRight();
            }
            else
            {
                Begin();
            }
        }
        static void MainMenu()
        {
            Console.WriteLine("Would you like to begin your forest adventure, (I was gone a week so this isnt");
            Console.WriteLine("going to be great, dont expect a high quality game) just type Begin to start");
            String input = Console.ReadLine();
            if (input == "Begin")
            {
                Begin();
            }
            else
            {
                Console.WriteLine("Try again");
                MainMenu();
            }
        }
        static void Main(string[] args)
        { 
        
        }

    }
}
