using OnboardingApi.Models;

namespace OnboardingApi.Logic
{
    public interface IPrimeCheckBll
    {
        PrimeCheckResult GetPrimeNumbers(int inputNumber);
    }
}