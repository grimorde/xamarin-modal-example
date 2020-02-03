using System;
using System.ComponentModel;
using Xamarin.Forms;
using XamarinModalExample.ViewModels;

namespace XamarinModalExample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();
            var viewModel = new MainViewModel();
            this.BindingContext = viewModel;
        }
    }
}
