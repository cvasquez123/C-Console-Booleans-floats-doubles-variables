using System;

namespace hwthursday
{
    class Program
    {
        public static void Main(string[] args)
        {
            addTwoWords("car", "vasquez");
            add(5, 4);
            MyPrivateMethod();
            string result = twoStrings("Car", "los");
            Console.WriteLine(result);
          
        }

        // 2 Parameters and public
        public static void addTwoWords(string word1, string word2)
        {
            Console.WriteLine(word1 + word2);
        }

        // Private 
        private static void add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }

        // Return 
        public static  string twoStrings(String c, String d)
        {
            return c + d;
        }


        public static void MyPrivateMethod()
        {
            Console.WriteLine("This is my private method ");
        }

       
    }
}
