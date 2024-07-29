using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HxDotnet.TagHelpers;

[HtmlTargetElement("*", Attributes = "hx-*")]
public class HtmxAttributesTagHelper : TagHelper
{
    public const string HxGetAttributeName = "hx-get";
    public const string HxPostAttributeName = "hx-post";
    public const string HxPushUrlAttributeName = "hx-push-url";
    public const string HxSelectAttributeName = "hx-select";
    public const string HxSelectOobAttributeName = "hx-select-oob";
    public const string HxSwapAttributeName = "hx-swap";
    public const string HxSwapOobAttributeName = "hx-swap-oob";
    public const string HxTargetAttributeName = "hx-target";
    public const string HxTriggerAttributeName = "hx-trigger";
    public const string HxValsAttributeName = "hx-vals";
    public const string HxOnEventAttributeName = "hx-on-events";
    public const string HxOnAttributePrefix = "hx-on-";


    /// <summary>
    /// issues a GET to the specified URL
    /// </summary>
    [HtmlAttributeName(HxGetAttributeName)]
    public string? HxGet { get; set; }

    /// <summary>
    /// issues a POST to the specified URL
    /// </summary>
    [HtmlAttributeName(HxPostAttributeName)]
    public string? HxPost { get; set; }

    /// <summary>
    /// push a URL into the browser location bar to create history
    /// </summary>
    [HtmlAttributeName(HxPushUrlAttributeName)]
    public string? HxPushUrl { get; set; }

    /// <summary>
    /// select content to swap in from a response
    /// </summary>
    [HtmlAttributeName(HxSelectAttributeName)]
    public string? HxSelect { get; set; }

    /// <summary>
    /// select content to swap in from a response, somewhere other than the target (out of band)
    /// </summary>
    [HtmlAttributeName(HxSelectOobAttributeName)]
    public string? HxSelectOob { get; set; }

    /// <summary>
    /// controls how content will swap in (outerHTML, beforeend, afterend, …)
    /// </summary>
    [HtmlAttributeName(HxSwapAttributeName)]
    public string? HxSwap { get; set; }

    /// <summary>
    /// mark element to swap in from a response (out of band)
    /// </summary>
    [HtmlAttributeName(HxSwapOobAttributeName)]
    public string? HxSwapOob { get; set; }

    /// <summary>
    /// specifies the target element to be swapped
    /// </summary>
    [HtmlAttributeName(HxTargetAttributeName)]
    public string? HxTarget { get; set; }

    /// <summary>
    /// specifies the event that triggers the request
    /// </summary>
    [HtmlAttributeName(HxTriggerAttributeName)]
    public string? HxTrigger { get; set; }

    /// <summary>
    /// add values to submit with the request (JSON format)
    /// </summary>
    [HtmlAttributeName(HxValsAttributeName)]
    public string? HxVals { get; set; }

    /// <summary>
    /// handle events with inline scripts on elements
    /// </summary>
    [HtmlAttributeName(HxOnEventAttributeName, DictionaryAttributePrefix = HxOnAttributePrefix)]
    public Dictionary<string, string?> HxOnDictionary { get; set; } = [];


    // other attributes.

    public const string HxBoostAttributeName = "hx-boost";
    public const string HxConfirmAttributeName = "hx-confirm";
    public const string HxDeleteAttributeName = "hx-delete";
    public const string HxDisableAttributeName = "hx-disable";
    public const string HxDisableEltAttributeName = "hx-disabled-elt";
    public const string HxDisinheritAttributeName = "hx-disinherit";
    public const string HxEncodingAttributeName = "hx-encoding";
    public const string HxExtAttributeName = "hx-ext";
    public const string HxHeadersAttributeName = "hx-headers";
    public const string HxHistoryAttributeName = "hx-history";
    public const string HxHistoryEltAttributeName = "hx-history-elt";
    public const string HxIncludeAttributeName = "hx-include";
    public const string HxIndicatorAttributeName = "hx-indicator";
    public const string HxInheritAttributeName = "hx-inherit";
    public const string HxParamsAttributeName = "hx-params";
    public const string HxPatchAttributeName = "hx-patch";
    public const string HxPreserveAttributeName = "hx-preserve";
    public const string HxPromptAttributeName = "hx-prompt";
    public const string HxPutAttributeName = "hx-put";
    public const string HxReplaceUrlAttributeName = "hx-replace-url";
    public const string HxRequestAttributeName = "hx-request";
    public const string HxSyncAttributeName = "hx-sync";
    public const string HxValidateAttributeName = "hx-validate";
    /// <summary>
    /// add progressive enhancement for links and forms
    /// </summary>
    [HtmlAttributeName(HxBoostAttributeName)]
    public string? HxBoost { get; set; }

    /// <summary>
    /// shows a confirm() dialog before issuing a request
    /// </summary>
    [HtmlAttributeName(HxConfirmAttributeName)]
    public string? HxConfirm { get; set; }

    /// <summary>
    /// issues a DELETE to the specified URL
    /// </summary>
    [HtmlAttributeName(HxDeleteAttributeName)]
    public string? HxDelete { get; set; }

    /// <summary>
    /// disables htmx processing for the given node and any children nodes
    /// </summary>
    [HtmlAttributeName(HxDisableAttributeName)]
    public string? HxDisable { get; set; }


    /// <summary>
    /// adds the disabled attribute to the specified elements while a request is in flight
    /// </summary>
    [HtmlAttributeName(HxDisableEltAttributeName)]
    public string? HxDisableElt { get; set; }

    /// <summary>
    /// control and disable automatic attribute inheritance for child nodes
    /// </summary>
    [HtmlAttributeName(HxDisinheritAttributeName)]
    public string? HxDisinherit { get; set; }

    /// <summary>
    /// changes the request encoding type
    /// </summary>
    [HtmlAttributeName(HxEncodingAttributeName)]
    public string? HxEncoding { get; set; }

    /// <summary>
    /// extensions to use for this element
    /// </summary>
    [HtmlAttributeName(HxExtAttributeName)]
    public string? HxExt { get; set; }

    /// <summary>
    /// adds to the headers that will be submitted with the request
    /// </summary>
    [HtmlAttributeName(HxHeadersAttributeName)]
    public string? HxHeaders { get; set; }

    /// <summary>
    /// prevent sensitive data being saved to the history cache
    /// </summary>
    [HtmlAttributeName(HxHistoryAttributeName)]
    public string? HxHistory { get; set; }

    /// <summary>
    /// the element to snapshot and restore during history navigation
    /// </summary>
    [HtmlAttributeName(HxHistoryEltAttributeName)]
    public string? HxHistoryElt { get; set; }



    /// <summary>
    /// include additional data in requests
    /// </summary>
    [HtmlAttributeName(HxIncludeAttributeName)]
    public string? HxInclude { get; set; }

    /// <summary>
    /// the element to put the htmx-request class on during the request
    /// </summary>
    [HtmlAttributeName(HxIndicatorAttributeName)]
    public string? HxIndicator { get; set; }

    /// <summary>
    /// control and enable automatic attribute inheritance for child nodes if it has been disabled by default
    /// </summary>
    [HtmlAttributeName(HxInheritAttributeName)]
    public string? HxInherit { get; set; }

    /// <summary>
    /// filters the parameters that will be submitted with a request
    /// </summary>
    [HtmlAttributeName(HxParamsAttributeName)]
    public string? HxParams { get; set; }

    /// <summary>
    /// issues a PATCH to the specified URL
    /// </summary>
    [HtmlAttributeName(HxPatchAttributeName)]
    public string? HxPatch { get; set; }

    /// <summary>
    /// specifies elements to keep unchanged between requests
    /// </summary>
    [HtmlAttributeName(HxPreserveAttributeName)]
    public string? HxPreserve { get; set; }


    /// <summary>
    /// shows a prompt() before submitting a request
    /// </summary>
    [HtmlAttributeName(HxPromptAttributeName)]
    public string? HxPrompt { get; set; }

    /// <summary>
    /// issues a PUT to the specified URL
    /// </summary>
    [HtmlAttributeName(HxPutAttributeName)]
    public string? HxPut { get; set; }

    /// <summary>
    /// replace the URL in the browser location bar
    /// </summary>
    [HtmlAttributeName(HxReplaceUrlAttributeName)]
    public string? HxReplaceUrl { get; set; }

    /// <summary>
    /// configures various aspects of the request
    /// </summary>
    [HtmlAttributeName(HxRequestAttributeName)]
    public string? HxRequest { get; set; }

    /// <summary>
    /// control how requests made by different elements are synchronized
    /// </summary>
    [HtmlAttributeName(HxSyncAttributeName)]
    public string? HxSync { get; set; }

    /// <summary>
    /// force elements to validate themselves before a request
    /// </summary>
    [HtmlAttributeName(HxValidateAttributeName)]
    public string? HxValidate { get; set; }

#pragma warning disable MA0051 // Method is too long - think of something better to do for tag helpers later.
    public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
#pragma warning restore MA0051 // Method is too long
    {

        if (HxGet is not null)
        {
            output.Attributes.SetAttribute(HxGetAttributeName, HxGet);
        }
        if (HxPost is not null)
        {
            output.Attributes.SetAttribute(HxPostAttributeName, HxPost);
        }
        if (HxPushUrl is not null)
        {
            output.Attributes.SetAttribute(HxPushUrlAttributeName, HxPushUrl);
        }
        if (HxSelect is not null)
        {
            output.Attributes.SetAttribute(HxSelectAttributeName, HxSelect);
        }
        if (HxSelectOob is not null)
        {
            output.Attributes.SetAttribute(HxSelectOobAttributeName, HxSelectOob);
        }
        if (HxSwap is not null)
        {
            output.Attributes.SetAttribute(HxSwapAttributeName, HxSwap);
        }
        if (HxSwapOob is not null)
        {
            output.Attributes.SetAttribute(HxSwapOobAttributeName, HxSwapOob);
        }
        if (HxTarget is not null)
        {
            output.Attributes.SetAttribute(HxTargetAttributeName, HxTarget);
        }
        if (HxTrigger is not null)
        {
            output.Attributes.SetAttribute(HxTriggerAttributeName, HxTrigger);
        }
        if (HxVals is not null)
        {
            output.Attributes.SetAttribute(HxValsAttributeName, HxVals);
        }

        foreach (var kvp in HxOnDictionary)
        {
            output.Attributes.SetAttribute($"hx-on-{kvp.Key}", kvp.Value);
        }


        /// other attributes

        if (HxBoost is not null)
        {
            output.Attributes.SetAttribute(HxBoostAttributeName, HxBoost);
        }
        if (HxConfirm is not null)
        {
            output.Attributes.SetAttribute(HxConfirmAttributeName, HxConfirm);
        }
        if (HxDelete is not null)
        {
            output.Attributes.SetAttribute(HxDeleteAttributeName, HxDelete);
        }
        if (HxDisable is not null)
        {
            output.Attributes.SetAttribute(HxDisableAttributeName, HxDisable);
        }
        if (HxDisableElt is not null)
        {
            output.Attributes.SetAttribute(HxDisableEltAttributeName, HxDisableElt);
        }
        if (HxDisinherit is not null)
        {
            output.Attributes.SetAttribute(HxDisinheritAttributeName, HxDisinherit);
        }
        if (HxEncoding is not null)
        {
            output.Attributes.SetAttribute(HxEncodingAttributeName, HxEncoding);
        }
        if (HxExt is not null)
        {
            output.Attributes.SetAttribute(HxExtAttributeName, HxExt);
        }
        if (HxHeaders is not null)
        {
            output.Attributes.SetAttribute(HxHeadersAttributeName, HxHeaders);
        }
        if (HxHistory is not null)
        {
            output.Attributes.SetAttribute(HxHistoryAttributeName, HxHistory);
        }
        if (HxHistoryElt is not null)
        {
            output.Attributes.SetAttribute(HxHistoryEltAttributeName, HxHistoryElt);
        }
        if (HxInclude is not null)
        {
            output.Attributes.SetAttribute(HxIncludeAttributeName, HxInclude);
        }
        if (HxIndicator is not null)
        {
            output.Attributes.SetAttribute(HxIndicatorAttributeName, HxIndicator);
        }
        if (HxInherit is not null)
        {
            output.Attributes.SetAttribute(HxInheritAttributeName, HxInherit);
        }
        if (HxParams is not null)
        {
            output.Attributes.SetAttribute(HxParamsAttributeName, HxParams);
        }
        if (HxPatch is not null)
        {
            output.Attributes.SetAttribute(HxPatchAttributeName, HxPatch);
        }
        if (HxPreserve is not null)
        {
            output.Attributes.SetAttribute(HxPreserveAttributeName, HxPreserve);
        }
        if (HxPrompt is not null)
        {
            output.Attributes.SetAttribute(HxPromptAttributeName, HxPrompt);
        }
        if (HxPut is not null)
        {
            output.Attributes.SetAttribute(HxPutAttributeName, HxPut);
        }
        if (HxReplaceUrl is not null)
        {
            output.Attributes.SetAttribute(HxReplaceUrlAttributeName, HxReplaceUrl);
        }
        if (HxRequest is not null)
        {
            output.Attributes.SetAttribute(HxRequestAttributeName, HxRequest);
        }
        if (HxSync is not null)
        {
            output.Attributes.SetAttribute(HxSyncAttributeName, HxSync);
        }
        if (HxValidate is not null)
        {
            output.Attributes.SetAttribute(HxValidateAttributeName, HxValidate);
        }
        return Task.CompletedTask;
    }
}
