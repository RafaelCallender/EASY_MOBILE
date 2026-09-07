using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.LABELS.LABEL_DEFAULTS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BORDER.BORDER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS.ENTRY_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.DATEPICKER.DATEPICKER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BORDER.BORDER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.LABELS.LABEL_DEFAULTS;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQL.SQL_SERVICES.SQL_UPLOAD_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGEBUTTON.IMAGEBUTTON_DEFAULT;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.UPLOAD_VIEW.UPLOAD_MAIN_VIEW;

namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.UPLOAD_VIEW.UPLOAD_SELECTION_VIEW
{
    public partial class Upload_Selection_View01 : ContentPage
    {
        private static string[] data01 = new string[100];
        private static ImageButton01_Default ImageButton01_D01 = new ImageButton01_Default();
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static Border01_Default border01_D01 = new Border01_Default();
        private static Image01_Default Image01_D01 = new Image01_Default();
        private static Labels01_Default Labels01_D01 = new Labels01_Default();
        private static Button_Animation01 Button_A01 = new Button_Animation01();
        private static Picker01_Animation Picker01_A01 = new Picker01_Animation();
        private static Entrys01_Default Entrys01_D01 = new Entrys01_Default();
        private static File_Manger02 File_M02 = new File_Manger02();
        private static int counter01 = 0;
        private static Sql_Upload_Services01 Sql_Upload_S01 = new Sql_Upload_Services01();
        private static List<string> stored = new List<string>();
        private static Picker01_Default Picker01_D = new Picker01_Default();
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static bool statuscheck = false;
        private static bool stored_proccedure_bool = Sql_Upload_S01.view_database_storedprocedures(out data01[50]);
        public static string stored_proccedure_string = data01[50];
        public static string[] stored_proccedure_array = stored_proccedure_string.Split("\n");
        private static int count = 0;
        private static bool status_check = false;
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);

        public Upload_Selection_View01()
        {

            InitializeComponent();

            if (stored_proccedure_bool == true)
            {
                load_Upload_Selection_View01();

            }
            else
            {
                label01.Text = stored_proccedure_string;
            }

        }
        private void load_Selection_data01()
        {
            for (int i = 0; i < stored_proccedure_array.Length; i++)
            {
                string procedure = stored_proccedure_array[i].Trim();
                switch (stored_proccedure_array[int.Parse(data01[4])])
                {

                    case "delete_FilePath_using_FilePath":
                        _commands.Add(procedure, delete_FilePath_using_FilePath);
                        break;
                    case "delete_OriginalName_using_OriginalName":
                        _commands.Add(procedure, delete_OriginalName_using_OriginalName);
                        break;
                    case "delete_StoredName_using_StoredName":
                        _commands.Add(procedure, delete_StoredName_using_StoredName);
                        break;
                    case "delete_Username_using_Username":
                        _commands.Add(procedure, delete_Username_using_Username);
                        break;
                    case "find_OriginalName_using_FilePath":
                        _commands.Add(procedure, find_OriginalName_using_FilePath);
                        break;
                    case "find_OriginalName_using_OriginalName":
                        _commands.Add(procedure, find_OriginalName_using_OriginalName);
                        break;
                    case "find_OriginalName_using_StoredName":
                        _commands.Add(procedure, find_OriginalName_using_StoredName);
                        break;
                    case "find_OriginalName_using_Username":
                        _commands.Add(procedure, find_OriginalName_using_Username);
                        break;
                    case "find_StoredName_using_StoredName":
                        _commands.Add(procedure, find_StoredName_using_StoredName);
                        break;
                    case "find_StoredName_using_Username":
                        _commands.Add(procedure, find_StoredName_using_Username);
                        break;
                    case "find_username_using_FilePath":
                        _commands.Add(procedure, find_username_using_FilePath);
                        break;
                    case "find_username_using_OriginalName":
                        _commands.Add(procedure, find_username_using_OriginalName);
                        break;
                    case "find_username_using_StoredName":
                        _commands.Add(procedure, find_username_using_StoredName);
                        break;
                    case "find_username_using_username":
                        _commands.Add(procedure, find_username_using_username);
                        break;
                    case "insert_data":
                        _commands.Add(procedure, insert_data);
                        break;
                    case "update_OriginalName_using_OriginalName":
                        _commands.Add(procedure, update_OriginalName_using_OriginalName);
                        break;
                    case "update_StoredName_using_StoredName":
                        _commands.Add(procedure, update_StoredName_using_StoredName);
                        break;
                    case "update_username_using_username":
                        _commands.Add(procedure, update_username_using_username);
                        break;

                }
            }
        }


        private void delete_FilePath_using_FilePath()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                if (Sql_Upload_S01.delete_FilePath_using_FilePath(entry01.Text, out data01[25]) == true)
                {
                    label01.IsVisible = true;
                    label01.Text = $"{data01[25]}\n";
                }
                else
                {
                    label01.IsVisible = true;
                    label01.Text = $"{data01[25]}\n";
                }
            }
            else
            {
                label01.IsVisible = true;
                label01.Text = $"{data01[23]}\n";
            }

        }
        private void delete_OriginalName_using_OriginalName()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                if (Sql_Upload_S01.delete_OriginalName_using_OriginalName(entry01.Text, out data01[25]) == true)
                {
                    label01.IsVisible = true;
                    label01.Text = $"{data01[25]}\n";
                }
                else
                {
                    label01.IsVisible = true;
                    label01.Text = $"{data01[25]}\n";
                }
            }
            else
            {
                label01.IsVisible = true;
                label01.Text = $"{data01[23]}\n";
            }

        }
        private void delete_StoredName_using_StoredName()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                if (Sql_Upload_S01.delete_StoredName_using_StoredName(entry01.Text, out data01[25]) == true)
                {
                    label01.IsVisible = true;
                    label01.Text = $"{data01[25]}\n";
                }
                else
                {
                    label01.IsVisible = true;
                    label01.Text = $"{data01[25]}\n";
                }
            }
            else
            {
                label01.IsVisible = true;
                label01.Text = $"{data01[23]}\n";
            }

        }
        private void delete_Username_using_Username()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                if (Sql_Upload_S01.delete_Username_using_Username(entry01.Text, out data01[25]) == true)
                {
                    label01.IsVisible = true;
                    label01.Text = $"{data01[25]}\n";
                }
                else
                {
                    label01.IsVisible = true;
                    label01.Text = $"{data01[25]}\n";
                }
            }
            else
            {
                label01.IsVisible = true;
                label01.Text = $"{data01[23]}\n";
            }

        }
        private void find_OriginalName_using_FilePath()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                if (Sql_Upload_S01.find_OriginalName_using_FilePath(entry01.Text, out data01[25]) == true)
                {
                    label01.IsVisible = true;
                    label01.Text = $"{data01[25]}\n";
                }
                else
                {
                    label01.IsVisible = true;
                    label01.Text = $"{data01[25]}\n";
                }
            }
            else
            {
                label01.IsVisible = true;
                label01.Text = $"{data01[23]}\n";
            }

        }
        private void find_OriginalName_using_OriginalName()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                if (Sql_Upload_S01.find_OriginalName_using_OriginalName(entry01.Text, out data01[25]) == true)
                {
                    label01.IsVisible = true;
                    label01.Text = $"{data01[25]}\n";
                }
                else
                {
                    label01.IsVisible = true;
                    label01.Text = $"{data01[25]}\n";
                }
            }
            else
            {
                label01.IsVisible = true;
                label01.Text = $"{data01[23]}\n";
            }

        }
        private void find_OriginalName_using_StoredName()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                if (Sql_Upload_S01.find_OriginalName_using_StoredName(entry01.Text, out data01[25]) == true)
                {
                    label01.IsVisible = true;
                    label01.Text = $"{data01[25]}\n";
                }
                else
                {
                    label01.IsVisible = true;
                    label01.Text = $"{data01[25]}\n";
                }
            }
            else
            {
                label01.IsVisible = true;
                label01.Text = $"{data01[23]}\n";
            }

        }
        private void find_OriginalName_using_Username()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                if (Sql_Upload_S01.find_OriginalName_using_Username(entry01.Text, out data01[25]) == true)
                {
                    label01.IsVisible = true;
                    label01.Text = $"{data01[25]}\n";
                }
                else
                {
                    label01.IsVisible = true;
                    label01.Text = $"{data01[25]}\n";
                }
            }
            else
            {
                label01.IsVisible = true;
                label01.Text = $"{data01[23]}\n";
            }

        }
        private void find_StoredName_using_StoredName()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                if (Sql_Upload_S01.find_StoredName_using_StoredName(entry01.Text, out data01[25]) == true)
                {
                    label01.IsVisible = true;
                    label01.Text = $"{data01[25]}\n";
                }
                else
                {
                    label01.IsVisible = true;
                    label01.Text = $"{data01[25]}\n";
                }
            }
            else
            {
                label01.IsVisible = true;
                label01.Text = $"{data01[23]}\n";
            }

        }
        private void find_StoredName_using_Username()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                if (Sql_Upload_S01.find_StoredName_using_Username(entry01.Text, out data01[25]) == true)
                {
                    label01.IsVisible = true;
                    label01.Text = $"{data01[25]}\n";
                }
                else
                {
                    label01.IsVisible = true;
                    label01.Text = $"{data01[25]}\n";
                }
            }
            else
            {
                label01.IsVisible = true;
                label01.Text = $"{data01[23]}\n";
            }

        }
        private void find_username_using_FilePath()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                if (Sql_Upload_S01.find_username_using_FilePath(entry01.Text, out data01[25]) == true)
                {
                    label01.IsVisible = true;
                    label01.Text = $"{data01[25]}\n";
                }
                else
                {
                    label01.IsVisible = true;
                    label01.Text = $"{data01[25]}\n";
                }
            }
            else
            {
                label01.IsVisible = true;
                label01.Text = $"{data01[23]}\n";
            }

        }
        private void find_username_using_OriginalName()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                if (Sql_Upload_S01.find_username_using_OriginalName(entry01.Text, out data01[25]) == true)
                {
                    label01.IsVisible = true;
                    label01.Text = $"{data01[25]}\n";
                }
                else
                {
                    label01.IsVisible = true;
                    label01.Text = $"{data01[25]}\n";
                }
            }
            else
            {
                label01.IsVisible = true;
                label01.Text = $"{data01[23]}\n";
            }

        }
        private void find_username_using_StoredName()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                if (Sql_Upload_S01.find_username_using_StoredName(entry01.Text, out data01[25]) == true)
                {
                    label01.IsVisible = true;
                    label01.Text = $"{data01[25]}\n";
                }
                else
                {
                    label01.IsVisible = true;
                    label01.Text = $"{data01[25]}\n";
                }
            }
            else
            {
                label01.IsVisible = true;
                label01.Text = $"{data01[23]}\n";
            }

        }
        private void find_username_using_username()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                if (Sql_Upload_S01.find_username_using_username(entry01.Text, out data01[25]) == true)
                {
                    label01.IsVisible = true;
                    label01.Text = $"{data01[25]}\n";
                }
                else
                {
                    label01.IsVisible = true;
                    label01.Text = $"{data01[25]}\n";
                }
            }
            else
            {
                label01.IsVisible = true;
                label01.Text = $"{data01[23]}\n";
            }

        }
        private void insert_data()
        {

        }
        private void update_OriginalName_using_OriginalName()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                label01.Text = string.Empty;
                counter01++;
            }
            else
            {
                label01.Text = data01[23];
                counter01--;
            }
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                counter01++;
                label01.Text = string.Empty;
            }
            else
            {
                label02.Text = data01[23];
                counter01--;

            }
            if (counter01 == 2)
            {
                if (Sql_Upload_S01.update_OriginalName_using_OriginalName(entry01.Text, entry02.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];
                }
                else
                {
                    label02.Text = data01[25];
                }
            }
            else
            {
                label02.Text = "please check errors";
            }

        }
        private void update_StoredName_using_StoredName()
        {


            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                label01.Text = string.Empty;
                counter01++;
            }
            else
            {
                label01.Text = data01[23];
                counter01--;
            }
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                counter01++;
                label01.Text = string.Empty;
            }
            else
            {
                label02.Text = data01[23];
                counter01--;

            }
            if (counter01 == 2)
            {
                if (Sql_Upload_S01.update_StoredName_using_StoredName(entry01.Text, entry02.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];
                }
                else
                {
                    label02.Text = data01[25];
                }
            }
            else
            {
                label02.Text = "please check errors";
            }

        }
        private void update_username_using_username()
        {


            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                label01.Text = string.Empty;
                counter01++;
            }
            else
            {
                label01.Text = data01[23];
                counter01--;
            }
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                counter01++;
                label01.Text = string.Empty;
            }
            else
            {
                label02.Text = data01[23];
                counter01--;

            }
            if (counter01 == 2)
            {
                if (Sql_Upload_S01.update_username_using_username(entry01.Text, entry02.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];
                }
                else
                {
                    label02.Text = data01[25];
                }
            }
            else
            {
                label02.Text = "please check errors";
            }

        }

        private void load_default_view()
        {
           label01.IsVisible = false;
            label02.IsVisible = false;
            label03.IsVisible = false;
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
            border03.IsVisible = false;
            border04.IsVisible = false;

        }

        private void load_default_view02()
        {
            label01.IsVisible = false;
            label02.IsVisible = false;
            label03.IsVisible = false;
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = false;
            border04.IsVisible = false;

        }
        private void load_Upload_Selection_View01()
        {

            load_default_view();
            Image01_D01.image01(image01);
            image01.Source = File_M02.source[(int)File_Manger02.image_index01.Easy_Callender_page_1];
            imagebutton01.Source = File_M02.source[(int)File_Manger02.image_index01.Easy_Callender_page_1];
            Entrys01_D01.Entrys01(entry01);
            border01_D01.border001(border01);
            border01_D01.border002(border02);
            border01_D01.border002(border03);
            border01_D01.border002(border04);
            Picker01_D.picker01(picker01);
            Labels01_D01.label01(label01);
            Labels01_D01.label01(label02);
            Labels01_D01.label01(label03);
            Button01_D01.button01(button01);
            Button01_D01.button02(button02);
            Button01_D01.button02(button03);
            ImageButton01_D01.ImageButton01(imagebutton01);
            button01.Clicked += button01_clicked;
            button02.Clicked += button02_clicked;
            button03.Clicked += button03_clicked;
            button01.Text = "ok";
            button02.Text = "back";
            button03.Text = "upload";
            picker01.SelectedIndexChanged += Picker01_SelectedIndexChanged;
            picker01.ItemsSource = stored_proccedure_array.ToList();
            picker01.Title = "Select";
        }

        private void Picker01_SelectedIndexChanged(object? sender, EventArgs e)
        {

            switch (picker01.SelectedIndex)
            {
                case 0:
                    load_default_view();
                    entry01.Placeholder = "Username";
                    break;
                case 1:
                    load_default_view();
                    entry01.Placeholder = "Email address";
                    break;
                case 2:
                    load_default_view();
                    entry01.Placeholder = "Username";
                    break;

            }
        }

        private void load_Upload_Selection_View01_data()
        {

            if (Security_Serv01.isPicker_selected(picker01, out data01[24]) == true)
            {
                int selection = picker01.SelectedIndex;
                int stringlength = stored_proccedure_array.Length;
                if (selection >= 0 &&
                    selection < stringlength)
                {
                    string key = stored_proccedure_array[selection].Trim();
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
            load_Upload_Selection_View01_data();
        }
        private async void button02_clicked(object? sender, EventArgs e)
        {
            if (count == 3)
            {
                status_check = true;

            }
            else
            {
                status_check = false;
            }
        }
        private async void button03_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button02);
            await button02.Navigation.PushAsync(new Upload_Main_View01());
        }
    }
}