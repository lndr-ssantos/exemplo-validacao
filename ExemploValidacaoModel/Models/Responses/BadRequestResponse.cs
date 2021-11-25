using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace ExemploValidacaoModel.Models.Responses
{
    public class BadRequestResponse : IActionResult
    {
        public List<string> Errors { get; set; }

        public BadRequestResponse(List<string> errors)
        {
            Errors = errors;
        }

        public async Task ExecuteResultAsync(ActionContext context)
        {
            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            await new JsonResult(this).ExecuteResultAsync(context);
        }
    }
}
