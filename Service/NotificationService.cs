using Microsoft.JSInterop;

public class NotificationService
{
    private readonly IJSRuntime _jsRuntime;

    public NotificationService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public async Task ShowNotificationAsync(string title, string message)
    {
        var options = new
        {
            body = message,
            //icon = "/icon.png"
        };

        await _jsRuntime.InvokeVoidAsync("showNotification", title, options);
    }
}
