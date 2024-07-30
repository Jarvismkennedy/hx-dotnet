using System;
using System.Text.Json;

namespace HxDotnet;

public static class HttpResponseExtensions
{

    /// <summary>
    /// <inheritdoc cref="HxResponseHeaderNames.HxLocation"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="value"></param>
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
    /// <param name="value"></param>
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
    /// <param name="value"></param>
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
    /// <param name="value"></param>
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
    /// <param name="value"></param>
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
    /// <param name="value"></param>
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
    /// <param name="value"></param>
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
    /// <param name="value"></param>
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
    /// <param name="value"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxReplaceUrl(this HttpResponse response, Uri uri)
    {
        response.Headers.Append(HxResponseHeaderNames.HxReplaceUrl, uri.ToString());
        return response;
    }
    /// <summary>
    /// <inheritdoc cref="HxResponseHeaderNames.HxReplaceUrl"/>
    /// Prevents the browsers url from being updated.
    /// </summary>
    /// <param name="response"></param>
    /// <param name="value"></param>
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
    /// <inheritdoc cref="HxResponseHeaderNames.HxTrigger"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxTrigger(this HttpResponse response, IReadOnlyDictionary<string, object> events)
    {
        response.SetEvents(HxResponseHeaderNames.HxTrigger, events);
        return response;
    }
    /// <summary>
    /// <inheritdoc cref="HxResponseHeaderNames.HxTriggerAfterSettle"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxTriggerAfterSettle(this HttpResponse response, IReadOnlyDictionary<string, object> events)
    {
        response.SetEvents(HxResponseHeaderNames.HxTriggerAfterSettle, events);
        return response;
    }
    /// <summary>
    /// <inheritdoc cref="HxResponseHeaderNames.HxTriggerAfterSwap"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxTriggerAfterSwap(this HttpResponse response, IReadOnlyDictionary<string, object> events)
    {
        response.SetEvents(HxResponseHeaderNames.HxTriggerAfterSwap, events);
        return response;
    }
    private static void SetEvents(this HttpResponse response, string triggerHeader, IReadOnlyDictionary<string, object> events)
    {
        if (triggerHeader is not HxResponseHeaderNames.HxTrigger and not HxResponseHeaderNames.HxTriggerAfterSettle
        and not HxResponseHeaderNames.HxTriggerAfterSwap)
        {
            throw new ArgumentException("Invalid trigger header", triggerHeader);
        }
        var hasCurrentValues = response.Headers.TryGetValue(triggerHeader, out var currentHeader);
        if (hasCurrentValues)
        {
            var currentEvents = JsonSerializer.Deserialize<Dictionary<string, object>>(currentHeader.ToString())!;
            foreach (var (key, value) in events)
            {
                currentEvents.TryAdd(key, value);
            }
            events = currentEvents;
        }
        response.Headers[triggerHeader] = JsonSerializer.Serialize(events, JsonConfiguration.Options);
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