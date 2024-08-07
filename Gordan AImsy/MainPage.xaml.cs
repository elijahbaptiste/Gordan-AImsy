using Gordan_AImsy.ViewModel;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using OpenAI;
using OpenAI.Chat;
using System.ClientModel;
using Android.App.AppSearch;

namespace Gordan_AImsy
{
    public partial class MainPage : ContentPage
    {
        private OpenAIClient _chatGptClient;

        public MainPage(MainPageViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
            this.Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, EventArgs e)
        {
            var openAiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");

            _chatGptClient = new(openAiKey);
        }

        private async Task GetChatClient(string UserPrompt)
        {
            if (string.IsNullOrWhiteSpace(UserPrompt))
            {
                return;
            }

            var client = _chatGptClient.GetChatClient("gpt-3.5-turbo-16k");
            string prompt = UserPrompt.ToString();

            AsyncResultCollection<StreamingChatCompletionUpdate> updates = client.CompleteChatStreamingAsync(prompt);
            StringWriter responseWriter = new();

            await foreach (StreamingChatCompletionUpdate update in updates)
            {
                foreach (ChatMessageContentPart updatePart in update.ContentUpdate)
                {
                    responseWriter.Write(updatePart.Text);
                }
            }

            var returnMessage = responseWriter.ToString();
            PromptAnswer.Text = returnMessage;
        }
    }
}   
    