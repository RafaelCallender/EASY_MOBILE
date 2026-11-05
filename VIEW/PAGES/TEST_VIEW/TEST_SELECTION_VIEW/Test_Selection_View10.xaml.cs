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
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_HELPER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.TEST_VIEW.TEST_SELECTION_VIEW
{
    public partial class Test_Selection_View10 : ContentPage
    {
        private Background_Default01 Background_D01 = new Background_Default01();
        private static string[] data01 = new string[100];
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static Border01_Default border01_D01 = new Border01_Default();
        private static Image01_Default Image01_D01 = new Image01_Default();
        private static Labels01_Default Labels01_D01 = new Labels01_Default();
        private static string menu_string01 = $"Book_of_Jasher\n" +
            $"book_of_judith\n" +
            $"Dead_Sea_Scrolls\n" +
            $"The_Book_of_TOB\n"
 ;
        private static string[] menu_array01 = menu_string01.Split("\n");
        private static Button_Animation01 Button_A01 = new Button_Animation01();
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Picker01_Animation Picker01_A01 = new Picker01_Animation();
        private static Entrys01_Default Entrys01_D01 = new Entrys01_Default();
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        private static File_Manger13 File_M13 = new File_Manger13();
        private static File_Manger05 File_M05 = new File_Manger05();
        private static File_Helper01 File_H01 = new File_Helper01();
        private static File_Manger02 File_M02 = new File_Manger02();
        private static string book01 = string.Empty;
        private static string book02 = string.Empty;
        private static string book03 = string.Empty;
        private static string book04 = string.Empty;
        private static string book05 = string.Empty;
        private static string book06 = string.Empty;
        private static string book07 = string.Empty;
        public Test_Selection_View10()
        {

            InitializeComponent();
            load_Selection_View01();
            book01 = File_M13.Book_of_Jasher_pdf;
            book02 = File_M13.Book_of_Jasher_pdf;
            book03 = File_M13.book_of_judith_pdf;
            book04 = File_M13.Dead_Sea_Scrolls_pdf;
            book05 = File_M13.The_Book_of_Enoch_pdf;
            book06 = File_M13.The_Book_of_Jubilees_pdf;
            book07 = File_M13.The_Book_of_TOB_pdf;
        }

        private void load_Selection_data01()
        {
            string procedure = menu_array01[picker01.SelectedIndex].Trim();
            switch (procedure)
            {
                case "Book_of_Jasher":
                    _commands[procedure] = Book_of_Jasher;
                    break;
                case "book_of_judith":
                    _commands[procedure] = book_of_judith;
                    break;
                case "Dead_Sea_Scrolls":
                    _commands[procedure] = Dead_Sea_Scrolls;
                    break;
                case "The_Book_of_TOB":
                    _commands[procedure] = The_Book_of_TOB;
                    break;
            }
        }
        private void unknown01()
        {
            label01.Text = "not yet developed";
        }
        private void Book_of_Jasher()
        {
            label01.Text = book01;
        }
        private void book_of_judith()
        {
            label01.Text = book02;
        }
        private void Dead_Sea_Scrolls()
        {
            label01.Text = book03;
        }
        private void The_Book_of_TOB()
        {
            label01.Text = book04;
        }
        private void load_default_view01()
        {

            label01.IsVisible = false;
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
            picker01.ItemsSource = menu_array01.ToList();
            picker01.Title = "Select";
        }

        private void Picker01_SelectedIndexChanged(object? sender, EventArgs e)
        {

            switch (menu_array01[picker01.SelectedIndex])
            {

                case "Book_of_Jasher":
                    load_default_view01();
                    break;
                case "book_of_judith":
                    load_default_view01();
                    break;
                case "Dead_Sea_Scrolls":
                    load_default_view01();
                    break;
                case "The_Book_of_TOB":
                    load_default_view01();
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
            await button02.Navigation.PushAsync(new Test_Main_View01());
        }
    }
}