using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LOCATION.LOCATION_HELPER;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.LABELS.LABEL_DEFAULTS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_DEFAULT;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.LOCATION_VIEW.LOCATION_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BORDER.BORDER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS.ENTRY_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LOCATION.LOCATION_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;

namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.LOCATION_VIEW.LOCATION_SELECTION_VIEW
{
    public partial class Location_Selection_View01 : ContentPage
    {

        private static string[] data01 = new string[100];
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static Border01_Default border01_D01 = new Border01_Default();
        private static Image01_Default Image01_D01 = new Image01_Default();
        private static Picker01_Default Picker01_D = new Picker01_Default();
        private static Labels01_Default Labels01_D01 = new Labels01_Default();
        private static string menu_string01 = "get device full location\n" +
                   "get ip address\n" +
                   "get city\n" +
                   "get state\n" +
                   "get country\n" +
                   "get location grid\n" +
                   "get_longitude\n" +
                   "get latitude\n";

        private static string[] menu_array01 = menu_string01.Split("\n");
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);

        private static Button_Animation01 Button_A01 = new Button_Animation01();
        private static Picker01_Animation Picker01_A01 = new Picker01_Animation();
        private static Entrys01_Default Entrys01_D01 = new Entrys01_Default();
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static File_Manger02 File_M02 = new File_Manger02();
        public Location_Selection_View01()
        {

            InitializeComponent();
            load_Selection_View01();
        }
        private void load_Selection_data01()
        {
            for (int i = 0; i < menu_array01.Length; i++)
            {
                string procedure = menu_array01[i].Trim();
                switch (menu_array01[int.Parse(data01[4])])
                {


                    case "get device full location":
                        _commands.Add(procedure, get_device_full_location);
                        break;
                    case "get ip address":
                        _commands.Add(procedure, get_ip_address);
                        break;
                    case "get city":
                        _commands.Add(procedure, get_city);
                        break;
                    case "get state":
                        _commands.Add(procedure, get_state);
                        break;
                    case "get country":
                        _commands.Add(procedure, get_country);
                        break;
                    case "get location grid":
                        _commands.Add(procedure, get_location_grid);
                        break;
                    case "get longitude":
                        _commands.Add(procedure, get_longitude);
                        break;
                    case "get latitude":
                        _commands.Add(procedure, get_latitude);
                        break;

                }
            }
        }

        private void get_device_full_location()
        {
            label02.Text = Location_Manager01.raw_data;
        }
        private void get_ip_address()
        {
            label02.Text = Location_Manager01.get_ipaddress01;
        }
        private void get_city()
        {
            label02.Text = Location_Manager01.get_city01;
        }
        private void get_state()
        {
            label02.Text = Location_Manager01.get_state01;
        }
        private void get_country()
        {
            label02.Text = Location_Manager01.get_country01;
        }
        private void get_location_grid()
        {
            label02.Text = Location_Manager01.get_location_grid01;
        }
        private void get_longitude()
        {
            label02.Text = Location_Manager01.get_longitude;
        }
        private void get_latitude()
        {
            label02.Text = Location_Manager01.get_latitude;
        }

        private void load_Selection_View01()
        {
            load_default_view();
            Image01_D01.image01(image01);
            image01.Source = File_M02.source[(int)File_Manger02.image_index01.Easy_Callender_page_1];
            Entrys01_D01.Entrys01(entry01);
            border01_D01.border001(border01);
            border01_D01.border002(border02);
            border01_D01.border002(border03);
            Labels01_D01.label01(label01);
            Labels01_D01.label01(label02);
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


        private void load_default_view()
        {
            label01.IsVisible = false;
            label02.IsVisible = true;
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = true;
        }
        private void Picker01_SelectedIndexChanged(object? sender, EventArgs e)
        {
            switch (menu_array01[picker01.SelectedIndex])
            {
                case "get device full locations":
                    load_default_view();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    break;
                case "get device full location":
                    load_default_view();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    break;
                case "get ip address":
                    load_default_view();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    break;
                case "get city":
                    load_default_view();
                    label01.Text = string.Empty;
                    break;
                case "get state":
                    load_default_view();
                    label01.Text = string.Empty;
                    break;
                case "get country":
                    load_default_view();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    break;
                case "get location grid":
                    load_default_view();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    break;
                case "get longitude":
                    load_default_view();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    break;
                case "get latitude":
                    load_default_view();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    break;
                default:
                    load_default_view();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
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
            await button02.Navigation.PushAsync(new Location_Main_View01());
        }
    }
}