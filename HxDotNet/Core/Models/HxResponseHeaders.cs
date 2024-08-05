using HxDotNet.Core.Constants;

namespace HxDotNet.Core.Models;

///<summary>
///	Response headers class to set response headers all at once.
///</summary>
public class HxResponseHeaders
{
    /// <summary>
    /// <inheritdoc cref="HxResponseHeaderNames.HxLocation" />
    /// </summary>
    public string? HxLocation { get; set; }

    /// <summary>
    /// <iheritdoc cref="HxResponseHeaderNames.HxPushUrl" />
    /// </summary>
    public string? HxPushUrl { get; set; }

    /// <summary>
    /// <iheritdoc cref="HxResponseHeaderNames.HxRedirect" />
    /// </summary>
    public string? HxRedirect { get; set; }

    /// <summary>
    /// <iheritdoc cref="HxResponseHeaderNames.HxRefresh" />
    /// </summary>
    public bool? HxRefresh { get; set; }

    /// <summary>
    /// <iheritdoc cref="HxResponseHeaderNames.HxReplaceUrl" />
    /// </summary>
    public string? HxReplaceUrl { get; set; }

    /// <summary>
    /// <iheritdoc cref="HxResponseHeaderNames.HxReswap" />
    /// </summary>
    public string? HxReswap { get; set; }

    /// <summary>
    /// <iheritdoc cref="HxResponseHeaderNames.HxRetarget" />
    /// </summary>
    public string? HxRetarget { get; set; }

    /// <summary>
    /// <iheritdoc cref="HxResponseHeaderNames.HxReselect" />
    /// </summary>
    public string? HxReselect { get; set; }

    /// <summary>
    /// <iheritdoc cref="HxResponseHeaderNames.HxTrigger" />
    /// </summary>
    public IReadOnlyDictionary<string, object>? HxTrigger { get; set; }

    /// <summary>
    /// <iheritdoc cref="HxResponseHeaderNames.HxTriggerAfterSettle" />
    /// </summary>
    public IReadOnlyDictionary<string, object>? HxTriggerAfterSettle { get; set; }

    /// <summary>
    /// <iheritdoc cref="HxResponseHeaderNames.HxTriggerAfterSwap" />
    /// </summary>
    public IReadOnlyDictionary<string, object>? HxTriggerAfterSwap { get; set; }
}
