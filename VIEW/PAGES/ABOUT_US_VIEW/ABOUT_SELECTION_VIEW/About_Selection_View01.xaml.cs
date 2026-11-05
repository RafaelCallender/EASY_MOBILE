using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.LABELS.LABEL_DEFAULTS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BORDER.BORDER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS.ENTRY_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGEBUTTON.IMAGEBUTTON_DEFAULT;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.ABOUT_US_VIEW.ABOUT_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGEBUTTON.IMAGEBUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BACKGROUND.BACKGROUND_DEFAULT;

namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.ABOUT_US_VIEW.ABOUT_SELECTION_VIEW
{
    public partial class About_Selection_View01 : ContentPage
    {
        private Background_Default01 Background_D01 = new Background_Default01();
        private static string[] data01 = new string[100];
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static Border01_Default border01_D01 = new Border01_Default();
        private static Image01_Default Image01_D01 = new Image01_Default();
        private static Labels01_Default Labels01_D01 = new Labels01_Default();
        private static string menu_string01 = $"about company\n"

        ;
        private static string[] menu_array01 = menu_string01.Split("\n");
        private static Button_Animation01 Button_A01 = new Button_Animation01();
        private static Picker01_Animation Picker01_A01 = new Picker01_Animation();
        private static Entrys01_Default Entrys01_D01 = new Entrys01_Default();
        private static Picker01_Default Picker01_D = new Picker01_Default();
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static ImageButton01_Default ImageButton01_D01 = new ImageButton01_Default();
        private static ImageButton_Animaiton01 ImageButton_A01 = new ImageButton_Animaiton01();
        private static File_Manger02 File_M02 = new File_Manger02();
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        public About_Selection_View01()
        {

            InitializeComponent();
            load_About_Selection_View01();
        }
        private void load_Selection_data01()
        {

            string procedure = menu_array01[picker01.SelectedIndex];
            switch (procedure)
            {
                case "about company":
                    _commands.Add(procedure, about_company);
                    break;

            }

        }

        private void about_company()
        {
           // label01.Text = File_Manger01.aboutus;
           label01.Text =string.Empty;
        }


        private void load_About_Selection_View01()
        {
            Background_D01.background01(this);
            load_default_view();
            Image01_D01.image01(image01);
            image01.Source = File_M02.source[(int)File_Manger02.image_index01.Easy_Callender_page_1];
            Entrys01_D01.Entrys01(entry01);
            border01_D01.border008(border01);
            border01_D01.border002(border02);
            border01_D01.border008(border03);
            border01_D01.border008(border04);
            Picker01_D.picker01(picker01);
            Labels01_D01.label04(label01);
            Labels01_D01.label04(label02);
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

        private void load_default_view()
        {

            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = true;
            border04.IsVisible = false;
    
        }
        private void load_default_view02()
        {
     
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = true;
            border04.IsVisible = true;

        }

        private void Picker01_SelectedIndexChanged(object? sender, EventArgs e)
        {

            switch (menu_array01[picker01.SelectedIndex])
            {
                case "about company":
                    load_default_view02();
                    break;
                default:
                    load_default_view();
                    break;


            }
        }

        private void load_Selection_View01()
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
            load_Selection_View01();
        }
        private async void button02_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button02);
            await button02.Navigation.PushAsync(new About_Main_View01());
        }       
    }
}
