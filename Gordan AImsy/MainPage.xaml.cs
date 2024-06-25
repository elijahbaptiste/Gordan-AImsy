using System.Runtime.CompilerServices;

namespace Gordan_AImsy
{
    public partial class MainPage : ContentPage
    {
        List<(string, string)> Chats = new List<(string, string)>();
        public string question { get; private set; }
        public string message  { get; private set; }

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        { 
          
        
        }
        
    }
}   
    