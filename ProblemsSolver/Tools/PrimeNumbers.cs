using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemsSolver.Tools
{
    /// <summary>
    /// Method to working with prime numbers
    /// </summary>
    public static class PrimeNumbers
    {
        static List<long> numbers = new List<long>(); //List of prime numbers

        const int firstNumber = 2; //Constant for moving step by step through even numbers
        static int mult = 0;       //Multiplier for moving

        static PrimeNumbers()
        {
            mult++;
            numbers.Add(mult * firstNumber);
            mult++;
            numbers.Add(mult * firstNumber - 1);
            numbers.Add(mult * firstNumber + 1);
        }

        /// <summary>
        /// Method to searching next two member sequince of prime numbers 
        /// </summary>
        static void SearchNext()
        {
            long number = 0;

            mult += 2;
            number = mult * firstNumber - 1;
            if (number.IsPrime()) numbers.Add(number);

            mult++;
            number = mult * firstNumber + 1;
            if (number.IsPrime()) numbers.Add(number);
        }

        /// <summary>
        /// Method to searching all members, that below boundler
        /// </summary>
        /// <param name="boundler">limit of sequence</param>
        public static void SearchBelow(int boundler)
        {
            while(numbers.Last() < boundler)
            {
                SearchNext();
            }
        }

        /// <summary>
        /// Method to defining is number prime or not-prime
        /// </summary>
        /// <param name="number">some number</param>
        /// <returns>Returns true if number is prime and false if not-prime</returns>
        public static bool IsPrime(this long number)
        {
            int idPrime = 0;
            long divider;


            divider = number / numbers[idPrime];
            while(numbers[idPrime] <= divider)
            {
                if(number%numbers[idPrime] == 0)
                {
                    return false;
                }
                idPrime++;
                if(idPrime >= numbers.Count)
                {
                    while (numbers.Count <= idPrime)
                    {
                        SearchNext();
                    }
                }
                
                divider = number / numbers[idPrime];
            }
            return true;
        }

        /// <summary>
        /// Async method to getting concrete element of sequence of prime numbers
        /// </summary>
        public static async Task<long> AsyncGetElementAt(int index)
        {
            --index; // The first element of sequence has index 0, for that we use decrement for index

            if (numbers.Count() > index)
                return numbers.ElementAt(index);
            else
            {
                while(numbers.Count <= index)
                {
                    await Task.Run(() => SearchNext());
                }
                return numbers.ElementAt(index);
            }
        }

        /// <summary>
        /// Method to getting concrete element of sequence of prime numbers
        /// </summary>
        public static long GetElementAt(int index)
        {
            --index; //The first element of sequence has index 0, for that we use decrement for index
 
            if (numbers.Count() > index)
                return numbers.ElementAt(index);
            else
            {
                while (numbers.Count <= index)
                {
                    SearchNext();
                }
                return numbers.ElementAt(index);
            }
        }

        /// <summary>
        /// Method to getting sequence of finded prime numbers
        /// </summary>
        /// <returns>Returns sequince prime numbers</returns>
        public static List<long> GetSequence()
        {
            return numbers;
        }

    }
}
