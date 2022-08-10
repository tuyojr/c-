using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp
{
    internal class Movies
    {

        public string name;
        public string universe;
        private string rating; //only code inside the Movie class can access this.

        public Movies(string aName, string aUniverse, string aRating)
        {

            name = aName;
            universe = aUniverse;
            Rating = aRating;

        }

        //create getters and setters that allow outside code to access and modify and set the rating.

        public string Rating
        {
            //allows us get the rating
            get { return rating; }
            //allows us modify the rating
            set { 
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                } else
                {
                    rating = "NR";
                }
            }
        }

    }
}
