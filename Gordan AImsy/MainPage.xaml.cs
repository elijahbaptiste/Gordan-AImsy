using Gordan_AImsy.ViewModel;
using System.Runtime.CompilerServices;

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
    