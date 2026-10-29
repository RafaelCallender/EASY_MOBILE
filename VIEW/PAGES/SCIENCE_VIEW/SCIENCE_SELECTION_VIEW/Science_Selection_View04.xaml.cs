using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BACKGROUND.BACKGROUND_DEFAULT;
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
        private Background_Default01 Background_D01 = new Background_Default01();
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
        private static bool stored_procedure_bool = MySql_Chemistry_Serv01.view_chemistry_database_storedprocedures(out data01[50]);
        private static string stored_procedure_string = data01[50];
        private static string[] stored_procedure_array = stored_procedure_string.Split("\n");
        private static File_Manger02 File_M02 = new File_Manger02();
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        public Science_Selection_View04()
        {
            InitializeComponent();
            load_Selection_View01();

        }


        private void load_default_view01()
        {


            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = false;
            border04.IsVisible = false;
            button01.IsVisible = false;


        }
        private void load_default_view02()
        {


            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = true;
            border04.IsVisible = false;
            button01.IsVisible = true;


        }
        private void load_default_view03()
        {


            border01.IsVisible = true;
            border02.IsVisible = true;
            border03.IsVisible = true;
            border04.IsVisible = false;
            button01.IsVisible = true;


        }
        private void load_default_view04()
        {

            label01.IsVisible = false;
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = true;
            border04.IsVisible = true;
            button01.IsVisible = true;


        }

        private void load_Selection_data01()
        {
            string procedure = stored_procedure_array[picker01.SelectedIndex].Trim();
            switch (procedure)
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



        private void load_Selection_View01()
        {
            if (stored_procedure_bool == true)
            {
                load_default_view02();

            }
            else
            {
                label01.Text = stored_procedure_string;
                load_default_view01();
            }

            Background_D01.background01(this);
            Image01_D01.image01(image01);
            image01.Source = File_M02.source[(int)File_Manger02.image_index01.Easy_Callender_page_1];
            Entrys01_D01.Entrys02(entry01);
            border01_D01.border008(border01);
            border01_D01.border008(border02);
            border01_D01.border008(border03);
            border01_D01.border008(border04);
            Labels01_D01.label04(label01);
            Labels01_D01.label04(label02);
            Labels01_D01.label04(label03);
            Button01_D01.button03(button01);
            Button01_D01.button03(button02);
            button01.Clicked += button01_clicked;
            button02.Clicked += button02_clicked;
            button01.Text = "ok";
            button02.Text = "back";
            picker01.SelectedIndexChanged += Picker01_SelectedIndexChanged;
            picker01.ItemsSource = stored_procedure_array.ToList();
            picker02.ItemsSource = stored_procedure_array.ToList();
            picker01.Title = "Select";
            picker02.Title = "Element Catagory";



        }

        private void Picker01_SelectedIndexChanged(object? sender, EventArgs e)
        {

            switch (stored_procedure_array[picker01.SelectedIndex].Trim())
            {
                case "find_Alkali_Metals":
                    load_default_view01();
                    break;
                case "Find_Actinides":
                    load_default_view01();
                    break;
                case "find_Alkaline_Earth_Metals":
                    load_default_view01();
                    break;
                case "find_Lanthanides_Rare_Earth_Metals":
                    load_default_view01();
                    break;
                case "find_Noble_Gases":
                    load_default_view01();
                    break;
                case "find_Nonmetal_Gases_at_Room_Temperature":
                    load_default_view01();
                    break;
                case "find_Transition_Metals":
                    load_default_view01();
                    break;
                case "find_element_using_atomic_number":
                    load_default_view03();
                    break;
                case "find_element_using_symbol":
                    load_default_view03();
                    break;
                case "find_element_using_name":
                    load_default_view03();
                    break;
                case "view_all_elements":
                    load_default_view01();
                    break;

            }
        }



        private async void find_Alkali_Metals()
        {

            label01.Text = await MySql_Chemistry_Serv01.find_Alkali_Metals();
        }
        private async void Find_Actinides()
        {
            label01.Text = await MySql_Chemistry_Serv01.Find_Actinides();
        }
        private async void find_Alkaline_Earth_Metals()
        {

            label01.Text = await MySql_Chemistry_Serv01.find_Alkaline_Earth_Metals();


        }
        private async void find_Lanthanides_Rare_Earth_Metals()
        {
            label01.Text = await MySql_Chemistry_Serv01.find_Lanthanides_Rare_Earth_Metals();
        }
        private async void find_Noble_Gases()
        {
            label01.Text = await MySql_Chemistry_Serv01.find_Noble_Gases();
        }
        private async void find_Nonmetal_Gases_at_Room_Temperature()
        {
            label01.Text = await MySql_Chemistry_Serv01.find_Nonmetal_Gases_at_Room_Temperature();
        }
        private async void find_Transition_Metals()
        {
            label01.Text = await MySql_Chemistry_Serv01.find_Transition_Metals();
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
                int stringlength = stored_procedure_array.Length;
                if (selection >= 0 &&
                    selection < stringlength)
                {
                    string key = stored_procedure_array[selection].Trim();
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
                    label01.Text = "Invalid selection.";
                }

            }
            else
            {
                label01.Text = data01[24];

            }
        }



        private void load_Selection01()
        {
            if (Security_Serv01.isPicker_selected(picker01, out data01[24]) == true)
            {
                string key = stored_procedure_array[picker01.SelectedIndex].Trim();
                load_Selection_data01();
                if (_commands.TryGetValue(key, out Action action))
                {
                    action();
                    _commands.Clear();
                }
                else
                {
                    label03.Text = $"{key} command not found";
                }
            }
            else
            {
                label03.Text = data01[24];
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
            await button02.Navigation.PushAsync(new Science_Main_View01());
        }
    }
}