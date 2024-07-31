namespace HxDotNet.Core.Constants;

/// <summary>
/// Defines the names of htmx response headers
/// </summary>
public static class HxResponseHeaderNames
{
    /// <summary>
    /// allows you to do a client-side redirect that does not do a full page reload
    /// </summary>
    public const string HxLocation = "HX-Location";
    /// <summary>
    /// pushes a new url into the history stack
    /// </summary>
    public const string HxPushUrl = "HX-Push-Url";
    /// <summary>
    /// can be used to do a client-side redirect to a new location
    /// </summary>
    public const string HxRedirect = "HX-Redirect";

    /// <summary>
    /// if set to “true” the client-side will do a full refresh of the page
    /// </summary>
    public const string HxRefresh = "HX-Refresh";
    /// <summary>
    /// replaces the current URL in the location bar
    /// </summary>
    public const string HxReplaceUrl = "HX-Replace-Url";
    /// <summary>
    /// allows you to specify how the response will be swapped. See hx-swap for possible values
    /// </summary>
    public const string HxReswap = "HX-Reswap";
    /// <summary>
    /// a CSS selector that updates the target of the content update to a different element on the page
    /// </summary>
    public const string HxRetarget = "HX-Retarget";
    /// <summary>
    /// a CSS selector that allows you to choose which part of the response is used to be swapped in. Overrides an existing hx-select on the triggering element
    /// </summary>
    public const string HxReselect = "HX-Reselect";
    /// <summary>
    /// allows you to trigger client-side events
    /// </summary>
    public const string HxTrigger = "HX-Trigger";
    /// <summary>
    /// allows you to trigger client-side events after the settle step
    /// </summary>
    public const string HxTriggerAfterSettle = "HX-Trigger-After-Settle";
    /// <summary>
    /// allows you to trigger client-side events after the swap step
    /// </summary>
    public const string HxTriggerAfterSwap = "HX-Trigger-After-Swap";
}