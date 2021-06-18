using System;
using System.Collections.Generic;



//variable declaration,data types, collections, code block, string interpolation, control, conditional, functions,


namespace getting_started
{
    class Program
    {
        static void Main(string[] args)
        {

            var code = "";
            string success = "success";
            int request_code = 200;
            var check = true;

            
            //Array (needs an array size or initializer)
            var students = new string[3];
            var roll = new int[]{1,2,3};

            students[0] = "Aravind";
            students[1] = "Bhanu";
            students[2] = "Carthik";


            //List (dynamically filled)
            var mathMarks = new List<int>();

            while (check)
            {
                Console.WriteLine("Enter grades");
                mathMarks.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine("Continue? true/false");
                check = bool.Parse(Console.ReadLine());

            }
            

            //Dict



            //objects
            school asu = new school();


            var totalMarks = cal_total(mathMarks);

            Console.WriteLine("Enter passcode");
            code = Console.ReadLine();

            //controls and conditionals

            while(code != "pass")
            {
                 if (code == "pass")
                {
                    Console.WriteLine("Authenticated with passcode = {0} and status {1} {2} ", code, request_code, success); //string Interpolation
                    break;
                }
                 else
                {
                    Console.WriteLine("Incorrect Passcode, Enter again");
                    code = Console.ReadLine();
                }
            }


            foreach (var student in students)
            {

                Console.WriteLine(student);
            }

            
            switch (totalMarks)
            {
                case 20:
                    Console.WriteLine("Total Marks are 20 and Class performed just okay");
                    break;
                case 30:
                    Console.WriteLine("Total Marks are 20 and Class performance is good");
                    break;
                case 40:
                    Console.WriteLine("Total Marks are 20 and Class performace: Exceptional");
                    break;
                default:
                    Console.WriteLine("Total Marks are not a round figures");
                    Console.WriteLine("Total Marks = {0}", totalMarks);
                    break;

            }



            print_roll(roll);

            //functions

            void print_roll(int[] x)
            {
                for (int i=0; i < x.Length; i++)
                {
                    Console.WriteLine(x[i]);
                }
                
            }

            int cal_total(List<int> x)
            {
                int total = 0;
                for (int i = 0; i < students.Length; i++)
                {
                    total += x[i];
                }
                return total;
            }

        }
    }


    class school
    {

    }
}
