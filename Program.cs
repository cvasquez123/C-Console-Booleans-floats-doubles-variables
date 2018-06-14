using System;

namespace hwthursday
{
    class Program
    {
        public static void Main(string[] args)
        {
            addTwoWords("car", "vasquez");
            add(5, 4);
            s
          
        }

        // Parameters
        public static void addTwoWords(string word1, string word2)
        {
            Console.WriteLine(word1 + word2);
        }

        // Public
        private static void add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }

        private void MyPrivateMethod()
        {
            Console.WriteLine("This is my private method ");
        }

        public void sampleMethod()
        {
            Console.WriteLine("This method is free for everybody to use");
        }
    }
}
