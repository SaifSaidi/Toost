# Toost
Lightweight, fast, and easy-to-use toast notifications for Blazor applications.

## Installation

1.  Install the `Toost` NuGet package.
    ```bash
    dotnet add package Toost
    ```

2.  In your `Program.cs` (or `Startup.cs`), register the Toost service.
    ```csharp
    builder.Services.AddToostServices();
    ```

3.  In your `MainLayout.razor` (or wherever you want the toasts to appear), add the `Toosts` component.
    ```razor
    <Toosts />
    ```

## Usage

1.  Inject `ToostService` into the component or page where you want to show a toast.
    ```razor
    @inject ToostService ToostService
    ```

2.  Call one of the methods on the `ToostService` to show a toast.
    ```csharp
    ToostService.Success("This is a success message!");
    ToostService.Info("This is an info message.");
    ToostService.Warning("This is a warning message.");
    ToostService.Error("This is an error message.");
    ```

## Configuration

You can configure the titles for each toast type by providing an `Action<ToostOptions>` when you register the service.

```csharp
builder.Services.AddToostServices(options =>
{
    options.Titles[AlertType.Success] = "Great!";
    options.Titles[AlertType.Error] = "Oops!";
});
```

You can also configure the position of the toasts by setting the `Position` parameter on the `Toosts` component.

```razor
<Toosts Position="Position.TopLeft" />
```

Available positions:
- `TopRight` (default)
- `TopLeft`
- `BottomRight`
- `BottomLeft`
- `TopCenter`
- `BottomCenter`
