// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NautaSessionException.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Nothing.Nauta.App.Exceptions;

public class NautaSessionException : Exception
{
    public NautaSessionException(string message, Exception exception)
        : base(message, exception)
    {
    }
}