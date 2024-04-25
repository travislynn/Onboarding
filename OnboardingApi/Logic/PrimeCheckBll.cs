using Microsoft.Extensions.Logging;
using OnboardingApi.Models;
using static System.Net.Mime.MediaTypeNames;

namespace OnboardingApi.Logic
{
    public class PrimeCheckBll
    {
        public PrimeCheckResult Get(int inputNumber)
        {

            //If the input number is prime, just return it back

            //If the input number is not prime, return the next prime number that is higher than my input,
            //and also return the next prime number that is lower than my input


            return new PrimeCheckResult { };
        }
    }
}
