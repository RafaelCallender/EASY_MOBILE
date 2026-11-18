using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BACKGROUND.BACKGROUND_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.LABELS.LABEL_DEFAULTS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_ANIMATION;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.TEST_VIEW.TEST_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BORDER.BORDER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS.ENTRY_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_HELPER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILE_SERVICES.FILE_PICKER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.AUDIO_SERVICES;
namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.TEST_VIEW.TEST_SELECTION_VIEW
{
    public partial class Test_Selection_View11 : ContentPage
    {
        private Background_Default01 Background_D01 = new Background_Default01();
        private static string[] data01 = new string[100];
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static Border01_Default border01_D01 = new Border01_Default();
        private static Image01_Default Image01_D01 = new Image01_Default();
        private static Labels01_Default Labels01_D01 = new Labels01_Default();
        private static Button_Animation01 Button_A01 = new Button_Animation01();
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Picker01_Animation Picker01_A01 = new Picker01_Animation();
        private static Entrys01_Default Entrys01_D01 = new Entrys01_Default();
        private static string menu_string01 = $"Text to speech linux 01\n" +
                                              $"Read audio file\n" +
                                              $"Read audio file\n" +
                                              $"download audio file\n";

        private static string[] menu_array01 = menu_string01.Split("\n");
        private static File_Helper01 File_H01 = new File_Helper01();
        private static File_Manger02 File_M02 = new File_Manger02();
        // private static Audio_Services03 Audio_Serv03 = new Audio_Services03();
        private static Audio_Services01 Audio_Serv01 = new Audio_Services01();
        private static File_Picker01 File_P01 = new File_Picker01();
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);

        public Test_Selection_View11()
        {

            InitializeComponent();
            load_Selection_View01();

        }

        private void load_Selection_data01()
        {
            string procedure = menu_array01[picker01.SelectedIndex].Trim();
            switch (procedure)
            {
                case "Text to speech linux 01":
                    _commands.Add(procedure, text_to_speech_linux01);
                    break;
                case "Read audio file":
                    _commands.Add(procedure, read_audio_file01);
                    break;
                case "download audio file":
                    _commands.Add(procedure, download_audio_file);
                    break;

            }
        }
        private void unknown01()
        {
            label01.Text = "not yet developed";
        }
        private async void download_audio_file()
        {

            /*  string modelPath =
                    "/home/swageteam101/Desktop/OneDrive/PROJECTS/EASYPROJECT01/EASY_CALLENDER01/FILES/BIN/ggml-base.en.bin";

                string transcriptPath =
                    "/home/swageteam101/Desktop/OneDrive/PROJECTS/EASYPROJECT01/EASY_CALLENDER01/FILES/TRANSCRIPTS";

                var youtubeService =
                    new Audio_S03.transcribe_youtube_video01(
                        modelPath,
                        transcriptPath);

                // YouTube video
                string youtubeUrl =
                    "https://www.youtube.com/watch?v=VIDEO_ID";

                // Generate TXT
                string result =
                    await Audio_S03.transcribe_youtube_video01(
                        youtubeUrl, "txt");

                Console.WriteLine("Transcript saved: " + result);

                // Generate SRT
                string resultSrt =
                    await Audio_S03.transcribe_youtube_video01(
                        youtubeUrl, "srt");*/

            label01.Text = "not yet developed";

        }
        private async void text_to_speech_linux01()
        {

            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                await Audio_Serv01.text_to_speech_linux01(data01[3]);
                label01.Text = data01[3];
            }
            else
            {
                label01.Text = data01[23];
            }
        }


        private async void read_audio_file01()
        {
            if (File_P01.FilePickerLinux02(entry01.Text, out data01[25]) == true)
            {
                await Audio_Serv01.read_audio_file01(data01[25]);
                label01.Text = data01[3];
            }
            else
            {
                label01.Text = data01[25];
            }

        }

        private void load_default_view01()
        {

            label01.IsVisible = false;
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = true;

        }

        private void load_Selection_View01()
        {
            Background_D01.background01(this);
            load_default_view01();
            Image01_D01.image01(image01);
            image01.Source = File_M02.source[(int)File_Manger02.image_index01.Easy_Callender_page_1];
            Entrys01_D01.Entrys02(entry01);
            border01_D01.border008(border01);
            border01_D01.border008(border02);
            border01_D01.border008(border03);
            Labels01_D01.label04(label01);
            Button01_D01.button03(button01);
            Button01_D01.button03(button02);
            button01.Clicked += button01_clicked;
            button02.Clicked += button02_clicked;
            button01.Text = "ok";
            button02.Text = "back";
            picker01.SelectedIndexChanged += Picker01_SelectedIndexChanged;
            picker01.ItemsSource = menu_array01.ToList();
            picker01.Title = "Select";
        }

        private void Picker01_SelectedIndexChanged(object? sender, EventArgs e)
        {

            switch (menu_array01[picker01.SelectedIndex])
            {

                case $"Text to speech linux 01":
                    load_default_view01();
                    break;
                case $"Read audio file":
                    load_default_view01();
                    break;      
                case $"download audio file":
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
            await button02.Navigation.PushAsync(new Test_Main_View01());
        }
    }
}