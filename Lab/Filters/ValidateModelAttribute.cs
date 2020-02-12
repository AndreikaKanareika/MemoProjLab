using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;

namespace Lab.Filters
{
    public class ValidateModelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var key = context.ModelState.Keys.First();
                context.Result = new BadRequestObjectResult(new { Message = context.ModelState[key].Errors.First().ErrorMessage });
            }
        }
    }
}
