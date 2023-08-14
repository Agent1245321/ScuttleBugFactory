using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRun
{
    internal class ScuttleBug
    {
        //creating the base variables for the scuttleBug objects;
        double legs;
        int eyes;
        int id;
        string name;


        //creating the properties for the variables, this allows us to restrict the access to them in other classes;
        public double Legs { get; private set; }
        public int Eyes { get; private set; }
        
        public string Name { get; set; }
        public int ID { get; set; }


        //this is the ScuttleBug Object, it takes 4 arguments to define the bug;
        public ScuttleBug(double legs, int eyes, string name, int iD)
        {
            // sets the properties of this scuttlebug
            this.Legs = legs;
            this.Eyes = eyes;
            this.Name = name;
            this.ID = iD;

            //tells the console about the scuttleBug
            Console.WriteLine($"This Scuttlebug has {this.Legs} legs and {this.Eyes} eyes, his name is {name}.");
            Console.WriteLine($"He is the {Generation(iD)} of his kind");
        }


        //switch statement to handle generation string
        string Generation(int num)
        {
            switch (num)
            {
                case 1:
                    return "1st";
                    break;

                case 2:
                    return "2nd";
                    break;

                case 3:
                    return "3rd";
                    break;

                case 4:
                    return "4th";
                    break;

                case 5:
                    return "5th";
                    break;

                case 6:
                    return "6th";
                    break;

                case 7:
                    return "7th";
                    break;

                case 8:
                    return "8th";
                    break;

                case 9:
                    return "9th";
                    break;

                case 10:
                    return "10th";
                    break;

                default:
                    return "god";
                    break;
            }

        }
    }
}
