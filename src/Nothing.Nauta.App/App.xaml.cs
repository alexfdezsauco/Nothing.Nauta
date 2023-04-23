// --------------------------------------------------------------------------------------------------------------------
// <copyright file="App.xaml.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Nothing.Nauta.App
{
    public partial class App : Application
    {
        public App()
        {
            this.InitializeComponent();

            this.MainPage = new MainPage();
        }
    }
}