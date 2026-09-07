using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.LABELS.LABEL_DEFAULTS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_ANIMATION;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.TEST_VIEW.TEST_MAIN_VIEW;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.TRANSLATE_VIEW.TRANSLATE_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BORDER.BORDER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.AI_SERVICES.AI_TEXT_TO_TEXT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LANGUAGE.LANGUAGE_HELPER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LANGUAGE.LANGUAGE_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGEBUTTON.IMAGEBUTTON_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGEBUTTON.IMAGEBUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS.ENTRY_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.AUDIO_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;


namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.TRANSLATE_VIEW.TRANSLATE_SELECTION_VIEW
{
    public partial class Translate_Selection_View02 : ContentPage
    {
        private static string[] data01 = new string[100];
        private static Image01_Default Image01_D01 = new Image01_Default();
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static Border01_Default border01_D01 = new Border01_Default();
        private static Labels01_Default Labels01_D01 = new Labels01_Default();
        private static string menu_string01 =
                $"Translate Text\n" +
                $"Translate_image\n" +
                $"Translate_speech\n" +
                $"Bulk_translate_text\n";
        private static string[] menu_array01 = menu_string01.Split("\n");
        private static Button_Animation01 Button_A01 = new Button_Animation01();
        private static Picker01_Animation Picker01_A01 = new Picker01_Animation();
        private static Entrys01_Default Entrys01_D01 = new Entrys01_Default();
        private static Picker01_Default Picker01_D = new Picker01_Default();
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Language_Services02 Language_S02 = new Language_Services02();
        private static Language_Helper01 Language_H01 = new Language_Helper01();
        private static ImageButton_Animaiton01 ImageButton_A01 = new ImageButton_Animaiton01();
        private static ImageButton01_Default ImageButton01_D = new ImageButton01_Default();
        private static int counter01 = 0;
        private bool statuescheck = false;
        private static Language_Services01 Language_S01 = new Language_Services01();
        private static File_Manger02 File_M02 = new File_Manger02();
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);


        public Translate_Selection_View02()
        {

            InitializeComponent();
            load_Translate_Selection_View02();
        }
        private void load_Selection_data01()
        {
            for (int i = 0; i < menu_array01.Length; i++)
            {
                string procedure = menu_array01[i].Trim();
                switch (menu_array01[int.Parse(data01[4])])
                {
                    case "Translate Text":
                        _commands.Add(procedure, Translate_text);
                        break;
                }
            }
        }
        private void Translate_text()
        {
            if (picker02.SelectedIndex != -1)
            {

                counter01++;
            }
            else
            {
                counter01--;


            }
            if (Security_Serv01.empty_string(entry01.Text, out data01[20]) == true)
            {
                counter01++;

            }
            else
            {
                counter01--;
                label01.Text = $"{data01[20]}\n";
            }
            if (counter01 == 2)
            {
                label03.Text =  Language_S02.Translate_text(Language_H01.code[picker02.SelectedIndex], entry01.Text.Trim()).GetAwaiter().GetResult();
            }
            else
            {
                label03.Text = $"please fix the errors\n";

            }

        }


        private void Translate_image()
        {
            label01.Text = $"not yet developed\n";
        }
        private void Translate_speech()
        {
            label01.Text = $"not yet developed\n";
        }
        private void Bulk_translate_text()
        {
            label01.Text = $"not yet developed\n";
        }

        private void load_default_view01()
        {
            label01.IsVisible = false;
            label02.IsVisible = false;
            label03.IsVisible = false;
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = true;
            border04.IsVisible = false;
            imagebutton01.IsVisible = false;


        }

        private void load_Translate_Selection_View02()
        {
            load_default_view01();
            Image01_D01.image01(image01);
            image01.Source = File_M02.source[(int)File_Manger02.image_index01.Easy_Callender_page_1];
            Entrys01_D01.Entrys01(entry01);
            border01_D01.border001(border01);
            border01_D01.border002(border02);
            border01_D01.border002(border03);
            border01_D01.border002(border04);
            Labels01_D01.label01(label01);
            Labels01_D01.label01(label02);
            Labels01_D01.label01(label03);
            Picker01_D.picker01(picker01);
            Picker01_D.picker01(picker02);
            ImageButton01_D.ImageButton01(imagebutton01);
            Button01_D01.button01(button01);
            Button01_D01.button02(button02);
            button01.Clicked += button01_clicked;
            button02.Clicked += button02_clicked;
            imagebutton01.Clicked += imagebutton01_clicked;
            button01.Text = "ok";
            button02.Text = "back";
            picker01.SelectedIndexChanged += Picker01_SelectedIndexChanged;
            picker01.ItemsSource = menu_array01.ToList();
            picker01.Title = "Select";
            picker02.ItemsSource = menu_array01.ToList();
            picker02.Title = "Select Language";

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
                case 3:
                    load_default_view01();
                    break;
                case 4:
                    load_default_view01();
                    break;



            }
        }

        private void load_Translate_Selection_View02_data()
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
            load_Translate_Selection_View02_data();
        }
        private async void button02_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button02);
            await button02.Navigation.PushAsync(new Translate_Main_View01());
        }
        private async void imagebutton01_clicked(object? sender, EventArgs e)
        {
            await ImageButton_A01.imagebutton_rotateto01(imagebutton01);
            statuescheck = true;

        }

    }
}