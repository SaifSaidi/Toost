using Microsoft.Extensions.Options;

namespace Toost;

public sealed class ToostService
{
    private readonly ToostOptions _options;

    internal event EventHandler<ToostInstance>? OnShow;

    public ToostService(IOptions<ToostOptions> options)
    {
        _options = options.Value;
    }

    public void ShowToast(AlertType level, string message, int duration = 5000)
    {
        var toast = new ToostInstance(Guid.NewGuid(), DateTime.UtcNow, GetTitle(level), message, level, duration);
        OnShow?.Invoke(this, toast);
    }

    public void Success(string message, int duration = 5000)
    {
        ShowToast(AlertType.Success, message, duration);
    }

    public void Info(string message, int duration = 5000)
    {
        ShowToast(AlertType.Info, message, duration);
    }

    public void Warning(string message, int duration = 5000)
    {
        ShowToast(AlertType.Warning, message, duration);
    }

    public void Error(string message, int duration = 5000)
    {
        ShowToast(AlertType.Error, message, duration);
    }

    private string GetTitle(AlertType level) =>
        _options.Titles.TryGetValue(level, out var englishTitle) ? englishTitle : "Notification";
}