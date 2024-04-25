using Microsoft.AspNetCore.Mvc;
using OnboardingApi.Logic;
using OnboardingApi.Models;

namespace OnboardingApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrimeCheckController : ControllerBase
    {
        private readonly ILogger<PrimeCheckController> _logger;
        private readonly IPrimeCheckBll _bll;

        public PrimeCheckController(ILogger<PrimeCheckController> logger, IPrimeCheckBll bll)
        {
            _logger = logger;
            _bll = bll;
        }

        [HttpGet(Name = "PrimeCheck")]
        public PrimeCheckResult Get(int inputNumber)
        {
            return _bll.GetPrimeNumbers(inputNumber);
        }
    }
}
