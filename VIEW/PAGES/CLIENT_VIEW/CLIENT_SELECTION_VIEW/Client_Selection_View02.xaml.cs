using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.CLIENT_VIEW.CLIENT_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQL.SQL_SERVICES.SQL_CLIENTS_SERVICES;
using System;
using System.Text;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.LABELS.LABEL_DEFAULTS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_ANIMATION;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.SELECTION_VIEW.SELECTION_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BORDER.BORDER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS.ENTRY_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_HELPER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILE_SERVICES.FILE_PICKER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.COLORS.COLORS_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.MODEL.CLIENT_MODEL;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_SERVICES.MYSQL_CLIENTS_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;

namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.CLIENT_VIEW.CLIENT_SELECTION_VIEW
{
    public partial class Client_Selection_View02:ContentPage
    {
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static string[] data01 = new string[100];
        private static Border01_Default border01_D01 = new Border01_Default();
        private static Image01_Default Image01_D01 = new Image01_Default();
        private static Labels01_Default Labels01_D01 = new Labels01_Default();
        private static int count = 0;
        private static bool status_check = false;
        private static MySql_Client_Services01 MySql_Client_S01 = new MySql_Client_Services01();
        private static bool stored_procedure_bool = MySql_Client_S01.view_client_database_storedprocedures(out data01[50]);
        private static string stored_procedure_string = data01[50];
        private static string[] stored_procedure_array = stored_procedure_string.Split("\n");
           private static string menu_string =
                $"client name\n" +
            $"client emailaddress\n" +
            $"client_phonenumber\n" +
            $"client api key\n" +
            $"client cashappdata01\n" +
            $"client zelleappdata01\n" +
            $"client venmoappdata01\n" +
            $"client paypalappdata01\n" +
    $"client logo\n" +
        $"client primary color\n" +
        $"client secondary color\n" +
            $"client tertiary color\n" +
            $"client social media\n" +
        $"client type\n";
        private static string[] menu_array = menu_string.Split("\n");
        private static Client_Model01 Client_M01 = new Client_Model01();
        private static Colors_Services01 Colors_S01 = new Colors_Services01();
        private string types = string.Empty;
        private int counter01 = 0;
        private static Button_Animation01 Button_A01 = new Button_Animation01();
        private static Picker01_Animation Picker01_A01 = new Picker01_Animation();
        private static Entrys01_Default Entrys01_D01 = new Entrys01_Default();
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static File_Manger02 File_M02 = new File_Manger02();
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);

        public Client_Selection_View02()
        {

            InitializeComponent();
            if (stored_procedure_bool == true)
            {
                load_Selection_View01();
            }
            else
            {
                load_default_view01();
                label01.Text = stored_procedure_string;
            }

        }

        private void load_Selection_data01()
        {
            for (int i = 0; i < stored_procedure_array.Length; i++)
            {
                string procedure = stored_procedure_array[i].Trim();
                switch (stored_procedure_array[picker01.SelectedIndex])
                {
                    case "delete_client_using_name":
                        _commands.Add(procedure, delete_client_using_name);
                        break;
                    case "delete_client_using_phonenumber":
                        _commands.Add(procedure, delete_client_using_phonenumber);
                        break;
                    case "find_client_api_key_by_emailaddress":
                        _commands.
                        Add(procedure, find_client_api_key_by_emailaddress);
                        break;
                    case "find_client_api_key_by_name":
                        _commands.Add(procedure, find_client_api_key_by_name);
                        break;
                    case "find_client_api_key_by_phonnumeber":
                        _commands.Add(procedure, find_client_api_key_by_phonnumeber);
                        break;
                    case "find_client_apikey_by_apikey":
                        _commands.Add(procedure, find_client_apikey_by_apikey);
                        break;
                    case "find_client_apikey_by_cashappdata01":
                        _commands.Add(procedure, find_client_apikey_by_cashappdata01);
                        break;
                    case "find_client_apikey_by_venmoappdata01":
                        _commands.Add(procedure, find_client_apikey_by_venmoappdata01);
                        break;
                    case "find_client_cashappdata01_by_apikey":
                        _commands.Add(procedure, find_client_cashappdata01_by_apikey);
                        break;
                    case "find_client_cashappdata01_by_cashappdata01":
                        _commands.Add(procedure, find_client_cashappdata01_by_cashappdata01);
                        break;
                    case "find_client_cashappdata01_by_emailaddress":
                        _commands.Add(procedure, find_client_cashappdata01_by_emailaddress);
                        break;
                    case "find_client_cashappdata01_by_name":
                        _commands.Add(procedure, find_client_cashappdata01_by_name);
                        break;
                    case "find_client_cashappdata01_by_paypalappdata01":
                        _commands.Add(procedure, find_client_cashappdata01_by_paypalappdata01);
                        break;
                    case "find_client_cashappdata01_by_phonnumeber":
                        _commands.Add(procedure, find_client_cashappdata01_by_phonnumeber);
                        break;
                    case "find_client_cashappdata01_by_venmoappdata01":
                        _commands.Add(procedure, find_client_cashappdata01_by_venmoappdata01);
                        break;
                    case "find_client_colors_using_emailaddress":
                        _commands.Add(procedure, find_client_colors_using_emailaddress);
                        break;
                    case "find_client_colors_using_name":
                        _commands.Add(procedure, find_client_colors_using_name);
                        break;
                    case "find_client_colors_using_phonenumber":
                        _commands.Add(procedure, find_client_colors_using_phonenumber);
                        break;
                    case "find_client_data_using_email":
                        _commands.Add(procedure, find_client_data_using_email);
                        break;
                    case "find_client_data_using_latitude_and_longitude":
                        _commands.Add(procedure, find_client_data_using_latitude_and_longitude);
                        break;
                    case "find_client_data_using_logo":
                        _commands.Add(procedure, find_client_data_using_logo);
                        break;
                    case "find_client_data_using_name":
                        _commands.Add(procedure, find_client_data_using_name);
                        break;
                    case "find_client_data_using_number":
                        _commands.Add(procedure, find_client_data_using_number);
                        break;
                    case "find_client_emailaddress_by_apikey":
                        _commands.Add(procedure, find_client_emailaddress_by_apikey);
                        break;
                    case "find_client_emailaddress_by_cashappdata01":
                        _commands.Add(procedure, find_client_emailaddress_by_cashappdata01);
                        break;
                    case "find_client_emailaddress_by_emailaddress":
                        _commands.Add(procedure, find_client_emailaddress_by_emailaddress);
                        break;
                    case "find_client_emailaddress_by_name":
                        _commands.Add(procedure, find_client_emailaddress_by_name);
                        break;
                    case "find_client_emailaddress_by_paypalappdata01":
                        _commands.Add(procedure, find_client_emailaddress_by_paypalappdata01);
                        break;
                    case "find_client_emailaddress_by_phonnumeber":
                        _commands.Add(procedure, find_client_emailaddress_by_phonnumeber);
                        break;
                    case "find_client_emailaddress_by_venmoappdata01":
                        _commands.Add(procedure, find_client_emailaddress_by_venmoappdata01);
                        break;
                    case "find_client_location_using_emailaddress":
                        _commands.Add(procedure, find_client_location_using_emailaddress);
                        break;
                    case "find_client_location_using_name":
                        _commands.Add(procedure, find_client_location_using_name);
                        break;
                    case "find_client_location_using_phonenumber":
                        _commands.Add(procedure, find_client_location_using_phonenumber);
                        break;
                    case "find_client_logo_by_emailaddress":
                        _commands.Add(procedure, find_client_logo_by_emailaddress);
                        break;
                    case "find_client_logo_by_logo":
                        _commands.Add(procedure, find_client_logo_by_logo);
                        break;
                    case "find_client_logo_by_name":
                        _commands.Add(procedure, find_client_logo_by_name);
                        break;
                    case "find_client_logo_by_phonenumber":
                        _commands.Add(procedure, find_client_logo_by_phonenumber);
                        break;
                    case "find_client_name_by_cashappdata01":
                        _commands.Add(procedure, find_client_name_by_cashappdata01);
                        break;
                    case "find_client_name_by_emailaddress":
                        _commands.Add(procedure, find_client_name_by_emailaddress);
                        break;
                    case "find_client_name_by_name":
                        _commands.Add(procedure, find_client_name_by_name);
                        break;
                    case "find_client_name_by_paypalappdata01":
                        _commands.Add(procedure, find_client_name_by_paypalappdata01);
                        break;
                    case "find_client_name_by_phonnumeber":
                        _commands.Add(procedure, find_client_name_by_phonnumeber);
                        break;
                    case "find_client_name_by_venmoappdata01":
                        _commands.Add(procedure, find_client_name_by_venmoappdata01);
                        break;
                    case "find_client_paypalappdata01_by_apikey":
                        _commands.Add(procedure, find_client_paypalappdata01_by_apikey);
                        break;
                    case "find_client_paypalappdata01_by_cashappdata01":
                        _commands.Add(procedure, find_client_paypalappdata01_by_cashappdata01);
                        break;
                    case "find_client_paypalappdata01_by_emailaddress":
                        _commands.Add(procedure, find_client_paypalappdata01_by_emailaddress);
                        break;
                    case "find_client_paypalappdata01_by_name":
                        _commands.Add(procedure, find_client_paypalappdata01_by_name);
                        break;
                    case "find_client_paypalappdata01_by_paypalappdata01":
                        _commands.Add(procedure, find_client_paypalappdata01_by_paypalappdata01);
                        break;
                    case "find_client_paypalappdata01_by_phonnumeber":
                        _commands.Add(procedure, find_client_paypalappdata01_by_phonnumeber);
                        break;
                    case "find_client_paypalappdata01_by_venmoappdata01":
                        _commands.Add(procedure, find_client_paypalappdata01_by_venmoappdata01);
                        break;
                    case "find_client_phonenumber_by_apikey":
                        _commands.Add(procedure, find_client_phonenumber_by_apikey);
                        break;
                    case "find_client_phonenumber_by_cashappdata01":
                        _commands.Add(procedure, find_client_phonenumber_by_cashappdata01);
                        break;
                    case "find_client_phonenumber_by_emailaddress":
                        _commands.Add(procedure, find_client_phonenumber_by_emailaddress);
                        break;
                    case "find_client_phonenumber_by_name":
                        _commands.Add(procedure, find_client_phonenumber_by_name);
                        break;
                    case "find_client_phonenumber_by_paypalappdata01":
                        _commands.Add(procedure, find_client_phonenumber_by_paypalappdata01);
                        break;
                    case "find_client_phonenumber_by_phonnumeber":
                        _commands.Add(procedure, find_client_phonenumber_by_phonnumeber);
                        break;
                    case "find_client_phonenumber_by_venmoappdata01":
                        _commands.Add(procedure, find_client_phonenumber_by_venmoappdata01);
                        break;
                    case "find_client_venmoappdata01_by_apikey":
                        _commands.Add(procedure, find_client_venmoappdata01_by_apikey);
                        break;
                    case "find_client_venmoappdata01_by_cashappdata01":
                        _commands.Add(procedure, find_client_venmoappdata01_by_cashappdata01);
                        break;
                    case "find_client_venmoappdata01_by_emailaddress":
                        _commands.Add(procedure, find_client_venmoappdata01_by_emailaddress);
                        break;
                    case "find_client_venmoappdata01_by_name":
                        _commands.Add(procedure, find_client_venmoappdata01_by_name);
                        break;
                    case "find_client_venmoappdata01_by_paypalappdata01":
                        _commands.Add(procedure, find_client_venmoappdata01_by_paypalappdata01);
                        break;
                    case "find_client_venmoappdata01_by_phonnumeber":
                        _commands.Add(procedure, find_client_venmoappdata01_by_phonnumeber);
                        break;
                    case "find_client_venmoappdata01_by_venmoappdata01":
                        _commands.Add(procedure, find_client_venmoappdata01_by_venmoappdata01);
                        break;
                    case "find_client_zellaappdata01_by_apikey":
                        _commands.Add(procedure, find_client_zellaappdata01_by_apikey);
                        break;
                    case "find_client_zellaappdata01_by_zellaappdata01":
                        _commands.Add(procedure, find_client_zellaappdata01_by_zellaappdata01);
                        break;
                    case "find_client_zelleappdata01_by_cashappdata01":
                        _commands.Add(procedure, find_client_zelleappdata01_by_cashappdata01);
                        break;
                    case "find_client_zelleappdata01_by_emailaddress":
                        _commands.Add(procedure, find_client_zelleappdata01_by_emailaddress);
                        break;
                    case "find_client_zelleappdata01_by_name":
                        _commands.Add(procedure, find_client_zelleappdata01_by_name);
                        break;
                    case "find_client_zelleappdata01_by_phonnumeber":
                        _commands.Add(procedure, find_client_zelleappdata01_by_phonnumeber);
                        break;
                    case "find_client_zelleappdata01_by_venmoappdata01":
                        _commands.Add(procedure, find_client_zelleappdata01_by_venmoappdata01);
                        break;
                    case "insert_client_data":
                        _commands.Add(procedure, insert_client_data);
                        break;
                    case "update_clients_apikey_using_apikey":
                        _commands.Add(procedure, update_clients_apikey_using_apikey);
                        break;
                    case "update_clients_cashappdata01_using_cashappdata01":
                        _commands.Add(procedure, update_clients_cashappdata01_using_cashappdata01);
                        break;
                    case "update_clients_email_using_email":
                        _commands.Add(procedure, update_clients_email_using_email);
                        break;
                    case "update_clients_logo_using_logo":
                        _commands.Add(procedure, update_clients_logo_using_logo);
                        break;
                    case "update_clients_name_using_name":
                        _commands.Add(procedure, update_clients_name_using_name);
                        break;
                    case "update_clients_paypalappdata01_using_paypalappdata01":
                        _commands.Add(procedure, update_clients_paypalappdata01_using_paypalappdata01);
                        break;
                    case "update_clients_phnenumber_using_phonenumbe":
                        _commands.Add(procedure, update_clients_phnenumber_using_phonenumber);
                        break;
                    case "update_clients_venmoappdata01_using_venmoappdata01":
                        _commands.Add(procedure, update_clients_venmoappdata01_using_venmoappdata01);
                        break;
                    case "update_clients_zelleappdata01_using_zellappdata01":
                        _commands.Add(procedure, update_clients_zelleappdata01_using_zellappdata01);
                        break;
                    case "view_all_client_data":
                        _commands.Add(procedure, view_all_client_data);
                        break;
                }

            }
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
            label10.IsVisible = false;
            label11.IsVisible = false;
            label12.IsVisible = false;
            label13.IsVisible = false;
            label14.IsVisible = false;
            label15.IsVisible = false;

            border01.IsVisible = false;
            border02.IsVisible = false;
            border03.IsVisible = false;
            border04.IsVisible = false;
            border05.IsVisible = false;
            border06.IsVisible = false;
            border07.IsVisible = false;
            border08.IsVisible = false;
            border09.IsVisible = false;
            border10.IsVisible = false;
            border11.IsVisible = false;
            border12.IsVisible = false;
            border13.IsVisible = false;
            border14.IsVisible = false;
            border15.IsVisible = false;
            border16.IsVisible = false;
            button03.IsVisible = false;
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
            label10.IsVisible = false;
            label11.IsVisible = false;
            label12.IsVisible = false;
            label13.IsVisible = false;
            label14.IsVisible = false;
            label15.IsVisible = false;

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
            border11.IsVisible = false;
            border12.IsVisible = false;
            border13.IsVisible = false;
            border14.IsVisible = false;
            border15.IsVisible = false;
            border16.IsVisible = true;
            button03.IsVisible = false;

        }
        private void load_default_view02()
        {
               entry01.Placeholder = menu_array[0];
            entry02.Placeholder = menu_array[1];
            entry03.Placeholder = menu_array[2];
            entry04.Placeholder = menu_array[3];
            entry05.Placeholder = menu_array[4];
            entry06.Placeholder = menu_array[5];
            entry07.Placeholder = menu_array[6];
            entry08.Placeholder = menu_array[7];
            entry09.Placeholder = menu_array[8];
            entry10.Placeholder = menu_array[9];
            entry11.Placeholder = menu_array[10];
            entry12.Placeholder = menu_array[11];
            entry13.Placeholder = menu_array[12];
            entry14.Placeholder = menu_array[13];
            label01.IsVisible = false;
            label02.IsVisible = false;
            label03.IsVisible = false;
            label04.IsVisible = false;
            label05.IsVisible = false;
            label06.IsVisible = false;
            label07.IsVisible = false;
            label08.IsVisible = false;
            label09.IsVisible = false;
            label10.IsVisible = false;
            label11.IsVisible = false;
            label12.IsVisible = false;
            label13.IsVisible = false;
            label14.IsVisible = false;
            label15.IsVisible = false;

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
            border12.IsVisible = true;
            border13.IsVisible = true;
            border14.IsVisible = true;
            border15.IsVisible = true;
            border16.IsVisible = true;
            button03.IsVisible = false;

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
            label10.IsVisible = false;
            label11.IsVisible = false;
            label12.IsVisible = false;
            label13.IsVisible = false;
            label14.IsVisible = false;
            label15.IsVisible = false;

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
            border11.IsVisible = false;
            border12.IsVisible = false;
            border13.IsVisible = false;
            border14.IsVisible = false;
            border15.IsVisible = false;
            border16.IsVisible = false;
            button03.IsVisible = false;

        }
        private void load_Selection_View01()
        {

            load_default_view();
            Image01_D01.image01(image01);
            image01.Source = File_M02.source[(int)File_Manger02.image_index01.Easy_Callender_page_1];

            Entrys01_D01.Entrys01(entry01);
            Entrys01_D01.Entrys01(entry02);
            Entrys01_D01.Entrys01(entry03);
            Entrys01_D01.Entrys01(entry04);
            Entrys01_D01.Entrys01(entry05);
            Entrys01_D01.Entrys01(entry06);
            Entrys01_D01.Entrys01(entry07);
            Entrys01_D01.Entrys01(entry08);
            Entrys01_D01.Entrys01(entry09);
            Entrys01_D01.Entrys01(entry10);
            Entrys01_D01.Entrys01(entry11);
            Entrys01_D01.Entrys01(entry12);
            Entrys01_D01.Entrys01(entry13);
            Entrys01_D01.Entrys01(entry14);

            border01_D01.border001(border01);
            border01_D01.border002(border02);
            border01_D01.border002(border03);
            border01_D01.border002(border04);
            border01_D01.border002(border05);
            border01_D01.border002(border06);
            border01_D01.border002(border07);
            border01_D01.border002(border08);
            border01_D01.border002(border09);
           

            Labels01_D01.label01(label01);
            Labels01_D01.label01(label02);
            Labels01_D01.label01(label03);
            Labels01_D01.label01(label04);
            Labels01_D01.label01(label05);
            Labels01_D01.label01(label06);
            Labels01_D01.label01(label07);
           
            Image01_D01.image01(image01);
            Button01_D01.button01(button01);
            Button01_D01.button01(button02);
            Button01_D01.button01(button03);
            button01.Clicked += button01_clicked;
            button02.Clicked += button02_clicked;
            button03.Clicked += button03_clicked;
            button01.Text = "ok";
            button02.Text = "back";
            button03.Text = "next";
            picker01.SelectedIndexChanged += Picker01_SelectedIndexChanged;
            picker01.ItemsSource = stored_procedure_array.ToList();
            picker01.Title = "Select";
        }
        private void Picker01_SelectedIndexChanged(object? sender, EventArgs e)
        {

            switch (picker01.SelectedIndex)
            {
                case > 70:
                    load_default_view01();
                    break;
         

       
                default:
                    load_default_view();
                    break;
            }
        }

        private void delete_client_using_email()
        {


            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.email_check(entry01.Text, out data01[24]) == true)
                {
                    if (MySql_Client_S01.delete_client_using_email(entry01.Text, out data01[25]) == true)
                    {
                        label01.Text = data01[25];
                    }
                    else
                    {
                        label01.Text = data01[25];
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
        private void delete_client_using_name()
        {
            entry01.Placeholder = $"name";

            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                if (MySql_Client_S01.delete_client_using_name(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];
                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[24];

            }

        }
        private void delete_client_using_phonenumber()
        {
            entry01.Placeholder = $"phonenumber\n";

            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.phone_check(entry01.Text, out data01[24]) == true)
                {
                    if (MySql_Client_S01.delete_client_using_phonenumber(entry01.Text, out data01[25]) == true)
                    {
                        label01.Text = data01[25];
                    }
                    else
                    {
                        label01.Text = data01[25];
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
        private void find_client_api_key_by_emailaddress()
        {
            entry01.Placeholder = $"email address\n";

            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.email_check(entry01.Text, out data01[24]) == true)
                {

                    if (MySql_Client_S01.find_client_api_key_by_emailaddress(entry01.Text, out data01[25]) == true)
                    {
                        label01.Text = data01[25];


                    }
                    else
                    {
                        label01.Text = data01[25];
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
        private void find_client_api_key_by_name()
        {
            entry01.Placeholder = $"name\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_api_key_by_name(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }
        }
        private void find_client_api_key_by_phonnumeber()
        {
            entry01.Placeholder = $"phonenumber\n";

            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.phone_check(entry01.Text, out data01[24]) == true)
                {

                    if (MySql_Client_S01.find_client_api_key_by_phonnumeber(entry01.Text, out data01[25]) == true)
                    {
                        label01.Text = data01[25];


                    }
                    else
                    {
                        label01.Text = data01[25];
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
        private void find_client_apikey_by_apikey()
        {
            entry01.Placeholder = $"apikey\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_apikey_by_apikey(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }
        }
        private void find_client_apikey_by_cashappdata01()
        {
            entry01.Placeholder = $"cashappdata01\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_apikey_by_cashappdata01(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }

        }
        private void find_client_apikey_by_paypalappdata01()
        {
            entry01.Placeholder = $"paypalappdata01\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_apikey_by_paypalappdata01(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }
        }
        private void find_client_apikey_by_venmoappdata01()
        {
            entry01.Placeholder = $"venmoappdata01\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_apikey_by_venmoappdata01(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }
        }
        private void find_client_cashappdata01_by_apikey()
        {
            entry01.Placeholder = $"apikey\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_cashappdata01_by_apikey(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }

        }
        private void find_client_cashappdata01_by_cashappdata01()
        {
            entry01.Placeholder = $"cashappdata01\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_cashappdata01_by_cashappdata01(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }

        }
        private void find_client_cashappdata01_by_emailaddress()
        {
            entry01.Placeholder = $"emailaddressr\n";

            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.email_check(entry01.Text, out data01[24]) == true)
                {

                    if (MySql_Client_S01.find_client_cashappdata01_by_emailaddress(entry01.Text, out data01[25]) == true)
                    {
                        label01.Text = data01[25];


                    }
                    else
                    {
                        label01.Text = data01[25];
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
        private void find_client_cashappdata01_by_name()
        {
            entry01.Placeholder = $"name\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_cashappdata01_by_name(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }

        }
        private void find_client_cashappdata01_by_paypalappdata01()
        {
            entry01.Placeholder = $"paypalappdata01\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_cashappdata01_by_paypalappdata01(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }

        }
        private void find_client_cashappdata01_by_phonnumeber()
        {
            entry01.Placeholder = $"phonnumeber\n";

            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.phone_check(entry01.Text, out data01[24]) == true)
                {

                    if (MySql_Client_S01.find_client_cashappdata01_by_phonnumeber(entry01.Text, out data01[25]) == true)
                    {
                        label01.Text = data01[25];


                    }
                    else
                    {
                        label01.Text = data01[25];
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
        private void find_client_cashappdata01_by_venmoappdata01()
        {
            entry01.Placeholder = $"venmoappdata01\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_cashappdata01_by_venmoappdata01(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }

        }
        private void find_client_colors_using_emailaddress()
        {
            entry01.Placeholder = $"emailaddressr\n";

            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.email_check(entry01.Text, out data01[24]) == true)
                {

                    if (MySql_Client_S01.find_client_colors_using_emailaddress(entry01.Text, out data01[25]) == true)
                    {
                        label01.Text = data01[25];


                    }
                    else
                    {
                        label01.Text = data01[25];
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
        private void find_client_colors_using_name()
        {
            entry01.Placeholder = $"name\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_colors_using_name(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }

        }
        private void find_client_colors_using_phonenumber()
        {
            entry01.Placeholder = $"phonenumber\n";

            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.phone_check(entry01.Text, out data01[24]) == true)
                {

                    if (MySql_Client_S01.find_client_colors_using_phonenumber(entry01.Text, out data01[25]) == true)
                    {
                        label01.Text = data01[25];


                    }
                    else
                    {
                        label01.Text = data01[25];
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
        private void find_client_data_using_email()
        {
            entry01.Placeholder = $"email\n";

            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.email_check(entry01.Text, out data01[24]) == true)
                {

                    if (MySql_Client_S01.find_client_data_using_email(entry01.Text, out data01[25]) == true)
                    {
                        label01.Text = data01[25];


                    }
                    else
                    {
                        label01.Text = data01[25];
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
        private void find_client_data_using_latitude_and_longitude()
        {
            entry01.Placeholder = $"latitude\n";
            entry02.Placeholder = $"longitude\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                counter01++;
            }
            else
            {
                counter01--;
                label01.Text = data01[23];
            }
            if (Security_Serv01.empty_string(entry02.Text, out data01[23]) == true)
            {
                counter01++;

            }
            else
            {
                counter01--;
                label02.Text = data01[23];
            }
            if (counter01 == 2)
            {
                if (MySql_Client_S01.find_client_data_using_latitude_and_longitude(entry01.Text, entry02.Text, out data01[25]) == true)
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
                label02.Text = "please fix errors";
            }
        }
        private void find_client_data_using_logo()
        {
            entry01.Placeholder = $"logo\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_data_using_logo(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }


        }
        private void find_client_data_using_name()
        {
            entry01.Placeholder = $"name\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_data_using_name(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }


        }
        private void find_client_data_using_number()
        {
            entry01.Placeholder = $"number\n";

            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.phone_check(entry01.Text, out data01[24]) == true)
                {

                    if (MySql_Client_S01.find_client_data_using_number(entry01.Text, out data01[25]) == true)
                    {
                        label01.Text = data01[25];

                    }
                    else
                    {
                        label01.Text = data01[25];
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
        private void find_client_emailaddress_by_apikey()
        {
            entry01.Placeholder = $"apikey\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_emailaddress_by_apikey(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }




        }
        private void find_client_emailaddress_by_cashappdata01()
        {
            entry01.Placeholder = $"cashappdata01\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_emailaddress_by_cashappdata01(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }
        }
        private void find_client_emailaddress_by_emailaddress()
        {
            entry01.Placeholder = $"emailaddressr\n";

            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.email_check(entry01.Text, out data01[24]) == true)
                {

                    if (MySql_Client_S01.find_client_emailaddress_by_emailaddress(entry01.Text, out data01[25]) == true)
                    {
                        label01.Text = data01[25];
                    }
                    else
                    {
                        label01.Text = data01[25];
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
        private void find_client_emailaddress_by_name()
        {
            entry01.Placeholder = $"name\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_emailaddress_by_name(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }

        }
        private void find_client_emailaddress_by_paypalappdata01()
        {
            entry01.Placeholder = $"paypalappdata01\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_emailaddress_by_paypalappdata01(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }

        }
        private void find_client_emailaddress_by_phonnumeber()
        {
            entry01.Placeholder = $"phonnumeber\n";

            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.phone_check(entry01.Text, out data01[24]) == true)
                {

                    if (MySql_Client_S01.find_client_emailaddress_by_phonnumeber(entry01.Text, out data01[25]) == true)
                    {
                        label01.Text = data01[25];


                    }
                    else
                    {
                        label01.Text = data01[25];
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
        private void find_client_emailaddress_by_venmoappdata01()
        {
            entry01.Placeholder = $"venmoappdata01\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_emailaddress_by_venmoappdata01(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }


        }
        private void find_client_location_using_emailaddress()
        {
            entry01.Placeholder = $"emailaddressr\n";

            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.email_check(entry01.Text, out data01[24]) == true)
                {

                    if (MySql_Client_S01.find_client_location_using_emailaddress(entry01.Text, out data01[25]) == true)
                    {
                        label01.Text = data01[25];


                    }
                    else
                    {
                        label01.Text = data01[25];
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
        private void find_client_location_using_name()
        {
            entry01.Placeholder = $"name\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_location_using_name(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }



        }
        private void find_client_location_using_phonenumber()
        {
            entry01.Placeholder = $"phonenumber\n";

            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.phone_check(entry01.Text, out data01[24]) == true)
                {

                    if (MySql_Client_S01.find_client_location_using_phonenumber(entry01.Text, out data01[25]) == true)
                    {
                        label01.Text = data01[25];


                    }
                    else
                    {
                        label01.Text = data01[25];
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
        private void find_client_logo_by_emailaddress()
        {
            entry01.Placeholder = $"emailaddressr\n";

            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.email_check(entry01.Text, out data01[24]) == true)
                {

                    if (MySql_Client_S01.find_client_logo_by_emailaddress(entry01.Text, out data01[25]) == true)
                    {
                        label01.Text = data01[25];


                    }
                    else
                    {
                        label01.Text = data01[25];
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
        private void find_client_logo_by_logo()
        {
            entry01.Placeholder = $"logo\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_logo_by_logo(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }


        }
        private void find_client_logo_by_name()
        {
            entry01.Placeholder = $"name\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_logo_by_name(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }


        }
        private void find_client_logo_by_phonenumber()
        {
            entry01.Placeholder = $"phonenumber\n";

            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.phone_check(entry01.Text, out data01[24]) == true)
                {

                    if (MySql_Client_S01.find_client_logo_by_phonenumber(entry01.Text, out data01[25]) == true)
                    {
                        label01.Text = data01[25];


                    }
                    else
                    {
                        label01.Text = data01[25];
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
        private void find_client_name_by_cashappdata01()
        {

            entry01.Placeholder = $"cashappdata01\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_name_by_cashappdata01(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }



        }
        private void find_client_name_by_emailaddress()
        {
            entry01.Placeholder = $"emailaddressr\n";

            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.email_check(entry01.Text, out data01[24]) == true)
                {

                    if (MySql_Client_S01.find_client_name_by_emailaddress(entry01.Text, out data01[25]) == true)
                    {
                        label01.Text = data01[25];


                    }
                    else
                    {
                        label01.Text = data01[25];
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
        private void find_client_name_by_name()
        {
            entry01.Placeholder = $"name\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_name_by_name(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }



        }
        private void find_client_name_by_paypalappdata01()
        {
            entry01.Placeholder = $"paypalappdata01\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_name_by_paypalappdata01(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }



        }
        private void find_client_name_by_phonnumeber()
        {
            entry01.Placeholder = $"emailaddressr\n";

            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.email_check(entry01.Text, out data01[24]) == true)
                {

                    if (MySql_Client_S01.find_client_cashappdata01_by_emailaddress(entry01.Text, out data01[25]) == true)
                    {
                        label01.Text = data01[25];


                    }
                    else
                    {
                        label01.Text = data01[25];
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
        private void find_client_name_by_venmoappdata01()
        {

            entry01.Placeholder = $"venmoappdata01\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_name_by_venmoappdata01(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }



        }
        private void find_client_paypalappdata01_by_apikey()
        {

            entry01.Placeholder = $"apikey\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_paypalappdata01_by_apikey(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }



        }
        private void find_client_paypalappdata01_by_cashappdata01()
        {

            entry01.Placeholder = $"cashappdata01\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_paypalappdata01_by_cashappdata01(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }



        }
        private void find_client_paypalappdata01_by_emailaddress()
        {
            entry01.Placeholder = $"emailaddressr\n";

            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.email_check(entry01.Text, out data01[24]) == true)
                {

                    if (MySql_Client_S01.find_client_paypalappdata01_by_emailaddress(entry01.Text, out data01[25]) == true)
                    {
                        label01.Text = data01[25];


                    }
                    else
                    {
                        label01.Text = data01[25];
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
        private void find_client_paypalappdata01_by_name()
        {
            entry01.Placeholder = $"name\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_paypalappdata01_by_name(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }

        }
        private void find_client_paypalappdata01_by_paypalappdata01()
        {
            entry01.Placeholder = $"paypalappdata01\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_paypalappdata01_by_paypalappdata01(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }

        }
        private void find_client_paypalappdata01_by_phonnumeber()
        {
            entry01.Placeholder = $"phonnumeber\n";

            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.phone_check(entry01.Text, out data01[24]) == true)
                {

                    if (MySql_Client_S01.find_client_cashappdata01_by_emailaddress(entry01.Text, out data01[25]) == true)
                    {
                        label01.Text = data01[25];


                    }
                    else
                    {
                        label01.Text = data01[25];
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
        private void find_client_paypalappdata01_by_venmoappdata01()
        {

            entry01.Placeholder = $"venmoappdata01\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_paypalappdata01_by_venmoappdata01(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }



        }
        private void find_client_phonenumber_by_apikey()
        {

            entry01.Placeholder = $"apikey\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_phonenumber_by_apikey(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }



        }
        private void find_client_phonenumber_by_cashappdata01()
        {



            entry01.Placeholder = $"cashappdata01\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_phonenumber_by_cashappdata01(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }






        }
        private void find_client_phonenumber_by_emailaddress()
        {
            entry01.Placeholder = $"emailaddressr\n";

            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.email_check(entry01.Text, out data01[24]) == true)
                {

                    if (MySql_Client_S01.find_client_phonenumber_by_emailaddress(entry01.Text, out data01[25]) == true)
                    {
                        label01.Text = data01[25];


                    }
                    else
                    {
                        label01.Text = data01[25];
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
        private void find_client_phonenumber_by_name()
        {

            entry01.Placeholder = $"name\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_phonenumber_by_name(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }



        }
        private void find_client_phonenumber_by_paypalappdata01()
        {

            entry01.Placeholder = $"paypalappdata01\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_cashappdata01_by_name(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }



        }
        private void find_client_phonenumber_by_phonnumeber()
        {
            entry01.Placeholder = $"phonnumeber\n";

            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.phone_check(entry01.Text, out data01[24]) == true)
                {

                    if (MySql_Client_S01.find_client_phonenumber_by_phonnumeber(entry01.Text, out data01[25]) == true)
                    {
                        label01.Text = data01[25];


                    }
                    else
                    {
                        label01.Text = data01[25];
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
        private void find_client_phonenumber_by_venmoappdata01()
        {
            entry01.Placeholder = $"venmoappdata01\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_phonenumber_by_venmoappdata01(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }



        }
        private void find_client_venmoappdata01_by_apikey()
        {
            entry01.Placeholder = $"apikey\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_venmoappdata01_by_apikey(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }



        }
        private void find_client_venmoappdata01_by_cashappdata01()
        {
            entry01.Placeholder = $"cashappdata01()e\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_venmoappdata01_by_cashappdata01(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }



        }
        private void find_client_venmoappdata01_by_emailaddress()
        {
            entry01.Placeholder = $"emailaddressr\n";

            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.email_check(entry01.Text, out data01[24]) == true)
                {

                    if (MySql_Client_S01.find_client_venmoappdata01_by_emailaddress(entry01.Text, out data01[25]) == true)
                    {
                        label01.Text = data01[25];
                    }
                    else
                    {
                        label01.Text = data01[25];
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
        private void find_client_venmoappdata01_by_name()
        {

            entry01.Placeholder = $"name\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_venmoappdata01_by_name(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }






        }
        private void find_client_venmoappdata01_by_paypalappdata01()
        {

            entry01.Placeholder = $"paypalappdata01\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_venmoappdata01_by_paypalappdata01(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }






        }
        private void find_client_venmoappdata01_by_phonnumeber()
        {
            entry01.Placeholder = $"phonnumeber\n";

            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.phone_check(entry01.Text, out data01[24]) == true)
                {

                    if (MySql_Client_S01.find_client_venmoappdata01_by_phonnumeber(entry01.Text, out data01[25]) == true)
                    {
                        label01.Text = data01[25];


                    }
                    else
                    {
                        label01.Text = data01[25];
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
        private void find_client_venmoappdata01_by_venmoappdata01()
        {
            entry01.Placeholder = $"venmoappdata01\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_venmoappdata01_by_venmoappdata01(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }



        }
        private void find_client_zellaappdata01_by_apikey()
        {
            entry01.Placeholder = $"apikey\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_zellaappdata01_by_apikey(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }



        }
        private void find_client_zellaappdata01_by_zellaappdata01()
        {
            entry01.Placeholder = $"zellaappdata01\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_zellaappdata01_by_zellaappdata01(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }



        }
        private void find_client_zelleappdata01_by_cashappdata01()
        {
            entry01.Placeholder = $"cashappdata01\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_zelleappdata01_by_cashappdata01(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }



        }
        private void find_client_zelleappdata01_by_emailaddress()
        {
            entry01.Placeholder = $"emailaddressr\n";

            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.email_check(entry01.Text, out data01[24]) == true)
                {

                    if (MySql_Client_S01.find_client_zelleappdata01_by_emailaddress(entry01.Text, out data01[25]) == true)
                    {
                        label01.Text = data01[25];


                    }
                    else
                    {
                        label01.Text = data01[25];
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
        private void find_client_zelleappdata01_by_name()
        {
            entry01.Placeholder = $"name\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_zelleappdata01_by_name(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }


        }
        private void find_client_zelleappdata01_by_phonnumeber()
        {
            entry01.Placeholder = $"phonnumeber\n";

            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.phone_check(entry01.Text, out data01[24]) == true)
                {

                    if (MySql_Client_S01.find_client_zelleappdata01_by_phonnumeber(entry01.Text, out data01[25]) == true)
                    {
                        label01.Text = data01[25];


                    }
                    else
                    {
                        label01.Text = data01[25];
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
        private void find_client_zelleappdata01_by_venmoappdata01()
        {
            entry01.Placeholder = $"venmoappdata01\n";
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (MySql_Client_S01.find_client_zelleappdata01_by_venmoappdata01(entry01.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];

                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];

            }




        }
        private void insert_client_data()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[20]) == true)
            {

                counter01++;
                label01.Text = data01[21];
            }
            else
            {
                counter01--;
                label01.Text = data01[21];
            }

            if (Security_Serv01.empty_string(entry02.Text, out data01[24]) == true)
            {
                counter01++;
            }
            else
            {

                counter01--;
                label02.Text = data01[24];
            }
            if (Security_Serv01.empty_string(entry03.Text, out data01[24]) == true)
            {
                counter01++;
            }
            else
            {

                counter01--;
                label03.Text = data01[24];
            }
            if (Security_Serv01.empty_string(entry04.Text, out data01[24]) == true)
            {
                counter01++;
            }
            else
            {

                counter01--;
                label04.Text = data01[24];
            }
            if (Security_Serv01.empty_string(entry05.Text, out data01[24]) == true)
            {
                counter01++;
            }
            else
            {

                counter01--;
                label05.Text = data01[24];
            }
            if (Security_Serv01.empty_string(entry06.Text, out data01[24]) == true)
            {
                counter01++;
            }
            else
            {

                counter01--;
                label06.Text = data01[24];
            }

            if (Security_Serv01.empty_string(entry06.Text, out data01[24]) == true)
            {
                counter01++;
            }
            else
            {

                counter01--;
                label07.Text = data01[24];
            }



            if (counter01 == 7)
            {
                if (MySql_Client_S01.insert_client_data(entry01.Text, entry02.Text, entry03.Text, entry04.Text,
                                                      entry05.Text, entry06.Text, entry07.Text, entry07.Text,
                                                      entry08.Text, entry09.Text, entry10.Text, entry11.Text,
                                                      entry12.Text, entry13.Text, out data01[25]) == true)
                {
                    label01.Text = data01[25];
                }
                else
                {
                    label01.Text = data01[25];
                }

            }
            else
            {
                label01.Text = "please correct errors";
            }

        }
        private void update_clients_apikey_using_apikey()
        {

            entry01.Placeholder = $"apikey\n";
            entry02.Placeholder = $"mew apikey\n";

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
                if (MySql_Client_S01.update_clients_apikey_using_apikey(entry01.Text, entry02.Text, out data01[25]) == true)
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
        private void update_clients_cashappdata01_using_cashappdata01()
        {
            entry01.Placeholder = $"cashappdata01\n";
            entry02.Placeholder = $"mew cashappdata01\n";

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
                if (MySql_Client_S01.update_clients_cashappdata01_using_cashappdata01(entry01.Text, entry02.Text, out data01[25]) == true)
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
        private void update_clients_email_using_email()
        {
            entry01.Placeholder = $"email\n";
            entry02.Placeholder = $"mew email\n";

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
                if (Security_Serv01.email_check(entry02.Text, out data01[24]) == true)
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
                if (MySql_Client_S01.update_clients_email_using_email(entry01.Text, entry02.Text, out data01[25]) == true)
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
        private void update_clients_logo_using_logo()
        {
            entry01.Placeholder = $"logo\n";
            entry02.Placeholder = $"mew logo\n";

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
                if (MySql_Client_S01.update_clients_logo_using_logo(entry01.Text, entry02.Text, out data01[25]) == true)
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
        private void update_clients_name_using_name()
        {
            entry01.Placeholder = $"name";
            entry02.Placeholder = $"new name\n";

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
                if (MySql_Client_S01.update_clients_logo_using_logo(entry01.Text, entry02.Text, out data01[25]) == true)
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
        private void update_clients_paypalappdata01_using_paypalappdata01()
        {
            entry01.Placeholder = $"paypalappdata01";
            entry02.Placeholder = $"new paypalappdata01\n";

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
                if (MySql_Client_S01.update_clients_paypalappdata01_using_paypalappdata01(entry01.Text, entry02.Text, out data01[25]) == true)
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
        private void update_clients_phnenumber_using_phonenumber()
        {
            entry01.Placeholder = $"phonenumber\n";
            entry02.Placeholder = $"mew phonenumber\n";

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
                if (MySql_Client_S01.update_clients_phnenumber_using_phonenumber(entry01.Text, entry02.Text, out data01[25]) == true)
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
        private void update_clients_venmoappdata01_using_venmoappdata01()
        {
            entry01.Placeholder = $"venmoappdata01";
            entry02.Placeholder = $"new venmoappdata01\n";

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
                if (MySql_Client_S01.update_clients_venmoappdata01_using_venmoappdata01(entry01.Text, entry02.Text, out data01[25]) == true)
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
        private void update_clients_zelleappdata01_using_zellappdata01()
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
                if (MySql_Client_S01.update_clients_zelleappdata01_using_zellappdata01(entry01.Text, entry02.Text, out data01[25]) == true)
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
        private void view_all_client_data()
        {
            if (MySql_Client_S01.view_all_client_data(out data01[23]) == true)
            {
                label01.Text = data01[23];
            }
            else
            {
                label01.Text = data01[23];
            }

        }
        private void load_Client_Selection_View01_data()
        {

            if (Security_Serv01.isPicker_selected(picker01, out data01[24]) == true)
            {
                int selection = picker01.SelectedIndex;
                int stringlength=stored_procedure_array.Length;
                if (selection >= 0 &&
                    selection < stringlength)
                {
                    string key = stored_procedure_array[selection].Trim();
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
             load_Client_Selection_View01_data();
        }
        private async void button02_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button02);
            await button02.Navigation.PushAsync(new Selection_Main_View01());
        }
        private async void button03_clicked(object? sender, EventArgs e)
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
    }
}