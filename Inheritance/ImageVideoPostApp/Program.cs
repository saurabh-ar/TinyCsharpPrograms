using System;
using System.Timers;

namespace ImageVideoPostApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Post post1 = new Post();
            Console.WriteLine(post1.ToString());

            Post post2 = new Post("Happy bday post", "Lata", true);
            Console.WriteLine(post2.ToString());

            ImagePost post3 = new ImagePost("Happy bday post", "Nana", true, "www.google.com");
            Console.WriteLine(post3.ToString());

            ImagePost post4 = new ImagePost();
            Console.WriteLine(post4.ToString());

            VideoPost post5 = new VideoPost();
            Console.WriteLine(post5.ToString());

            VideoPost post6 = new VideoPost("New Video Post", "Nana", true, "https://Nanakavideo.com", 150);
            Console.WriteLine(post6.ToString());

            VideoPost post7 = new VideoPost();
            Console.WriteLine(post7.ToString());

            post6.playVideo();


            
        }
   
    }
}
