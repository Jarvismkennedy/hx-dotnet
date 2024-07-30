namespace HxDotNet.Core.Constants;

public static class HxRequestHeaderNames
{
    /// <summary>
    /// indicates that the request is via an element using hx-boost
    /// </summary>
    public const string HxBoosted = "HX-Boosted";
    /// <summary>
    /// the current URL of the browser
    /// </summary>
    public const string HxCurrentUrl = "HX-Current-URL";
    /// <summary>
    /// “true” if the request is for history restoration after a miss in the local history cache
    /// </summary>
    public const string HxHistoryRestoreRequest = "HX-History-Restore-Request";
    /// <summary>
    /// the user response to an hx-prompt
    /// </summary>
    public const string HxPrompt = "HX-Prompt";
    /// <summary>
    /// always “true”
    /// </summary>
    public const string HxRequest = "HX-Request";
    /// <summary>
    /// the id of the target element if it exists
    /// </summary>
    public const string HxTarget = "HX-Target";
    /// <summary>
    /// the name of the triggered element if it exists
    /// </summary>
    public const string HxTriggerName = "HX-Trigger-Name";
    /// <summary>
    /// the id of the triggered element if it exists
    /// </summary>
    public const string HxTrigger = "HX-Trigger";

}
