
namespace HxDotnet;

public static class HttpResponseExtensions
{

    /// <summary>
    /// <inheritdoc cref="ResponseHeaderNames.HxLocation"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static HttpResponse HxLocation(this HttpResponse response, string value)
    {
        response.Headers.Append(ResponseHeaderNames.HxLocation, value);
        return response;
    }
    /// <summary>
    /// <inheritdoc cref="ResponseHeaderNames.HxPushUrl"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static HttpResponse HxPushUrl(this HttpResponse response, string value)
    {
        response.Headers.Append(ResponseHeaderNames.HxPushUrl, value);
        return response;
    }

    /// <summary>
    /// <inheritdoc cref="ResponseHeaderNames.HxRedirect"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxRedirect(this HttpResponse response, string value)
    {
        response.Headers.Append(ResponseHeaderNames.HxRedirect, value);
        return response;
    }
    /// <summary>
    /// <inheritdoc cref="ResponseHeaderNames.HxRefresh"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxRefresh(this HttpResponse response, string value)
    {
        response.Headers.Append(ResponseHeaderNames.HxRefresh, value);
        return response;
    }
    /// <summary>
    /// <inheritdoc cref="ResponseHeaderNames.HxReplaceUrl"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxReplaceUrl(this HttpResponse response, string value)
    {
        response.Headers.Append(ResponseHeaderNames.HxReplaceUrl, value);
        return response;
    }
    /// <summary>
    /// <inheritdoc cref="ResponseHeaderNames.HxReswap"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxReswap(this HttpResponse response, string value)
    {
        response.Headers.Append(ResponseHeaderNames.HxReswap, value);
        return response;
    }
    /// <summary>
    /// <inheritdoc cref="ResponseHeaderNames.HxRetarget"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxRetarget(this HttpResponse response, string value)
    {
        response.Headers.Append(ResponseHeaderNames.HxRetarget, value);
        return response;
    }
    /// <summary>
    /// <inheritdoc cref="ResponseHeaderNames.HxReselect"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxReselect(this HttpResponse response, string value)
    {
        response.Headers.Append(ResponseHeaderNames.HxReselect, value);
        return response;
    }
    /// <summary>
    /// <inheritdoc cref="ResponseHeaderNames.HxTrigger"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxTrigger(this HttpResponse response, string value)
    {
        response.Headers.Append(ResponseHeaderNames.HxTrigger, value);
        return response;
    }
    /// <summary>
    /// <inheritdoc cref="ResponseHeaderNames.HxTriggerAfterSettle"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxTriggerAfterSettle(this HttpResponse response, string value)
    {
        response.Headers.Append(ResponseHeaderNames.HxTriggerAfterSettle, value);
        return response;
    }
    /// <summary>
    /// <inheritdoc cref="ResponseHeaderNames.HxTriggerAfterSwap"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxTriggerAfterSwap(this HttpResponse response, string value)
    {
        response.Headers.Append(ResponseHeaderNames.HxTriggerAfterSwap, value);
        return response;
    }
}