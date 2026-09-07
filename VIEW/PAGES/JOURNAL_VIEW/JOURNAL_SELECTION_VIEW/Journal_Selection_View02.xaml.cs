
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.LABELS.LABEL_DEFAULTS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_ANIMATION;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.JOURNAL_VIEW.JOURNAL_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BORDER.BORDER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS.ENTRY_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_SERVICES.MYSQL_JOURNAL_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;

namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.JOURNAL_VIEW.JOURNAL_SELECTION_VIEW
{
    public partial class Journal_Selection_View02 : ContentPage
    {
        private static string[] data01 = new string[100];
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static Border01_Default border01_D01 = new Border01_Default();
        private static Image01_Default Image01_D01 = new Image01_Default();
        private static Labels01_Default Labels01_D01 = new Labels01_Default();
        private static Button_Animation01 Button_A01 = new Button_Animation01();
        private static Picker01_Animation Picker01_A01 = new Picker01_Animation();
        private static Entrys01_Default Entrys01_D01 = new Entrys01_Default();
        private static File_Manger02 File_M02 = new File_Manger02();
        private static MySql_Journal_Services01 MySql_Journal_S01 = new MySql_Journal_Services01();
        private static bool stored_procedure_bool = MySql_Journal_S01.view_journal_database_storedprocedures(out data01[50]);
        private static string stored_procedure_string = data01[50];
        private static string[] stored_procedure_array = stored_procedure_string.Split("\n");
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        private static Security_Services01 Security_Serv01 = new Security_Services01();

        public Journal_Selection_View02()
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
        private void load_default_view()
        {
            label01.IsVisible = false;
            label02.IsVisible = false;
            border01.IsVisible = false;
            border02.IsVisible = true;
            border03.IsVisible = true;
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
            picker01.ItemsSource = stored_procedure_array.ToList();
            picker01.Title = "Select";
        }

        private void Picker01_SelectedIndexChanged(object? sender, EventArgs e)
        {

            switch (stored_procedure_array[picker01.SelectedIndex])
            {
                case "find_message_using_message":
                    load_default_view();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    break;
                case "find_message_using_upload":
                    load_default_view();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    break;
                case "find_message_using_username":
                    load_default_view();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    break;
                case "find_upload_using_message":
                    load_default_view();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    break;
                case "find_upload_using_upload":
                    load_default_view();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    break;
                case "find_upload_using_username":
                    load_default_view();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    break;
                case "find_username_using_message":
                    load_default_view();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    break;
                case "find_username_using_upload":
                    load_default_view();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    break;
                case "find_username_using_username":
                    load_default_view();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    break;
                case "insert_journal":
                    load_default_view();
                    label01.Text = string.Empty;
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
                    case "insert_journal":
                        _commands.Add(procedure, insert_journal);
                        break;
                    case "find_message_using_message":
                        _commands.Add(procedure, find_message_using_message);
                        break;
                    case "find_message_using_upload":
                        _commands.Add(procedure, find_message_using_upload);
                        break;
                    case "find_message_using_username":
                        _commands.Add(procedure, find_message_using_username);
                        break;
                    case "find_upload_using_message":
                        _commands.Add(procedure, find_upload_using_message);
                        break;
                    case "find_upload_using_upload":
                        _commands.Add(procedure, find_upload_using_upload);
                        break;
                    case "find_upload_using_username":
                        _commands.Add(procedure, find_upload_using_username);
                        break;
                    case "find_username_using_message":
                        _commands.Add(procedure, find_username_using_message);
                        break;
                    case "find_username_using_upload":
                        _commands.Add(procedure, find_username_using_upload);
                        break;
                    case "find_username_using_username":
                        _commands.Add(procedure, find_username_using_username);
                        break;

                }
            }
        }

        private void insert_journal()
        {
            label01.Text = $"not yet developed \n";
        }

        private void find_message_using_message()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Journal_S01.find_message_using_message(entry01.Text, out data01[24]) == true)
                {
                    label02.Text = data01[24];
                }
                else
                {
                    label02.Text = data01[24];
                }
            }
            else
            {
                label02.Text = data01[23];
            }

        }
        private void find_message_using_upload()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Journal_S01.find_message_using_upload(entry01.Text, out data01[24]) == true)
                {
                    label02.Text = data01[24];
                }
                else
                {
                    label02.Text = data01[24];
                }
            }
            else
            {
                label02.Text = data01[23];
            }

        }
        private void find_message_using_username()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Journal_S01.find_message_using_username(entry01.Text, out data01[24]) == true)
                {
                    label02.Text = data01[24];
                }
                else
                {
                    label02.Text = data01[24];
                }
            }
            else
            {
                label02.Text = data01[23];
            }

        }
        private void find_upload_using_message()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Journal_S01.find_upload_using_message(entry01.Text, out data01[24]) == true)
                {
                    label02.Text = data01[24];
                }
                else
                {
                    label02.Text = data01[24];
                }
            }
            else
            {
                label02.Text = data01[23];
            }
        }
        private void find_upload_using_upload()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Journal_S01.find_upload_using_upload(entry01.Text, out data01[24]) == true)
                {
                    label02.Text = data01[24];
                }
                else
                {
                    label02.Text = data01[24];
                }
            }
            else
            {
                label02.Text = data01[23];
            }

        }
        private void find_upload_using_username()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Journal_S01.find_upload_using_username(entry01.Text, out data01[24]) == true)
                {
                    label02.Text = data01[24];
                }
                else
                {
                    label02.Text = data01[24];
                }
            }
            else
            {
                label02.Text = data01[23];
            }

        }
        private void find_username_using_message()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Journal_S01.find_username_using_message(entry01.Text, out data01[24]) == true)
                {
                    label02.Text = data01[24];
                }
                else
                {
                    label02.Text = data01[24];
                }
            }
            else
            {
                label02.Text = data01[23];
            }

        }
        private void find_username_using_upload()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                label02.Text = "not yet developed";

            }
            else
            {
                label02.Text = data01[23];
            }

        }
        private void find_username_using_username()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Journal_S01.find_username_using_username(entry01.Text, out data01[24]) == true)
                {
                    label02.Text = data01[24];
                }
                else
                {
                    label02.Text = data01[24];
                }
            }
            else
            {
                label02.Text = data01[23];
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
            await button02.Navigation.PushAsync(new Journal_Main_View01());
        }
    }
}