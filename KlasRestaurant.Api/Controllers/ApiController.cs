
using ErrorOr;
using Microsoft.AspNetCore.Mvc;

namespace KlasRestaurant.Api.Controllers;

/*this is a common component that contains a method which takes a 
list of errors and convert it to a meaningful problem details response
*/
[ApiController]
public class ApiController : ControllerBase
{
    protected IActionResult Problem(List<Error> errors)
    {
        /*this is an inteermediate implementation as the there is not yet a model validation
          in our service at this point
        */
        var firstError = errors[0];
        var statusCode = firstError.Type switch
        {
            ErrorType.Conflict => StatusCodes.Status409Conflict,
            ErrorType.Validation => StatusCodes.Status400BadRequest,
            ErrorType.NotFound => StatusCodes.Status404NotFound,
            _ => StatusCodes.Status500InternalServerError
        };
        return Problem(statusCode: statusCode, title: firstError.Description);
    }
}