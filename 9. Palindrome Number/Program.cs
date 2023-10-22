using System;

namespace _9._Palindrome_Number
{
    internal class Program
    {
        private bool IsPalindrome(int x){
            string number = x.ToString();
            int lastIndex = number.Length - 1;

            if (x < 0)
                return false;

            for (int i = 0; i < number.Length / 2; i++)
            {
                if (number[i] != number[lastIndex])
                    return false;
                else
                    lastIndex--;
            }

            return true;
        }
        
        public static void Main(string[] args){
            Program program = new Program();
            
            Console.WriteLine(program.IsPalindrome(905509)); // true
        }
    }
}