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
        static void Main(string[] args)
        {
            string sex, age, occupation, hobbies, peeves;
            double s, a, o, h, p;
            string[] i = new string[5];
            WriteLine("Welcome to the MatchMaker App!");
            WriteLine();
            WriteLine("We have plenty of singles and swingers waiting to match with you");
            WriteLine();
            WriteLine("Please answer the following questions:");
            WriteLine();
            // where I am leaving off, I am going to create an array to allow me to gather
            //the user's responses to see if the other user would want to go on a date or not
            MatchMaker Object = new MatchMaker();

            string sex1; 
            Object.Sex = AskForSex();
            sex = ReadLine();
            i[0] = sex;
            double.TryParse(sex, out s);
            if (s==0)
            {
                sex1 = "Male";
            }
            else
            {
                sex1 = "Female";
            }

            
            Object.Age = AskForAge();
            age = ReadLine();
            i[1] = age;
            double.TryParse(age, out a);

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
            if(h==0)
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

            if (p==0)
            {
                peeves1 = "Hates the Word Moist";
            }
            else
            {
                peeves1 = "Hates the word fetus";
            }
            //
            //
            //after we have stored these values, we have the option of finding the % match or just using the tree\
            // so this is where we begin the tree
            // we must also change the .Parse into try parse in order to get to to work. 
            //
            //
            if ((s == 0) && (a >= 31) &&  (o == 0) && (h == 0) && (p == 0))
            {
                WriteLine();
                WriteLine("Congrats! You matched with Jacob Henry");
                WriteLine("Bio:");
                WriteLine("I like guns, I like Women, and I like beer");

                
            }
            else if ((s == 0) && (a > 17) && (o == 1) && (h == 0) && (p == 0))
            {
                WriteLine();
                WriteLine("Congrats! You matched with Fred Wilson");
                WriteLine("Bio:");
                WriteLine("'You miss 100% of the shots you don't take'" );
                WriteLine("- Wayne Gretzky");
                WriteLine("- Michael Scott");
                WriteLine("- Fred Wilson");


            }
            else if ((s == 0) && (a <=30) && (o == 0) && (h == 1) && (p == 1))
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
            else if ((s == 0) && (a >50) && (o == 1) && (h == 1) && (p == 1))
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
            else if ((s == 1) && (a >17) && (a<30) && (o == 0) && (h == 1) && (p == 0))
            {
                WriteLine();
                WriteLine("Congrats! You matched with Chloe Lamb!");
                WriteLine("Bio:");
                WriteLine("Music Runs My Life");
                WriteLine("Adventures Keep Me Sane");
                WriteLine("Love being out doors, catch me at Belle's");


            }
            else if ((s == 1) && (a> 40) && (o == 1) && (h == 1) && (p == 0))
            {
                WriteLine();
                WriteLine("Congrats! You matched with Remy LaBam!");
                WriteLine("Bio:");
                WriteLine("@__Flowers23");


            }
            else if ((s == 1) && (a >17) && (o == 1) && (h == 0) && (p == 1))
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

                WriteLine();
                    WriteLine("you matched with no one");
                WriteLine();
               WriteLine("This is a very unique combintation of qualities");
                WriteLine();
                WriteLine("" + sex1);
                WriteLine(a + "years old" );
                WriteLine("" + occupation1);
                WriteLine("" + hobbie1);
                WriteLine("" + peeves1);
               
            }
            //all we need to 2 more men and 4 more women
            // also has more info about the individuals
            // done :)

            Read();
        }
        public static string AskForSex()
        {
            string inValue;


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

            inValue = Console.ReadLine();

            return inValue;
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
