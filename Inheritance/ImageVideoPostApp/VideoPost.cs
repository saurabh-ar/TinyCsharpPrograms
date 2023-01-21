using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ImageVideoPostApp
{
    internal class VideoPost:Post
    {
        public string VideoURL { get; set; }
        public int Length { get; set; }

        public VideoPost()
        {
            if (ID == 0)
            {
                ID = 0;
            }
            ID = GetNextID();
            VideoURL = "www.defaultVideoURL.com";
            Length = 0;
        }

        public VideoPost(string title, string sendByUsername, bool isPublic, string videoURL, int length)
        {
            ID= GetNextID();
            Title= title;
            SendByUsername = sendByUsername;
            IsPublic=isPublic;
            VideoURL = videoURL;
            Length = length;

        }

        public override string ToString()
        {
            return $"{this.ID} : {this.Title}, Sent By : {this.SendByUsername}, Video URL : {this.VideoURL}, Length: {this.Length} ";
        }

        public void playVideo()
        {
            if(Length == 0 || Length < 0)
            {
                Console.WriteLine("Video Length should be greater than 0s");
            }


            Timer timer = new Timer(1000); // 1000 ms = 1 second
            timer.Elapsed += TimerCallback;
            timer.AutoReset = true;
            timer.Enabled = true;

            Console.WriteLine("Press 'Enter' to exit Playing.");
            Console.ReadLine();

       
        }
        public void TimerCallback(object o, ElapsedEventArgs e) => Console.WriteLine("Timer callback: {0}", e.SignalTime);
    }
}
