# Toost

Lightweight, fast, and easy-to-use toast notifications for Blazor applications.

## Installation

1.  Install the NuGet package.
    ```bash
    dotnet add package Toost
    ```

## Usage

1.  **Register the Toost service**

    In your `Program.cs`, add the following line:

    ```csharp
    builder.Services.AddToostServices();
    ```

2.  **Add the Toosts container**

    Add the `<Toosts />` component to your main layout file (e.g., `MainLayout.razor` or `App.razor`).

    ```razor
    <Toosts />
    ```

    You can customize the position of the toasts using the `Position` parameter. The default is `Position.BottomRight`.

    ```razor
    <Toosts Position="Position.TopRight" />
    ```

    Available positions:
    - `TopRight`
    - `TopLeft`
    - `BottomRight`
    - `BottomLeft`
    - `TopCenter`
    - `BottomCenter`

3.  **Show toasts from your components**

    Inject `ToostService` into any component or page and call its methods to display toasts.

    ```razor
    @page "/counter"
    @inject ToostService ToostService

    <h1>Counter</h1>

    <p>Current count: @currentCount</p>

    <button class="btn btn-primary" @onclick="IncrementCount">Click me</button>

    @code {
        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
            ToostService.Success($"The new count is: {currentCount}", duration: 3000);
        }
    }
    ```

### `ToostService` Methods

You can use the following methods to show different types of toasts:

```csharp
// Show a success toast
ToostService.Success("Your operation was successful.");

// Show an info toast
ToostService.Info("Here is some information.");

// Show a warning toast
ToostService.Warning("Please be cautious.");

// Show an error toast
ToostService.Error("An error occurred.");
```

Each method accepts an optional `duration` parameter in milliseconds (default is 5000ms).

