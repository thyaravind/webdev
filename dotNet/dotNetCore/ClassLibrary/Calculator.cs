using System;

namespace ClassLibrary
{
    public class Calculator
    {
 
        
        public static double Divide(double x, double y)
        {
            return x / y;
        }

        public static void ThrowsExceptionExample()
        {
            throw new System.IO.FileNotFoundException();
        }
        
        public static void ThrowsArgumentExceptionExample()
        {
            throw new ArgumentException("Parameter exception occured","file_name");
        }
        
    }
    
    
    public class Comparer1<T> {

        public static bool AreEqual(T value1, T value2) {

            return value1.Equals(value2);
        }

    }
        

    public class Comparer2{

        public static bool AreEqual<T>(T value1, T value2) {

            return value1.Equals(value2);
        }

    }
}