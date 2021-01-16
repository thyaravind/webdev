using System;
using System.Collections.Generic;

namespace classlibrary
{
    public partial class Person: IComparable<Person>
    {
        // fields
        public string Name;
        public DateTime DateOfBirth;
        public List<Person> Children = new List<Person>();
        public int Account;
        public Gender gender;
        
         
         
        
        
        // methods
        public void WriteToConsole()
        {
            Console.WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }

        
        /* Declaring both static and instance methods
        public static Person Procreate(Person p1,Person p2)
        {
            var child =  new Person();
            child.Name = $"Child of {p1.Name} and {p2.Name}";
            p1.Children.Add(child);
            p2.Children.Add(child);
            return child;
        }

        public Person ProcreateWith(Person p)
        {
            return Procreate(this, p);
        }
        */
        
        /*operators
        public static Person operator *(Person p1, Person p2)
        {
            return Procreate(p1,p2);
        }
        */
        
        
        
        /* local functions

        public static void Marraige(Person Groom, Person Bride,int KatnamAmount)
        {
            int MarriageExpenses = KatnamAmount / 10;
            Katnam();
            Thambulam(MarriageExpenses);
            


            void Katnam()
            {
                Groom.Account += KatnamAmount;
                
            }
            
            void Thambulam(int Expenses)
            {
                Groom.Account -= Expenses / 10;

            }
            
            
        }
        */

        public int CompareTo(Person other)
        {
            return Name.CompareTo(other.Name);
        }
        
        
        
        
    }
    
    // Enums
    public enum Gender
    {
        Male,
        Female,
        Other
    }

    public enum Fairness : short
    {
        SuperFair = 5,
        Fair = 4,
        Average = 3,
        BelowAverage = 2,
        NotFair = 1
    }


    [TestClass]
    public class PersonAgeTest
    {
        [TestMethod]
        public void Test_Age()
        {
            int expected = 
            
        }
        
    }
}
