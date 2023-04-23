// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ViewModelBase.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Nothing.Nauta.App.ViewModels
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    using Blorc.Data;

    using Nothing.Nauta.App.Annotations;
    using Nothing.Nauta.App.ViewModels.Interfaces;

    public class ViewModelBase : IViewModel
    {
        private readonly PropertyBag propertyBag = new PropertyBag();

        public ViewModelBase()
        {
            this.propertyBag.PropertyChanged += this.OnPropertyBagPropertyChanged;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        // TODO: Create a dispatcher service for this.
        public Func<Action, Task> InvokeAsync { get; set; }

        public virtual Task InitializeAsync()
        {
            return Task.CompletedTask;
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected TValue GetPropertyValue<TValue>(string propertyName)
        {
            return this.propertyBag.GetValue<TValue>(propertyName);
        }

        private void OnPropertyBagPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            this.OnPropertyChanged(e.PropertyName);
        }

        protected void SetPropertyValue<TValue>(string propertyName, TValue value)
        {
            this.propertyBag.SetValue<TValue?>(propertyName, value);
        }
    }
}
