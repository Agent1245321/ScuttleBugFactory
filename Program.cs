// See https://aka.ms/new-console-template for more information
using SpeedRun;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

int scuttleBugCount = 0;
double legs;
int eyes;
string name;
bool anotherOne;
string answer;

//A method having the user make a scuttlebug
void MakeScuttlebug()
{
    //asks the user for this cuttlebugs leg count and sets its legs to that
    Console.WriteLine($"How many legs should your child have?");
    legs = Convert.ToDouble(Console.ReadLine());

    //asks the user for this cuttlebugs eye count and sets its eyes to that
    Console.WriteLine($"How many eyes?");
    eyes = Convert.ToInt32(Console.ReadLine());

    //asks the user for this cuttlebugs name and saves it
    Console.WriteLine($"What shall you name this child?");
    name = Console.ReadLine();

    //adds to the count
    scuttleBugCount ++;

    //instaniates a new scuttlebug and uses all the variables taken from the user as the arguments
    ScuttleBug emptyVessel = new ScuttleBug(legs, eyes, name, scuttleBugCount);

    //asks the user if they wish to make another scuttlebug
    Console.WriteLine("Do You Wish To Create another child?");
    answer = Console.ReadLine();


    //ches if the answer is yes and calls the method again
    if(answer == "y" || answer == "yes" || answer == "Y" || answer == "Yes")
        {
        MakeScuttlebug();
    }
    //tells the user goodbye if the answer is not yes
    else
    {
        Console.WriteLine("enjoy your death");
    }
}



//Makes a scuttlebug
MakeScuttlebug();

