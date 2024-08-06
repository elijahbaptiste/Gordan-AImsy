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
    public ObservableCollection<ChatHistory> items;

    [ObservableProperty]
    string text;

    [ObservableProperty]
    string question;

    public MainPageViewModel()
    {
        items = new ObservableCollection<ChatHistory>() {
                new ChatHistory{Task ="Test String 1", message = "Test String 2"},
                new ChatHistory{Task ="Test String 3", message = "Test String 4"},
                new ChatHistory{Task ="Test String 5", message = "Test String 6"}
        };
    }

    [RelayCommand]
    void QuestionAsked()
    {
        Text = string.Empty;

        if (string.IsNullOrEmpty(question)) {
            return;
        }

        ChatHistory LastAsk = new ChatHistory { Task = question, message = "" };
        items.Add(LastAsk);
    }
}
