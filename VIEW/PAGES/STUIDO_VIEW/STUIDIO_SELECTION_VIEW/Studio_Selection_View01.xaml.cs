using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BACKGROUND.BACKGROUND_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.LABELS.LABEL_DEFAULTS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_ANIMATION;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.STUIDO_VIEW.STUDIO_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BORDER.BORDER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS.ENTRY_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.AUDIO_SERVICES;
using CommunityToolkit.Maui.Media;
using System.Globalization;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.EDITOR.EDITOR_DEFAULT;

namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.STUIDO_VIEW.STUIDIO_SELECTION_VIEW
{
    public partial class Studio_Selection_View01 : ContentPage
    {
        private readonly ISpeechToText speech = SpeechToText.Default;
        private bool isListening;
        private bool isStarting;
        private bool isStopping;
        private static Audio_Services01 Audio_Serv01 =
            new Audio_Services01();

        private Background_Default01 Background_D01 = new Background_Default01();
        private static string[] data01 = new string[100];
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static Border01_Default border01_D01 = new Border01_Default();
        private static Image01_Default Image01_D01 = new Image01_Default();
        private static Labels01_Default Labels01_D01 = new Labels01_Default();
        private static string menu_string01 = $"andriod_sound_options\n" +
                                                $"speech_to_text\n"


            ;
        private static string[] menu_array01 = menu_string01.Split("\n");
        private static Button_Animation01 Button_A01 = new Button_Animation01();
        private static Picker01_Animation Picker01_A01 = new Picker01_Animation();
        private static Entrys01_Default Entrys01_D01 = new Entrys01_Default();
        private static File_Manger02 File_M02 = new File_Manger02();
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Editor_defaul01 Editor_defaul01 = new Editor_defaul01();
        private Task? listeningTask;
        private CancellationTokenSource? speechCancellation;

        public Studio_Selection_View01()
        {
            InitializeComponent();
            load_Selection_View01();
        }
        private void load_Selection_data01()
        {
            string procedure = menu_array01[picker01.SelectedIndex].Trim();
            switch (procedure)
            {
                case "andriod_sound_options":
                    _commands.Add(procedure, andriod_sound_options);
                    break;
             }
        }

        private void andriod_sound_options()
        {
            label01.Text = Audio_Serv01.andriod_sound_options();
        }

        private void load_default_view01()
        {

            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = true;
            border04.IsVisible = false;
            button03.IsVisible = false;
            button04.IsVisible = false;
            button05.IsVisible = false;


        }
        private void load_default_view02()
        {

            border01.IsVisible = false;
            border02.IsVisible = false;
            border03.IsVisible = true;
            border04.IsVisible = true;
            button03.IsVisible = true;
            button04.IsVisible = true;
            button05.IsVisible = true;

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
            border01_D01.border002(border04);
            Labels01_D01.label04(label01);
            Editor_defaul01.Editors02(editor01);
            Button01_D01.button03(button01);
            Button01_D01.button03(button02);
            Button01_D01.button03(button03);
            Button01_D01.button03(button04);
            Button01_D01.button03(button05);
            button01.Clicked += button01_clicked;
            button02.Clicked += button02_clicked;
            button03.Clicked += button03_clicked;
            button04.Clicked += button04_clicked;
            button05.Clicked += OnClearClicked;
            button01.Text = "ok";
            button02.Text = "back";
            button03.Text = "Start Speaking";
            button04.Text = "Stop Recording";
            button05.Text = "clear";
            picker01.SelectedIndexChanged += Picker01_SelectedIndexChanged;
            picker01.ItemsSource = menu_array01.ToList();
            picker01.Title = "Select";
        }

        private void Picker01_SelectedIndexChanged(object? sender, EventArgs e)
        {

            switch (menu_array01[picker01.SelectedIndex])
            {
                case "andriod_sound_options":
                    load_default_view01();
                    break;
                case "speech_to_text":
                    load_default_view02();
                    break;
                default:
                    load_default_view01();
                    break;
            }
        }
        private void load_Selection01()
        {
            if (Security_Serv01.isPicker_selected(picker01, out data01[24]) == true)
            {
                string key = menu_array01[picker01.SelectedIndex].Trim();
                load_Selection_data01();
                if (_commands.TryGetValue(key, out Action action))
                {
                    action();
                    _commands.Clear();
                }
                else
                {
                    label01.Text = $"{key} command not found";
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
            await button02.Navigation.PushAsync(new Studio_Main_View01());
        }
        private async void button03_clicked(object? sender, EventArgs e)
        {
            if (isStarting || isListening)
                return;

            isStarting = true;
            isStopping = false;

            button03.IsEnabled = false;
            button04.IsEnabled = false;
            label01.Text = "Checking microphone permission...";

            CancellationTokenSource? cts = null;

            try
            {
                var micPermission =
                    await Permissions.RequestAsync<Permissions.Microphone>();

                if (micPermission != PermissionStatus.Granted)
                {
                    label01.Text = "Microphone permission denied.";
                    return;
                }

                cts = new CancellationTokenSource();
                speechCancellation = cts;

                bool speechPermission =
                    await speech.RequestPermissions(cts.Token);

                if (!speechPermission)
                {
                    label01.Text = "Speech recognition permission denied.";
                    return;
                }

                speech.RecognitionResultUpdated -= OnRecognitionUpdated;
                speech.RecognitionResultCompleted -= OnRecognitionCompleted;

                speech.RecognitionResultUpdated += OnRecognitionUpdated;
                speech.RecognitionResultCompleted += OnRecognitionCompleted;

                label01.Text = "Starting Android speech recognizer...";

                await speech.StartListenAsync(
                    new SpeechToTextOptions
                    {
                        Culture = CultureInfo.GetCultureInfo("en-US"),
                        ShouldReportPartialResults = true
                    },
                    cts.Token);

                // IMPORTANT:
                // StartListenAsync may return while Android is still listening.
                // Keep the event handlers subscribed until Stop or completion.

                isListening = true;
                isStarting = false;

                button03.Text = "Recording...";
                button03.IsEnabled = false;
                button04.IsEnabled = true;

                label01.Text = "Recognizer started. Speak now.";
            }
            catch (Exception ex)
            {
                speech.RecognitionResultUpdated -= OnRecognitionUpdated;
                speech.RecognitionResultCompleted -= OnRecognitionCompleted;

                label01.Text = $"Could not start speech recognition: {ex.Message}";

                if (ReferenceEquals(speechCancellation, cts))
                    speechCancellation = null;

                cts?.Dispose();

                isListening = false;
                isStarting = false;
                isStopping = false;

                button03.Text = "Start Speaking";
                button03.IsEnabled = true;
                button04.IsEnabled = false;

                await DisplayAlert("Speech Error", ex.Message, "OK");
                return;
            }

            // Do not reset the listening state here.
            // The recognizer remains active until Stop or completion.
        }


        private async void button04_clicked(object? sender, EventArgs e)
        {
            if (!isListening || isStopping)
                return;

            isStopping = true;
            button04.IsEnabled = false;
            label01.Text = "Stopping speech recognition...";

            try
            {
                await speech.StopListenAsync(CancellationToken.None);

                label01.Text = "Recording stopped.";
            }
            catch (Exception ex)
            {
                label01.Text = $"Stop failed: {ex.Message}";
                isStopping = false;
                button04.IsEnabled = true;
                return;
            }
            finally
            {
                // Reset controls after StopListenAsync completes.
                isListening = false;
                isStarting = false;
                isStopping = false;

                speech.RecognitionResultUpdated -= OnRecognitionUpdated;
                speech.RecognitionResultCompleted -= OnRecognitionCompleted;

                var oldCts = speechCancellation;
                speechCancellation = null;

                oldCts?.Dispose();

                listeningTask = null;

                button03.Text = "Start Speaking";
                button03.IsEnabled = true;
                button04.IsEnabled = false;
            }
        }


        private void OnRecognitionUpdated(
            object? sender,
            SpeechToTextRecognitionResultUpdatedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(
                $"SPEECH PARTIAL RESULT: [{e.RecognitionResult}]");

            MainThread.BeginInvokeOnMainThread(() =>
            {
                if (!string.IsNullOrWhiteSpace(e.RecognitionResult))
                {
                    // Android may return the whole phrase so far.
                    editor01.Text = e.RecognitionResult;
                    label01.Text = "Speech detected: " + e.RecognitionResult;
                }
                else
                {
                    label01.Text = "Recognizer active; waiting for words...";
                }
            });
        }


        private void OnRecognitionCompleted(
            object? sender,
            SpeechToTextRecognitionResultCompletedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(
                $"SPEECH COMPLETED: Success={e.RecognitionResult.IsSuccessful}; " +
                $"Text=[{e.RecognitionResult.Text}]; " +
                $"Error=[{e.RecognitionResult.Exception?.Message}]");

            MainThread.BeginInvokeOnMainThread(() =>
            {
                if (e.RecognitionResult.IsSuccessful)
                {
                    if (!string.IsNullOrWhiteSpace(e.RecognitionResult.Text))
                        editor01.Text = e.RecognitionResult.Text;

                    label01.Text = string.IsNullOrWhiteSpace(e.RecognitionResult.Text)
                        ? "Recognition finished, but no words were returned."
                        : "Speech recognized successfully.";
                }
                else
                {
                    label01.Text =
                        e.RecognitionResult.Exception?.Message
                        ?? "Speech recognition failed without an error message.";
                }
            });
        }
        private void OnClearClicked(object sender, EventArgs e)
        {
            editor01.Text = string.Empty;
            label01.Text = "Ready.";
        }
    }
}