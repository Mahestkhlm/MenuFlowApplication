using System;

namespace Menuflow
{
    class Program
    {
        private static void ErrorMessage()
        {
            Console.WriteLine("TYPING ERROR!! PRESS ANY KEY TO CONTINUE");
        }
        static void Main(string[] args)
        {
             
            
            bool type = false;
            while (!type)
            {
                Console.WriteLine("WELCOME TO THE MENUAPPLICATION");
                Console.WriteLine("*******************************\n");
                Console.WriteLine("MAIN MENU\n");
                Console.WriteLine("*************\n");
                Console.WriteLine("ENTER 1-SINGLE TICKET BOOKING");
                Console.WriteLine("ENTER 2-MULTIPLE TICKET BOOKING");
                Console.WriteLine("ENTER 3-REPEAT Text10 = TIMES");
                Console.WriteLine("ENTER 4-THE FUN THIRD WORD GAME");
                Console.WriteLine("ENTER 0-EXIT  ");
                String Option = Console.ReadLine();
                int age;

               

                switch (Option)
                {

                    case "0":
                        
                        Environment.Exit(0);
                        Console.WriteLine ("YOU WILL EXIT APPLICATION");
                        break;


                    //case 1: Displays the ticket price of the user enetered age
                    case "1":

                        Console.Clear();
                        Console.WriteLine("TO DISPLAY THE PRICE OF SINGLE TICKET\n");
                        Console.Write("Please Enter your Age:");
                        string count = Console.ReadLine();
                        //local variables
                        bool digit = Int32.TryParse(count, out age);
                        // Console.WriteLine ($ "digit {age}");
                        if (age < 20)
                        {
                            Console.WriteLine("Ticket price is:  80sek");
                        }
                        else

                            if (age > 64)
                        {
                            Console.WriteLine("Ticket price is: 90sek");
                        }
                        else

                        if (age < 5)
                        {
                            Console.WriteLine(" You Entry is free of Cost!");
                        }

                        else

                            Console.WriteLine("Normal Ticket Price is:  120 sek");
                        Console.ReadLine();
                        break;
                        //Case to calculate the total ticket cost of groupticket



                    case "2":

                        Console.Clear();
                        // Price list
                        int[] priceList = new int[] { 80, 90, 120, 0 };

                        // User input for number of persons
                        Console.Write("Please Enter The Number of Persons is a Group:");
                        Console.Write(" ");
                        var Group = Console.ReadLine();
                        int N;

                        //Checks whether the input in integer or not
                        while (!int.TryParse(Group, out N))
                        {
                            Console.WriteLine("WRONG DETAILS:ENTER AGAIN!");
                            Group = Console.ReadLine();
                        }

                        // To store the required sum 
                        int totalcount = 0;
                        int EnteredAge;
                        // loop over the number of persons in group
                        for (int i = 0; i < N; i++)
                        {
                            Console.WriteLine("Please enter your age: ");
                            var ageAsString = Console.ReadLine();
                            while (!int.TryParse(ageAsString, out EnteredAge))
                            {
                                Console.WriteLine(" \nPlease enter your age again.");
                                ageAsString = Console.ReadLine();
                            }

                            int ageGroup = EnteredAge;

                            // Adds the sum according to age group
                            if (ageGroup < 20)
                            {
                                totalcount += priceList[0];
                            }
                            else if (ageGroup > 64 )
                            {
                                totalcount += priceList[1];
                            }
                            else
                            {
                                if (ageGroup < 5)
                                {
                                    totalcount += priceList[2];
                                }
                                else
                                {
                                    totalcount += priceList[2];
                                }
                            }

                        }
                        Console.WriteLine("\n");
                        Console.WriteLine("TOTAL NUMBER OF PERSONS IN THE GROUP: {0} \nTHE TOTAL COST IS: {1} SEK", N, totalcount);
                        Console.ReadLine();
                        break;


                        // case for repeating text 
                    case "3":
                        int y;
                        Console.Clear();
                        Console.WriteLine(" Enter the text here:");
                        String text = Console.ReadLine();
                        for (y = 0; y < 10; y++)
                        {
                            //Iteration 10 times
                            int j = y + 1;

                            //Console.WriteLine("{0}. {1}, ", y, text); this syntax  prints in the nexttine
                            //Prints the text 10 times in a single line.
                            Console.Write("{0}. {1}, ", y, text);
                        }

                        Console.ReadLine();
                       
                        break;

                        //case 4: Splits the given string into substring and displays the third word of the enetered text
                    case "4":

                        Console.Clear();
                        Console.WriteLine(" THREEWORD GAME\n");

                        Console.WriteLine("Please enter a text with Minimum 3 word\n");
                        string word = Console.ReadLine();
                        //splits a given string into substring basedupon the strings given in array
                        string[] Thistxt = word.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                        //Splits the strings in arrays and displays the text 

                        Console.WriteLine("The thirword typed: \"{0}\" ", Thistxt[2]);

                        Console.ReadLine();
                        break;

                        //Exits the application if the user enters 0
                       
                    default:
                        
                        ErrorMessage();
                        Console.ReadLine();
                        break;



                }
               
            }
           
        }

     
    }
}



