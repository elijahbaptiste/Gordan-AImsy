using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Gordan_AImsy.ViewModel;


public partial class MainPageViewModel : ObservableObject
{
    

    [ObservableProperty]
    ObservableCollection<string> items;

    [ObservableProperty]
    string text;

    [ObservableProperty]
    string question;
    public MainPageViewModel()
    {
        items = new ObservableCollection<string>();
        question = "";
    }

    [RelayCommand]
    void QuestionAsked()
    {
        Text = string.Empty;

        if (string.IsNullOrEmpty(question)) {
            return;
        }

        items.Add(question);
    }
}
