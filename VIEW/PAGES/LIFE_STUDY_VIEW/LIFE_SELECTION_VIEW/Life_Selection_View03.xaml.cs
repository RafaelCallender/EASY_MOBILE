using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.LABELS.LABEL_DEFAULTS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_ANIMATION;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.LIFE_STUDY_VIEW.LIFE_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LIFE_STUDY_SERVICES.THE_BOOK_OF_JUBILEES;
//using EASYPROJECT01.EASY_CALLENDER01.SERVICES.AI_SERVICES.AI_TEXT_TO_TEXT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.AUDIO_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BORDER.BORDER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS.ENTRY_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.LIFE_STUDY_VIEW.LIFE_SELECTION_VIEW
{
    public partial class Life_Selection_View03 : ContentPage
    {
        private static string[] data01 = new string[100];
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static Border01_Default border01_D01 = new Border01_Default();
        private static Image01_Default Image01_D01 = new Image01_Default();
        private static Labels01_Default Labels01_D01 = new Labels01_Default();
        private static Security_Services01 Security_Serv01 = new Security_Services01();

        private static string menu_string01 = "Read the Jubilees\n" +
                                                     "audio book of the Jubilees\n" +
                                                     "questions about the Jubilees\n" +
                                                     "Record thoughts\n";
        private static string[] menu_array01 = menu_string01.Split("\n");

        private static Button_Animation01 Button_A01 = new Button_Animation01();

        private static Picker01_Animation Picker01_A01 = new Picker01_Animation();
        private static Entrys01_Default Entrys01_D01 = new Entrys01_Default();
        private static The_Book_Of_Jubilees01 The_Book_Of_Jubilee = new The_Book_Of_Jubilees01();
     //   private static Ai_Text_To_Text04 Ai_Text_To_T04 = new Ai_Text_To_Text04();
        private static Audio_Services01 Audio_Serv01 = new Audio_Services01();
        private static File_Manger02 File_M02 = new File_Manger02();
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        public Life_Selection_View03()
        {
            InitializeComponent();
            load_Selection_View01();
        }
        private void load_Selection_data01()
        {
            for (int i = 0; i < menu_array01.Length; i++)
            {
                string procedure = menu_array01[i].Trim();
                switch (menu_array01[picker01.SelectedIndex])
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
                    case "Record thoughts":
                        _commands.Add(procedure, Record_thoughts);
                        break;

                }
            }
        }
        private void Read_the_Jubilees()
        {
            label01.Text = The_Book_Of_Jubilee.read_full_book_text();
        }
        private void audio_book_of_the_Jubilees()
        {
            label01.Text = $"{The_Book_Of_Jubilee.read_full_book_text()}\n";
            Audio_Serv01.convert_text_to_voice01_linux(data01[2]).GetAwaiter().GetResult();

        }

        private void questions_about_the_Jubilees()
        {
  label01.Text = $"not yet developed";
        }

        private void Record_thoughts()
        {
label01.Text = $"not yet developed";
        }

        private void load_Selection_View01()
        {
            Image01_D01.image01(image01);
            image01.Source = File_M02.source[(int)File_Manger02.image_index01.Easy_Callender_page_1];
            Entrys01_D01.Entrys01(entry01);
            border01_D01.border001(border01);
            border01_D01.border002(border02);
            border01_D01.border002(border03);
            Labels01_D01.label01(label01);
            Button01_D01.button01(button01);
            Button01_D01.button02(button02);
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
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    break;
                case "audio book of the Jubilees":
                    load_default_view01();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    break;
                case "questions about the Jubilees":
                    load_default_view02();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    break;
                case "Record thoughts":
                    load_default_view02();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    break;


            }
        }
        private void load_default_view()
        {
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = true;
            label01.IsVisible = false;
            label02.IsVisible = false;

        }
        private void load_default_view01()
        {
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = true;
            label01.IsVisible = true;
            label02.IsVisible = false;
        }

        private void load_default_view02()
        {
            border01.IsVisible = true;
            border02.IsVisible = true;
            border03.IsVisible = true;
            label01.IsVisible = true;
            label02.IsVisible = false;
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