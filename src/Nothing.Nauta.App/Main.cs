namespace Nothing.Nauta.App
{
    using Microsoft.AspNetCore.Components;

    /// <summary>
    /// The Main class.
    /// </summary>
    public partial class Main
    {
        /// <summary>
        /// Gets or sets navigation manager.
        /// </summary>
        [Inject]
        public NavigationManager? NavigationManager { get; set; }

        /// <summary>
        /// Called on unlock button click.
        /// </summary>
        private void OnUnlockButtonClick()
        {
            this.NavigationManager?.NavigateTo("/");
        }
    }
}
