using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ExemploValidacaoModel.Models.Responses
{
    public static class CustomModelValidationErrorResponse
    {
        public static IActionResult Response(ActionContext actionContext)
        {
            var errors = actionContext.ModelState
                .Where(modelError => modelError.Value.Errors.Count > 0)
                .Select(modelError => modelError.Value.Errors.First().ErrorMessage)
                .ToList();

            return new BadRequestResponse(errors);
        }
    }
}
