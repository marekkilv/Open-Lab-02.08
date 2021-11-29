using System;

namespace Open_Lab_02._08
{
    public class Checker
    {
        public bool IsEmpty(string str)
        {
            string s1 = "abcd";
            string s2 = "";
            string s3 = null;

            Console.WriteLine("String s1 {0}.", Test(s1));
            Console.WriteLine("String s2 {0}.", Test(s2));
            Console.WriteLine("String s3 {0}.", Test(s3));

            String Test(string s)
          {
           if (String.IsNullOrEmpty(s))
              return "is null or empty";
            return String.Format("(\"{0}\") is neither null nor empty", s); 
                else
    return String.Format("(\"{0}\") is neither null nor empty", s);
                

        }
    }
}
