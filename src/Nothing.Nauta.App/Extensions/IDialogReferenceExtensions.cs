// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDialogReferenceExtensions.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

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