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
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQL.SQL_SERVICES.SQL_LANGUAGE_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.LANGUAGE_VIEW.LANGUAGE_MAIN_VIEW;

namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.LANGUAGE_VIEW.LANGUAGE_SELECTION_VIEW
{
    public partial class Language_Selection_View01 : ContentPage
    {
        private static string[] data01 = new string[100];
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static Border01_Default border01_D01 = new Border01_Default();
        private static Image01_Default Image01_D01 = new Image01_Default();
        private static Labels01_Default Labels01_D01 = new Labels01_Default();
        private static Sql_Language_Services01 Sql_Language_S01 = new Sql_Language_Services01();
        private static bool stored_procedure_bool = Sql_Language_S01.view_languge_database_storedprocedures(out data01[50]);
        private static string stored_procedure_string = data01[50];
        private static string[] stored_procedure_array = stored_procedure_string.Split("\n");
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        private static Button_Animation01 Button_A01 = new Button_Animation01();
        private static Picker01_Animation Picker01_A01 = new Picker01_Animation();
        private static Entrys01_Default Entrys01_D01 = new Entrys01_Default();
        private static File_Manger02 File_M02 = new File_Manger02();
        private static Picker01_Default Picker01_D = new Picker01_Default();
        private static Security_Services01 Security_Serv01 = new Security_Services01();


        public Language_Selection_View01()
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
            load_default_view01();
            Image01_D01.image01(image01);
            image01.Source = File_M02.source[(int)File_Manger02.image_index01.Easy_Callender_page_1];
            Entrys01_D01.Entrys01(entry01);
            border01_D01.border001(border01);
            border01_D01.border002(border02);
            border01_D01.border002(border03);
            Picker01_D.picker01(picker01);
            Labels01_D01.label01(label01);
            Labels01_D01.label01(label02);
            Button01_D01.button01(button01);
            Button01_D01.button02(button02);
            button01.Clicked += button01_clicked;
            button02.Clicked += button02_clicked;
            button01.Text = "ok";
            button02.Text = "back";
            picker01.SelectedIndexChanged += Picker01_SelectedIndexChanged;
            picker01.ItemsSource = stored_procedure_array.ToList();
            picker01.Title = "Select";

        }

        private void load_default_view()
        {

            label01.IsVisible = true;
            label02.IsVisible = false;
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible =false;
            entry01.Placeholder = string.Empty;
        }
        private void load_default_view01()
        {

            label01.IsVisible = false;
            label02.IsVisible = false;
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible =true;
            entry01.Placeholder = string.Empty;
        }
        private void load_default_view02()
        {

            label01.IsVisible = true;
            border01.IsVisible = true;
            border02.IsVisible = true;
            border03.IsVisible = true;
            entry01.Placeholder = string.Empty;
        }
        private void Picker01_SelectedIndexChanged(object? sender, EventArgs e)
        {

            switch (stored_procedure_array[picker01.SelectedIndex])
            {
                case "find_code_using_code":
                    load_default_view02();
                    entry01.Placeholder = "code";
                    label02.Text = string.Empty;
                    break;
                case "find_code_using_language":
                    load_default_view02();
                    entry01.Placeholder = "language";
                    label02.Text = string.Empty;
                    break;
                case "find_language_using_code":
                    load_default_view02();
                    entry01.Placeholder = "code";
                    label02.Text = string.Empty;
                    break;
                case "find_language_using_Language":
                    load_default_view02();
                    entry01.Placeholder = "code";
                    label02.Text = string.Empty;
                    break;
                case "insert_language":
                    load_default_view02();
                    label02.Text = string.Empty;
                    break;
                case "view_all_data_from_language_table":
                    load_default_view01();
                    entry01.Placeholder = string.Empty;
                    label02.Text = string.Empty;
                    break;
            }
        }

        private void load_Selection_data01()
        {
            for (int i = 0; i < stored_procedure_array.Length; i++)
            {
                string procedure = stored_procedure_array[i].Trim();
                   switch (stored_procedure_array[picker01.SelectedIndex])
                {
                    case "find_code_using_code":
                        _commands.Add(procedure, find_code_using_code);
                        break;
                    case "find_code_using_language":
                        _commands.Add(procedure, find_code_using_language);
                        break;
                    case "find_language_using_code":
                        _commands.Add(procedure, find_language_using_code);
                        break;
                    case "find_language_using_Language":
                        _commands.Add(procedure, find_language_using_Language);
                        break;
                    case "insert_language":
                        _commands.Add(procedure, insert_language);
                        break;
                    case "view_all_data_from_language_table":
                        _commands.Add(procedure, view_all_data_from_language_table);
                        break;
                    case "view_languge_database_storedprocedures":
                        _commands.Add(procedure, view_languge_database_storedprocedures);
                        break;
                }
            }
        }
        private void find_code_using_code()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Sql_Language_S01.find_code_using_code(entry01.Text, out data01[24]) == true)
                {
                    label01.IsVisible = true;
                    label01.Text = data01[24];
                }
                else
                {
                    label01.Text = data01[24];
                }
            }
            else
            {
                label01.IsVisible = true;
                label01.Text = data01[23];
            }

        }
        private void find_code_using_language()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                if (Sql_Language_S01.find_code_using_language(entry01.Text, out data01[24]) == true)
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
        private void find_language_using_code()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                if (Sql_Language_S01.find_language_using_code(entry01.Text, out data01[24]) == true)
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
        private void find_language_using_Language()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Sql_Language_S01.find_language_using_Language(entry01.Text, out data01[24]) == true)
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
        private void insert_language()
        {

        }
        private void view_all_data_from_language_table()
        {
            if (Sql_Language_S01.view_all_data_from_language_table(out data01[24]) == true)
            {
                label01.Text = data01[24];
            }
            else
            {
                label01.Text = data01[24];
            }
        }
        private void view_languge_database_storedprocedures()
        {
            if (Sql_Language_S01.view_languge_database_storedprocedures(out data01[24]) == true)
            {
                label01.Text = data01[24];
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
            await button02.Navigation.PushAsync(new Language_Main_View01());
        }
    }
}
