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
        private static Audio_Services01 Audio_Serv01 = new Audio_Services01();
        private Background_Default01 Background_D01 = new Background_Default01();
        private static string[] data01 = new string[100];
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static Border01_Default border01_D01 = new Border01_Default();
        private static Image01_Default Image01_D01 = new Image01_Default();
        private static Labels01_Default Labels01_D01 = new Labels01_Default();
        private static string menu_string = $"text to speech linux\n" +
                                             $"text to speech andriode\n";



        private static string[] menu_array01 = menu_string.Split("\n");
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
                case "text to speech linux":
                    _commands.Add(procedure, text_to_speech_linux);
                    break;

                case "text to speech andriode":
                    _commands.Add(procedure, text_to_speech_andriod);
                    break;
            }
        }

        private void text_to_speech_linux()
        {
            label01.IsVisible = true;
            label01.Text = "only for desktop or web";
        }

        private void text_to_speech_andriod()
        {
            label01.IsVisible = true;
            label01.Text = "speek";

        }
        private void load_default_view()
        {
            label01.IsVisible = false;
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = true;
            button03.IsVisible = false;
            button04.IsVisible = false;
            button05.IsVisible = false;


        }

        private void load_default_view01()
        {

            label01.IsVisible = false;
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = true;
            button03.IsVisible = false;
            button04.IsVisible = false;
            button05.IsVisible = false;


        }
        private void load_default_view02()
        {
            label01.IsVisible = false;
            border01.IsVisible = false;
            border02.IsVisible = false;
            border03.IsVisible = true;
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
            Labels01_D01.label09(label01);
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
                case "text to speech linux":
                    load_default_view01();
                    break;
                case "text to speech andriode":
                    load_default_view02();
                    break;
                default:
                    load_default_view01();
                    break;
            }
        }
        private async Task load_Selection01()
        {
            var res = await Security_Serv01.isPicker_selected_mobile(picker01);
            if (res.success == true)
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
                label01.Text = res.output;
            }
        }
        private async void button01_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button01);
            await load_Selection01();
        }
        private async void button02_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button02);
            await button02.Navigation.PushAsync(new Studio_Main_View01());
        }
        private async void button03_clicked(object? sender, EventArgs e)
        {
            string output = await Audio_Serv01.speech_to_text_start_andriod();
            label01.IsVisible = true;
            label01.Text = output;
        }
        private async void button04_clicked(object? sender, EventArgs e)
        {
            string output = await Audio_Serv01.speech_to_text_end_andriod();
            label01.IsVisible = true;
            label01.Text = output;
        }
        private void OnClearClicked(object sender, EventArgs e)
        {
            label01.IsVisible = true;
            label01.Text = "Ready.";
        }
    }
}