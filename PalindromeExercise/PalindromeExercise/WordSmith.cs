using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            bool conditional;
            string reverseWord = "";
            List<char> original = word.ToList<char>();
            for(int i= original.Count -1; i >=0; i--)
            {
                reverseWord += original[i];

            }

            if(word == reverseWord)
            {
                conditional = true;
            }
            else
            {
                conditional = false;
            }



            return conditional;


            
        }

        public bool IsAPalindrome()
        {
            throw new NotImplementedException();
        }
    }
}
