using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HxDotnet.TagHelpers;

public class OtherAttributesTagHelper : TagHelper
{

	/* hx-boost
		add progressive enhancement for links and forms
	hx-confirm
		shows a confirm() dialog before issuing a request
	hx-delete
		issues a DELETE to the specified URL
	hx-disable
		disables htmx processing for the given node and any children nodes
	hx-disabled-elt
		adds the disabled attribute to the specified elements while a request is in flight
	hx-disinherit
		control and disable automatic attribute inheritance for child nodes
	hx-encoding
		changes the request encoding type
	hx-ext
		extensions to use for this element
	hx-headers
		adds to the headers that will be submitted with the request
	hx-history
		prevent sensitive data being saved to the history cache
	hx-history-elt
		the element to snapshot and restore during history navigation
	hx-include
		include additional data in requests
	hx-indicator
		the element to put the htmx-request class on during the request
	hx-inherit
		control and enable automatic attribute inheritance for child nodes if it has been disabled by default
	hx-params
		filters the parameters that will be submitted with a request
	hx-patch
		issues a PATCH to the specified URL
	hx-preserve
		specifies elements to keep unchanged between requests
	hx-prompt
		shows a prompt() before submitting a request
	hx-put
		issues a PUT to the specified URL
	hx-replace-url
		replace the URL in the browser location bar
	hx-request
		configures various aspects of the request
	hx-sync
		control how requests made by different elements are synchronized
	hx-validate
		 force elements to validate themselves before a request
		 */
}