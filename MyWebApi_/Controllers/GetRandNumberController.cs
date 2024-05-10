using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyWebApi_.Controllers
{
    [Route("api/GetRandNumber")]
    [ApiController]
    public class GetRandNumberController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<int>> GetRandomNumber()
        {
            return Random.Shared.Next(0, 100);
        }

        [HttpPost]
        public async Task<ActionResult<int>> PostRandomNumber(int minValue, int maxValue)
        {
            if(minValue > maxValue)
            {
                return Random.Shared.Next(maxValue, minValue);
            }
            return Random.Shared.Next(minValue, maxValue);
        }
    }
}
