namespace HxDotNet.Core.Models;

/// <summary>
/// Defines an event to be sent in the <see cref="HxResponseHeaders.HxTrigger" />
/// <see cref="HxResponseHeaders.HxTriggerAfterSwap" /> or <see cref="HxResponseHeaders.HxTriggerAfterSettle" /> header
/// </summary>
public readonly record struct ServerEvent(string EventName, object EventDetail)
{
    /// <summary>
    /// Implicit conversion to ServerEvent
    /// </summary>
    public static implicit operator ServerEvent(string eventName) => new(eventName, new { });

    /// <summary>
    /// Implicit conversion to ServerEvent
    /// </summary>
    public static implicit operator ServerEvent((string, object) Event) =>
        new(Event.Item1, Event.Item2);
}
