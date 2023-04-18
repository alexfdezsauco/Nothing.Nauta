using MudBlazor;

public static class IDialogReferenceExtensions
{
    public static async Task<T?> GetReturnValueIfNotCancelledAsync<T>(this IDialogReference dialogReference)
    {
        if (!(await dialogReference.Result).Canceled)
        {
            return await dialogReference.GetReturnValueAsync<T>();
        }

        return default;
    }
}