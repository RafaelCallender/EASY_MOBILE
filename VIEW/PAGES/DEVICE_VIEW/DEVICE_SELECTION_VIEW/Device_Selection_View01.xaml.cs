using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BACKGROUND.BACKGROUND_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.LABELS.LABEL_DEFAULTS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BORDER.BORDER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS.ENTRY_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.DEVICE_VIEW.DEVICE_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.MODEL.WEB_MODEL.DEVICE_VIEW_MODEL;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.DEVICES.DEVICE_HELPER;

namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.DEVICE_VIEW.DEVICE_SELECTION_VIEW
{
    public partial class Device_Selection_View01 : ContentPage
    {
        private Background_Default01 Background_D01 = new Background_Default01();
        private static string[] data01 = new string[100];
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static Border01_Default border01_D01 = new Border01_Default();
        private static Image01_Default Image01_D01 = new Image01_Default();
        private static Labels01_Default Labels01_D01 = new Labels01_Default();
        private static Button_Animation01 Button_A01 = new Button_Animation01();
        private static Picker01_Animation Picker01_A01 = new Picker01_Animation();
        private static Entrys01_Default Entrys01_D01 = new Entrys01_Default();
        private static Picker01_Default Picker01_D = new Picker01_Default();
        
        private static File_Manger02 File_M02 = new File_Manger02();
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Device_Helpers01 Device_H01 = new Device_Helpers01();
        private static Device_View_Model01 Device_View_M01 = new Device_View_Model01();
        private static string menu_string01 =
                                           $"device details 01\n" +
                                           $"OS_String\n" +
                                           $"load_device_details01\n" +
                                           $"OS_details\n" +
                                           $"Linux details\n" +
                                           $"GetEnvironmentVariables_string\n";


        private static string[] menu_array01 = menu_string01.Split("\n");

        public Device_Selection_View01()
        {

            InitializeComponent();
            load_Selection_View01();
        }
        private void load_Selection_View01()
        {
            load_default_view();
            Image01_D01.image01(image01);
            Background_D01.background01(this);
            image01.Source = File_M02.source[(int)File_Manger02.image_index01.Easy_Callender_page_1];
            Entrys01_D01.Entrys02(entry01);
            border01_D01.border008(border01);
            border01_D01.border008(border02);
            border01_D01.border008(border03);
            Picker01_D.picker01(picker01);
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

        private void load_default_view()
        {

            label01.IsVisible = true;
            label02.IsVisible = false;
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = true;

        }
        private void load_default_view01()
        {

            label01.IsVisible = true;
            label02.IsVisible = false;
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = true;

        }
        private void load_Selection_data01()
        {

            string procedure = menu_array01[picker01.SelectedIndex];
            switch (procedure)
            {
                case "device details 01":
                    _commands.Add(procedure, device_details_01);
                    break;
                case "OS_String":
                    _commands.Add(procedure, OS_String);
                    break;
                case "load_device_details01":
                    _commands.Add(procedure, load_device_details01);
                    break;
                case "OS_details":
                    _commands.Add(procedure, OS_details);
                    break;
                case "Linux details":
                    _commands.Add(procedure, OS_details);
                    break;
                case "GetEnvironmentVariables_string":
                    _commands.Add(procedure, GetEnvironmentVariables_string);
                    break;
            }
        }

        private void device_details_01()
        {
            label01.Text = $"needs work";
        }
        private void OS_String()
        {
            label01.Text = $"{Device_H01.OS_String}";
        }
        private void load_device_details01()
        {
            label01.Text = $"{Device_H01.windows_info01}";
        }
        private void OS_details()
        {
            label01.Text = $"{Device_H01.windows_info01}";
        }
        private void Linux_details()
        {
            label01.Text = $"{Device_H01.windows_info01}";
        }
        private void GetEnvironmentVariables_string()
        {
            label01.Text = $"{Device_H01.GetEnvironmentVariables_string}";
        }

        private void Picker01_SelectedIndexChanged(object? sender, EventArgs e)
        {
            switch (menu_array01[picker01.SelectedIndex])
            {

                case "device details 01":
                    load_default_view();
                    break;
                case "OS_String":
                    load_default_view();
                    break;
                case "load_device_details0":
                    load_default_view();
                    break;
                case "OS_details":
                    load_default_view();
                    break;
                case "Linux details":
                    load_default_view();
                    break;
                case "GetEnvironmentVariables_string":
                    load_default_view();
                    break;
                default:
                    load_default_view();
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
                    label02.Text = $"{key} command not found";
                }
            }
            else
            {
                label02.Text = data01[24];
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
            await button02.Navigation.PushAsync(new Device_Main_View01());
        }
    }
}
