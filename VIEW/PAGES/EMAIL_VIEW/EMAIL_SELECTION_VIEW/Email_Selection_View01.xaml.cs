using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.LABELS.LABEL_DEFAULTS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_ANIMATION;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.EMAIL_VIEW.EMAIL_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQL.SQL_SERVICES.SQL_EMIAL_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.EMAIL_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BORDER.BORDER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS.ENTRY_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQL.SQL_SERVICES.SQL_EMIAL_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.EDITOR.EDITOR_DEFAULT;

namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.EMAIL_VIEW.EMAIL_SELECTION_VIEW;

public partial class Email_Selection_View01 : ContentPage
{
    private static string[] data01 = new string[100];
    private static Button01_Default Button01_D01 = new Button01_Default();
    private static Border01_Default border01_D01 = new Border01_Default();
    private static Image01_Default Image01_D01 = new Image01_Default();
    private static Security_Services01 Security_Serv01 = new Security_Services01();
    private static Labels01_Default Labels01_D01 = new Labels01_Default();
    private static Button_Animation01 Button_A01 = new Button_Animation01();

    private static Picker01_Animation Picker01_A01 = new Picker01_Animation();
    private static Entrys01_Default Entrys01_D01 = new Entrys01_Default();
    private static Sql_Email_Services01 Sql_Email_S01 = new Sql_Email_Services01();
    private static Email_Services01 Email_S01 = new Email_Services01();
    private static Security_Services01 Security_S01 = new Security_Services01();
    private static int counter = 0;
    private static bool stored_procedure_bool = Sql_Email_S01.view_email_database_storedprocedures(out data01[50]);
    private static string stored_procedure_string = data01[50];
    private static string[] stored_procedure_array = stored_procedure_string.Split("\n");
    private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
    private static File_Manger02 File_M02 = new File_Manger02();
    private static Editor_defaul01 Editor_defaul01 = new Editor_defaul01();

    public Email_Selection_View01()
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
        load_default_view();
        Image01_D01.image01(image01);
        image01.Source = File_M02.source[(int)File_Manger02.image_index01.Easy_Callender_page_1];
        Entrys01_D01.Entrys01(entry01);
        Editor_defaul01.Editors01(editor01);
        border01_D01.border001(border01);
        border01_D01.border002(border02);
        border01_D01.border002(border03);
        border01_D01.border002(border04);
        border01_D01.border002(border05);
        border01_D01.border002(border06);
        Labels01_D01.label01(label01);
        Labels01_D01.label01(label02);
        Labels01_D01.label01(label03);
        Labels01_D01.label01(label04);
        Labels01_D01.label01(label05);
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
        label01.IsVisible = false;
        label02.IsVisible = false;
        label03.IsVisible = false;
        label04.IsVisible = false;
        label05.IsVisible = true;
        border01.IsVisible = true;
        border02.IsVisible = false;
        border03.IsVisible = false;
        border04.IsVisible = false;
        border05.IsVisible = false;
        border06.IsVisible = true;

    }
    private void load_default_view01()
    {
        label01.IsVisible = true;
        label02.IsVisible = false;
        label03.IsVisible = false;
        label04.IsVisible = false;
        label05.IsVisible = false;
        border01.IsVisible = true;
        border02.IsVisible = true;
        border03.IsVisible = false;
        border04.IsVisible = false;
        border05.IsVisible = false;
        border06.IsVisible = true;

    }
    private void load_default_view02()
    {
        label01.IsVisible = true;
        label02.IsVisible = false;
        label03.IsVisible = false;
        label04.IsVisible = false;
        label05.IsVisible = false;
        border01.IsVisible = true;
        border02.IsVisible = true;
        border03.IsVisible = true;
        border04.IsVisible = false;
        border05.IsVisible = false;
        border06.IsVisible = true;

    }
    private void load_default_view03()
    {
        label01.IsVisible = true;
        label02.IsVisible = false;
        label03.IsVisible = false;
        label04.IsVisible = false;
        label05.IsVisible = false;
        border01.IsVisible = true;
        border02.IsVisible = true;
        border03.IsVisible = true;
        border04.IsVisible = true;
        border05.IsVisible = true;
        border06.IsVisible = true;

    }
    private void Picker01_SelectedIndexChanged(object? sender, EventArgs e)
    {

        switch (stored_procedure_array[picker01.SelectedIndex])
        {

            case "find_email_using_email":
                entry01.Placeholder = "email";
                entry02.Placeholder = string.Empty;
                entry03.Placeholder = string.Empty;
                editor01.Placeholder = string.Empty;
                load_default_view01();
                break;
            case "find_email_using_name":
                entry01.Placeholder = "email";
                entry02.Placeholder = string.Empty;
                entry03.Placeholder = string.Empty;
                editor01.Placeholder = string.Empty;
                load_default_view01();
                break;
            case "find_email_using_phonenumber":
                entry01.Placeholder = "phonenumber";
                entry02.Placeholder = string.Empty;
                entry03.Placeholder = string.Empty;
                editor01.Placeholder = string.Empty;
                load_default_view01();
                break;
            case "find_full_name_using_email":
                entry01.Placeholder = "email";
                entry02.Placeholder = string.Empty;
                entry03.Placeholder = string.Empty;
                editor01.Placeholder = string.Empty;
                load_default_view01();
                break;
            case "find_full_name_using_full_name":
                entry01.Placeholder = "name";
                entry02.Placeholder = string.Empty;
                entry03.Placeholder = string.Empty;
                editor01.Placeholder = string.Empty;
                load_default_view01();
                break;
            case "find_full_name_using_phonenumber":
                entry01.Placeholder = "phonenumber";
                entry01.Placeholder = string.Empty;
                entry01.Placeholder = string.Empty;
                editor01.Placeholder = string.Empty;
                load_default_view01();
                break;
            case "find_phonenumber_using_email":
                entry01.Placeholder = "email";
                entry02.Placeholder = string.Empty;
                entry03.Placeholder = string.Empty;
                editor01.Placeholder = string.Empty;
                load_default_view01();
                break;
            case "find_phonenumber_using_fullname":
                entry01.Placeholder = "name";
                entry02.Placeholder = string.Empty;
                entry03.Placeholder = string.Empty;
                editor01.Placeholder = string.Empty;
                load_default_view01();
                break;
            case "find_phonenumber_using_phonenumber":
                entry01.Placeholder = "phonenumber";
                entry02.Placeholder = string.Empty;
                entry03.Placeholder = string.Empty;
                editor01.Placeholder = string.Empty;
                load_default_view01();
                break;
            case "insert_email":
                entry01.Placeholder = "full name";
                entry02.Placeholder = "your email";
                entry03.Placeholder = "phonenumber";
                editor01.Placeholder = "messsage";
                load_default_view03();
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
                case "insert_email":
                    _commands.Add(procedure, insert_email);
                    break;
                case "find_email_using_email":
                    _commands.Add(procedure, find_email_using_email);
                    break;
                case "find_email_using_name":
                    _commands.Add(procedure, find_email_using_name);
                    break;
                case "find_email_using_phonenumber":
                    _commands.Add(procedure, find_email_using_phonenumber);
                    break;
                case "find_full_name_using_email":
                    _commands.Add(procedure, find_full_name_using_email);
                    break;
                case "find_full_name_using_full_name":
                    _commands.Add(procedure, find_full_name_using_full_name);
                    break;
                case "find_full_name_using_phonenumber":
                    _commands.Add(procedure, find_full_name_using_phonenumber);
                    break;
                case "find_phonenumber_using_email":
                    _commands.Add(procedure, find_phonenumber_using_email);
                    break;
                case "find_phonenumber_using_fullname":
                    _commands.Add(procedure, find_phonenumber_using_fullname);
                    break;
                case "find_phonenumber_using_phonenumber":
                    _commands.Add(procedure, find_phonenumber_using_phonenumber);
                    break;


            }
        }
    }



    private void insert_email()
    {
        counter = 0;
        if (Security_S01.empty_string(entry01.Text, out data01[25]) == true)
        {

            counter++;
            label01.IsVisible = false;
            label01.Text = string.Empty;
        }
        else
        {
            counter--;
            label01.IsVisible = true;
            label01.Text = data01[25];
        }
        if (Security_S01.empty_string(entry02.Text, out data01[25]) == true)
        {
            if (Security_S01.email_check(entry02.Text, out data01[26]) == true)
            {

                counter++;
                label02.IsVisible = false;
                label02.Text = string.Empty;

            }
            else
            {
                counter--;
                label02.IsVisible = true;
                label02.Text = data01[25];
            }
        }
        else
        {
            counter--;
            label02.IsVisible = true;
            label02.Text = $"full name is empty \n";
        }
        if (Security_S01.empty_string(entry03.Text, out data01[28]) == true)
        {
            if (Security_S01.phone_check(entry03.Text, out data01[29]) == true)
            {
                counter++;
                label03.IsVisible = false;
                label03.Text = string.Empty;
            }
            else
            {
                counter--;
                label03.IsVisible = true;
                label03.Text = data01[29];
            }
        }
        else
        {
            counter--;
            label03.IsVisible = true;
            label03.Text = data01[28];
        }

        if (Security_S01.empty_string(editor01.Text, out data01[30]) == true)
        {
            counter++;
            label04.IsVisible = false;
            label04.Text = string.Empty;
        }
        else
        {
            counter--;
            label04.IsVisible = true;
            label04.Text = data01[30];
        }
        if (counter == 4)
        {
            if (Email_S01.send_email(entry01.Text, entry02.Text, entry03.Text, editor01.Text, out data01[31]) == true)
            {

                if (Sql_Email_S01.insert_email(entry01.Text, entry02.Text, entry03.Text, editor01.Text, out data01[32]) == true)
                {
                    label05.Text = $"{data01[31]}\n" +
                                   $"{data01[32]}\n";


                }
                else
                {
                    label05.Text = data01[32];
                }

            }
            else
            {
                label05.Text = data01[31];

            }
        }
        else
        {
            label05.Text = "something happened wrong please check the error message and try again";

        }

    }
    private void find_email_using_email()
    {
        if (Security_S01.empty_string(entry01.Text, out data01[23]) == true)
        {
            if (Security_S01.email_check(entry01.Text, out data01[24]) == true)
            {
                if (Sql_Email_S01.find_email_using_email(entry01.Text, out data01[25]) == true)
                {
                    label01.IsVisible = true;
                    label01.Text = data01[25];
                }
                else
                {
                    label01.IsVisible = true;
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.IsVisible = true;
                label01.Text = data01[24];
            }
        }
        else
        {
            label01.IsVisible = true;
            label01.Text = data01[23];
        }


    }
    private void find_email_using_name()
    {
        if (Security_S01.empty_string(entry01.Text, out data01[23]) == true)
        {

            if (Sql_Email_S01.find_email_using_name(entry01.Text, out data01[25]) == true)
            {
                label01.IsVisible = true;
                label01.Text = data01[25];
            }
            else
            {
                label01.IsVisible = true;
                label01.Text = data01[25];
            }

        }
        else
        {
            label01.IsVisible = true;
            label01.Text = data01[23];
        }


    }
    private void find_email_using_phonenumber()
    {
        if (Security_S01.empty_string(entry01.Text, out data01[23]) == true)
        {
            if (Security_S01.phone_check(entry01.Text, out data01[24]) == true)
            {
                if (Sql_Email_S01.find_email_using_phonenumber(entry01.Text, out data01[25]) == true)
                {
                    label01.IsVisible = true;
                    label01.Text = data01[25];
                }
                else
                {
                    label01.IsVisible = true;
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.IsVisible = true;
                label01.Text = data01[24];
            }
        }
        else
        {
            label01.IsVisible = true;
            label01.Text = data01[23];
        }


    }
    private void find_full_name_using_email()
    {
        if (Security_S01.empty_string(entry01.Text, out data01[23]) == true)
        {
            if (Security_S01.email_check(entry01.Text, out data01[24]) == true)
            {
                if (Sql_Email_S01.find_full_name_using_email(entry01.Text, out data01[25]) == true)
                {
                    label01.IsVisible = true;
                    label01.Text = data01[25];
                }
                else
                {
                    label01.IsVisible = true;
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.IsVisible = true;
                label01.Text = data01[24];
            }
        }
        else
        {
            label01.IsVisible = true;
            label01.Text = data01[23];
        }

    }
    private void find_full_name_using_full_name()
    {
        if (Security_S01.empty_string(entry01.Text, out data01[23]) == true)
        {

            if (Sql_Email_S01.find_full_name_using_full_name(entry01.Text, out data01[25]) == true)
            {
                label01.IsVisible = true;
                label01.Text = data01[25];
            }
            else
            {
                label01.IsVisible = true;
                label01.Text = data01[25];
            }

        }
        else
        {
            label01.IsVisible = true;
            label01.Text = data01[23];
        }

    }
    private void find_full_name_using_phonenumber()
    {
        if (Security_S01.empty_string(entry01.Text, out data01[23]) == true)
        {
            if (Security_S01.phone_check(entry01.Text, out data01[24]) == true)
            {
                if (Sql_Email_S01.find_full_name_using_phonenumber(entry01.Text, out data01[25]) == true)
                {
                    label01.IsVisible = true;
                    label01.Text = data01[25];
                }
                else
                {
                    label01.IsVisible = true;
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.IsVisible = true;
                label01.Text = data01[24];
            }
        }
        else
        {
            label01.IsVisible = true;
            label01.Text = data01[23];
        }


    }
    private void find_phonenumber_using_email()
    {
        if (Security_S01.empty_string(entry01.Text, out data01[23]) == true)
        {
            if (Security_S01.email_check(entry01.Text, out data01[24]) == true)
            {
                if (Sql_Email_S01.find_phonenumber_using_email(entry01.Text, out data01[25]) == true)
                {
                    label01.IsVisible = true;
                    label01.Text = data01[25];
                }
                else
                {
                    label01.IsVisible = true;
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.IsVisible = true;
                label01.Text = data01[24];
            }
        }
        else
        {
            label01.IsVisible = true;
            label01.Text = data01[23];
        }

    }
    private void find_phonenumber_using_fullname()
    {
        if (Security_S01.empty_string(entry01.Text, out data01[23]) == true)
        {

            if (Sql_Email_S01.find_phonenumber_using_fullname(entry01.Text, out data01[25]) == true)
            {
                label01.IsVisible = true;
                label01.Text = data01[25];
            }
            else
            {
                label01.IsVisible = true;
                label01.Text = data01[25];
            }

        }
        else
        {
            label01.IsVisible = true;
            label01.Text = data01[23];
        }

    }
    private void find_phonenumber_using_phonenumber()
    {
        if (Security_S01.empty_string(entry01.Text, out data01[23]) == true)
        {
            if (Security_S01.phone_check(entry01.Text, out data01[24]) == true)
            {
                if (Sql_Email_S01.find_phonenumber_using_phonenumber(entry01.Text, out data01[25]) == true)
                {
                    label01.IsVisible = true;
                    label01.Text = data01[25];
                }
                else
                {
                    label01.IsVisible = true;
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.IsVisible = true;
                label01.Text = data01[24];
            }
        }
        else
        {
            label01.IsVisible = true;
            label01.Text = data01[23];
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
        await button02.Navigation.PushAsync(new Email_Main_View01());
    }
}