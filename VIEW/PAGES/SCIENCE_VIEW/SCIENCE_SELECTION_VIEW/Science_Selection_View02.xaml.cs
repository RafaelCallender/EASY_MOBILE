using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.LABELS.LABEL_DEFAULTS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_ANIMATION;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.SCIENCE_VIEW.SCIENCE_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BORDER.BORDER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQL.SQL_SERVICES.SQL_SCIENCE_SERVICES.SQL_CHEMISTRY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SCIENCE_SERVICES.CHEMISTRY.CHEMISTRY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SCIENCE_SERVICES.CHEMISTRY.CHEMISTRY_HELPER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS.ENTRY_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;

namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.SCIENCE_VIEW.SCIENCE_SELECTION_VIEW
{
    public partial class Science_Selection_View02 : ContentPage
    {
        private static string[] data01 = new string[100];
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static Image01_Default Image01_D01 = new Image01_Default();

        private static Labels01_Default Labels01_D01 = new Labels01_Default();
        private static Chemistry_Services02 Chemistry_Serv02 = new Chemistry_Services02();
        private static Chemistry_Helper01 Chemistry_H01 = new Chemistry_Helper01();
        private static int count = 0;
        private static Sql_Chemistry_Services01 Sql_Chemistry_Serv01 = new Sql_Chemistry_Services01();
        private static bool stored_procedure_bool = Sql_Chemistry_Serv01.view_chemistry_database_storedprocedures(out data01[50]);
        private static string stored_procedure_string = data01[50];
        private static string[] stored_procedure_array = stored_procedure_string.Split("\n");
        private static Button_Animation01 Button_A01 = new Button_Animation01();
        private static Picker01_Animation Picker01_A01 = new Picker01_Animation();
        private static Entrys01_Default Entrys01_D01 = new Entrys01_Default();
        private static Border01_Default border01_D01 = new Border01_Default();
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        private static File_Manger02 File_M02 = new File_Manger02();
        public Science_Selection_View02()

        {
            InitializeComponent();
            if (stored_procedure_bool == true)
            {
                load_Selection_View01();

            }
            else
            {
                load_default_view();
                label01.Text = stored_procedure_string;
            }
        }
        private void load_Selection_View01()
        {
            Image01_D01.image01(image01);
            image01.Source = File_M02.source[(int)File_Manger02.image_index01.Easy_Callender_page_1];
            Entrys01_D01.Entrys01(entry01);
            border01_D01.border001(border01);
            border01_D01.border002(border02);
            border01_D01.border002(border03);
            border01_D01.border002(border04);
            Labels01_D01.label02(label01);
            Labels01_D01.label02(label02);
            Labels01_D01.label02(label03);
            Button01_D01.button01(button01);
            Button01_D01.button02(button02);
            button01.Clicked += button01_clicked;
            button02.Clicked += button02_clicked;
            button01.Text = "ok";
            button02.Text = "back";
            picker01.SelectedIndexChanged += Picker01_SelectedIndexChanged;
            picker01.ItemsSource = stored_procedure_array.ToList();
            picker02.ItemsSource = Chemistry_H01.data_array.ToList();
            picker01.Title = "Select";
            picker02.Title = "Element Catagory";
        }

        private void load_Selection_data01()
        {
            for (int i = 0; i < stored_procedure_array.Length; i++)
            {
                string procedure = stored_procedure_array[i].Trim();
                switch (stored_procedure_array[int.Parse(data01[4])])
                {
                    case "Find_Actinides":
                        _commands.Add(procedure, Find_Actinides);
                        break;
                    case "find_Alkaline_Earth_Metals":
                        _commands.Add(procedure, find_Alkaline_Earth_Metals);
                        break;
                    case "find_element_using_atomic_number":
                        _commands.Add(procedure, find_element_using_atomic_number);
                        break;
                    case "find_element_using_name":
                        _commands.Add(procedure, find_element_using_name);
                        break;
                    case "find_element_using_symbol":
                        _commands.Add(procedure, find_element_using_symbol);
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
                    case "insert_catagory_type":
                        _commands.Add(procedure, insert_catagory_type);
                        break;
                    case "insert_element":
                        _commands.Add(procedure, insert_element);
                        break;
                    case "view_all_elements":
                        _commands.Add(procedure, view_all_elements);
                        break;
                    case "view_catagory_type":
                        _commands.Add(procedure, view_catagory_type);
                        break;
                }
            }
        }



        private void Find_Actinides()
        {
            if (Security_Serv01.isPicker_selected(picker02, out data01[23]) == true)
            {
                if (Sql_Chemistry_Serv01.Find_Actinides(out data01[24]) == true)
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
        private void find_Alkaline_Earth_Metals()
        {
            if (Security_Serv01.isPicker_selected(picker02, out data01[23]) == true)
            {
                if (Sql_Chemistry_Serv01.find_Alkaline_Earth_Metals(out data01[24]) == true)
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
        private void find_element_using_atomic_number()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Sql_Chemistry_Serv01.find_element_using_atomic_number(entry01.Text,out data01[24]) == true)
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
                if (Sql_Chemistry_Serv01.find_element_using_name(entry01.Text,out data01[24]) == true)
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
                if (Sql_Chemistry_Serv01.find_element_using_symbol(entry01.Text,out data01[24]) == true)
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
        private void find_Lanthanides_Rare_Earth_Metals()
        {
            if (Security_Serv01.isPicker_selected(picker02, out data01[23]) == true)
            {
                if (Sql_Chemistry_Serv01.find_Lanthanides_Rare_Earth_Metals(out data01[24]) == true)
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
        private void find_Noble_Gases()
        {
            if (Security_Serv01.isPicker_selected(picker02, out data01[23]) == true)
            {
                if (Sql_Chemistry_Serv01.find_Noble_Gases(out data01[24]) == true)
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
        private void find_Nonmetal_Gases_at_Room_Temperature()
        {
            if (Security_Serv01.isPicker_selected(picker02, out data01[23]) == true)
            {
                if (Sql_Chemistry_Serv01.find_Nonmetal_Gases_at_Room_Temperature(out data01[24]) == true)
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
        private void find_Transition_Metals()
        {
            if (Security_Serv01.isPicker_selected(picker02, out data01[23]) == true)
            {
                if (Sql_Chemistry_Serv01.find_Transition_Metals(out data01[24]) == true)
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
        private void insert_catagory_type()
        {

        }
        private void insert_element()
        {

        }
        private void view_all_elements()
        {

        }
        private void view_catagory_type()
        {

        }

        private void load_default_view()
        {
            label01.IsVisible = false;
            label02.IsVisible = false;
            label03.IsVisible = true;
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = false;
            border04.IsVisible = false;

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
        }
        private void load_default_view02()
        {
            label01.IsVisible = false;
            label02.IsVisible = false;
            label03.IsVisible = true;
            border01.IsVisible = true;
            border02.IsVisible = true;
            border03.IsVisible = true;
            border04.IsVisible = false;

        }
        private void Picker01_SelectedIndexChanged(object? sender, EventArgs e)
        {
            switch (stored_procedure_array[picker01.SelectedIndex])
            {
                case "Find_Actinides":
                    load_default_view01();
                    entry01.Placeholder = "element name";
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.IsVisible = true;
                    break;
                case "find_Alkaline_Earth_Metals":
                    load_default_view01();
                    entry01.Placeholder = "element name";
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.IsVisible = true;
                    break;
                case "find_element_using_atomic_number":
                    load_default_view02();
                    entry01.Placeholder = "element name";
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.IsVisible = true;
                    break;
                case "find_element_using_name":
                    load_default_view02();
                    entry01.Placeholder = "element name";
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.IsVisible = true;
                    break;
                case "find_element_using_symbol":
                    load_default_view02();
                    entry01.Placeholder = "element name";
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.IsVisible = true;
                    break;
                case "find_Lanthanides_Rare_Earth_Metals":
                    load_default_view01();
                    entry01.Placeholder = "element name";
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.IsVisible = true;
                    break;
                case "find_Noble_Gases":
                    load_default_view01();
                    entry01.Placeholder = "element name";
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.IsVisible = true;
                    break;
                case "find_Nonmetal_Gases_at_Room_Temperature":
                    load_default_view01();
                    entry01.Placeholder = "element name";
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.IsVisible = true;
                    break;
                case "find_Transition_Metals":
                    load_default_view01();
                    entry01.Placeholder = "element name";
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.IsVisible = true;
                    break;
                case "insert_catagory_type":
                    load_default_view01();
                    entry01.Placeholder = "element name";
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.IsVisible = true;
                    break;
                case "insert_element":
                    load_default_view01();
                    entry01.Placeholder = "element name";
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.IsVisible = true;
                    break;
                case "view_all_elements":
                    load_default_view02();
                    entry01.Placeholder = "element name";
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.IsVisible = true;
                    break;
                case "view_catagory_type":
                    load_default_view02();
                    entry01.Placeholder = "element name";
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.IsVisible = true;
                    break;
                default:
                    load_default_view01();
                    entry01.Placeholder = string.Empty;
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.IsVisible = false;
                    break;
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