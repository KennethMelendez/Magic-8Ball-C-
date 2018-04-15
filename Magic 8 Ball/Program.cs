using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_8_Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a bool that will allow the use to exit the program
            bool askAgain = true;
            //current responses for the user when asking a question
            string[] responses = {"Yes.", "No.", "Maybe..", "Try again..","NO DOUBT.","sorry but noo.."};
            //while loop to loop the conversation if the user wants to ask again
            while (askAgain == true) {

                //introduction
                Console.WriteLine("Welcome to the Magic 8-Ball!");
                Console.WriteLine("Ask me anything.");
                //this will capture the users input
                string userInput = Console.ReadLine();
                //response for the user before initiating a random response
                Console.WriteLine("Hmmm... " + userInput + "..?");
                //Random variable that will allow you to randomize numbers
                Random randomResponse = new Random();
                //calling the array and randomizing the response index of the array
                Console.WriteLine(responses[randomResponse.Next(0, responses.Length)]);
                //asking the user if want to play again
                Console.Write("Ask again? ( type -> y/n)");
                //yes or no user input
                string yesOrNo = Console.ReadLine();
                //creating if statements that determine the result of the program
                if (yesOrNo == "y")
                {
                    Console.WriteLine("No problem!");
                } else if (yesOrNo == "n")
                {
                    Console.WriteLine("GoodBye!");
                    askAgain = false;
                } else
                {
                    Console.WriteLine("Wait what?? ... ( type -> y/n) ");
                }
            }
        }
    }
}
