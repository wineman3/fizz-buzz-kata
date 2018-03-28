using System;
using System.Collections.Generic;

namespace FizzBuzz.Library
{
    public class FizzBuzzService
    {
        public String Print(int v)
        {
            String answer = "";
            if(IsDivisibleBy3(v))
            {
                answer="Fizz";
            }
            if (IsDivisibleBy5(v))
            {
                answer+="Buzz";
            }
            if(answer.Equals(""))
            {
                return v.ToString();
            }
            return answer;
        }
        private bool IsDivisibleBy3(int number)
        {
            return (number % 3 == 0);
        }
        private bool IsDivisibleBy5(int number)
        {
            return (number % 5 == 0);
        }
    }
}