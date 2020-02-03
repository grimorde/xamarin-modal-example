using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinModalExample.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Modal : ContentView
    {
        public static readonly BindableProperty ShowModalProperty
            = BindableProperty.Create(nameof(ShowModal), typeof(bool), typeof(Modal), defaultValue: false, defaultBindingMode: BindingMode.TwoWay, propertyChanged: ShowModalPropertyChanged);
        public static readonly BindableProperty ModalHeaderProperty
            = BindableProperty.Create(nameof(ModalHeader), typeof(string), typeof(Modal), defaultValue: string.Empty, defaultBindingMode: BindingMode.TwoWay);

        public string ModalHeader
        {
            get => GetValue(ModalHeaderProperty).ToString();
            set => SetValue(ModalHeaderProperty, value);
        }

        public bool ShowModal
        {
            get => (bool)GetValue(ShowModalProperty);
            set => SetValue(ShowModalProperty, value);
        }

        public Modal()
        {
            InitializeComponent();
            IsVisible = false;
        }

        private static void ShowModalPropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            ((Modal)bindable).IsVisible = (bool)newvalue;
        }

        private void CloseModalBtn_OnClicked(object sender, EventArgs e)
        {
            ShowModal = false;
        }
    }
}