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

namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.AI_VIEW.AI_SELECTION_VIEW
{
    public partial class Ai_Selection_View02 : ContentPage
    {
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

        private static string menus_string02 =

            $"Tell me whats on your mind\n" +
            $"lets develop together. how can i help?\n" +
            $"lets make web development feel better. how can i help?\n";
        private static string[] menus_array02 = menus_string02.Split("\n");
        public Ai_Selection_View02()
        {

            InitializeComponent();
            load_Ai_Selection_View02();
        }
        private void load_Ai_Selection_View02()
        {
            load_default_view01();
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
            picker01.ItemsSource = menus_array01.ToList();
            picker01.Title = "Select";
        }


        private void load_default_view01()
        {

            border01.IsVisible = true;
            border02.IsVisible = true;
            border03.IsVisible = true;
            label01.IsVisible = false;
        }
        private void Picker01_SelectedIndexChanged(object? sender, EventArgs e)
        {

            switch (picker01.SelectedIndex)
            {
                case 0:
                    load_default_view01();

                    break;
                case 1:
                    load_default_view01();
                    break;
                case 2:
                    load_default_view01();
                    break;

            }
        }



        private void load_Selection_data01()
        {
            for (int i = 0; i < menus_array01.Length; i++)
            {
                string procedure = menus_array01 [i].Trim();
                switch (menus_array01[picker01.SelectedIndex])
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
        }
        private void Ai_text_generation()
        {
            label01.IsVisible = true;

            label01.Text = menus_array01[picker01.SelectedIndex];

            if (Security_Serv01.empty_string(entry01.Text, out data01[25]) == true)
            {


                data01[4] =  Ai_Text_To_T01.text_to_text_generator01(entry01.Text).GetAwaiter().GetResult();;
                label01.Text = $"{data01[0]}\n{data01[25]}\n";

            }
            else
            {
                label01.Text = data01[25];
            }
        }
        private void Ai_text_generation_for_developers()
        {
            label01.IsVisible = true;
            
            label01.Text = menus_array01[picker01.SelectedIndex];
            data01[4] =  Ai_Text_To_T01.text_to_text_generator01(entry01.Text).GetAwaiter().GetResult();;
            if (Security_Serv01.empty_string(entry01.Text, out data01[25]) == true)
            {

                label01.Text = $"{data01[0]}\n{data01[25]}\n";

            }
            else
            {
                label01.Text = data01[25];
            }
        }
        private void Ai_text_generation_for_web_developers()
        {
            label01.IsVisible = true;
            
            data01[4] =  Ai_Text_To_T01.text_to_text_generator01(entry01.Text).GetAwaiter().GetResult();;
            if (Security_Serv01.empty_string(entry01.Text, out data01[25]) == true)
            {

          //      data01[0] = File_H01.file_saved(entry01.Text, data01[4], (int)File_Helper01.file_path_data01_enum.question);
                label01.Text = $"{data01[0]}\n{data01[25]}\n";

            }
            else
            {
                label01.Text = data01[25];
            }
        }
        private void load_Ai_Selection_View02_data()
        {
            if (Security_Serv01.isPicker_selected(picker01, out data01[24]) == true)
            {
                int selection = picker01.SelectedIndex;
                int stringlength=menus_array01.Length;
                if (selection >= 0 &&
                    selection < stringlength)
                {
                    string key = menus_array01[selection].Trim();
                    load_Selection_data01();

                    if (_commands.TryGetValue(key, out Action action))
                    {

                        action();


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
             load_Ai_Selection_View02_data();
        }
        private async void button02_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button02);
            await button02.Navigation.PushAsync(new Ai_Main_View01());
        }
    }
}