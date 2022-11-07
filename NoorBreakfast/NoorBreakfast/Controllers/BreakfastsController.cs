using Microsoft.AspNetCore.Mvc;
using NoorBreakfast.Contracts.Breakfast;

namespace NoorBreakfast.Controllers
{
    [ApiController]
    public class BreakfastsController : ControllerBase
    {
        [HttpPost("/breakfasts")]
        public IActionResult CreateBreakfast(CreateBreakfastRequest request)
        {
            return Ok(request);
        }
    }
}
