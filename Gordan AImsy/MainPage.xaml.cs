using Gordan_AImsy.ViewModel;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace Gordan_AImsy
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage(MainPageViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm; 
        }

    }
}   
    