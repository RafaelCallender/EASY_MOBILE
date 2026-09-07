using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.LABELS.LABEL_DEFAULTS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_ANIMATION;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.USER_VIEW.USER_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BORDER.BORDER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_SERVICES.MYSQL_USER_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LOCATION.LOCATION_HELPER;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS.ENTRY_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.DATEPICKER.DATEPICKER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BORDER.BORDER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.LABELS.LABEL_DEFAULTS;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;




namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.USER_VIEW.USER_SELECTION_VIEW
{
    public partial class User_Selection_View02 : ContentPage
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
        private static int counter01 = 0;
        private static MySql_User_Services01 MySql_User_S01 = new MySql_User_Services01();
        public static bool stored_proccedure_bool = MySql_User_S01.view_user_database_storedprocedures(out data01[50]);
        public static string stored_proccedure_string = data01[50];
        public static string[] stored_proccedure_array = stored_proccedure_string.Split("\n");
        private static Location_Helper01 Location_H01 = new Location_Helper01();
        private static List<string> stored = new List<string>();
        private static Picker01_Default Picker01_D = new Picker01_Default();
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static DatePicker_Default_01 DatePicker_D01 = new DatePicker_Default_01();
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        private static bool statuscheck = false;
        public User_Selection_View02()
        {

            InitializeComponent();
     
            if (stored_proccedure_bool == true)
            {
                load_Selection_View01();
            }
            else
            {
                load_default_view();
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
                    case "delete_user_using_phonenumber":
                        _commands.Add(procedure, delete_user_using_phonenumber);
                        break;
                    case "delete_user_using_username":
                        _commands.Add(procedure, delete_user_using_username);
                        break;
                    case "find_email_using_email":
                        _commands.Add(procedure, find_email_using_email);
                        break;
                    case "find_email_using_username":
                        _commands.Add(procedure, find_email_using_username);
                        break;
                    case "find_password_using_email":
                        _commands.Add(procedure, find_password_using_email);
                        break;
                    case "find_password_using_username":
                        _commands.Add(procedure, find_password_using_username);
                        break;
                    case "find_phonenumber_using_email":
                        _commands.Add(procedure, find_phonenumber_using_email);
                        break;
                    case "find_phonenumber_using_phonenumber":
                        _commands.Add(procedure, find_phonenumber_using_phonenumber);
                        break;
                    case "find_phonenumber_using_username":
                        _commands.Add(procedure, find_phonenumber_using_username);
                        break;
                    case "find_user_location_using_email":
                        _commands.Add(procedure, find_user_location_using_email);
                        break;
                    case "find_user_location_using_username":
                        _commands.Add(procedure, find_user_location_using_username);
                        break;
                    case "find_username_password":
                        _commands.Add(procedure, find_username_password);
                        break;
                    case "find_username_using_email":
                        _commands.Add(procedure, find_username_using_email);
                        break;
                    case "find_username_using_username":
                        _commands.Add(procedure, find_username_using_username);
                        break;

                    case "insert_text_file_using_username":
                        _commands.Add(procedure, insert_text_file_using_username);
                        break;
                    case "insert_user":
                        _commands.Add(procedure, insert_user);
                        break;
                    case "insert_user_audio_file_using_username":
                        _commands.Add(procedure, insert_user_audio_file_using_username);
                        break;
                    case "insert_user_text_file_using_username":
                        _commands.Add(procedure, insert_user_text_file_using_username);
                        break;
                    case "update_email_using_email":
                        _commands.Add(procedure, update_email_using_email);
                        break;
                    case "update_email_using_username":
                        _commands.Add(procedure, update_email_using_username);
                        break;
                    case "update_password_using_email":
                        _commands.Add(procedure, update_password_using_email);
                        break;
                    case "update_password_using_phonenumber":
                        _commands.Add(procedure, update_password_using_phonenumber);
                        break;
                    case "update_password_using_username":
                        _commands.Add(procedure, update_password_using_username);
                        break;
                    case "update_phonenumber_using_email":
                        _commands.Add(procedure, update_phonenumber_using_email);
                        break;
                    case "update_phonenumber_using_username":
                        _commands.Add(procedure, update_phonenumber_using_username);
                        break;
                    case "update_user_location_using_email":
                        _commands.Add(procedure, update_user_location_using_email);
                        break;
                    case "update_user_location_using_name":
                        _commands.Add(procedure, update_user_location_using_name);
                        break;
                    case "update_user_location_using_phonenumber":
                        _commands.Add(procedure, update_user_location_using_phonenumber);
                        break;
                    case "update_user_location_using_username":
                        _commands.Add(procedure, update_user_location_using_username);
                        break;
                    case "update_username_using_email":
                        _commands.Add(procedure, update_username_using_email);
                        break;
                    case "update_username_using_phonenumber":
                        _commands.Add(procedure, update_username_using_phonenumber);
                        break;
                    case "update_username_using_username":
                        _commands.Add(procedure, update_username_using_username);
                        break;
                    case "user_login":
                        _commands.Add(procedure, user_login);
                        break;
                    case "view_all_emails":
                        _commands.Add(procedure, view_all_emails);
                        break;
                    case "view_all_passwords":
                        _commands.Add(procedure, view_all_passwords);
                        break;
                    case "view_all_phonenumber":
                        _commands.Add(procedure, view_all_phonenumber);
                        break;
                    case "view_all_username":
                        _commands.Add(procedure, view_all_username);
                        break;
                    case "view_user_table":
                        _commands.Add(procedure, view_user_table);
                        break;

                }
            }
        }


        private void delete_user_using_phonenumber()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                if (MySql_User_S01.delete_user_using_phonenumber(entry01.Text, out data01[25]) == true)
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
        private void delete_user_using_username()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                if (MySql_User_S01.delete_user_using_username(entry01.Text, out data01[25]) == true)
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
        private void find_email_using_email()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                if (Security_Serv01.email_check(entry01.Text, out data01[24]) == true)
                {

                    if (MySql_User_S01.find_email_using_email(entry01.Text, out data01[25]) == true)
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
                    label01.Text = $"{data01[24]}\n";

                }
            }
            else
            {
                label01.IsVisible = true;
                label01.Text = $"{data01[23]}\n";
            }

        }
        private void find_email_using_username()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                if (MySql_User_S01.find_email_using_username(entry01.Text, out data01[25]) == true)
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
        private void find_password_using_email()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.email_check(entry01.Text, out data01[24]) == true)
                {
                    if (MySql_User_S01.find_password_using_email(entry01.Text, out data01[25]) == true)
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
                    label01.Text = $"{data01[24]}\n";
                }
            }
            else
            {
                label01.IsVisible = true;
                label01.Text = $"{data01[23]}\n";
            }

        }
        private void find_password_using_username()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                if (MySql_User_S01.find_password_using_username(entry01.Text, out data01[25]) == true)
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
        private void find_phonenumber_using_email()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.email_check(entry01.Text, out data01[24]) == true)
                {

                    if (MySql_User_S01.find_phonenumber_using_email(entry01.Text, out data01[25]) == true)
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
                    label01.Text = $"{data01[24]}\n";
                }
            }
            else
            {
                label01.IsVisible = true;
                label01.Text = $"{data01[23]}\n";
            }

        }
        private void find_phonenumber_using_phonenumber()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.phone_check(entry01.Text, out data01[24]) == true)
                {

                    if (MySql_User_S01.find_user_location_using_username(entry01.Text, out data01[25]) == true)
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
                    label01.Text = $"{data01[24]}\n";
                }
            }
            else
            {
                label01.IsVisible = true;
                label01.Text = $"{data01[23]}\n";
            }

        }
        private void find_phonenumber_using_username()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                if (MySql_User_S01.find_phonenumber_using_username(entry01.Text, out data01[25]) == true)
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
        private void find_user_location_using_email()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.email_check(entry01.Text, out data01[24]) == true)
                {

                    if (MySql_User_S01.find_user_location_using_username(entry01.Text, out data01[25]) == true)
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
                    label01.Text = $"{data01[24]}\n";
                }
            }
            else
            {
                label01.IsVisible = true;
                label01.Text = $"{data01[23]}\n";
            }

        }
        private void find_user_location_using_username()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                if (MySql_User_S01.find_user_location_using_username(entry01.Text, out data01[25]) == true)
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
        private void find_username_password()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                if (MySql_User_S01.find_username_password(entry01.Text, out data01[25]) == true)
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
        private void find_username_using_email()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.empty_string(entry01.Text, out data01[24]) == true)
                {

                    if (MySql_User_S01.find_username_using_email(entry01.Text, out data01[25]) == true)
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
                    label01.Text = $"{data01[24]}\n";
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

                if (MySql_User_S01.find_username_using_username(entry01.Text, out data01[25]) == true)
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
        private void insert_text_file_using_username()
        {
            label01.Text = $"not yet developed\n";
        }
        private void insert_user()
        {
            counter01 = 0;
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_User_S01.find_username_using_username(entry01.Text, out data01[25]) == false)
                {
                    counter01++;
                    label01.IsVisible = false;
                }
                else
                {
                    label01.IsVisible = true;
                    counter01--;
                    label01.Text = $"{data01[23]}\n";
                }

            }
            else
            {
                label01.IsVisible = true;
                counter01--;
                label01.Text = $"{data01[23]}\n";

            }
            if (Security_Serv01.empty_string(entry02.Text, out data01[23]) == true)
            {
                label02.IsVisible = false;
                counter01++;
            }
            else
            {
                label02.IsVisible = true;
                counter01--;
                label04.Text = $"{data01[23]}\n";

            }

            if (Security_Serv01.empty_string(entry03.Text, out data01[23]) == true)
            {
                label03.IsVisible = false;
                counter01++;
            }
            else
            {
                label03.IsVisible = true;
                counter01--;
                label03.Text = $"{data01[23]}\n";

            }
            if (Security_Serv01.empty_string(entry04.Text, out data01[23]) == true)
            {
                label04.IsVisible = false;
                counter01++;
            }
            else
            {
                label04.IsVisible = true;
                counter01--;
                label04.Text = $"{data01[23]}\n";

            }
            if (Security_Serv01.empty_string(entry05.Text, out data01[23]) == true)
            {
                if (Security_Serv01.email_check(entry05.Text, out data01[24]) == true)
                {
                    label05.IsVisible = false;
                    counter01++;



                }
                else
                {
                    label05.IsVisible = true;
                    counter01--;
                    label05.Text = $"{data01[24]}\n";
                }

            }
            else
            {
                label05.IsVisible = true;
                counter01--;
                label05.Text = $"{data01[23]}\n";

            }
            if (Security_Serv01.empty_string(entry06.Text, out data01[22]) == true)
            {
                if (Security_Serv01.phone_check(entry06.Text, out data01[23]) == true)
                {
                    label06.IsVisible = false;
                    counter01++;

                }
                else
                {
                    label06.IsVisible = true;
                    counter01--;
                    label06.Text = $"{data01[23]}\n";
                }
            }
            else
            {
                label06.IsVisible = true;
                counter01--;
                label06.Text = $"{data01[22]}\n";

            }
            if (Security_Serv01.empty_string(entry07.Text, out data01[23]) == true)
            {
                label07.IsVisible = false;
                counter01++;
            }
            else
            {
                label07.IsVisible = true;
                counter01--;
                label07.Text = $"{data01[23]}\n";

            }
            if (Security_Serv01.empty_string(entry08.Text, out data01[23]) == true)
            {
                label08.IsVisible = false;
                counter01++;
            }
            else
            {
                label08.IsVisible = true;
                counter01--;
                label08.Text = $"{data01[23]}\n";

            }
            if (entry08.Text == entry07.Text)
            {
                label08.IsVisible = false;
                counter01++;

            }
            else
            {
                label08.IsVisible = true;
                counter01--;
                label08.Text = $"password does not match\n";
            }
            if (counter01 == 10)
            {
                if (MySql_User_S01.insert_user(entry01.Text, entry02.Text, entry03.Text, entry04.Text, entry05.Text, entry06.Text, entry07.Text, out data01[1]) == true)
                {
                    label09.IsVisible = true;
                    label09.Text += $"{data01[1]}\n";

                }
                else
                {
                    label09.IsVisible = true;
                    label09.Text += $"{data01[1]}\n";
                }
            }
            else
            {
                label09.IsVisible = true;
                label09.Text += $"please fix errors\n";
            }
        }
        private void insert_user_audio_file_using_username()
        {
            label01.Text = $"not yet developed\n";
        }
        private void insert_user_text_file_using_username()
        {
            label01.Text = $"not yet developed\n";
        }
        private void update_email_using_email()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                if (Security_Serv01.email_check(entry01.Text, out data01[23]) == true)
                {
                    label01.Text = string.Empty;
                    counter01++;

                }

                else
                {
                    label01.Text = data01[23];
                    counter01--;
                }
            }
            else
            {
                label01.Text = data01[23];
                counter01--;
            }
            if (Security_Serv01.empty_string(entry02.Text, out data01[23]) == true)
            {
                counter01++;
                label02.Text = string.Empty;
            }
            else
            {
                label02.Text = data01[23];
                counter01--;

            }
            if (counter01 == 2)
            {
                if (MySql_User_S01.update_email_using_email(entry01.Text, entry02.Text, out data01[25]) == true)
                {
                    label02.Text = data01[25];
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
        private void update_email_using_username()
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
                if (MySql_User_S01.update_email_using_username(entry01.Text, entry02.Text, out data01[25]) == true)
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
        private void update_password_using_email()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                if (Security_Serv01.empty_string(entry01.Text, out data01[24]) == true)
                {
                    label01.Text = string.Empty;
                    counter01++;
                }
                else
                {
                    label01.Text = data01[23];
                    counter01--;
                }

            }
            else
            {
                label01.Text = data01[23];
                counter01--;
            }
            if (Security_Serv01.empty_string(entry02.Text, out data01[23]) == true)
            {
                counter01++;
                label02.Text = string.Empty;
            }
            else
            {
                label02.Text = data01[23];
                counter01--;

            }
            if (counter01 == 2)
            {
                if (MySql_User_S01.update_password_using_email(entry01.Text, entry02.Text, out data01[25]) == true)
                {
                    label02.Text = data01[25];
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
        private void update_password_using_phonenumber()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                if (Security_Serv01.phone_check(entry01.Text, out data01[24]) == true)
                {

                    label01.Text = string.Empty;
                    counter01++;
                }
                else
                {

                    label01.Text = data01[24];
                    counter01--;
                }
            }
            else
            {
                label01.Text = data01[23];
                counter01--;
            }
            if (Security_Serv01.empty_string(entry02.Text, out data01[23]) == true)
            {
                counter01++;
                label02.Text = string.Empty;
            }
            else
            {
                label02.Text = data01[23];
                counter01--;

            }
            if (counter01 == 2)
            {
                if (MySql_User_S01.update_password_using_phonenumber(entry01.Text, entry02.Text, out data01[25]) == true)
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
        private void update_password_using_username()
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
            if (Security_Serv01.empty_string(entry02.Text, out data01[23]) == true)
            {
                counter01++;
                label02.Text = string.Empty;
            }
            else
            {
                label02.Text = data01[23];
                counter01--;

            }
            if (counter01 == 2)
            {
                if (MySql_User_S01.update_password_using_username(entry01.Text, entry02.Text, out data01[25]) == true)
                {
                    label02.Text = data01[25];
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
        private void update_phonenumber_using_email()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                if (Security_Serv01.email_check(entry01.Text, out data01[24]) == true)
                {
                    label01.Text = string.Empty;
                    counter01++;
                }
                else
                {
                    label01.Text = data01[24];
                    counter01--;
                }

            }
            else
            {
                label01.Text = data01[23];
                counter01--;
            }
            if (Security_Serv01.empty_string(entry02.Text, out data01[23]) == true)
            {

                if (Security_Serv01.phone_check(entry02.Text, out data01[24]) == true)
                {
                    label02.Text = string.Empty;
                    counter01++;
                }
                else
                {
                    label02.Text = data01[24];
                    counter01--;
                }

            }
            else
            {
                label02.Text = data01[23];
                counter01--;
            }
            if (counter01 == 2)
            {
                if (MySql_User_S01.update_phonenumber_using_email(entry01.Text, entry02.Text, out data01[25]) == true)
                {
                    label02.Text = data01[25];
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
        private void update_phonenumber_using_username()
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
                if (MySql_User_S01.update_phonenumber_using_username(entry01.Text, entry02.Text, out data01[25]) == true)
                {
                    label02.Text = data01[25];
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
        private void update_user_location_using_email()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.empty_string(entry01.Text, out data01[24]) == true)
                {
                    label01.Text = string.Empty;
                    counter01++;
                }
                else
                {
                    label01.Text = data01[24];
                    counter01--;
                }

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
                label01.Text = data01[23];
                counter01--;

            }
            if (counter01 == 2)
            {
                if (MySql_User_S01.update_user_location_using_email(entry01.Text, entry02.Text, out data01[25]) == true)
                {
                    label02.Text = data01[25];
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
        private void update_user_location_using_name()
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
            if (Security_Serv01.empty_string(entry02.Text, out data01[23]) == true)
            {
                counter01++;
                label02.Text = string.Empty;
            }
            else
            {
                label02.Text = data01[23];
                counter01--;

            }
            if (counter01 == 2)
            {
                if (MySql_User_S01.update_user_location_using_name(entry01.Text, entry02.Text, out data01[25]) == true)
                {
                    label02.Text = data01[25];
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
        private void update_user_location_using_phonenumber()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.phone_check(entry01.Text, out data01[24]) == true)
                {
                    label01.Text = string.Empty;
                    counter01++;
                }
                else
                {
                    label01.Text = data01[24];
                    counter01--;
                }
            }
            else
            {
                label01.Text = data01[23];
                counter01--;
            }
            if (Security_Serv01.empty_string(entry02.Text, out data01[23]) == true)
            {
                counter01++;
                label02.Text = string.Empty;
            }
            else
            {
                label02.Text = data01[23];
                counter01--;

            }
            if (counter01 == 2)
            {
                if (MySql_User_S01.update_user_location_using_phonenumber(entry01.Text, entry02.Text, out data01[25]) == true)
                {
                    label02.Text = data01[25];
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
        private void update_user_location_using_username()
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
                label02.Text = string.Empty;
            }
            else
            {
                label02.Text = data01[23];
                counter01--;

            }
            if (counter01 == 2)
            {
                if (MySql_User_S01.update_user_location_using_username(entry01.Text, entry02.Text, out data01[25]) == true)
                {
                    label02.Text = data01[25];
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
        private void update_username_using_email()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.email_check(entry01.Text, out data01[24]) == true)
                {

                    label01.Text = string.Empty;
                    counter01++;
                }
                else
                {
                    label01.Text = data01[24];
                    counter01--;
                }

            }
            else
            {
                label01.Text = data01[23];
                counter01--;
            }
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                counter01++;
                label02.Text = string.Empty;
            }
            else
            {
                label02.Text = data01[23];
                counter01--;

            }
            if (counter01 == 2)
            {
                if (MySql_User_S01.update_username_using_email(entry01.Text, entry02.Text, out data01[25]) == true)
                {
                    label02.Text = data01[25];
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
        private void update_username_using_phonenumber()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                if (Security_Serv01.phone_check(entry01.Text, out data01[23]) == true)
                {
                    label01.Text = string.Empty;
                    counter01++;
                }
                else
                {
                    label01.Text = data01[23];
                    counter01--;
                }

            }
            else
            {
                label01.Text = data01[23];
                counter01--;
            }
            if (Security_Serv01.empty_string(entry02.Text, out data01[23]) == true)
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
                if (MySql_User_S01.update_username_using_phonenumber(entry01.Text, entry02.Text, out data01[25]) == true)
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
            if (Security_Serv01.empty_string(entry02.Text, out data01[23]) == true)
            {
                counter01++;
                label02.Text = string.Empty;
            }
            else
            {
                label02.Text = data01[23];
                counter01--;

            }
            if (counter01 == 2)
            {
                if (MySql_User_S01.update_username_using_username(entry01.Text, entry02.Text, out data01[25]) == true)
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
        private void user_login()
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
            if (Security_Serv01.empty_string(entry02.Text, out data01[23]) == true)
            {
                counter01++;
                label02.Text = string.Empty;
            }
            else
            {
                label02.Text = data01[23];
                counter01--;

            }
            if (counter01 == 2)
            {
                if (MySql_User_S01.user_login(entry01.Text, entry02.Text, out data01[25]) == true)
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
        private void view_all_emails()
        {
           // label01.Text = MySql_User_S01.view_all_emails();
             label01.Text ="needs work";
        }
        private void view_all_passwords()
        {
            label01.Text = MySql_User_S01.view_all_passwords();
        }
        private void view_all_phonenumber()
        {
            label01.Text = MySql_User_S01.view_all_phonenumber();
        }
        private void view_all_username()
        {
            label01.Text = MySql_User_S01.view_all_username();
        }
        private void view_user_table()
        {
            label01.Text = "not yet developed";
        }

        private void load_default_view()
        {
            label01.IsVisible = false;
            label02.IsVisible = false;
            label03.IsVisible = false;
            label04.IsVisible = false;
            label05.IsVisible = false;
            label06.IsVisible = false;
            label07.IsVisible = false;
            label08.IsVisible = false;
            label09.IsVisible = false;
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = false;
            border04.IsVisible = false;
            border05.IsVisible = false;
            border06.IsVisible = false;
            border07.IsVisible = false;
            border08.IsVisible = false;
            border09.IsVisible = false;
            border10.IsVisible = false;
            border11.IsVisible = true;

        }

        private void load_default_view01()
        {
            label01.IsVisible = false;
            label02.IsVisible = false;
            label03.IsVisible = false;
            label04.IsVisible = false;
            label05.IsVisible = false;
            label06.IsVisible = false;
            label07.IsVisible = false;
            label08.IsVisible = false;
            label09.IsVisible = false;
            border01.IsVisible = true;
            border02.IsVisible = true;
            border03.IsVisible = false;
            border04.IsVisible = false;
            border05.IsVisible = false;
            border06.IsVisible = false;
            border07.IsVisible = false;
            border08.IsVisible = false;
            border09.IsVisible = false;
            border10.IsVisible = false;
            border11.IsVisible = true;

        }
        private void load_default_view02()
        {
            label01.IsVisible = false;
            label02.IsVisible = false;
            label03.IsVisible = false;
            label04.IsVisible = false;
            label05.IsVisible = false;
            label06.IsVisible = false;
            label07.IsVisible = false;
            label08.IsVisible = false;
            label09.IsVisible = false;
            border01.IsVisible = true;
            border02.IsVisible = true;
            border03.IsVisible = true;
            border04.IsVisible = false;
            border05.IsVisible = false;
            border06.IsVisible = false;
            border07.IsVisible = false;
            border08.IsVisible = false;
            border09.IsVisible = false;
            border10.IsVisible = false;
            border11.IsVisible = true;

        }
        private void load_default_view03()
        {
            label01.IsVisible = false;
            label02.IsVisible = false;
            label03.IsVisible = false;
            label04.IsVisible = false;
            label05.IsVisible = false;
            label06.IsVisible = false;
            label07.IsVisible = false;
            label08.IsVisible = false;
            label09.IsVisible = false;
            border01.IsVisible = true;
            border02.IsVisible = true;
            border03.IsVisible = true;
            border04.IsVisible = true;
            border05.IsVisible = true;
            border06.IsVisible = true;
            border07.IsVisible = true;
            border08.IsVisible = true;
            border09.IsVisible = true;
            border10.IsVisible = true;
            border11.IsVisible = true;

        }
        private void load_Selection_View01()
        {
            load_default_view();
            Image01_D01.image01(image01);
            image01.Source = File_M02.source[(int)File_Manger02.image_index01.Easy_Callender_page_1];
            Entrys01_D01.Entrys01(entry01);
            Entrys01_D01.Entrys01(entry01);
            Entrys01_D01.Entrys01(entry02);
            Entrys01_D01.Entrys01(entry03);
            Entrys01_D01.Entrys01(entry04);
            Entrys01_D01.Entrys01(entry05);
            Entrys01_D01.Entrys01(entry06);
            Entrys01_D01.Entrys01(entry07);
            Entrys01_D01.Entrys01(entry08);
            border01_D01.border001(border01);
            border01_D01.border002(border02);
            border01_D01.border002(border03);
            border01_D01.border002(border04);
            border01_D01.border002(border05);
            border01_D01.border002(border06);
            border01_D01.border002(border07);
            border01_D01.border002(border08);
            border01_D01.border002(border09);
            border01_D01.border002(border10);
            DatePicker_D01.datepicker01(datepicker01);
            Picker01_D.picker01(picker01);
            Labels01_D01.label01(label02);
            Labels01_D01.label01(label03);
            Labels01_D01.label01(label04);
            Labels01_D01.label01(label05);
            Labels01_D01.label01(label06);
            Labels01_D01.label01(label07);
            Labels01_D01.label01(label08);
            Button01_D01.button01(button01);
            Button01_D01.button02(button02);
            button01.Clicked += button01_clicked;
            button02.Clicked += button02_clicked;
            button01.Text = "ok";
            button02.Text = "back";
            picker01.SelectedIndexChanged += Picker01_SelectedIndexChanged;
            picker01.ItemsSource = stored_proccedure_array.ToList();
            picker01.Title = "Select";
        }

        private void Picker01_SelectedIndexChanged(object? sender, EventArgs e)
        {

            switch (stored_proccedure_array[picker01.SelectedIndex])
            {


                case "delete_user_using_phonenumber":
                    entry01.Placeholder = "phonenumber";
                    load_default_view01();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "delete_user_using_username":
                    entry01.Placeholder = "username";
                    load_default_view01();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "find_email_using_email":
                    entry01.Placeholder = "email";
                    load_default_view01();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "find_email_using_username":
                    entry01.Placeholder = "file path";
                    load_default_view01();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "find_password_using_email":
                    entry01.Placeholder = "file path";
                    load_default_view01();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "find_password_using_username":
                    entry01.Placeholder = "file path";
                    load_default_view01();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "find_phonenumber_using_email":
                    entry01.Placeholder = "file path";
                    load_default_view01();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "find_phonenumber_using_phonenumber":
                    entry01.Placeholder = "file path";
                    load_default_view01();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "find_phonenumber_using_username":
                    entry01.Placeholder = "file path";
                    load_default_view01();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "find_user_location_using_email":
                    entry01.Placeholder = "file path";
                    load_default_view01();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "find_user_location_using_username":
                    entry01.Placeholder = "file path";
                    load_default_view01();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "find_username_password":
                    entry01.Placeholder = "passwor";
                    load_default_view01();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "find_username_using_email":
                    entry01.Placeholder = "email";
                    load_default_view01();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "find_username_using_username":
                    entry01.Placeholder = "username";
                    load_default_view01();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "find_usernmae_using_username":
                    entry01.Placeholder = "username";
                    load_default_view01();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "insert_text_file_using_username":
                    entry01.Placeholder = "usersname";
                    entry02.Placeholder = "file path";
                    load_default_view02();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "insert_user":
                    load_default_view03();
                    label03.Text = string.Empty;
                    break;
                case "insert_user_audio_file_using_username":
                    load_default_view02();
                    entry01.Placeholder = "usersname";
                    entry02.Placeholder = " file path";
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "insert_user_text_file_using_username":
                    load_default_view02();
                    entry01.Placeholder = " usersname";
                    entry02.Placeholder = " file path";
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "update_email_using_email":
                    load_default_view02();
                    entry01.Placeholder = "phonenumber";
                    entry02.Placeholder = "new usersname";
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "update_email_using_username":
                    load_default_view02();
                    entry01.Placeholder = "phonenumber";
                    entry02.Placeholder = "new usersname";
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "update_password_using_email":
                    load_default_view02();
                    entry01.Placeholder = "phonenumber";
                    entry02.Placeholder = "new usersname";
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "update_password_using_phonenumber":
                    load_default_view02();
                    entry01.Placeholder = "phonenumber";
                    entry02.Placeholder = "new usersname";
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "update_password_using_username":
                    load_default_view02();
                    entry01.Placeholder = "phonenumber";
                    entry02.Placeholder = "new usersname";
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "update_phonenumber_using_email":
                    load_default_view02();
                    entry01.Placeholder = "phonenumber";
                    entry02.Placeholder = "new usersname";
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "update_phonenumber_using_username":
                    load_default_view02();
                    entry01.Placeholder = "phonenumber";
                    entry02.Placeholder = "new usersname";
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "update_user_location_using_email":
                    load_default_view02();
                    entry01.Placeholder = "phonenumber";
                    entry02.Placeholder = "new usersname";
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "update_user_location_using_name":
                    load_default_view02();
                    entry01.Placeholder = "name";
                    entry02.Placeholder = "new location";
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "update_user_location_using_phonenumber":
                    load_default_view02();
                    entry01.Placeholder = "phonenumber";
                    entry02.Placeholder = "new location";
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "update_user_location_using_username":
                    load_default_view02();
                    entry01.Placeholder = "username";
                    entry02.Placeholder = "new location";
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "update_username_using_email":
                    load_default_view02();
                    entry01.Placeholder = "email";
                    entry02.Placeholder = "new usersname";
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "update_username_using_phonenumber":
                    load_default_view02();
                    entry01.Placeholder = "phonenumber";
                    entry02.Placeholder = "new usersname";
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "update_username_using_username":
                    load_default_view02();
                    entry01.Placeholder = "username";
                    entry02.Placeholder = "new usersname";
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "user_login":
                    load_default_view02();
                    entry01.Placeholder = "username";
                    entry02.Placeholder = "password";
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "view_all_emails":
                    load_default_view();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "view_all_passwords":
                    load_default_view();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "view_all_phonenumber":
                    load_default_view();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "view_all_username":
                    load_default_view();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
                case "view_user_table":
                    load_default_view();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    label03.Text = string.Empty;
                    label04.Text = string.Empty;
                    label05.Text = string.Empty;
                    label06.Text = string.Empty;
                    label07.Text = string.Empty;
                    label08.Text = string.Empty;
                    label09.Text = string.Empty;
                    break;
            }
        }

        private void load_Selection01()
        {
            if (Security_Serv01.isPicker_selected(picker01, out data01[24]) == true)
            {
                string key = stored_proccedure_array[picker01.SelectedIndex].Trim();
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
            await button02.Navigation.PushAsync(new User_Main_View01());
        }
    }
}