using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Video horseKick = new Video("Horse kicks down a shed", "John Michael", 35);

        Comment horseKick1 = new Comment("Carl Jørgensen", "This is a great video!");
        Comment horseKick2 = new Comment("Lorne Jacobson", "Crazy horse!");
        Comment horseKick3 = new Comment("Carla Knudsen", "You should treat the horse better!");

        Video dadJoke = new Video("Dad makes a lame joke", "Sarah Lawrence", 73);

        Comment dadJoke1 = new Comment("Tim Andersen", "hahahaha");
        Comment dadJoke2 = new Comment("Cathy Rupert", "That's not funny");
        Comment dadJoke3 = new Comment("Rick Down", "Great joke!");
        Comment dadJoke4 = new Comment("Helena Jake", "Dads are so fun :)");

        Video unboxMakeUp = new Video("New Loreal makeup unboxing", "Laura Jennings", 345);

        Comment unboxMakeUp1 = new Comment("Gunnar Larsen", "I don't need this.");
        Comment unboxMakeUp2 = new Comment("Michelle Roberts", "This is taking to long.");
        Comment unboxMakeUp3 = new Comment("Robert Bent", "Why do I spend time watching this?");

        Video skateboardAccident = new Video("Boy gets knocked off his skateboard", "John Curry", 45);

        Comment skateboardAccident1 = new Comment("Jenna Mccarthy", "Ouch!");
        Comment skateboardAccident2 = new Comment("Christina Lorne", "That has to hurt!");
        Comment skateboardAccident3 = new Comment("Brad Pott", "Nice!");
        Comment skateboardAccident4 = new Comment("Cary Lane", "Why do boys always do stupid stuff.");

        horseKick.AddComment(horseKick1);
        horseKick.AddComment(horseKick2);
        horseKick.AddComment(horseKick3);

        dadJoke.AddComment(dadJoke1);
        dadJoke.AddComment(dadJoke2);
        dadJoke.AddComment(dadJoke3);
        dadJoke.AddComment(dadJoke4);

        unboxMakeUp.AddComment(unboxMakeUp1);
        unboxMakeUp.AddComment(unboxMakeUp2);
        unboxMakeUp.AddComment(unboxMakeUp3);

        skateboardAccident.AddComment(skateboardAccident1);
        skateboardAccident.AddComment(skateboardAccident2);
        skateboardAccident.AddComment(skateboardAccident3);
        skateboardAccident.AddComment(skateboardAccident4);

        horseKick.DisplayVideo();
        dadJoke.DisplayVideo();
        unboxMakeUp.DisplayVideo();
        skateboardAccident.DisplayVideo();
    }
}