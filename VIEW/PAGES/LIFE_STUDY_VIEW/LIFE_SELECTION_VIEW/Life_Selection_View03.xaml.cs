using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BACKGROUND.BACKGROUND_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.LABELS.LABEL_DEFAULTS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_ANIMATION;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.LIFE_STUDY_VIEW.LIFE_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LIFE_STUDY_SERVICES.THE_BOOK_OF_JUBILEES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.AUDIO_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BORDER.BORDER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS.ENTRY_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_HELPER;

namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.LIFE_STUDY_VIEW.LIFE_SELECTION_VIEW
{
    public partial class Life_Selection_View03 : ContentPage
    {
        private Background_Default01 Background_D01 = new Background_Default01();
        private static string[] data01 = new string[100];
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static Border01_Default border01_D01 = new Border01_Default();
        private static Image01_Default Image01_D01 = new Image01_Default();
        private static Labels01_Default Labels01_D01 = new Labels01_Default();
        private static Security_Services01 Security_Serv01 = new Security_Services01();

        private static string menu_string01 = "Read the Jubilees\n" +
                                                     "audio book of the Jubilees\n" +
                                                     "questions about the Jubilees\n" +
                                                          $"write your thoughts\n" +
                                    $"Speak your thoughts\n" +
                                    $"listen to past recorded thoughts\n" +
                                    $"read past recorded thoughts\n";
        private static string[] menu_array01 = menu_string01.Split("\n");
        private static Button_Animation01 Button_A01 = new Button_Animation01();
        private static Picker01_Animation Picker01_A01 = new Picker01_Animation();
        private static Entrys01_Default Entrys01_D01 = new Entrys01_Default();
        private static The_Book_Of_Jubilees01 The_Book_Of_Jubilee = new The_Book_Of_Jubilees01();

        private static Audio_Services01 Audio_Serv01 = new Audio_Services01();
        private static File_Manger02 File_M02 = new File_Manger02();
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        private static string book01 = string.Empty;
        private static File_Servicesr01 File_Serv01 = new File_Servicesr01();
        private static string filepath = File_Helper01.SavedTextDirectory01[(int)File_Helper01.SavedTextDirectory_strings.mytextfile03].Trim();
        private static bool content_bool = true;
        private static string content_string = string.Empty;
        public Life_Selection_View03()
        {
            InitializeComponent();
            load_Selection_View01();
            book01 = The_Book_Of_Jubilee.read_full_book_text();
        }
        private void load_Selection_data01()
        {

            string procedure = menu_array01[picker01.SelectedIndex].Trim();
            switch (procedure)
            {
                case "Read the Jubilees":
                    _commands.Add(procedure, Read_the_Jubilees);
                    break;
                case "audio book of the Jubilees":
                    _commands.Add(procedure, audio_book_of_the_Jubilees);
                    break;
                case "questions about the Jubilees":
                    _commands.Add(procedure, questions_about_the_Jubilees);
                    break;
                case "write your thoughts":
                    _commands.Add(procedure, write_your_thoughts);
                    break;
                case "Speak your thoughts":
                    _commands.Add(procedure, Speak_your_thoughts);
                    break;
                case "listen to past recorded thoughts":
                    _commands.Add(procedure, listen_to_past_recorded_thoughts);
                    break;
                case "read past recorded thoughts":
                    _commands.Add(procedure, read_past_recorded_thoughts);
                    break;

            }
        }

        private void Read_the_Jubilees()
        {
            label01.IsVisible = true;
            label01.Text = book01;
        }
        private async void audio_book_of_the_Jubilees()
        {
            label01.IsVisible = true;
            label01.Text = book01;
            await TextToSpeech.Default.SpeakAsync(book01);
        }

        private void questions_about_the_Jubilees()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                label01.IsVisible = true;
                label01.Text = "not yet developed";
            }
            else
            {
                label01.IsVisible = true;
                label01.Text = data01[23];
            }
        }

        private void write_your_thoughts()
        {

            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (File_Serv01.write_to_texfile01(filepath, entry01.Text, out data01[24]) == true)
                {
                    label01.IsVisible = true;
                    label01.Text = data01[24];
                }
                else
                {
                    label01.IsVisible = true;
                    label01.Text = data01[24];
                }
            }
            else
            {
                label01.IsVisible = true;
                label01.Text = data01[23];
            }

        }
        private void Speak_your_thoughts()
        {
            label01.IsVisible = true;
            label01.Text = "not yet develop";
        }
        private async void listen_to_past_recorded_thoughts()
        {
            content_bool = File_Serv01.Read_Document01(filepath, out data01[50]);
            if (content_bool == true)
            {
                label01.IsVisible = true;
                content_string = data01[50];
                label01.Text = content_string;
                await TextToSpeech.Default.SpeakAsync(content_string);
            }
            else
            {
                label01.IsVisible = true;
                label01.Text = content_string;
            }
        }
        private async void read_past_recorded_thoughts()
        {

            content_bool = File_Serv01.Read_Document01(filepath, out data01[50]);
            if (content_bool == true)
            {
                label01.IsVisible = true;
                content_string = data01[50];
                label01.Text = content_string;
                await TextToSpeech.Default.SpeakAsync(content_string);
            }
            else
            {
                label01.IsVisible = true;
                label01.Text = content_string;
            }

        }


        private void load_Selection_View01()
        {
            load_default_view();
            Image01_D01.image01(image01);
            Background_D01.background01(this);
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
            picker01.ItemsSource = menu_array01.ToList();
            picker01.Title = "Select";
        }

        private void Picker01_SelectedIndexChanged(object? sender, EventArgs e)
        {


            switch (menu_array01[picker01.SelectedIndex])
            {
                case "Read the Jubilees":
                    load_default_view01();
                    break;
                case "audio book of the Jubilees":
                    load_default_view01();
                    break;
                case "questions about the Jubilees":
                    load_default_view02();
                    break;
                case "write your thoughts":
                    load_default_view02();
                    break;
                case "Speak your thoughts":
                    load_default_view01();
                    break;
                case "listen to past recorded thoughts":
                    load_default_view01();
                    break;
                case "read past recorded thoughts":
                    load_default_view01();
                    break;


            }
        }
        private void load_default_view()
        {
            label01.IsVisible = false;
            label01.Text = string.Empty;
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = true;



        }
        private void load_default_view01()
        {
            label01.IsVisible = false;
            label01.Text = string.Empty;
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = true;
        }

        private void load_default_view02()
        {
            label01.IsVisible = false;
            label01.Text = string.Empty;
            border01.IsVisible = true;
            border02.IsVisible = true;
            border03.IsVisible = true;
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
            await button02.Navigation.PushAsync(new Life_Main_View01());
        }
    }
}