using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.LABELS.LABEL_DEFAULTS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_ANIMATION;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.SCIENCE_VIEW.SCIENCE_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BORDER.BORDER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_SERVICES.MYSQL_SCIENCE_SERVICES.MYSQL_CHEMISTRY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS.ENTRY_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;

namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.SCIENCE_VIEW.SCIENCE_SELECTION_VIEW
{
    public partial class Science_Selection_View04 : ContentPage
    {
        private static string[] data01 = new string[100];
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static Image01_Default Image01_D01 = new Image01_Default();
        private static Labels01_Default Labels01_D01 = new Labels01_Default();
        private static Button_Animation01 Button_A01 = new Button_Animation01();
        private static Picker01_Animation Picker01_A01 = new Picker01_Animation();
        private static Entrys01_Default Entrys01_D01 = new Entrys01_Default();
        private static Border01_Default border01_D01 = new Border01_Default();
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static MySql_Chemistry_Services01 MySql_Chemistry_Serv01 = new MySql_Chemistry_Services01();
        private static bool menu_bool01 = MySql_Chemistry_Serv01.view_chemistry_database_storedprocedures(out data01[50]);
        private static string menu_string01 = data01[50];
        private static string[] menu_array01 = menu_string01.Split("\n");
        private static int count = 0;
        private static File_Manger02 File_M02 = new File_Manger02();
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        public Science_Selection_View04()
        {
            InitializeComponent();
            if (menu_bool01 == true)
            {
                load_Science_Selection_View04();
                load_default_view01();
            }
            else
            {
                label01.Text = menu_string01;
                load_default_view01();
            }

        }


        private void load_default_view01()
        {

            label01.IsVisible = false;
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = true;
            border04.IsVisible = false;


        }

        private void load_Selection_data01()
        {
            for (int i = 0; i < menu_array01.Length; i++)
            {
                string procedure = menu_array01[i].Trim();
                switch (menu_array01[int.Parse(data01[4])])
                {

                    case "find_Alkali_Metals":
                        _commands.Add(procedure, find_Alkali_Metals);
                        break;
                    case "Find_Actinides":
                        _commands.Add(procedure, Find_Actinides);
                        break;
                    case "find_Alkaline_Earth_Metals":
                        _commands.Add(procedure, find_Alkaline_Earth_Metals);
                        break;
                    case "find_Lanthanides_Rare_Earth_Metals":
                        _commands.Add(procedure, find_Lanthanides_Rare_Earth_Metals);
                        break;
                    case "find_Noble_Gases":
                        _commands.Add(procedure, find_Noble_Gases);
                        break;
                    case "find_Nonmetal_Gases_at_Room_Temperature":
                        _commands.Add(procedure, find_Nonmetal_Gases_at_Room_Temperature);
                        break;
                    case "find_Transition_Metals":
                        _commands.Add(procedure, find_Transition_Metals);
                        break;
                    case "find_element_using_atomic_number":
                        _commands.Add(procedure, find_element_using_atomic_number);
                        break;
                    case "find_element_using_symbol":
                        _commands.Add(procedure, find_element_using_symbol);
                        break;
                    case "find_element_using_name":
                        _commands.Add(procedure, find_element_using_name);
                        break;
                    case "view_all_elements":
                        _commands.Add(procedure, view_all_elements);
                        break;
                }

            }
        }



        private void load_Science_Selection_View04()
        {

            Image01_D01.image01(image01);
            image01.Source = File_M02.source[(int)File_Manger02.image_index01.Easy_Callender_page_1];
            Entrys01_D01.Entrys01(entry01);
            border01_D01.border001(border01);
            border01_D01.border002(border02);
            border01_D01.border002(border03);
            border01_D01.border002(border04);
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

            switch (picker01.SelectedIndex)
            {
                case 0:
                    load_default_view01();
                    entry01.Placeholder = "Search Element";

                    break;
                case 1:
                    load_default_view01();
                    entry01.Placeholder = " ";
                    break;
                case 2:
                    load_default_view01();
                    entry01.Placeholder = " ";
                    break;

            }
        }



        private void find_Alkali_Metals()
        {

           label01.Text = MySql_Chemistry_Serv01.find_Alkali_Metals().GetAwaiter().GetResult();
        }
        private void Find_Actinides()
        {
            label01.Text = MySql_Chemistry_Serv01.Find_Actinides().GetAwaiter().GetResult();
        }
        private void find_Alkaline_Earth_Metals()
        {

            label01.Text = MySql_Chemistry_Serv01.find_Alkaline_Earth_Metals().GetAwaiter().GetResult();


        }
        private void find_Lanthanides_Rare_Earth_Metals()
        {
            label01.Text = MySql_Chemistry_Serv01.find_Lanthanides_Rare_Earth_Metals().GetAwaiter().GetResult();
        }
        private void find_Noble_Gases()
        {
            label01.Text = MySql_Chemistry_Serv01.find_Noble_Gases().GetAwaiter().GetResult();
        }
        private void find_Nonmetal_Gases_at_Room_Temperature()
        {
            label01.Text = MySql_Chemistry_Serv01.find_Nonmetal_Gases_at_Room_Temperature().GetAwaiter().GetResult();
        }
        private void find_Transition_Metals()
        {
            label01.Text = MySql_Chemistry_Serv01.find_Transition_Metals().GetAwaiter().GetResult();
        }

        private void find_element_using_atomic_number()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                var res = MySql_Chemistry_Serv01.find_element_using_atomic_number(entry01.Text, out data01[24]);
                if (res == true)
                {
                    label01.Text = data01[24];
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
        private void find_element_using_symbol()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                var res = MySql_Chemistry_Serv01.find_element_using_symbol(entry01.Text, out data01[24]);
                if (res == true)
                {
                    label01.Text = data01[24];
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
        private void find_element_using_name()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                var res = MySql_Chemistry_Serv01.find_element_using_name(entry01.Text, out data01[24]);
                if (res == true)
                {
                    label01.Text = data01[24];
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
        private void view_all_elements()
        {
            label01.Text = MySql_Chemistry_Serv01.view_all_elements();
        }
        private void load_Science_Selection_View03_data()
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



        private void load_Science_Selection_View04_data()
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
            load_Science_Selection_View04_data();
        }
        private async void button02_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button02);
            await button02.Navigation.PushAsync(new Science_Main_View01());
        }
    }
}