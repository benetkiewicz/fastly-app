namespace FastlyApp.Logic;

using Microsoft.AspNetCore.Mvc.Filters;

public class CacheOnFastlyAttribute : ResultFilterAttribute
{
    public int MaxAge { get; set; }

    public override void OnResultExecuting(ResultExecutingContext context)
    {
        context.HttpContext.Response.Headers.Add("Surrogate-Control", $"max-age={MaxAge}");
        context.HttpContext.Response.Headers["Cache-Control"] = "no-store, max-age=0";
        base.OnResultExecuting(context);
    }
}