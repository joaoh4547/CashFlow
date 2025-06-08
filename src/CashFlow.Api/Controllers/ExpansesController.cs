using CashFlow.Communication.Requests;
using Microsoft.AspNetCore.Mvc;

namespace CashFlow.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExpansesController : ControllerBase
{
    [HttpPost]
    public IActionResult Register([FromBody] RegisterExpanseRequest request)
    {
        return Created();
    }
}
