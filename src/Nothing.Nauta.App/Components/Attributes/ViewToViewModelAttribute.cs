namespace Nothing.Nauta.App.Components.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class ViewToViewModelAttribute : Attribute
{
    public string PropertyName { get; }

    public ViewToViewModelAttribute(string propertyName = "")
    {
        PropertyName = propertyName;
    }
}