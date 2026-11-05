using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BACKGROUND.BACKGROUND_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.LABELS.LABEL_DEFAULTS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_ANIMATION;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.TEST_VIEW.TEST_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BORDER.BORDER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS.ENTRY_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;

namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.TEST_VIEW.TEST_SELECTION_VIEW
{
    public partial class Test_Selection_View05 : ContentPage
    {
        private Background_Default01 Background_D01 = new Background_Default01();
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static Border01_Default border01_D01 = new Border01_Default();
        private static Image01_Default Image01_D01 = new Image01_Default();
        private static Labels01_Default Labels01_D01 = new Labels01_Default();
        private static string menu_string = $"mytextfile01\n" +
                        $"mytextfile02\n" +
                        $"mytextfile03\n" +
                        $"mytextfile04\n" +
                        $"mytextfile05\n" +
                        $"mytextfile06\n" +
                        $"mytextfile07\n" +
                        $"mytextfile08\n" +
                        $"mytextfile09\n" +
                        $"list all\n";
        private static string[] menu_array = menu_string.Split("\n");
        private static Button_Animation01 Button_A01 = new Button_Animation01();
        private static Picker01_Animation Picker01_A01 = new Picker01_Animation();
        private static Entrys01_Default Entrys01_D01 = new Entrys01_Default();
        private static File_Manger02 File_M02 = new File_Manger02();
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        public Test_Selection_View05()
        {

            InitializeComponent();
            load_Selection_View01();
        }
        private void load_Selection_data01()
        {
            string procedure = menu_array[picker01.SelectedIndex].Trim();
            switch (procedure)
            {
                case "mytextfile01":
                    _commands.Add(procedure, mytextfile01);
                    break;
                case "mytextfile02":
                    _commands.Add(procedure, mytextfile02);
                    break;
                case "mytextfile03":
                    _commands.Add(procedure, mytextfile03);
                    break;
                case "mytextfile04":
                    _commands.Add(procedure, mytextfile04);
                    break;
                case "mytextfile05":
                    _commands.Add(procedure, mytextfile05);
                    break;
                case "mytextfile06":
                    _commands.Add(procedure, mytextfile06);
                    break;
                case "mytextfile07":
                    _commands.Add(procedure, mytextfile07);
                    break;
                case "mytextfile08":
                    _commands.Add(procedure, mytextfile08);
                    break;
                case "mytextfile09":
                    _commands.Add(procedure, mytextfile09);
                    break; ;
                case "list all":
                    _commands.Add(procedure, list_all);
                    break;
            }

        }
        private void mytextfile01()
        {
            label01.Text = File_Manger01.save_files[0];
        }
        private void mytextfile02()
        {
            label01.Text = File_Manger01.save_files[1];
        }
        private void mytextfile03()
        {
            label01.Text = File_Manger01.save_files[2];
        }
        private void mytextfile04()
        {
            label01.Text = File_Manger01.save_files[3];
        }
        private void mytextfile05()
        {
            label01.Text = File_Manger01.save_files[4];
        }
        private void mytextfile06()
        {
            label01.Text = File_Manger01.save_files[5];
        }
        private void mytextfile07()
        {
            label01.Text = File_Manger01.save_files[6];
        }
        private void mytextfile08()
        {
            label01.Text = File_Manger01.save_files[7];
        }
        private void mytextfile09()
        {
            label01.Text = File_Manger01.save_files[8];
        }
        private void mytextfile10()
        {
            label01.Text = File_Manger01.save_files[9];
        }
        private void list_all()
        {
            for (int i = 0; i < File_Manger01.save_files.Length; i++)
            {
                label01.Text = File_Manger01.save_files[i];
            }

        }
        private void load_default_view01()
        {

        
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = true;

        }


        private void load_Selection_View01()
        {
            Background_D01.background01(this);
            load_default_view01();
            Image01_D01.image01(image01);
            image01.Source = File_M02.source[(int)File_Manger02.image_index01.Easy_Callender_page_1];
            Entrys01_D01.Entrys02(entry01);
            border01_D01.border008(border01);
            border01_D01.border008(border02);
            border01_D01.border008(border03);
            Labels01_D01.label04(label01);
            Button01_D01.button03(button01);
            Button01_D01.button03(button02);
            button01.Clicked += button01_clicked;
            button02.Clicked += button02_clicked;
            button01.Text = "ok";
            button02.Text = "back";
            picker01.SelectedIndexChanged += Picker01_SelectedIndexChanged;
            picker01.ItemsSource = menu_array.ToList();
            picker01.Title = "Select";
        }

        private void Picker01_SelectedIndexChanged(object? sender, EventArgs e)
        {

            switch (menu_array[picker01.SelectedIndex])
            {
              
                case "mytextfile01":
                    load_default_view01();
                    break;
                case "mytextfile02":
                    load_default_view01();
                    break;
                case "mytextfile03":
                    load_default_view01();
                    break;
                case "mytextfile04":
                    load_default_view01();
                    break;
                case "mytextfile05":
                    load_default_view01();
                    break;
                case "mytextfile06":
                    load_default_view01();
                    break;
                case "mytextfile07":
                    load_default_view01();
                    break;
                case "mytextfile08":
                    load_default_view01();
                    break;
                case "mytextfile09":
                    load_default_view01();
                    break;
                case "list all":
                    load_default_view01();
                    break;
            }
        }

        private void load_Test_Selection_View05_data()
        {
            if (Security_Serv01.isPicker_selected(picker01, out data01[24]) == true)
            {
                int selection = picker01.SelectedIndex;
                int stringlength = menu_array.Length;
                if (selection >= 0 &&
                    selection < stringlength)
                {
                    string key = menu_array[selection].Trim();
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
            load_Test_Selection_View05_data();
        }
        private async void button02_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button02);
            await button02.Navigation.PushAsync(new Test_Main_View01());
        }
    }
}