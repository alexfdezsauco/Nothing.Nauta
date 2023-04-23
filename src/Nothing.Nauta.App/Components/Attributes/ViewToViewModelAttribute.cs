// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ViewToViewModelAttribute.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Nothing.Nauta.App.Components.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class ViewToViewModelAttribute : Attribute
{
    public ViewToViewModelAttribute(string propertyName = "")
    {
        this.PropertyName = propertyName;
    }

    public string PropertyName { get; }
}