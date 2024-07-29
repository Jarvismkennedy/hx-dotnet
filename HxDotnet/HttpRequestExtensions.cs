namespace HxDotnet;

public static class HttpRequestExtensions
{
    public static bool IsHtmx(this HttpRequest request)
    {
        return request.Headers.ContainsKey(RequestHeaderNames.HxRequest);
    }
}