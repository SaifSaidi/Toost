namespace Toost;

public sealed class ToostService
{
    internal event EventHandler<ToostInstance>? OnShow;

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



    private static readonly Dictionary<AlertType, string> Titles = new()
    {
        [AlertType.Success] = "Success",
        [AlertType.Info] = "Info",
        [AlertType.Warning] = "Warning",
        [AlertType.Error] = "Error"
    };

    private static string GetTitle(AlertType level) =>
        Titles.TryGetValue(level, out var title) ? title : "Notification";
}