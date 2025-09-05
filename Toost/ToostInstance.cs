namespace Toost;

public interface IToostInstance
{
    Guid Id { get; }
    DateTime Timestamp { get; }
    string Title { get; }
    string Message { get; }
    AlertType Type { get; }
    int Duration { get; }
}

internal readonly record struct ToostInstance(
    Guid Id,
    DateTime Timestamp,
    string Title,
    string Message,
    AlertType Type,
    int Duration
) : IToostInstance;


