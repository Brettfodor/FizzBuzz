using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Get(int num)
        {
            
            if (isMultipleOf3And5(num))
            {
                return "FizzBuzz";
            }
            else if (isMultipleOf3(num))
            {
                return "Fizz";
            }
            else if (isMultipleOf5(num))
            {
                return "Buzz";
            }  

            return num.ToString();
        }
        private bool isMultipleOf3(int numberToCheck)
            {
                return numberToCheck % 3 == 0;
            }

        private bool isMultipleOf5(int numberToCheck2)
            {
            return numberToCheck2 % 5 == 0;
            }
        private bool isMultipleOf3And5(int numbertocheck)
        {
            return numbertocheck % 3 == 0 && numbertocheck % 5 == 0;
        }
    }
}
