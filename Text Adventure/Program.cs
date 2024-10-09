using System.Security.AccessControl;

namespace Text_Adventure
{
    internal class Program
    {
        static void Main(string[] args)// this is an adventure into a dark cursed forest, where it will eventually loop back onto itself, mixing and warping reality everytime you make a full loop, or die.
            //every time it loops, things get mixed up or scrambled, or stacked, like for instane there is an oak and birch tree mixed and jumbled together, that deer is croaking like a frog.
            //you have to pay attention to the paths, the more things are warped, the stronger the forest, and its best to avoid going that route.
        {
            Console.WriteLine("You are in a dark forest, its getting dark and you have to get back, infront of you there are two paths. ");
            Console.WriteLine(" both seem the same, but you notice footprints going right, which path Do you choose?");
            Console.WriteLine("Left | Right");
            String input = Console.ReadLine();
            if (input == "Left")//correct choice
            {
                
                Console.WriteLine("You decide to not follow those prints, and move left, after a while of walking you see three paths.");
                Console.WriteLine("On the left you see smoke, probably a campfire, on the Right you see a lake far ahead in the distance, and in the middle you see .... more forest, which do you choose?");
                Console.WriteLine("Campfire | Middle | Lake");
                input = Console.ReadLine();
                if (input == "Campfire")//Campfire smoke
                {
                    Console.WriteLine("You decide to follow the smoke and try to find survivors, but as you get closer you see the smoke start to get smaller and smaller, when you make it there, you find....nothing");
                    Console.WriteLine("there was no camp, there was just an open clearing with a path continuing on into the woods, should you turn back, or head on into the woods?");//both paths return to the begining, loop 1
                    Console.WriteLine("Reverse | Forward");
                    input = Console.ReadLine();
                    if (input == "Reverse")
                    {
                        Console.WriteLine("You decide to head turn back, but as your makeing you way back through the woods, things start to look...familer, and as you turn right into a dense part of the forest.");
                        Console.WriteLine("You see...The same duel path as before, same trees, same rocks, same footprints, but now you recognize them, they are yours, but instead of them going right");
                        Console.WriteLine("They are going left, you seem to have, looped back around somehow, but its getting darker and darker as time moves ever foward, you have two options, Left | Right");
                        input = Console.ReadLine();
                        if (input == "Right")
                        {

                        }
                        else if (input == "Left")
                        {

                        }
                    }
                    else if (input == "Foward")
                    {
                        Console.WriteLine("You head foward, into the darkness ahead, you can make out some vague shapes in the dark, people standing behind trees, branchs breaking, but its getting harder to see");
                        Console.WriteLine("after you walk around a bend you see...The duel paths you took at the beginning, with footprints going Left, your foot prints, and nothing going to the right this time.");
                        Console.WriteLine("you once again need to make this choice, you seem to have looped around to the beggining of the paths, now you must choose the best path.  Left | Right");
                    }
                }
                else if (input == "Middle")//more forest
                {
                    Console.WriteLine("You head forward, deeper into the woods and as you walk you begin to notice things are looking familer...");
                }
                else if (input == "Lake")//lake
                {
                    Console.WriteLine("You head towards the lake, and after lots of walking, arrive to this great massive crystal clear lake, it is beutiful, but there doesnt seem to be a way back to you camp from here.");
                    Console.WriteLine("you could stop to get some freshwater, or continue on around it, getting some fresh water for your travels could be useful. Drink | Continue");
                }
            }
            else if (input == "Right")//poor but still viable choice
            {
                
                Console.WriteLine("You decide, against your better judgement, to follow the foot prints.");
            }
        
        
        }

    }
}
