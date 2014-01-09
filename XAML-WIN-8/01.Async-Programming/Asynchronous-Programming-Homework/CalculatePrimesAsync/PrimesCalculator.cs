using System.Collections.Generic;
using System.Threading.Tasks;

namespace CalculatePrimesAsync
{
    public class PrimesCalculator
    {
        public static Task<List<int>> GetPrimesInRangeAsync(int rangeFirst, int rangeLast)
        {
            return Task.Run(
                () => GetPrimesInRange(rangeFirst, rangeLast)
                    );
        }

        public static Task<List<string>> GetPrimesCouplesAsync(int rangeFirst, int rangeLast)
        {
            return Task.Run(
                () => GetPrimesCouples(rangeFirst, rangeLast));
        }



        private static List<string> GetPrimesCouples(int rangeFirst, int rangeLast)
        {
            var primes = GetPrimesInRange(rangeFirst, rangeLast);
            var primesCouples = new List<string>();

            foreach (int prime in primes)
            {
                int lastDigit = prime % 10;

                if (lastDigit != prime && CheckIsPrime(lastDigit))
                {
                    primesCouples.Add(prime + "-" + lastDigit);
                    continue;
                }

                int rangeFrom = lastDigit;

                rangeFrom *= 10;
                int rangeTo = rangeFrom + 9;

                bool partnerFound = false;
                while (!partnerFound)
                {
                    List<int> partners = GetPrimesInRange(rangeFrom, rangeTo);
                    if (partners.Count > 0)
                    {
                        int newNumber = int.Parse(prime + "" + partners[0]);
                        primesCouples.Add(prime + "_" + partners[0]);
                        partnerFound = true;
                    }
                    rangeFrom *= 10;
                    rangeTo += 9;
                }
            }

            return primesCouples;
        }

        public static bool CheckIsPrime(int number)
        {
            bool isPrime = true;
            for (int divider = 2; divider < number; divider++)
            {
                if (number % divider == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }


        public static List<int> GetPrimesInRange(int rangeFirst, int rangeLast)
        {
            var primes = new List<int>();

            for (int number = rangeFirst; number < rangeLast; number++)
            {
                bool isPrime = true;
                for (int divider = 2; divider < number; divider++)
                {
                    if (number % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(number);
                }
            }

            return primes;
        }
    }
}