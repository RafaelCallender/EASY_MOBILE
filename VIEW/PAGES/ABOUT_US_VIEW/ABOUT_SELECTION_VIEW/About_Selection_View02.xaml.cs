using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.LABELS.LABEL_DEFAULTS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BORDER.BORDER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS.ENTRY_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGEBUTTON.IMAGEBUTTON_DEFAULT;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.ABOUT_US_VIEW.ABOUT_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGEBUTTON.IMAGEBUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BACKGROUND.BACKGROUND_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.EMAIL_SERVICES;
using Microsoft.Maui.ApplicationModel.Communication;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.EDITOR.EDITOR_DEFAULT;

namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.ABOUT_US_VIEW.ABOUT_SELECTION_VIEW
{
    public partial class About_Selection_View02 : ContentPage
    {
        private Background_Default01 Background_D01 = new Background_Default01();
        private static string[] data01 = new string[100];
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static Border01_Default border01_D01 = new Border01_Default();
        private static Image01_Default Image01_D01 = new Image01_Default();
        private static Labels01_Default Labels01_D01 = new Labels01_Default();
        private static string menu_string01 = $"call\n" +
                                              $"text\n" +
                                              $"email\n"

        ;
        private static Email_Services01 Email_S01 = new Email_Services01();
        private static string[] menu_array01 = menu_string01.Split("\n");
        private static Button_Animation01 Button_A01 = new Button_Animation01();
        private static Picker01_Animation Picker01_A01 = new Picker01_Animation();
        private static Entrys01_Default Entrys01_D01 = new Entrys01_Default();
        private static Picker01_Default Picker01_D = new Picker01_Default();
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static ImageButton01_Default ImageButton01_D01 = new ImageButton01_Default();
        private static ImageButton_Animaiton01 ImageButton_A01 = new ImageButton_Animaiton01();
        private static File_Manger02 File_M02 = new File_Manger02();
        private static Editor_defaul01 Editor_defaul01 = new Editor_defaul01();
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        public About_Selection_View02()
        {

            InitializeComponent();
            load_Selection_View01();
        }
        private void load_Selection_data01()
        {

            string procedure = menu_array01[picker01.SelectedIndex];
            switch (procedure)
            {

                case "call":
                    _commands.Add(procedure, call);
                    break;
                case "text":
                    _commands.Add(procedure, text);
                    break;
                case "email":
                    _commands.Add(procedure, email);
                    break;

            }

        }

        private void call()
        {
            try
            {
                PhoneDialer.Default.Open(File_Manger01.API03?.Trim());
                label01.Text = $"Opening phone dialer: {File_Manger01.API03?.Trim()}";
            }
            catch (Exception ex)
            {
                label01.Text = $"Unable to open phone dialer: {ex.Message}\n{File_Manger01.API03?.Trim()}";
            }
        }
        private async void text()
        {

            if (Security_Serv01.empty_string(entry01.Text, out data01[24]) == true)
            {
                try
                {
                    var message = new SmsMessage(
                        entry01.Text,
                        File_Manger01.API03?.Trim()
                    );

                    await Sms.Default.ComposeAsync(message);
                    label01.Text = "Text message composer opened.";
                }
                catch (FeatureNotSupportedException)
                {
                    label01.Text = $"Text messaging is not supported on this device.\n{File_Manger01.API03?.Trim()}";
                }
                catch (Exception ex)
                {
                    label01.Text = $"Unable to open text messaging: {ex.Message}\n{File_Manger01.API03?.Trim()}";
                }
            }
            else
            {
                label03.Text = data01[25];
            }
        }
        private void email()
        {
            int count = 0;
            if (Security_Serv01.empty_string(entry01.Text, out data01[24]) == true)
            {
                count++;
                label01.Text = string.Empty;
            }
            else
            {
                count--;
                label01.Text = data01[24];
            }
            if (Security_Serv01.empty_string(entry02.Text, out data01[24]) == true)
            {
                if (Security_Serv01.email_check(entry02.Text, out data01[25]) == true)
                {
                    count++;
                    label02.Text = string.Empty;
                }
                else
                {
                    count--;
                    label02.Text = data01[25];
                }

            }
            else
            {
                count--;
                label02.Text = data01[24];
            }
            if (Security_Serv01.empty_string(entry03.Text, out data01[24]) == true)
            {
                if (Security_Serv01.phone_check(entry03.Text, out data01[25]) == true)
                {
                    count++;
                    label03.Text = string.Empty;
                }
                else
                {
                    count--;
                    label03.Text = data01[25];
                }

            }
            else
            {
                count--;
                label03.Text = data01[24];
            }
            if (Security_Serv01.empty_string(editor01.Text, out data01[24]) == true)
            {
                count++;
                label04.Text = string.Empty;
            }
            else
            {
                count--;
                label04.Text = data01[24];
            }
            if (count == 4)
            {
                if (Security_Serv01.is_connected_to_netwrok_andriod(out data01[26]) == true)
                {
                    if (Email_S01.send_email(entry02.Text, entry01.Text, entry03.Text, editor01.Text, out data01[27]) == true)
                    {
                        entry01.Text = string.Empty;
                        entry02.Text = string.Empty;
                        entry03.Text = string.Empty;
                        editor01.Text = string.Empty;
                        label05.Text = data01[27];
                    }
                    else
                    {
                        label05.Text = data01[27];
                    }
                }
                else
                {
                    label05.Text = data01[26];
                }
            }
            else
            {
                label05.Text = $"fix errors";
            }

        }
        private void load_Selection_View01()
        {

            load_default_view();
            Image01_D01.image01(image01);
            Background_D01.background01(this);
            image01.Source = File_M02.source[(int)File_Manger02.image_index01.Easy_Callender_page_1];
            Entrys01_D01.Entrys02(entry01);
            Entrys01_D01.Entrys02(entry02);
            Entrys01_D01.Entrys02(entry03);
            Editor_defaul01.Editors02(editor01);
            border01_D01.border008(border01);
            border01_D01.border002(border02);
            border01_D01.border002(border03);
            border01_D01.border002(border04);
            border01_D01.border002(border05);
            border01_D01.border008(border06);
            Labels01_D01.label04(label01);
            Labels01_D01.label04(label02);
            Labels01_D01.label04(label03);
            Labels01_D01.label04(label04);
            Labels01_D01.label04(label05);
            Button01_D01.button03(button01);
            Button01_D01.button03(button02);
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

            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = false;
            border04.IsVisible = false;
            border05.IsVisible = false;
            border06.IsVisible = true;


        }
        private void load_default_view01()
        {

            border01.IsVisible = true;
            border02.IsVisible = true;
            border03.IsVisible = false;
            border04.IsVisible = false;
            border05.IsVisible = false;
            border06.IsVisible = true;


        }
        private void load_default_view02()
        {
            border01.IsVisible = true;
            border02.IsVisible = true;
            border03.IsVisible = true;
            border04.IsVisible = true;
            border05.IsVisible = true;
            border06.IsVisible = true;


        }
        private void Picker01_SelectedIndexChanged(object? sender, EventArgs e)
        {

            switch (menu_array01[picker01.SelectedIndex])
            {
                case "call":
                    load_default_view();
                    label01.Text = string.Empty;
                    entry01.Text = string.Empty;
                    entry02.Text = string.Empty;
                    entry03.Text = string.Empty;
                    
                    break;
                case "text":
                    load_default_view01();
                    label01.Text = string.Empty;
                    entry01.Text = string.Empty;
                    entry01.Placeholder="Text";
                    entry01.Text = string.Empty;
                    entry02.Text = string.Empty;
                    entry03.Text = string.Empty;
                    
                    break;
                case "email":
                    load_default_view02();
                    entry01.Text = string.Empty;
                    entry02.Text = string.Empty;
                    entry03.Text = string.Empty;
                    label01.Text = string.Empty;
                    entry01.Placeholder = "Name";
                    entry02.Placeholder = "Email";
                    entry03.Placeholder = "Phonenumber";
                    editor01.Placeholder = "Message";
                    break;
                default:
                    load_default_view();
                    break;


            }
        }

        private void load_Selection01()
        {

            if (Security_Serv01.isPicker_selected(picker01, out data01[24]) == true)
            {
                string key = menu_array01[picker01.SelectedIndex].Trim();
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
            await button02.Navigation.PushAsync(new About_Main_View01());
        }
    }
}
