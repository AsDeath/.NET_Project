using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PaymentSystem.Shared;

namespace PaymentSystem.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurencyController : ControllerBase
    {
        [HttpGet]
        public CurrencyList GetCurrencies()
        {
            return new CurrencyList
            {
                Currencies = CurrencyManager.Currencies
            };
        }
    }
}
