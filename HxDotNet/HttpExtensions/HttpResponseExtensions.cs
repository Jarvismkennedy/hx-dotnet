using HxDotNet.Core.Constants;
using HxDotNet.Core.Models;

namespace HxDotNet.HttpExtensions;

/// <summary>
/// Defines extension methods for adding htmx functionality to the response.
/// </summary>
public static class HttpResponseExtensions
{
    /// <summary>
    ///  Sets the HxResponseHeaders.
    /// </summary>
    public static HttpResponse SetHxHeaders(this HttpResponse response, HxResponseHeaders headers)
    {
        if (headers.HxLocation is not null)
        {
            response.HxLocation(headers.HxLocation);
        }
        if (headers.HxPushUrl is not null)
        {
            response.HxPushUrl(headers.HxPushUrl);
        }
        if (headers.HxRedirect is not null)
        {
            response.HxRedirect(headers.HxRedirect);
        }
        if (headers.HxRefresh is bool hxRefresh)
        {
            response.HxRefresh(hxRefresh);
        }
        if (headers.HxReplaceUrl is not null)
        {
            response.HxReplaceUrl(headers.HxReplaceUrl);
        }
        if (headers.HxReswap is not null)
        {
            response.HxReswap(headers.HxReswap);
        }
        if (headers.HxRetarget is not null)
        {
            response.HxRetarget(headers.HxRetarget);
        }
        if (headers.HxReselect is not null)
        {
            response.HxReselect(headers.HxReselect);
        }
        if (headers.HxTrigger is not null)
        {
            response.HxTrigger(headers.HxTrigger);
        }
        if (headers.HxTriggerAfterSettle is not null)
        {
            response.HxTriggerAfterSettle(headers.HxTriggerAfterSettle);
        }
        if (headers.HxTriggerAfterSwap is not null)
        {
            response.HxTriggerAfterSwap(headers.HxTriggerAfterSwap);
        }
        return response;
    }

    /// <summary>
    /// <inheritdoc cref="HxResponseHeaderNames.HxLocation"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="uri"></param>
    /// <returns></returns>
    public static HttpResponse HxLocation(this HttpResponse response, Uri uri)
    {
        response.Headers.Append(HxResponseHeaderNames.HxLocation, uri.ToString());
        return response;
    }

    /// <summary>
    /// <inheritdoc cref="HxResponseHeaderNames.HxLocation"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="url"></param>
    /// <returns></returns>
    public static HttpResponse HxLocation(this HttpResponse response, string url)
    {
        response.Headers.Append(HxResponseHeaderNames.HxLocation, url);
        return response;
    }

    /// <summary>
    /// <inheritdoc cref="HxResponseHeaderNames.HxPushUrl"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="uri"></param>
    /// <returns></returns>
    public static HttpResponse HxPushUrl(this HttpResponse response, Uri uri)
    {
        response.Headers.Append(HxResponseHeaderNames.HxPushUrl, uri.ToString());
        return response;
    }

    /// <summary>
    /// <inheritdoc cref="HxResponseHeaderNames.HxPushUrl"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="url"></param>
    /// <returns></returns>
    public static HttpResponse HxPushUrl(this HttpResponse response, string url)
    {
        response.Headers.Append(HxResponseHeaderNames.HxPushUrl, url);
        return response;
    }

    /// <summary>
    /// <inheritdoc cref="HxResponseHeaderNames.HxRedirect"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="url"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxRedirect(this HttpResponse response, string url)
    {
        response.Headers.Append(HxResponseHeaderNames.HxRedirect, url);
        return response;
    }

    /// <summary>
    /// <inheritdoc cref="HxResponseHeaderNames.HxRedirect"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="uri"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxRedirect(this HttpResponse response, Uri uri)
    {
        response.Headers.Append(HxResponseHeaderNames.HxRedirect, uri.ToString());
        return response;
    }

    /// <summary>
    /// <inheritdoc cref="HxResponseHeaderNames.HxRefresh"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="shouldRefresh"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxRefresh(this HttpResponse response, bool shouldRefresh)
    {
        response.Headers.Append(HxResponseHeaderNames.HxRefresh, shouldRefresh ? "true" : "false");
        return response;
    }

    /// <summary>
    /// <inheritdoc cref="HxResponseHeaderNames.HxReplaceUrl"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="url"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxReplaceUrl(this HttpResponse response, string url)
    {
        response.Headers.Append(HxResponseHeaderNames.HxReplaceUrl, url);
        return response;
    }

    /// <summary>
    /// <inheritdoc cref="HxResponseHeaderNames.HxReplaceUrl"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="uri"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxReplaceUrl(this HttpResponse response, Uri uri)
    {
        response.Headers.Append(HxResponseHeaderNames.HxReplaceUrl, uri.ToString());
        return response;
    }

    /// <summary>
    /// Sets the hx-replace-url header to false.
    /// <inheritdoc cref="HxResponseHeaderNames.HxReplaceUrl"/>
    /// Prevents the browsers url from being updated.
    /// </summary>
    /// <param name="response"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxPreventReplaceUrl(this HttpResponse response)
    {
        response.Headers.Append(HxResponseHeaderNames.HxReplaceUrl, "false");
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
    /// Sets the status code to <see href="https://en.wikipedia.org/wiki/86_(term)">286</see>, telling htmx to stop polling.
    /// </summary>
    /// <param name="response"></param>
    /// <returns></returns>
    public static HttpResponse HxStopPolling(this HttpResponse response)
    {
        response.StatusCode = 286;
        return response;
    }

    /// <summary>
    /// Sets the status code to statusCode
    /// </summary>
    /// <param name="response"></param>
    /// <param name="statusCode"></param>
    /// <returns></returns>
    public static HttpResponse StatusCode(this HttpResponse response, int statusCode)
    {
        response.StatusCode = statusCode;
        return response;
    }
}
