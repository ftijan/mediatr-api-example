using Microsoft.AspNetCore.Mvc;

namespace Example.MediatR.Api.Utils
{
    public static class RequestUtils
    {
        internal static IActionResult CreatePayloadResult(this object payload)
        {
            if (payload == null)
            {
                return new NotFoundResult();
            }

            return new JsonResult(payload)
            {
                StatusCode = 200,
                ContentType = "application/json"
            };
        }
    }
}
