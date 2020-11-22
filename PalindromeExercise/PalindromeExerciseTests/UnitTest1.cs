using System;
using Xunit;
using PalindromeExercise;


namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("omar", false)]
        [InlineData("madam", true)]
        public void Test1(string x, bool expected)
        {
            //arrange
            var test = new WordSmith();

            var actual = test.IsAPalindrome(x);

            Assert.Equal(expected, actual);
            
        }
        
    }
}
