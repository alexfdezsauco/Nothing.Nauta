namespace Nothing.Nauta.App.ViewModels
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    using Blorc.Data;
    using Blorc.MVVM;

    using Nothing.Nauta.App.Annotations;

    public interface IViewModel : Blorc.MVVM.IViewModel
    {
        Task InitializeAsync();
    }

    public class ViewModelBase : IViewModel
    {
        private readonly PropertyBag _propertyBag = new PropertyBag();

        public event PropertyChangedEventHandler? PropertyChanged;

        public virtual Task InitializeAsync()
        {
            return Task.CompletedTask;
        }

        public ViewModelBase()
        {
            _propertyBag.PropertyChanged += OnPropertyBagPropertyChanged;
        }

        private void OnPropertyBagPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            OnPropertyChanged(e.PropertyName);
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected TValue GetPropertyValue<TValue>(string propertyName)
        {
            return _propertyBag.GetValue<TValue>(propertyName);
        }

        protected void SetPropertyValue<TValue>(string propertyName, TValue value)
        {
            _propertyBag.SetValue<TValue?>(propertyName, value);
        }
    }
}
