using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Extensions.Logging;
using OnboardingApi.Models;
using static System.Net.Mime.MediaTypeNames;

namespace OnboardingApi.Logic
{
    public class PrimeCheckBll : IPrimeCheckBll
    {
        public PrimeCheckResult GetPrimeNumbers(int inputNumber)
        {

            //If the input number is prime, just return it back
            if (isPrime(inputNumber))
            {
                return new PrimeCheckResult { result1 = inputNumber };
            }
            //If the input number is not prime, return the next prime number that is higher than my input,
            //and also return the next prime number that is lower than my input
            int lowerPrimeNumber= inputNumber, upperPrimeNumber= inputNumber;
            while (!isPrime(--lowerPrimeNumber)) ;
            while(!isPrime(++upperPrimeNumber)) ;
            return new PrimeCheckResult { result1 = lowerPrimeNumber, result2 = upperPrimeNumber };
        }
        public bool isPrime(int inputNumber)
        {
            if(inputNumber <= 1)
            {
                return false;
            }
            if(inputNumber <= 3) 
            {
                return true;
            }
            if(inputNumber %2 == 0 || inputNumber % 3==0) 
            {
                return false;
            }
            for (int i = 5; i * i <= inputNumber; i++)
            {
                if(inputNumber % i== 0 || inputNumber %(i +2) ==0)
                {
                    return false;
                }
                
            }
            return true;
        }
    }
}
