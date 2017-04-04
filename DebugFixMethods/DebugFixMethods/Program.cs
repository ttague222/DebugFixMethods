using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugFixMethods
{
    //Debugged by Tom Tague 1/22/17
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        //This will begin the program and run the other methods
        public void run()
        {
            int choice = 0;

            Writeprompt();
            choice = ReadChoice();
            WriteChoice(choice);

        }
        //This will output the text asking you to enter your choice for the class you would like to register for. 
        void Writeprompt()
        {
            Console.Write("This program is by: Tom Tague \n");
            Console.WriteLine("Please select a course for which you want to register by typing the number inside []");
            Console.WriteLine("[1]IT 145\n[2]IT 200\n[3]IT 201\n[4]IT 270\n[5]IT 315\n[6]IT 328\n[7]IT 330");
            Console.Write("Enter your choice : ");
        }
        //This method will take the number you entered and return it as an int.
        int ReadChoice()
        {
            string s = "";
            s = Console.ReadLine();
            return int.Parse(s);
        }
        //This method will output your choice of class. 
        public void WriteChoice(int choice)
        {
            Console.WriteLine("Your choice is {0}", choice);
        }

    }
}










class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }


        void run()
        {
            int choice;
            int firstChoice = 0, secondChoice = 0, thirdChoice = 0;
            int totalCredit = 0;
            string yesOrNo = "";

            System.Console.WriteLine("Tom Tague Copy");

            do
            {
                WritePrompt();
                choice = Convert.ToInt32(Console.ReadLine());


                switch (ValidateChoice(choice, firstChoice, secondChoice, thirdChoice, totalCredit))
                {

                    case -1:
                        Console.WriteLine("Your entered selection {0} is not a recognized course.", choice);
                        break;
                    case -2:
                        Console.WriteLine("You have already registerd for this {0} course.", ChoiceToCourse(choice));
                        break;
                    case -3:
                        Console.WriteLine("You can not register for more than 9 credit hours.");
                        break;
                    case 0:
                        Console.WriteLine("Registration Confirmed for course {0}.", ChoiceToCourse(choice));
                        totalCredit += 3;
                        if (firstChoice == 0)
                            firstChoice = choice;
                        else if (secondChoice == 0)
                            secondChoice = choice;
                        else if (thirdChoice == 0)
                            thirdChoice = choice;
                        break;

                }

                WriteCurrentRegistration(firstChoice, secondChoice, thirdChoice);
                Console.Write("\nDo you want to try again? (Y|N)? : ");
                yesOrNo = (Console.ReadLine()).ToUpper();
            } while (yesOrNo == "Y");

            Console.WriteLine("Thank you for registering with us");
        }

        void WritePrompt()
        {
            Console.WriteLine("Please select a course for which you want to register by typing the number inside []");
            Console.WriteLine("[1]IT 145\n[2]IT 200\n[3]IT 201\n[4]IT 270\n[5]IT 315\n[6]IT 328\n[7]IT 330");
            Console.Write("Enter your choice : ");
        }

        int ValidateChoice(int choice, int firstChoice, int secondChoice, int thirdChoice, int totalCredit)
        {

            if (choice < 1 || choice > 7)
                return -1;
            else if (choice == firstChoice && choice == secondChoice && choice == thirdChoice)
                return -2;
            else if (totalCredit >= 9)
                return -3;
            return 0;
        }


        void WriteCurrentRegistration(int firstChoice, int secondChoice, int thirdChoice)
        {
            if (firstChoice == 0)
                Console.WriteLine("You are not currently registered for any classes");
            if (secondChoice == 0 && firstChoice > 0)
                Console.WriteLine("You are currently registered for {0}", ChoiceToCourse(firstChoice));
            else if (thirdChoice == 0 && firstChoice > 0)
                Console.WriteLine("You are currently registered for {0}, {1}", ChoiceToCourse(firstChoice), ChoiceToCourse(secondChoice));
            else if (firstChoice > 0)
                Console.WriteLine("You are currently registered for {0}, {1}, {2}", ChoiceToCourse(firstChoice), ChoiceToCourse(secondChoice), ChoiceToCourse(thirdChoice));
        }

        string ChoiceToCourse(int choice)
        {
            string course = "";
            switch (choice)
            {
                case 1:
                    course = "IT 145";
                    break;
                case 2:
                    course = "IT 200";
                    break;
                case 3:
                    course = "IT 201";
                    break;
                case 4:
                    course = "IT 270";
                    break;
                case 5:
                    course = "IT 315";
                    break;
                case 6:
                    course = "IT 328";
                    break;
                case 7:
                    course = "IT 330";
                    break;
                default:
                    break;
            }
            return course;
        }






























