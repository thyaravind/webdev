using System;
using System.IO;


namespace consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* METHOD TYPES
            Console.WriteLine("Hello World!");
            var Aravind = new Person();
            var Wife = new Person { Name = "Aravind's wife"};
            var SecondWife = new Person { Name = "Aravind's second wife"};
            Aravind.Name = "Aravind";
            Aravind.WriteToConsole();
            
            Person.Procreate(Aravind, Wife).WriteToConsole();
            Aravind.ProcreateWith(SecondWife).WriteToConsole();
            
            
            var Child = Aravind * Wife;
            Child.WriteToConsole();

            */

            /* Exception Handling
            try
            {
                StreamReader reader =
                    new StreamReader(@"/Users/aravind/OneDrive/OneDocuments/Algorithm/dotNet/CSharp/202/Data/data2.txt");
                Console.WriteLine(reader.ReadToEnd());
                reader.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);
            }
            */
            
            /* Enums
            var Aravind = new Person(){Name = "Aravind",};
            Aravind.gender = Gender.Male;
            int[] values = (int[])Enum.GetValues(typeof(Gender));

            foreach (var value in values)
            {
                Console.WriteLine(value);
            }
            
            
            //Strongly typed
            int Num = (int) Gender.Female;
            Gender gender = (Gender)2;
            Fairness fairness = (Fairness) Gender.Female;
            */
            
            





        }
    }
}

