using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MatchMaker
{
    class MatchMakerApp
    {
        // we use static here so that the main method doesn't belong to a specific object 
        // we used void so that main doesn't return a value //
        static void Main(string[] args)
        {
            // here we assign values to our variables which we will use later when we ask for user input://
            string sex, age, occupation, hobbies, peeves;
            double s, a, o, h, p;
            string[] i = new string[5];
            WriteLine("Welcome to the MatchMaker App!");
            WriteLine();
            WriteLine("We have plenty of singles and swingers waiting to match with you");
            WriteLine();
            WriteLine("Please answer the following questions:");
            WriteLine();
            
            //the user's responses to see if the other user would want to go on a date or not//
            //this is where we match the user based on their input//
            //we have created conditions where if they are met, the match is more accurate//
            MatchMaker Object = new MatchMaker();

            string sex1;
            Object.Sex = AskForSex();
            sex = ReadLine();
            i[0] = sex;
            double.TryParse(sex, out s);
            if (s == 0)
            {
                sex1 = "Male"; 
            //ex: if user here enters 0, then they would match with all the male candidates in our array//
            }
            else
            {
                sex1 = "Female";
            }


            Object.Age = AskForAge();
            age = ReadLine();
            i[1] = age;
            double.TryParse(age, out a);
            // here we parse the age parameter as double //
            // we used TryParse so that it accepts the value type as a reference //
            // and writes the parsed value to the variable//

            string occupation1;
            Object.Occupation = AskForOccupation();
            occupation = ReadLine();
            i[2] = occupation;
            double.TryParse(occupation, out o);
            if (o == 0)
            {
                occupation1 = "Currently a Student";
            }
            else
            {
                occupation1 = "Has a Job";
            }

            string hobbie1;
            Object.Hobbies = AskForHobbies();
            hobbies = ReadLine();
            i[3] = hobbies;
            double.TryParse(hobbies, out h);
            if (h == 0)
            // we use if else for each constant assigned value because we know most people
            // would choose one of the two options we gave them, and not both//
            

          
            {
                hobbie1 = "Likes dating outside";
            }
            else
            {
                hobbie1 = "Likes Dating inside";
            }

            string peeves1;
            Object.Age = AskForPeeves();
            peeves = ReadLine();
            i[4] = peeves;
            double.TryParse(peeves, out p);

            if (p == 0)
            {
                peeves1 = "Hates the Word Moist";
            }
            else
            {
                peeves1 = "Hates the word fetus";
            }
            // This is where the user would see who they matched with based on their responses //
            // Again, we used if, else if statements to have an accurate match from the assigned values //
            if ((s == 0) && (a >= 31) && (o == 0) && (h == 0) && (p == 0))
            {
                WriteLine();
                WriteLine("Congrats! You matched with Jacob Henry");
                WriteLine("Bio:");
                WriteLine("I like guns, I like Women, and I like beer");


            }
            else if ((s == 0) && (a > 17) && (o == 1) && (h == 0) && (p == 0))
            {
            // we include the name of the person matched, including a bio
            // that we thought went well with the profile: //
                WriteLine();
                WriteLine("Congrats! You matched with Fred Wilson");
                WriteLine("Bio:");
                WriteLine("'You miss 100% of the shots you don't take'");
                WriteLine("- Wayne Gretzky");
                WriteLine("- Michael Scott");
                WriteLine("- Fred Wilson");


            }
            else if ((s == 0) && (a <= 30) && (o == 0) && (h == 1) && (p == 1))
            {
                WriteLine();
                WriteLine("Congrats! You matched with Nick Mckenny");
                WriteLine("Bio:");
                WriteLine("Not here for a long time");
                WriteLine("Here for a halal time");


            }
            else if ((s == 0) && (a > 35) && (o == 1) && (h == 1) && (p == 0))
            {
                WriteLine();
                WriteLine("Congrats! You matched with Jacob");
                WriteLine("Bio:");
                WriteLine("I like guns, I like Women, and I like beer");

            }
            else if ((s == 0) && (a > 50) && (o == 1) && (h == 1) && (p == 1))
            {
                WriteLine();
                WriteLine("Congrats! You matched with Sam Wise");
                WriteLine("Bio:");
                WriteLine("Women age like fine wine");

            }
            else if ((s == 1) && (a <= 30) && (o == 1) && (h == 1) && (p == 1))
            {
                WriteLine();
                WriteLine("Congrats! You matched with Emily Johnson!");
                WriteLine("Bio:");
                WriteLine("just be yourself");


            }
            else if ((s == 1) && (a > 17) && (a < 30) && (o == 0) && (h == 1) && (p == 0))
            {
                WriteLine();
                WriteLine("Congrats! You matched with Chloe Lamb!");
                WriteLine("Bio:");
                WriteLine("Music Runs My Life");
                WriteLine("Adventures Keep Me Sane");
                WriteLine("Love being out doors, catch me at Belle's");


            }
            else if ((s == 1) && (a > 40) && (o == 1) && (h == 1) && (p == 0))
            {
                WriteLine();
                WriteLine("Congrats! You matched with Remy LaBam!");
                WriteLine("Bio:");
                WriteLine("@__Flowers23");


            }
            else if ((s == 1) && (a > 17) && (o == 1) && (h == 0) && (p == 1))
            {
                WriteLine();
                WriteLine("Congrats! You matched with Kelsey Boomingdale!");
                WriteLine("Bio:");
                WriteLine("Want someone who is as dorky as me :P");


            }
            else if ((s == 1) && (a > 70) && (o == 0) && (h == 1) && (p == 1))
            {
                WriteLine();
                WriteLine("Congrats! You matched with Meritt!");
                WriteLine("Bio:");
                WriteLine("I like Older men");


            }

            else
            {
                // we also included a 'match' with none of our candidates if their responses did not //
                // match with the candidates from above using the 'else' statement //
                WriteLine();
                WriteLine("you matched with no one");
                WriteLine();
                WriteLine("This is a very unique combintation of qualities");
                WriteLine();
                WriteLine("" + sex1);
                WriteLine(a + "years old");
                WriteLine("" + occupation1);
                WriteLine("" + hobbie1);
                WriteLine("" + peeves1);

            }

            Read();
        }

        // here we used public static string because it would allow one 
        // object per process but can be accesssed outside the class  like we did above //
        public static string AskForSex()
        {
            string inValue;

            // here is where we ask the questions that will match them based on their responses //
            // we wanted it to be simple for the user so we asked them to enter an integer for each //
            WriteLine();
            Console.Write("Are you into Men or Women? (0 for male, 1 for Female) ");

            inValue = Console.ReadLine();

            return inValue;
        }



        public static string AskForAge()
        {
            string inValue;
            WriteLine();
            Console.Write("How old are you? ");
            // this is the only question where we did not ask the user to enter a specific value //
            // we matched the user based on this response using > , < statements in our if/else statements //

            inValue = Console.ReadLine();

            return inValue;
            // we used the return statement for invalue so that it ends the execution of this method 
            // where it appears and returns control to the calling method string //
        }
        public static string AskForOccupation()
        {
            string inValue;
            WriteLine();
            Console.Write("Press 0 if you are a student or 1 if you have a job ");

            inValue = Console.ReadLine();

            return inValue;
        }


        public static string AskForHobbies()
        {
            string inValue;
            WriteLine();
            Console.WriteLine("If you prefer having a date outside, press 0");
            WriteLine("if you prefer having a date inside, press 1");

            inValue = Console.ReadLine();

            return inValue;
        }
        public static string AskForPeeves()
        {
            string inValue;
            WriteLine();
            Console.Write("Which word do you dislike the most; 0 for moist, 1 for fetus ");

            inValue = Console.ReadLine();

            return inValue;
        }
    }
}