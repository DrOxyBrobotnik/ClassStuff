using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_stuff
{
    internal class Movies
    {
        private string title;
        private string director;
        private string rating;

        public Movies(string aTtitle, string aDirector, string aRating) 
        {
            title = aTtitle;
            director = aDirector;
            rating = aRating;
        }

        public string Methodz() 
        {
            return "nsfw";
        }

        public string Rating
        {
            get { return rating; }
            set {
                if(Methodz() == "nsfw") 
                {
                    Console.WriteLine("Oh... tell me more");
                }
                else 
                {
                    rating = "NR";
                }
            }
        }
    }
}
