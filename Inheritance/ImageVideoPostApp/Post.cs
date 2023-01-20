using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageVideoPostApp
{
    internal class Post
    {
        // Static Feilds
        private static int currentPostId;

        // Essentials Properties that a POST must have
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        // Default Constructor: 
        // WHY ? Ans -> If the derived class doesnt invoke a Base class
        // Explicitly, the default constructor is called Implicitly.
        // Thats why we create one here.
        
        public Post()
        {
            ID = 0;
            Title = "My first Post";
            SendByUsername = "Default User";
            IsPublic = true;
        }

        public Post(string title, string sendByUsername, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic=isPublic; 
        }
        public override string ToString()
        {
            return ($"{this.ID} : {this.Title}, Sent By : {this.SendByUsername}, URL : , ");
        }
    }
}
