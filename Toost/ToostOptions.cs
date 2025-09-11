using System.Collections.Generic;

namespace Toost;

public class ToostOptions
{
    public Dictionary<AlertType, string> Titles { get; set; } = new()
    {
        [AlertType.Success] = "Success",
        [AlertType.Info] = "Info",
        [AlertType.Warning] = "Warning",
        [AlertType.Error] = "Error"
    };
}
