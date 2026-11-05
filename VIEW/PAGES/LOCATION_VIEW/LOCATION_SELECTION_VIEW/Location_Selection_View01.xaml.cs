using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BACKGROUND.BACKGROUND_DEFAULT;
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
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LOCATION.LOCATION_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.DEVICES.DEVICE_SERVICES;
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
using System.Collections.ObjectModel;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.MAPS.MAPS_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.MODEL.LOCATION_MODEL.LOCATION_SET_MODEL;
using System.Globalization;

namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.LOCATION_VIEW.LOCATION_SELECTION_VIEW
{
    public partial class Location_Selection_View01 : ContentPage
    {

        private static Maps_Default Maps_D = new Maps_Default();
        private Background_Default01 Background_D01 = new Background_Default01();
        private static string[] data01 = new string[100];
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static Border01_Default border01_D01 = new Border01_Default();
        private static Image01_Default Image01_D01 = new Image01_Default();
        private static Picker01_Default Picker01_D = new Picker01_Default();
        private static Labels01_Default Labels01_D01 = new Labels01_Default();
        private static Location_Services01 Location_Serv01 = new Location_Services01();
        private static Location_Services02 Location_Serv02 = new Location_Services02();
        private static string menu_string01 =
                 "get_city_mobile01\n" +
"get_state_mobile01\n" +
"get_country_mobile01\n" +
"get_longitude_mobile\n" +
"get_latitude_mobile\n" +
"get device full location mobile\n" +
"GetLocationDataAsync\n" +
"GetLocationDataAsync01\n" +
    "GetCoordinates\n" +
"show Map\n";
        private static string[] menu_array01 = menu_string01
            .Split('\n', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);

        private static Button_Animation01 Button_A01 = new Button_Animation01();
        private static Picker01_Animation Picker01_A01 = new Picker01_Animation();
        private static Entrys01_Default Entrys01_D01 = new Entrys01_Default();
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static File_Manger02 File_M02 = new File_Manger02();
        private static Device_Services01 Device_S01 = new Device_Services01();
        private static string[] location_array { get; set; }
        private static ObservableCollection<Location_Set_Model01> Items01 { get; set; } = new ObservableCollection<Location_Set_Model01>();
        private static Location_Services03 Location_Serv03 = new Location_Services03();
        public Location_Selection_View01()
        {
            InitializeComponent();
            load_Selection_View01();
        }



        private static async Task<string> set_mobile_location()
        {
            try
            {
                var res = await Device_S01.get_mobile_location01();
                if (res.success == true)
                {
                    data01[60] = res.output;
                }
                else
                {

                    data01[60] = $"{res.output}";
                }
            }
            catch (Exception ex)
            {

                data01[60] = $"Unable to get mobile location: {ex.Message}";
            }
            return data01[60];
        }
        private async void load_location01()
        {
            string result = await set_mobile_location();
            location_array = result.Split('\n');

        }
        private void load_Selection_data01()
        {
            string procedure = menu_array01[picker01.SelectedIndex].Trim();
            switch (procedure)
            {


                case "get_city_mobile01":
                    _commands[procedure] = get_city_mobile01;
                    break;
                case "get_state_mobile01":
                    _commands[procedure] = get_state_mobile01;
                    break;
                case "get_country_mobile01":
                    _commands[procedure] = get_country_mobile01;
                    break;
                case "get_longitude_mobile":
                    _commands[procedure] = get_longitude_mobile;
                    break;
                case "get_latitude_mobile":
                    _commands[procedure] = get_latitude_mobile;
                    break;
                case "get device full location mobile":
                    _commands[procedure] = get_device_full_location_mobile;
                    break;
                case "show Map":
                    _commands[procedure] = show_Map;
                    break;
                case "GetLocationDataAsync":
                    _commands[procedure] = GetLocationDataAsync;
                    break;
                case "GetLocationDataAsync01":
                    _commands[procedure] = GetLocationDataAsync01;
                    break;
                case "GetCoordinates":
                    _commands.Add(procedure, GetCoordinates);
                    break;
            }
        }

        private void show_Map()
        {
            double lat = double.Parse(location_array[4].Trim());
            double Long = double.Parse(location_array[3].Trim());
            var points = new[]
                      {
            new { Name = location_array[0].Trim(), Latitude= lat, Longitude =Long }

        };

            foreach (var point in points)
            {
                var location = new Location(
                    point.Latitude,
                    point.Longitude);

                var pin = new Pin
                {
                    Label = point.Name,
                    Location = location,
                    Type = PinType.Place
                };

                MyMap.Pins.Add(pin);
                MyMap.MoveToRegion(
                    MapSpan.FromCenterAndRadius(
                        location,
                        Distance.FromMiles(1)));





            }





        }
        private async void get_device_full_location_mobile()
        {
            double lat = double.Parse(location_array[4].Trim());
            double Long = double.Parse(location_array[3].Trim());

            var a = new Location_Set_Model01
            {
                City = location_array[0],
                State = location_array[1],
                CountryName = location_array[2],
                Longitude = Long.ToString(),
                Latitude = lat.ToString()

            };
            Items01.Add(a);
            CollectionView01.ItemsSource = Items01;
        }

        private void get_city_mobile01()
        {
            if (Security_Serv01.is_connected_to_netwrok_andriod(out data01[24]) == true)
            {

                label01.Text = location_array[0];
            }
            else
            {
                label01.Text = data01[24];
            }

        }
        private async void GetLocationDataAsync()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.is_connected_to_netwrok_andriod(out data01[24]) == true)
                {
                    try
                    {
                        data01[5] = await Location_Serv02.GetLocationDataAsync(entry01.Text);
                        string[] res_array = data01[5].Split("\n");
                        double lat = double.Parse(res_array[0].Trim());
                        double Long = double.Parse(res_array[1].Trim());
                        var points = new[]
                {
            new { Name = location_array[0], Latitude = lat, Longitude = Long}

        };

                        foreach (var point in points)
                        {
                            var location = new Location(
                                point.Latitude,
                                point.Longitude);

                            var pin = new Pin
                            {
                                Label = point.Name,
                                Location = location,
                                Type = PinType.Place
                            };

                            MyMap.Pins.Add(pin);
                            MyMap.MoveToRegion(
                                MapSpan.FromCenterAndRadius(
                                    location,
                                    Distance.FromMiles(1)));
                        }
                        label01.Text = await Location_Serv02.GetLocationDataAsync(entry01.Text);
                    }
                    catch (Exception ex)
                    {
                        label01.Text = $"Location lookup failed: {ex.Message}";
                    }
                }
                else
                {
                    label01.Text = data01[24];
                }

            }
            else
            {
                label01.Text = data01[23];
            }
        }
        private async void GetLocationDataAsync01()
        {
             if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.is_connected_to_netwrok_andriod(out data01[24]) == true)
                {
                    try
                    {
                        string array_string =  await Location_Serv01.GetLocationDataAsync01(entry01.Text);
                        string[] array01 = array_string.Split("\n");

                        string city = array01[0].Trim();
                        string state = array01[1].Trim();
                        string county = array01[2].Trim();
                        double lat = double.Parse(array01[3].Trim());
                        double Long = double.Parse(array01[4].Trim());

                        var a = new Location_Set_Model01
                        {
                            City = city,
                            State = state,
                            CountryName = county,
                            Longitude = Long.ToString(),
                            Latitude = lat.ToString()

                        };
                        Items01.Add(a);
                        CollectionView01.ItemsSource = Items01;
                        var points = new[]
                                  {
            new { Name = array01[0].Trim(), Latitude= lat, Longitude =Long }

        };

                        foreach (var point in points)
                        {
                            var location = new Location(
                                point.Latitude,
                                point.Longitude);

                            var pin = new Pin
                            {
                                Label = point.Name,
                                Location = location,
                                Type = PinType.Place
                            };

                            MyMap.Pins.Add(pin);
                            MyMap.MoveToRegion(
                                MapSpan.FromCenterAndRadius(
                                    location,
                                    Distance.FromMiles(1)));





                        }


                        label01.Text = await Location_Serv03.GetCoordinates(entry01.Text);
                    }
                    catch (Exception ex)
                    {
                        load_default_view01();
                        label01.Text = $"Location lookup failed: {ex.Message}";

                    }
                }
                else
                {
                    load_default_view01();
                    label01.Text = data01[24];
                }
            }
            else
            {
                load_default_view01();
                label01.Text = data01[23];
            }

        }
        private void get_state_mobile01()
        {
            if (Security_Serv01.is_connected_to_netwrok_andriod(out data01[24]) == true)
            {
                label01.Text = location_array[1];
            }
            else
            {
                label01.Text = data01[24];
            }


        }
        private void get_country_mobile01()
        {
            if (Security_Serv01.is_connected_to_netwrok_andriod(out data01[24]) == true)
            {
                label01.Text = location_array[2];
            }
            else
            {
                label01.Text = data01[24];
            }

        }
        private void get_longitude_mobile()
        {
            if (Security_Serv01.is_connected_to_netwrok_andriod(out data01[24]) == true)
            {
                label01.Text = location_array[3];
            }
            else
            {
                label01.Text = data01[24];
            }

        }
        private void get_latitude_mobile()
        {
            if (Security_Serv01.is_connected_to_netwrok_andriod(out data01[24]) == true)
            {
                label01.Text = location_array[4];
            }
            else
            {
                label01.Text = data01[24];
            }

        }
        private async void GetCoordinates()
        {

            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.is_connected_to_netwrok_andriod(out data01[24]) == true)
                {
                    try
                    {
                        string array_string = await Location_Serv03.GetCoordinates(entry01.Text);
                        string[] array01 = array_string.Split("\n");

                        string city = array01[0].Trim();
                        string state = array01[1].Trim();
                        string county = array01[2].Trim();
                        double lat = double.Parse(array01[3].Trim());
                        double Long = double.Parse(array01[4].Trim());

                        var a = new Location_Set_Model01
                        {
                            City = city,
                            State = state,
                            CountryName = county,
                            Longitude = Long.ToString(),
                            Latitude = lat.ToString()

                        };
                        Items01.Add(a);
                        CollectionView01.ItemsSource = Items01;
                        var points = new[]
                                  {
            new { Name = array01[0].Trim(), Latitude= lat, Longitude =Long }

        };

                        foreach (var point in points)
                        {
                            var location = new Location(
                                point.Latitude,
                                point.Longitude);

                            var pin = new Pin
                            {
                                Label = point.Name,
                                Location = location,
                                Type = PinType.Place
                            };

                            MyMap.Pins.Add(pin);
                            MyMap.MoveToRegion(
                                MapSpan.FromCenterAndRadius(
                                    location,
                                    Distance.FromMiles(1)));





                        }


                        label01.Text = await Location_Serv03.GetCoordinates(entry01.Text);
                    }
                    catch (Exception ex)
                    {
                        load_default_view01();
                        label01.Text = $"Location lookup failed: {ex.Message}";

                    }
                }
                else
                {
                    load_default_view01();
                    label01.Text = data01[24];
                }
            }
            else
            {
                load_default_view01();
                label01.Text = data01[23];
            }
        }

        private void load_Selection_View01()
        {
            load_default_view();
            load_location01();
            Background_D01.background01(this);
            Image01_D01.image01(image01);
            image01.Source = File_M02.source[(int)File_Manger02.image_index01.Easy_Callender_page_1];
            Entrys01_D01.Entrys02(entry01);
            border01_D01.border008(border01);
            border01_D01.border008(border02);
            border01_D01.border002(border03);
            border01_D01.border008(border04);
            border01_D01.border008(border05);
            Labels01_D01.label04(label01);
            Labels01_D01.label04(label02);
            Button01_D01.button03(button01);
            Button01_D01.button03(button02);
            Maps_D.maps08(MyMap);
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
            border03.IsVisible = false;
            border04.IsVisible = true;
            border05.IsVisible = false;
        }
        private void load_default_view01()
        {
            label01.IsVisible = true;
            label02.IsVisible = false;
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = false;
            border04.IsVisible = true;
            border05.IsVisible = false;
        }
        private void load_default_view02()
        {
            label01.IsVisible = false;
            label02.IsVisible = false;
            border01.IsVisible = false;
            border02.IsVisible = true;
            border03.IsVisible = false;
            border04.IsVisible = true;
            border05.IsVisible = false;
        }
        private void load_default_view03()
        {
            label01.IsVisible = false;
            label02.IsVisible = false;
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = false;
            border04.IsVisible = true;
            border05.IsVisible = true;
        }
        private void load_default_view04()
        {
            label01.IsVisible = true;
            label02.IsVisible = false;
            border01.IsVisible = false;
            border02.IsVisible = true;
            border03.IsVisible = true;
            border04.IsVisible = true;
            border05.IsVisible = false;
        }

        private void load_default_view05()
        {
            label01.IsVisible = true;
            label02.IsVisible = false;
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = true;
            border04.IsVisible = true;
            border05.IsVisible = false;
        }
        private void load_default_view06()
        {
            label01.IsVisible = false;
            label02.IsVisible = false;
            border01.IsVisible = true;
            border02.IsVisible = true;
            border03.IsVisible = true;
            border04.IsVisible = true;
            border05.IsVisible = true;
        }
        private void Picker01_SelectedIndexChanged(object? sender, EventArgs e)
        {

            switch (menu_array01[picker01.SelectedIndex])
            {


                case "get_city_mobile01":
                    load_default_view01();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    break;
                case "get_state_mobile01":
                    load_default_view01();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    break;
                case "get_country_mobile01":
                    load_default_view01();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    break;
                case "get_longitude_mobile":
                    load_default_view01();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    break;
                case "get_latitude_mobile":
                    load_default_view01();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    break;
                case "get device full location mobile":
                    load_default_view03();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    break;
                case "show Map":
                    load_default_view02();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    break;
                case "GetLocationDataAsync":
                    load_default_view05();
                    entry01.Placeholder = "addresss";
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    break;
                case "GetLocationDataAsync01":
                    load_default_view05();
                    entry01.Placeholder = "addresss";
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    break;
                case "GetCoordinates":
                    load_default_view06();
                    entry01.Placeholder = "addresss";
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
                _commands.Clear();
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