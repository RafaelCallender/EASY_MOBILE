using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BACKGROUND.BACKGROUND_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.LABELS.LABEL_DEFAULTS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_ANIMATION;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.AI_VIEW.AI_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.AI_SERVICES.AI_TEXT_TO_TEXT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_HELPER;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BORDER.BORDER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS.ENTRY_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using System.Threading.Tasks;
using LLama;
using LLama.Common;
using LLama.Sampling;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.AI_SERVICES.AI_HELPER;
using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.AI_VIEW.AI_SELECTION_VIEW
{
    public partial class Ai_Selection_View02 : ContentPage
    {
        private LLamaWeights? model01;
        private LLamaContext? context01;
        private InteractiveExecutor? executor01;

        private readonly SemaphoreSlim _lock = new(1, 1);
        private bool _modelLoadStarted;

        public bool IsLoaded => executor01 != null;
        private Background_Default01 Background_D01 = new Background_Default01();
        private static string[] data01 = new string[100];
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static Border01_Default border01_D01 = new Border01_Default();
        private static Image01_Default Image01_D01 = new Image01_Default();
        private static File_Helper01 File_H01 = new File_Helper01();
        private static Labels01_Default Labels01_D01 = new Labels01_Default();
        private static string menus_string01 =

                   $"Ai text generation\n" +
                   $"Ai text generation for developers\n" +
                   $"Ai text generation for web developers\n";
        private static string[] menus_array01 = menus_string01.Split("\n");
        private static Button_Animation01 Button_A01 = new Button_Animation01();
        private static Picker01_Animation Picker01_A01 = new Picker01_Animation();
        private static Entrys01_Default Entrys01_D01 = new Entrys01_Default();
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Ai_Text_To_Text01 Ai_Text_To_T01 = new Ai_Text_To_Text01();
        private static File_Manger02 File_M02 = new File_Manger02();
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);

        private static Ai_Helper01 Ai_H01 = new Ai_Helper01();
        public Ai_Selection_View02()
        {

            InitializeComponent();
            load_Selection_View01();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            if (_modelLoadStarted)
            {
                return;
            }

            _modelLoadStarted = true;
            await LoadModel01Async();
        }
        private void load_Selection_View01()
        {
            load_default_view01();
            Background_D01.background01(this);
            Image01_D01.image01(image01);
            image01.Source = File_M02.source[(int)File_Manger02.image_index01.Easy_Callender_page_1];
            Entrys01_D01.Entrys02(entry01);
            border01_D01.border008(border01);
            border01_D01.border002(border02);
            border01_D01.border008(border03);
            Labels01_D01.label09(label01);
            Button01_D01.button03(button01);
            Button01_D01.button03(button02);
            button01.Clicked += button01_clicked;
            button02.Clicked += button02_clicked;
            button01.Text = "ok";
            button02.Text = "back";
            picker01.SelectedIndexChanged += Picker01_SelectedIndexChanged;
            picker01.ItemsSource = menus_array01.ToList();
            picker01.Title = "Select";
        }


        private void load_default_view01()
        {
            label01.IsVisible = false;
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = true;

        }
        private void load_default_view02()
        {
            label01.IsVisible = false;
            border01.IsVisible = true;
            border02.IsVisible = true;
            border03.IsVisible = true;

        }
        private void Picker01_SelectedIndexChanged(object? sender, EventArgs e)
        {

            switch (menus_array01[picker01.SelectedIndex])
            {
                case "Ai text generation":
                    load_default_view02();
                    entry01.Placeholder = "whats your question";
                    break;
                case "Ai text generation for developers":
                    load_default_view02();
                    entry01.Placeholder = "whats your question";
                    break;
                case "Ai text generation for web developers":
                    load_default_view02();
                    entry01.Placeholder = "whats your question";
                    break;
                default:
                    load_default_view01();
                    break;

            }
        }



        private void load_Selection_data01()
        {

            string procedure = menus_array01[picker01.SelectedIndex].Trim();
            switch (procedure)
            {
                case "Ai text generation":
                    _commands.Add(procedure, Ai_text_generation);
                    break;

                case "Ai text generation for developers":
                    _commands.Add(procedure, Ai_text_generation_for_developers);
                    break;

                case "Ai text generation for web developers":
                    _commands.Add(procedure, Ai_text_generation_for_web_developers);
                    break;
            }

        }
        private async Task LoadModelAsync(string modelPath)
        {
            await _lock.WaitAsync();

            try
            {
                if (executor01 != null)
                    return;

                await Task.Run(() =>
                {
                    var parameters = new ModelParams(modelPath)
                    {
                        ContextSize = 1024,
                        BatchSize = 128,
                        GpuLayerCount = 0
                    };

                    model01 = LLamaWeights.LoadFromFile(parameters);
                    context01 = model01.CreateContext(parameters);
                    executor01 = new InteractiveExecutor(context01);
                });
            }
            finally
            {
                _lock.Release();
            }
        }

        private void Dispose()
        {
            _lock.Wait();

            try
            {
                executor01 = null;
                context01?.Dispose();
                context01 = null;
                model01?.Dispose();
                model01 = null;
            }
            finally
            {
                _lock.Release();
            }
        }

        private async Task<string> GenerateTextAsync(string prompt, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(prompt))
                return string.Empty;

            await _lock.WaitAsync(cancellationToken);

            try
            {
                var executor = executor01;
                if (executor == null)
                    throw new InvalidOperationException(
                        "Load the GGUF model before generating text.");

                var output = new System.Text.StringBuilder();
                var inferenceParams = new InferenceParams
                {
                    MaxTokens = 256,
                    SamplingPipeline = new DefaultSamplingPipeline
                    {
                        Temperature = 0.7f
                    }
                };

                await foreach (var token in executor.InferAsync(
                    prompt,
                    inferenceParams,
                    cancellationToken))
                {
                    output.Append(token);
                }

                return output.ToString();
            }
            finally
            {
                _lock.Release();
            }
        }

        private async Task LoadModel01Async()
        {
            label01.Text = "Loading AI model...";

            try
            {
                string modelPath = await Ai_H01.GetModelPathAsync();
                await LoadModelAsync(modelPath);

                label01.Text = "AI model loaded. Enter your prompt.";
            }
            catch (Exception ex)
            {
                label01.Text = $"Model loading error: {ex.Message}";
            }
        }

        private async void Ai_text_generation()
        {
            // GET USER INPUT FROM ENTRY
            string input01 = entry01.Text ?? string.Empty;

            if (string.IsNullOrWhiteSpace(input01))
            {
                await DisplayAlert(
                    "Error",
                    "Please enter a prompt.",
                    "OK");

                return;
            }

            var executor = executor01;
            if (executor == null)
            {
                label01.Text = "The AI model is not loaded.";
                return;
            }

            button01.IsEnabled = false;
            label01.Text = "Generating response...";

            try
            {
                // RUN AI GENERATION OFF THE UI THREAD
                var inference01 = new InferenceParams
                {
                    MaxTokens = 256,
                    SamplingPipeline = new DefaultSamplingPipeline
                    {
                        Temperature = 0.7f
                    }
                };

                var outputBuilder01 = new System.Text.StringBuilder();
                await foreach (var token01 in executor.InferAsync(
                    input01,
                    inference01))
                {
                    outputBuilder01.Append(token01);
                }

                // ASSIGN AI OUTPUT TO XAML LABEL
                label01.IsVisible = true;
                label01.Text = outputBuilder01.ToString();
            }
            catch (Exception ex)
            {
                label01.IsVisible = true;
                label01.Text = $"Generation error: {ex.Message}";
            }
            finally
            {
                label01.IsVisible = true;
                button01.IsEnabled = true;
            }
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            // Keep the model loaded while navigating between pages.
            // Dispose model resources when the owning service or app
            // is shutting down, not every time this page disappears.
        }


        private void Ai_text_generation_for_developers()
        {
            label01.IsVisible = true;
            label01.Text = "not yet developed";
        }
        private void Ai_text_generation_for_web_developers()
        {
            label01.IsVisible = true;
            label01.Text = "not yet developed";
        }
        private void load_Selection01()
        {
            if (Security_Serv01.isPicker_selected(picker01, out data01[24]) == true)
            {
                int selection = picker01.SelectedIndex;
                int stringlength = menus_array01.Length;
                if (selection >= 0 &&
                    selection < stringlength)
                {
                    string key = menus_array01[selection].Trim();
                    load_Selection_data01();
                    if (_commands.TryGetValue(key, out Action action))
                    {

                        action();
                        _commands.Clear();
                        entry01.Text = string.Empty;

                    }
                    else
                    {
                        label01.Text = $"{key} command not found";
                    }
                }
                else
                {
                    label01.Text = "Invalid selection.";
                }

            }
            else
            {
                label01.Text = data01[24];

            }

        }

        private async void button01_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button01);
            load_Selection01();
        }
        private async void button02_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button02);
            await button02.Navigation.PushAsync(new Ai_Main_View01());
        }
    }
}