
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.LABELS.LABEL_DEFAULTS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_ANIMATION;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.AI_VIEW.AI_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.AI_SERVICES.AI_TEXT_TO_TEXT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.AI_SERVICES.AI_TEXT_TO_TEXT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.AI_SERVICES.AI_TEXT_TO_IMAGE;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BORDER.BORDER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS.ENTRY_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_HELPER;
namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.AI_VIEW.AI_SELECTION_VIEW
{

    public partial class Ai_Selection_View04 : ContentPage
    {
        private static string[] data01 = new string[100];
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static Border01_Default border01_D01 = new Border01_Default();
        private static Image01_Default Image01_D01 = new Image01_Default();

        private static Labels01_Default Labels01_D01 = new Labels01_Default();
        private static string menu_string01 =

            $"image generation\n";
        private static string[] menu_array01 = menu_string01.Split("\n");

        private static string menu_string02 =

            $"What image would you like for me to make?\n";
        private static string[] menu_array02 = menu_string02.Split("\n");
        private static Button_Animation01 Button_A01 = new Button_Animation01();

        private static Picker01_Animation Picker01_A01 = new Picker01_Animation();
        private static Entrys01_Default Entrys01_D01 = new Entrys01_Default();
        private static File_Helper01 File_H01 = new File_Helper01();
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Ai_Text_To_Image01 Ai_Text_To_I01 = new Ai_Text_To_Image01();
        private static File_Manger02 File_M02 = new File_Manger02();
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        public Ai_Selection_View04()
        {

            InitializeComponent();
            load_Ai_Selection_View04();
        }
        private void load_Ai_Selection_View04()
        {
            Entrys01_D01.Entrys01(entry01);
            Image01_D01.image01(image01);
            image01.Source = File_M02.source[(int)File_Manger02.image_index01.Easy_Callender_page_1];
            load_default_view01();
            border01_D01.border001(border01);
            border01_D01.border002(border02);
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
        private void load_default_view01()
        {

            label01.IsVisible = false;
            border01.IsVisible = true;
            border02.IsVisible = true;
            border03.IsVisible = true;

        }
        private void Picker01_SelectedIndexChanged(object? sender, EventArgs e)
        {

            switch (picker01.SelectedIndex)
            {
                case 0:
                    load_default_view01();
                    break;

            }
        }

        private void load_Selection_data01()
        {
            for (int i = 0; i < menu_array01.Length; i++)
            {
                string procedure = menu_array01[i].Trim();
                switch (menu_array01[picker01.SelectedIndex])
                {
                    case "image generation":
                        _commands.Add(procedure, image_generation);
                        break;
                }
            }
        }
        private void image_generation()
        {
            label01.IsVisible = true;
         //   data01[0] = File_H01.file_saved("", "", (int)File_Helper01.file_path_data01_enum.question);
            label01.Text = menu_array01[picker01.SelectedIndex];
            if (Security_Serv01.empty_string(entry01.Text, out data01[25]) == true)
            {

                //      data01[0] = File_H01.file_saved(entry01.Text, data01[4], (int)File_Helper01.file_path_data01_enum.question);
                data01[4] = Ai_Text_To_I01.AI_Text_to_image_Generator_Flux_Free(entry01.Text).GetAwaiter().GetResult(); ;
                label01.Text = $"{data01[0]}\n" +
                                $"{data01[25]}\n" +
                                $"{data01[4]}";

            }
            else
            {
                label01.Text = data01[25];
            }


        }

        private void load_Ai_Selection_View04_data()
        {

            if (Security_Serv01.isPicker_selected(picker01, out data01[24]) == true)
            {
                int selection = picker01.SelectedIndex;
                int stringlength = menu_array01.Length;
                if (selection >= 0 &&
                    selection < stringlength)
                {
                    string key = menu_array01[selection].Trim();
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
            load_Ai_Selection_View04_data();
        }
        private async void button02_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button02);
            await button02.Navigation.PushAsync(new Ai_Main_View01());
        }
    }
}