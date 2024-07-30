
namespace HxDotnet;

public static class HttpResponseExtensions
{

    /// <summary>
    /// <inheritdoc cref="HxResponseHeaderNames.HxLocation"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static HttpResponse HxLocation(this HttpResponse response, string value)
    {
        response.Headers.Append(HxResponseHeaderNames.HxLocation, value);
        return response;
    }
    /// <summary>
    /// <inheritdoc cref="HxResponseHeaderNames.HxPushUrl"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static HttpResponse HxPushUrl(this HttpResponse response, string value)
    {
        response.Headers.Append(HxResponseHeaderNames.HxPushUrl, value);
        return response;
    }

    /// <summary>
    /// <inheritdoc cref="HxResponseHeaderNames.HxRedirect"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxRedirect(this HttpResponse response, string value)
    {
        response.Headers.Append(HxResponseHeaderNames.HxRedirect, value);
        return response;
    }
    /// <summary>
    /// <inheritdoc cref="HxResponseHeaderNames.HxRefresh"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxRefresh(this HttpResponse response, string value)
    {
        response.Headers.Append(HxResponseHeaderNames.HxRefresh, value);
        return response;
    }
    /// <summary>
    /// <inheritdoc cref="HxResponseHeaderNames.HxReplaceUrl"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxReplaceUrl(this HttpResponse response, string value)
    {
        response.Headers.Append(HxResponseHeaderNames.HxReplaceUrl, value);
        return response;
    }
    /// <summary>
    /// <inheritdoc cref="HxResponseHeaderNames.HxReswap"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxReswap(this HttpResponse response, string value)
    {
        response.Headers.Append(HxResponseHeaderNames.HxReswap, value);
        return response;
    }
    /// <summary>
    /// <inheritdoc cref="HxResponseHeaderNames.HxRetarget"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxRetarget(this HttpResponse response, string value)
    {
        response.Headers.Append(HxResponseHeaderNames.HxRetarget, value);
        return response;
    }
    /// <summary>
    /// <inheritdoc cref="HxResponseHeaderNames.HxReselect"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxReselect(this HttpResponse response, string value)
    {
        response.Headers.Append(HxResponseHeaderNames.HxReselect, value);
        return response;
    }
    /// <summary>
    /// <inheritdoc cref="HxResponseHeaderNames.HxTrigger"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxTrigger(this HttpResponse response, string value)
    {
        response.Headers.Append(HxResponseHeaderNames.HxTrigger, value);
        return response;
    }
    /// <summary>
    /// <inheritdoc cref="HxResponseHeaderNames.HxTriggerAfterSettle"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxTriggerAfterSettle(this HttpResponse response, string value)
    {
        response.Headers.Append(HxResponseHeaderNames.HxTriggerAfterSettle, value);
        return response;
    }
    /// <summary>
    /// <inheritdoc cref="HxResponseHeaderNames.HxTriggerAfterSwap"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxTriggerAfterSwap(this HttpResponse response, string value)
    {
        response.Headers.Append(HxResponseHeaderNames.HxTriggerAfterSwap, value);
        return response;
    }
}