using System;
using System.Data.SqlClient;
using System.Reflection;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            
            #region METHOD TYPES
            /*
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

            #endregion

            
            
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
            
            
            /* Reflection
            Type T0 = Type.GetType("DirectClass");
            
            var Aravind = new Person();
            Type T = Aravind.GetType();

            var T2 = typeof(Person);
            
            
            Console.WriteLine(T.FullName);
            Console.WriteLine(T.Namespace);
            Console.WriteLine(T.Name);
            Console.WriteLine("Class Properties");
            
            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.Name + "," + property.PropertyType.Name );
            }
            
            
            
            Console.WriteLine("Class methods");
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.Name + "," + method.ReturnType.Name);
            }

            */


            SqlConnection con = new SqlConnection("data source=.; database=Inrika; integrated security=SSPI");


            /* Generics
             
            bool result1 = Comparer1<int>.AreEqual(1,1);
            bool result2 = Comparer2.AreEqual<string>("a","b");

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            */
            
            
            
            
        }
    }
}
