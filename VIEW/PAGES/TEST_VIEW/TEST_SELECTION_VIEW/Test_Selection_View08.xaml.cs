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
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LINUX.LINUX_HELPER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_SERVICES;

namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.TEST_VIEW.TEST_SELECTION_VIEW
{
    public partial class Test_Selection_View08 : ContentPage
    {
        private Background_Default01 Background_D01 = new Background_Default01();
        private static string[] data01 = new string[100];
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static Border01_Default border01_D01 = new Border01_Default();
        private static Image01_Default Image01_D01 = new Image01_Default();
        private static Labels01_Default Labels01_D01 = new Labels01_Default();
        private static File_Servicesr01 File_S01 = new File_Servicesr01();
        private static string menu_string01 = $"linux string 01\n" +
           $"linux Directory search\n" +
           $"linux file search\n"
 ;
        private static string[] menu_array01 = menu_string01.Split("\n");
        private static Button_Animation01 Button_A01 = new Button_Animation01();
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Picker01_Animation Picker01_A01 = new Picker01_Animation();
        private static Entrys01_Default Entrys01_D01 = new Entrys01_Default();
        private static Linux_Helper01 Linux_H01 = new Linux_Helper01();
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        private static File_Manger02 File_M02 = new File_Manger02();
        public Test_Selection_View08()
        {
            InitializeComponent();
            load_Selection_View01();
        }

        private void load_Selection_data01()
        {
            string procedure = menu_array01[picker01.SelectedIndex].Trim();
            switch (procedure)
            {
                case "linux string 01":
                    _commands.Add(procedure, linux_string_01);
                    break;
                case "linux Directory search":
                    _commands.Add(procedure, linux_Directory_search);
                    break;
                case "linux file search":
                    _commands.Add(procedure, linux_file_search);
                    break;
            }
        }
        private void linux_string_01()
        {
            label01.Text = Linux_Helper01.linux_OneDrive_array[(int)Linux_Helper01.linux_OneDrive01_index.DeleteRemoteFolder];
        }
        private void linux_Directory_search()
        {

            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                label01.Text = File_S01.find_directory(entry01.Text);

            }
            else
            {
                label01.Text = data01[23];

            }
        }
        private void linux_file_search()
        {

            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                label01.Text = File_S01.find_files(entry01.Text.Trim());

            }
            else
            {
                label01.Text = data01[23];
            }
        }

        private void load_default_view01()
        {

            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = true;

        }
        private void load_default_view02()
        {

            border01.IsVisible = true;
            border02.IsVisible = true;
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
                case "linux string 01":
                    load_default_view01();
                    entry01.Placeholder = "directory name";
                    break;
                case "linux Directory search":
                    load_default_view02();
                    break;
                case "linux file search":
                    load_default_view02();
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
            await button02.Navigation.PushAsync(new Test_Main_View01());
        }
    }
}