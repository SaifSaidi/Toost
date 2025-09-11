# Toost
Lightweight, fast, and easy-to-use toast notifications for Blazor applications.

## Installation

1.  Install the `Toost` NuGet package.
    ```bash
    dotnet add package Toost
    ```

2.  In your `Program.cs`, register the Toost service.
    ```csharp
    builder.Services.AddToost();
    ```

3.  Add the `<Toosts />` component to your main layout file (e.g., `MainLayout.razor` or `App.razor`).
    ```razor
    <Toosts @rendermode="InteractiveServer" />
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
Each method accepts an optional `duration` parameter in milliseconds (default is 5000ms).

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
<Toosts @rendermode="InteractiveServer" Position="Position.TopLeft" />
```

Available positions:
- `TopRight`
- `TopLeft`
- `BottomRight` (default)
- `BottomLeft`
- `TopCenter`
- `BottomCenter`

You can also show the time the toast was created by setting the `ShowTime` parameter to `true`.

```razor
<Toosts ShowTime="true" />
```
