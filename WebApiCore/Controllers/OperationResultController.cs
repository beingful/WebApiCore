using Microsoft.AspNetCore.Mvc;

namespace WebApiCore
{
    [Route("[controller]")]
    [ApiController]
    public class ReverseController : ControllerBase
    {
        [HttpGet]
        public OperationResult Reverse(string? data = null)
        {
            OperationResult result = new OperationResult(data);
            
            if (data is string strData)
            {
                var selector = new HandlerRouter(strData, typeof(double));
                Handler handler = selector.GetHandler();
                result = handler.GetResult();
            }

            return result;
        }
    }
}