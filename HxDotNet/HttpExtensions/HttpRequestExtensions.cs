using HxDotNet.Core.Constants;
using HxDotNet.Core.Models;

namespace HxDotNet.HttpExtensions;

/// <summary>
/// Defines extension methods for working with htmx request headers
/// </summary>
public static class HttpRequestExtensions
{
    /// <summary>
    /// Returns true if the request was sent with htmx, otherwise false.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public static bool IsHxRequest(this HttpRequest request)
    {
        return request.Headers.ContainsKey(HxRequestHeaderNames.HxRequest);
    }
    /// <summary>
    /// Extracts the htmx request headers from the request.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public static HxRequestHeaders GetHxHeaders(this HttpRequest request)
    {
        request.Headers.TryGetValue(HxRequestHeaderNames.HxBoosted, out var HxBoosted);
        request.Headers.TryGetValue(HxRequestHeaderNames.HxCurrentUrl, out var HxCurrentUrl);
        request.Headers.TryGetValue(HxRequestHeaderNames.HxHistoryRestoreRequest, out var HxHistoryRestoreRequest);
        request.Headers.TryGetValue(HxRequestHeaderNames.HxPrompt, out var HxPrompt);
        request.Headers.TryGetValue(HxRequestHeaderNames.HxRequest, out var HxRequest);
        request.Headers.TryGetValue(HxRequestHeaderNames.HxTarget, out var HxTarget);
        request.Headers.TryGetValue(HxRequestHeaderNames.HxTriggerName, out var HxTriggerName);
        request.Headers.TryGetValue(HxRequestHeaderNames.HxTrigger, out var HxTrigger);
        return new HxRequestHeaders()
        {
            HxBoosted = HxBoosted,
            HxCurrentUrl = HxCurrentUrl,
            HxHistoryRestoreRequest = HxHistoryRestoreRequest,
            HxPrompt = HxPrompt,
            HxRequest = HxRequest,
            HxTarget = HxTarget,
            HxTriggerName = HxTriggerName,
            HxTrigger = HxTrigger,
        };
    }
}