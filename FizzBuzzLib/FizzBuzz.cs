namespace FizzBuzzLib
{
    public class FizzBuzz : IFizzBuzz
    {

        //This function recieves an integer and parses it into a string, unless it satistfies specific conditions
        public string FizzBuzzifyAnInt(int num)
        {
            //if multiple of 15 return FizzBuzz check 15 first otherwise it will never be met
            if (num % 15 == 0)
            {
                return "FizzBuzz";
            }
            //if multiple of 5 return Buzz
            else if (num % 5 == 0)
            {
                return "Buzz";
            }
            //if multiple of 3 return Fizz
            else if (num % 3 == 0)
            {
                return "Fizz";
            }
            //else return the interger as a string
            return num.ToString();
        }
    }
}
