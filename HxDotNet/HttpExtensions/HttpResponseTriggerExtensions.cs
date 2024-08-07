using System.Text.Json;
using HxDotNet.Configuration;
using HxDotNet.Core.Constants;
using HxDotNet.Core.Models;

namespace HxDotNet.HttpExtensions;

///<summary>
///	Defines extension methods for adding Hx-Trigger response header.
///	</summary>
public static class HttpResponseTriggerExtensions
{
    #region HxTrigger
    /// <summary>
    /// <inheritdoc cref="HxResponseHeaderNames.HxTrigger"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="event"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxTrigger(this HttpResponse response, ServerEvent @event)
    {
        response.SetEvents(HxResponseHeaderNames.HxTrigger, @event);
        return response;
    }

    /// <summary>
    /// <inheritdoc cref="HxResponseHeaderNames.HxTrigger"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="events"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxTrigger(
        this HttpResponse response,
        ReadOnlySpan<ServerEvent> events
    )
    {
        response.SetEvents(HxResponseHeaderNames.HxTrigger, events);
        return response;
    }

    /// <summary>
    /// <inheritdoc cref="HxResponseHeaderNames.HxTrigger"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="events"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxTrigger(this HttpResponse response, params ServerEvent[] events)
    {
        response.SetEvents(HxResponseHeaderNames.HxTrigger, events);
        return response;
    }
    #endregion
    #region HxTriggerAfterSwap
    /// <summary>
    /// <inheritdoc cref="HxResponseHeaderNames.HxTriggerAfterSwap"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="event"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxTriggerAfterSwap(this HttpResponse response, ServerEvent @event)
    {
        response.SetEvents(HxResponseHeaderNames.HxTriggerAfterSwap, @event);
        return response;
    }

    /// <summary>
    /// <inheritdoc cref="HxResponseHeaderNames.HxTriggerAfterSwap"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="events"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxTriggerAfterSwap(
        this HttpResponse response,
        ReadOnlySpan<ServerEvent> events
    )
    {
        response.SetEvents(HxResponseHeaderNames.HxTriggerAfterSwap, events);
        return response;
    }

    /// <summary>
    /// <inheritdoc cref="HxResponseHeaderNames.HxTriggerAfterSwap"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="events"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxTriggerAfterSwap(
        this HttpResponse response,
        params ServerEvent[] events
    )
    {
        response.SetEvents(HxResponseHeaderNames.HxTriggerAfterSwap, events);
        return response;
    }
    #endregion
    #region HxTriggerAfterSettle
    /// <summary>
    /// <inheritdoc cref="HxResponseHeaderNames.HxTriggerAfterSettle"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="event"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxTriggerAfterSettle(this HttpResponse response, ServerEvent @event)
    {
        response.SetEvents(HxResponseHeaderNames.HxTriggerAfterSettle, @event);
        return response;
    }

    /// <summary>
    /// <inheritdoc cref="HxResponseHeaderNames.HxTriggerAfterSettle"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="events"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxTriggerAfterSettle(
        this HttpResponse response,
        ReadOnlySpan<ServerEvent> events
    )
    {
        response.SetEvents(HxResponseHeaderNames.HxTriggerAfterSettle, events);
        return response;
    }

    /// <summary>
    /// <inheritdoc cref="HxResponseHeaderNames.HxTriggerAfterSettle"/>
    /// </summary>
    /// <param name="response"></param>
    /// <param name="events"></param>
    /// <returns></returns>
    /// <inheritdoc />
    public static HttpResponse HxTriggerAfterSettle(
        this HttpResponse response,
        params ServerEvent[] events
    )
    {
        response.SetEvents(HxResponseHeaderNames.HxTriggerAfterSettle, events);
        return response;
    }
    #endregion

    private static void SetEvents(this HttpResponse response, string triggerHeader, ServerEvent ev)
    {
        var hasCurrentValues = response.Headers.TryGetValue(triggerHeader, out var currentHeader);
        Dictionary<string, object> currentEvents;
        if (hasCurrentValues)
        {
            currentEvents = JsonSerializer.Deserialize<Dictionary<string, object>>(
                currentHeader.ToString()
            )!;
            currentEvents.TryAdd(ev.EventName, ev.EventDetail);
        }
        else
        {
            currentEvents = new Dictionary<string, object>(StringComparer.Ordinal)
            {
                { ev.EventName, ev.EventDetail },
            };
        }
        response.Headers[triggerHeader] = JsonSerializer.Serialize(
            currentEvents,
            JsonConfiguration.Options
        );
    }

    private static void SetEvents(
        this HttpResponse response,
        string triggerHeader,
        ReadOnlySpan<ServerEvent> events
    )
    {
        var hasCurrentValues = response.Headers.TryGetValue(triggerHeader, out var currentHeader);
        Dictionary<string, object> currentEvents;
        if (hasCurrentValues)
        {
            currentEvents = JsonSerializer.Deserialize<Dictionary<string, object>>(
                currentHeader.ToString()
            )!;
            foreach (var ev in events)
            {
                currentEvents.TryAdd(ev.EventName, ev.EventDetail);
            }
        }
        else
        {
            currentEvents = new(StringComparer.Ordinal);
            foreach (var ev in events)
            {
                currentEvents.TryAdd(ev.EventName, ev.EventDetail);
            }
        }
        response.Headers[triggerHeader] = JsonSerializer.Serialize(
            currentEvents,
            JsonConfiguration.Options
        );
    }
}
