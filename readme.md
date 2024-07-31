# hx-dotnet

htmx integration for dotnet.

Currently a work in progress. There will be breaking changes. Examples are not complete.

# HxController

The `HxController` class extends from `Microsoft.AspNetCore.Mvc.Controller`, and provides a method

```cs
    public ActionResult HxView(string? Name=null, object? Model=null);
```

which will return `Controller.View` or `Controller.PartialView` depending on the request headers.

# Response headers

The static class `HxDotNet.HttpExtensions.HttpResponseExtensions` provides extension methods for setting the response headers,

```cs
IReadOnlyDictionary<string, object> triggerAfterSettleEvents =
    new Dictionary<string, object>(StringComparer.InvariantCulture)
    {
        {"my-event", new { myValue = "my-value" }},
    };

Response.HxTriggerAfterSettle(triggerAfterSettleEvents).HxReswap("none").HxStopPolling();
```

# Request headers

The static class `HxDotNet.HttpExtensions.HttpRequestExtensions` provides methods for extracting the htmx headers.

```cs
if (Request.IsHxRequest()){
    HxRequestHeaders headers = Request.GetHxHeaders();
}
```

# Tag Helpers

There is currently a tag helper that provides documentation for the `hx-` attributes. The documentation is currently limited. More tag helpers will be added in the future.

```html
@addTagHelper *, HxDotNet

...

<button hx-post="@Url.Action("MyAction")" ></button>
```
