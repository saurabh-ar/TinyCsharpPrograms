using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageVideoPostApp
{
    internal class ImagePost : Post
    {
        public string URL { get; set; }
        public ImagePost()
        {
            if (this.ID==0)
            {
                ID = 0;
            }
            ID= GetNextID();
            URL = "www.helloURL.com";
        }

        public ImagePost(string title, string sendByUsername, bool isPublic, string url)
        {
            // All these properties are coming from Parent : POST
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
            // This is coming from : ImagePOST
            this.URL = url;
        }

        public override string ToString()
        {
            return $"{this.ID} : {this.Title}, Sent By : {this.SendByUsername}, URL : {this.URL}";
        }
    }
}
