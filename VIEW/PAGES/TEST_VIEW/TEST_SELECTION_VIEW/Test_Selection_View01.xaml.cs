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
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_HELPER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_SERVICES;


namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.TEST_VIEW.TEST_SELECTION_VIEW
{
    public partial class Test_Selection_View01 : ContentPage
    {
        private string[] data01 = new string[100];
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static Border01_Default border01_D01 = new Border01_Default();
        private static Image01_Default Image01_D01 = new Image01_Default();
        private static Labels01_Default Labels01_D01 = new Labels01_Default();
        private static string menu_string01 = $"display images\n" +
                                               $"find images\n" +
                                                $"display text\n" +
                                     $"Admin_text\n" +
        $"API_string\n" +
$"Chemistry_text\n" +
        $"Chemistry01_text\n" +
        $"Client_Textfile01_txt\n" +
        $"cloudinary_com_text\n" +
        $"GMAIL_CREDENTIAL_text\n" +
        $"hairstyle_info_01_text\n" +
        $"hairstyle_info_02_text\n" +
        $"Language_Abbreviation_text\n" +
        $"Language_Name_text\n" +
       $"Linux01_text\n" +
        $"Sql_info01_text\n" +
        $"The_Bible_KJV_text\n" +
        $"The_Book_of_Enoch_text\n" +
        $"The_Book_of_Jubilees_text\n" +
          $"Book_of_Jasher_pdf\n" +
           $"book_of_judith_pdf\n" +
            $"Dead_Sea_Scrolls_pdf\n" +
            $"The_Book_of_Enoch_pdf\n" +
            $"The_Book_of_Jubilees_pdf\n" +
            $"The_Book_of_TOB_pdf\n" +
        $"nba_text\n";
        private static string[] menu_array01 = menu_string01.Split("\n", StringSplitOptions.RemoveEmptyEntries);
        private static Button_Animation01 Button_A01 = new Button_Animation01();
        private static Picker01_Animation Picker01_A01 = new Picker01_Animation();
        private static Entrys01_Default Entrys01_D01 = new Entrys01_Default();
        private static File_Manger02 File_M02 = new File_Manger02();
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static File_Manger13 File_M13 = new File_Manger13();

        public Test_Selection_View01()
        {
            InitializeComponent();
            load_Selection_View01();
        }
        private void load_default_view01()
        {
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = false;
            border04.IsVisible = true;
        }
        private void load_default_view02()
        {
            border01.IsVisible = true;
            border02.IsVisible = true;
            border03.IsVisible = false;
            border04.IsVisible = true;
        }
        private void load_Selection_View01()
        {
            load_default_view01();
            Image01_D01.image01(image01);
            image01.Source = File_M02.source[(int)File_Manger02.image_index01.Easy_Callender_page_1];
            Entrys01_D01.Entrys01(entry01);
            Entrys01_D01.Entrys01(entry02);
            border01_D01.border001(border01);
            border01_D01.border002(border02);
            border01_D01.border002(border03);
            Labels01_D01.label02(label01);
            Labels01_D01.label02(label02);
            Labels01_D01.label02(label03);
            Button01_D01.button01(button01);
            Button01_D01.button01(button02);
            button01.Clicked += button01_clicked;
            button02.Clicked += button02_clicked;
            button01.Text = "ok";
            button02.Text = "back";
            picker01.SelectedIndexChanged += Picker01_SelectedIndexChanged;
            picker01.ItemsSource = menu_array01.ToList();
            picker01.Title = "Select";
        }
        private void load_Selection_data01()
        {
            for (int i = 0; i < menu_array01.Length; i++)
            {
                string procedure = menu_array01[i].Trim();
                switch (menu_array01[picker01.SelectedIndex])
                {
                    case "display images":
                        _commands.Add(procedure, display_images);
                        break;
                    case "find images":
                        _commands.Add(procedure, find_images);
                        break;
                    case "Admin_text":
                        _commands.Add(procedure, Admin_text);
                        break;
                    case "API_string":
                        _commands.Add(procedure, API_string);
                        break;
                    case "Chemistry_text":
                        _commands.Add(procedure, Chemistry_text);
                        break;
                    case "Chemistry01_text":
                        _commands.Add(procedure, Chemistry01_text);
                        break;
                    case "Client_Textfile01_txt":
                        _commands.Add(procedure, Client_Textfile01_txt);
                        break;
                    case "cloudinary_com_text":
                        _commands.Add(procedure, cloudinary_com_text);
                        break;
                    case "GMAIL_CREDENTIAL_text":
                        _commands.Add(procedure, GMAIL_CREDENTIAL_text);
                        break;
                    case "hairstyle_info_01_text":
                        _commands.Add(procedure, hairstyle_info_01_text);
                        break;
                    case "hairstyle_info_02_text":
                        _commands.Add(procedure, hairstyle_info_02_text);
                        break;
                    case "Language_Abbreviation_text":
                        _commands.Add(procedure, Language_Abbreviation_text);
                        break;
                    case "Language_Name_text":
                        _commands.Add(procedure, Language_Name_text);
                        break;
                    case "Linux01_text":
                        _commands.Add(procedure, Linux01_text);
                        break;
                    case "Sql_info01_text":
                        _commands.Add(procedure, Sql_info01_text);
                        break;
                    case "The_Bible_KJV_text":
                        _commands.Add(procedure, The_Bible_KJV_text);
                        break;
                    case "The_Book_of_Enoch_text":
                        _commands.Add(procedure, The_Book_of_Enoch_text);
                        break;
                    case "The_Book_of_Jubilees_text":
                        _commands.Add(procedure, The_Book_of_Jubilees_text);
                        break;
                    case "nba_text":
                        _commands.Add(procedure, nba_text);
                        break;
                    case "Book_of_Jasher_pdf":
                        _commands.Add(procedure, Book_of_Jasher_pdf);
                        break;

                    case "Dead_Sea_Scrolls_pdf":
                        _commands.Add(procedure, Dead_Sea_Scrolls_pdf);
                        break;
                    case "The_Book_of_Enoch_pdf":
                        _commands.Add(procedure, The_Book_of_Enoch_pdf);
                        break;
                    case " The_Book_of_Jubilees_pdf":
                        _commands.Add(procedure, The_Book_of_Jubilees_pdf);
                        break;
                    case " The_Book_of_TOB_pdf":
                        _commands.Add(procedure, The_Book_of_TOB_pdf);
                        break;
                }
            }
        }


        private void Book_of_Jasher_pdf()
        {
            label03.Text = File_M13.Book_of_Jasher_pdf;
        }
        private void book_of_judith_pdf()
        {
            label03.Text = File_M13.book_of_judith_pdf;
        }
        private void Dead_Sea_Scrolls_pdf()
        {
            label03.Text = File_M13.Dead_Sea_Scrolls_pdf;
        }
        private void The_Book_of_Enoch_pdf()
        {
            label03.Text = File_M13.The_Book_of_Enoch_pdf;
        }
        private void The_Book_of_Jubilees_pdf()
        {
            label03.Text = File_M13.The_Book_of_Jubilees_pdf;
        }
        private void The_Book_of_TOB_pdf()
        {
            label03.Text = File_M13.The_Book_of_TOB_pdf;
        }
        private void display_images()
        {
            for (int i = 0; i < File_Helper01.data03.Length; i++)
            {
                label03.Text += $"{i}.){File_Helper01.data03[i]}\n";
            }

        }

        private void Admin_text()
        {
            label03.Text = File_Manger01.Admin_text01;
        }
        private void API_string()
        {
            label03.Text = File_Manger01.API_string;
        }
        private void Chemistry_text()
        {
            label03.Text = File_Manger01.Chemistry_text;
        }
        private void Chemistry01_text()
        {
            label03.Text = File_Manger01.Chemistry01_text;
        }
        private void Client_Textfile01_txt()
        {
            label03.Text = File_Manger01.Client_Textfile01_txt;
        }
        private void cloudinary_com_text()
        {
            label03.Text = File_Manger01.cloudinary_com_text01;
        }
        private void GMAIL_CREDENTIAL_text()
        {
            label03.Text = File_Manger01.GMAIL_CREDENTIAL_text;
        }
        private void hairstyle_info_01_text()
        {
            label03.Text = File_Manger01.hairstyle_info_01_text;
        }
        private void hairstyle_info_02_text()
        {
            label03.Text = File_Manger01.hairstyle_info_02_text;
        }
        private void Language_Abbreviation_text()
        {
            label03.Text = File_Manger01.Language_Abbreviation_text;
        }
        private void Language_Name_text()
        {
            label03.Text = File_Manger01.Language_Name_text;
        }
        private void Linux01_text()
        {
            label03.Text = File_Manger01.Linux01_text;
        }
        private void Sql_info01_text()
        {
            label03.Text = File_Manger01.Sql_info01_text;
        }
        private void The_Bible_KJV_text()
        {
            label03.Text = File_Manger01.The_Bible_KJV_text;
        }
        private void The_Book_of_Enoch_text()
        {
            label03.Text = File_Manger01.The_Book_of_Enoch_text;
        }
        private void The_Book_of_Jubilees_text()
        {
            label03.Text = File_Manger01.The_Book_of_Jubilees_text;
        }
        private void nba_text()
        {
            label03.Text = File_Manger01.nba_text;
        }
        private void find_images()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[25]) == true)
            {
                //  label03.Text = $"{File_S01.find_directory(entry01.Text)}\n";
                label03.Text = "needs work";
            }
            else
            {
                label03.Text = data01[25];
            }
        }
        private void Picker01_SelectedIndexChanged(object? sender, EventArgs e)
        {
            switch (menu_array01[picker01.SelectedIndex])
            {

                case "display images":
                    load_default_view01();
                    label03.Text = string.Empty;
                    break;
                case "find images":
                    entry01.Placeholder = "file name";
                    load_default_view02();
                    label03.Text = string.Empty;
                    break;
                case "display text":
                    load_default_view01();
                    label03.Text = string.Empty;
                    break;
                case "Admin_text":
                    load_default_view01();
                    label03.Text = string.Empty;
                    break;
                case "API_string":
                    load_default_view01();
                    label03.Text = string.Empty;
                    break;
                case "Chemistry_text":
                    load_default_view01();
                    label03.Text = string.Empty;
                    break;
                case "Chemistry01_text":
                    load_default_view01();
                    label03.Text = string.Empty;
                    break;
                case "Client_Textfile01_txt":
                    load_default_view01();
                    label03.Text = string.Empty;
                    break;
                case "cloudinary_com_text":
                    load_default_view01();
                    label03.Text = string.Empty;
                    break;
                case "GMAIL_CREDENTIAL_text":
                    load_default_view01();
                    label03.Text = string.Empty;
                    break;
                case "hairstyle_info_01_text":
                    load_default_view01();
                    label03.Text = string.Empty;
                    break;
                case "hairstyle_info_02_text":
                    load_default_view01();
                    label03.Text = string.Empty;
                    break;
                case "Language_Abbreviation_text":
                    load_default_view01();
                    label03.Text = string.Empty;
                    break;
                case "Language_Name_text":
                    load_default_view01();
                    label03.Text = string.Empty;
                    break;
                case "Linux01_text":
                    load_default_view01();
                    label03.Text = string.Empty;
                    break;
                case "Sql_info01_text":
                    load_default_view01();
                    label03.Text = string.Empty;
                    break;
                case "The_Bible_KJV_text":
                    load_default_view01();
                    label03.Text = string.Empty;
                    break;
                case "The_Book_of_Enoch_text":
                    load_default_view01();
                    label03.Text = string.Empty;
                    break;
                case "The_Book_of_Jubilees_text":
                    load_default_view01();
                    label03.Text = string.Empty;
                    break;
                case "nba_text":
                    load_default_view01();
                    label03.Text = string.Empty;
                    break;
                case "Book_of_Jasher_pdf":
                    load_default_view01();
                    label03.Text = string.Empty;
                    break;
                case "book_of_judith_pdf ":
                    load_default_view01();
                    label03.Text = string.Empty;
                    break;
                case "Dead_Sea_Scrolls_pdf":
                    load_default_view01();
                    label03.Text = string.Empty;
                    break;
                case "The_Book_of_Enoch_pdf":
                    load_default_view01();
                    label03.Text = string.Empty;
                    break;
                case "The_Book_of_Jubilees_pdf":
                    load_default_view01();
                    label03.Text = string.Empty;
                    break;
                case "The_Book_of_TOB_pdf":
                    load_default_view01();
                    label03.Text = string.Empty;
                    break;
                default:
                    load_default_view01();
                    label03.Text = string.Empty;
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
            await button02.Navigation.PushAsync(new Test_Main_View01());
        }
    }
}