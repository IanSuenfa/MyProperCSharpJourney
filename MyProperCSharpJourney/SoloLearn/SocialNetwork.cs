﻿using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Task on sololearn
namespace MyProperCSharpJourney.SoloLearn
{
    public static class SocialNetwork //Sorry for the slow week, there was an error which didnt allow me to run the code, but now its fixed i had to rebuild the project
    {
        public static void Example()
        {
            string postText = Console.ReadLine();

            Post post = new Post(); // Outputs "New post"
            post.Text = postText; // Sets the text
            post.ShowPost(); // Outputs the text
        }
    }

    class Post
    {
        private string text;

        // Constructor that outputs "New post"
        public Post()
        {
            Console.WriteLine("New post");
        }

        // Property to get and set text
        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public void ShowPost()
        {
            Console.WriteLine(text);
        }
    }
}
