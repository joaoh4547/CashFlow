using CashFlow.Application.UseCases.Expanses;
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
        try
        {
            var useCase = new RegisterExpanseUseCase();
            var response = useCase.Handle(request);
            return Created(string.Empty, response);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
        catch
        {
            return StatusCode(StatusCodes.Status500InternalServerError, "unknow error");
        }


    }
}
