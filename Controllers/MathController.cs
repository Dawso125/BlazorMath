using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace NewBlazorApp.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        [HttpGet]
        public ActionResult<int> Get(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return Ok(result);
            
        }
    }
}
