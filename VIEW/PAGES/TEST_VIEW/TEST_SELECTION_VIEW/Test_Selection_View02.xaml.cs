using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BACKGROUND.BACKGROUND_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.LABELS.LABEL_DEFAULTS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_ANIMATION;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.TEST_VIEW.TEST_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BORDER.BORDER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS.ENTRY_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_HELPER;

namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.TEST_VIEW.TEST_SELECTION_VIEW
{
    public partial class Test_Selection_View02 : ContentPage
    {
        private Background_Default01 Background_D01 = new Background_Default01();
        private static string[] data01 = new string[100];
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static Border01_Default border01_D01 = new Border01_Default();
        private static Image01_Default Image01_D01 = new Image01_Default();
        private static Labels01_Default Labels01_D01 = new Labels01_Default();
        private static string menu_string =
  $"API01\n" +
                   $"API02\n" +
                   $"API03\n" +
                   $"Client_Textfile01\n" +
                   $"Client_Textfile02\n" +
                   $"Client_Textfile03\n" +
                   $"Client_Textfile04\n" +
                   $"Client_Textfile05\n" +
                   $"cloudinary_com_text01\n" +
                   $"cloudinary_com_text02\n" +
                   $"cloudinary_com_text03\n" +
                   $"Admin_text01\n" +
                   $"Admin_text02\n" +
                   $"Admin_text03\n" +
                   $"Admin_text04\n" +
                   $"Linux_text04\n" +
                   $"Linux_text05\n" +
                   $"Linux_text06\n" +
                   $"list all textfiles\n" +
                   $"list all textfiles 01\n" +
                   $"list all saved textfiles\n" +
                   $"list all saved textfiles 01\n" +
                   $"list all directories\n" +
                    $"list all directories 01\n" +
                    $"data reader\n" +
$"data reader 01\n" +
$"file array\n";
        private static string[] menu_array01 = menu_string.Split("\n");
        private static Button_Animation01 Button_A01 = new Button_Animation01();
        private static Picker01_Animation Picker01_A01 = new Picker01_Animation();
        private static Entrys01_Default Entrys01_D01 = new Entrys01_Default();
        private static File_Manger02 File_M02 = new File_Manger02();
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        private static Security_Services01 Security_Serv01 = new Security_Services01();

        public Test_Selection_View02()
        {

            InitializeComponent();
            load_Selection_View01();
        }
        private void load_Selection_data01()
        {
            string procedure = menu_array01[picker01.SelectedIndex].Trim();
            switch (procedure)
            {

                case "API01":
                    _commands.Add(procedure, API01);
                    break;
                case "API02":
                    _commands.Add(procedure, API02);
                    break;
                case "API03":
                    _commands.Add(procedure, API03);
                    break;
                case "Client_Textfile01":
                    _commands.Add(procedure, Client_Textfile01);
                    break;
                case "Client_Textfile02":
                    _commands.Add(procedure, Client_Textfile02);
                    break;
                case "Client_Textfile03":
                    _commands.Add(procedure, Client_Textfile03);
                    break;
                case "Client_Textfile04":
                    _commands.Add(procedure, Client_Textfile04);
                    break;
                case "Client_Textfile05":
                    _commands.Add(procedure, Client_Textfile05);
                    break;
                case "cloudinary_com_text01":
                    _commands.Add(procedure, cloudinary_com_text01);
                    break;
                case "cloudinary_com_text02":
                    _commands.Add(procedure, cloudinary_com_text02);
                    break;
                case "cloudinary_com_text03":
                    _commands.Add(procedure, cloudinary_com_text03);
                    break;
                case "Admin_text01":
                    _commands.Add(procedure, Admin_text01);
                    break;
                case "Admin_text02":
                    _commands.Add(procedure, Admin_text02);
                    break;
                case "Admin_text03":
                    _commands.Add(procedure, Admin_text03);
                    break;
                case "Admin_text04":
                    _commands.Add(procedure, Admin_text04);
                    break;
                case "Linux_text04":
                    _commands.Add(procedure, Linux_text04);
                    break;
                case "Linux_text05":
                    _commands.Add(procedure, Linux_text05);
                    break;
                case "Linux_text06":
                    _commands.Add(procedure, Linux_text06);
                    break;
                case "list all textfiles":
                    _commands.Add(procedure, list_all_textfiles);
                    break;
                case "list all textfiles 01":
                    _commands.Add(procedure, list_all_textfiles01);
                    break;
                case "list all saved textfiles":
                    _commands.Add(procedure, list_all_saved_textfiles);
                    break;
                case "list all saved textfiles 01":
                    _commands.Add(procedure, list_all_saved_textfiles01);
                    break;
                case "list all directories":
                    _commands.Add(procedure, list_all_directories);
                    break;
                case "list all directories 01":
                    _commands.Add(procedure, list_all_directories_01);
                    break;
                case "data reader":
                    _commands.Add(procedure, data_reader);
                    break;
                case "data reader 01":
                    _commands.Add(procedure, data_reader_01);
                    break;
                case "file array":
                    _commands.Add(procedure, file_array);
                    break;

            }
        }
        private void list_all_textfiles01()
        {

           label01.Text =

            $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.Admin]}\n" +
              $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.API]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.Chemistry]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.Chemistry01]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.Client_Textfile01]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.cloudinary_com]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.GMAIL_CREDENTIAL]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.hairstyle_info_01]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.hairstyle_info_02]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.Language_Abbreviation]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.Language_Name]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.Sql_info01]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.The_Bible_KJV]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.The_Book_of_Enoch]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.The_Book_of_Jubilees]}\n" +
       $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.nba_text]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.Linux01]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.mytextfile01]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.mytextfile02]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.mytextfile03]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.mytextfile04]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.mytextfile05]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.mytextfile06]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.mytextfile07]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.aboutus]}\n"

            ;
        }
        
        private void list_all_directories()
        {
            foreach (string a in File_Helper01.directories)
            {
                label01.Text += $"{a}\n";
            }
        }
        private void list_all_directories_01()
        {
            label01.Text =
       $"{File_Helper01.directories[(int)File_Helper01.directories_string.dog_breads]}\n" +
   $"{File_Helper01.directories[(int)File_Helper01.directories_string.cashapp01]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.default_group_face01]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.default_single_face01]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.default_single_face02]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.default_single_face03]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.cashapp02]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.cashapp03]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.EYE_ICON01]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.paypal01]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.paypal02]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.paypal03]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.venmo02]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.venmo03]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.zelleimage01]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.zelleimages02]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.learning_icon01]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.person01]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.Easy_Callender_page_1]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.venmo01]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.GMAIL01]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.Book_of_Jasher]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.book_of_judith]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.Dead_Sea_Scrolls]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.The_Book_of_Enoch]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.The_Book_of_Jubilees]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.The_Book_of_TOB]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.Admin]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.API]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.Chemistry]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.Chemistry01]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.Client_Textfile01]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.cloudinary_com]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.GMAIL_CREDENTIAL]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.hairstyle_info_01]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.hairstyle_info_02]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.Language_Abbreviation]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.Language_Name]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.Sql_info01]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.The_Bible_KJV]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.The_Book_of_Enoch_pdf]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.The_Book_of_Jubilees_pdf]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.nba_text]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.Linux01]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.mytextfile01]}\n" +
           $"{File_Helper01.directories[(int)File_Helper01.directories_string.mytextfile02]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.mytextfile03]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.mytextfile04]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.mytextfile05]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.mytextfile06]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.mytextfile07]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.aboutus]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.resume01]}\n"

        ;
        }

        private void list_all_saved_textfiles01()
        {
            label01.Text = $"{File_Helper01.SavedTextDirectory01[(int)File_Helper01.SavedTextDirectory_strings.mytextfile01]}\n" +
                              $"{File_Helper01.SavedTextDirectory01[(int)File_Helper01.SavedTextDirectory_strings.mytextfile02]}\n" +
                              $"{File_Helper01.SavedTextDirectory01[(int)File_Helper01.SavedTextDirectory_strings.mytextfile03]}\n" +
                              $"{File_Helper01.SavedTextDirectory01[(int)File_Helper01.SavedTextDirectory_strings.mytextfile04]}\n" +
                              $"{File_Helper01.SavedTextDirectory01[(int)File_Helper01.SavedTextDirectory_strings.mytextfile05]}\n" +
                              $"{File_Helper01.SavedTextDirectory01[(int)File_Helper01.SavedTextDirectory_strings.mytextfile06]}\n"



            ;

        }

        private void data_reader()
        {
            foreach (string a in File_Helper01.data01)
            {
                label01.Text += $"{a}\n";
            }

        }

        private void file_array()
        {
            foreach (string a in File_Helper01.file_array01)
            {
                label01.Text += $"{a}\n";
            }

        }
        private void data_reader_01()
        {
            label01.Text =

     $"Admin:{File_Helper01.data01[(int)File_Helper01.text_string.Admin]}\n" +
       $"API: {File_Helper01.data01[(int)File_Helper01.text_string.API]}\n" +
 $"Chemistry: {File_Helper01.data01[(int)File_Helper01.text_string.Chemistry]}\n" +
 $"Chemistry01: {File_Helper01.data01[(int)File_Helper01.text_string.Chemistry01]}\n" +
 $"Client_Textfile01: {File_Helper01.data01[(int)File_Helper01.text_string.Client_Textfile01]}\n" +
 $"cloudinary_com: {File_Helper01.data01[(int)File_Helper01.text_string.cloudinary_com]}\n" +
 $"GMAIL_CREDENTIAL: {File_Helper01.data01[(int)File_Helper01.text_string.GMAIL_CREDENTIAL]}\n" +
 $"hairstyle_info_01: {File_Helper01.data01[(int)File_Helper01.text_string.hairstyle_info_01]}\n" +
 $"hairstyle_info_02: {File_Helper01.data01[(int)File_Helper01.text_string.hairstyle_info_02]}\n" +
 $"Language_Abbreviation: {File_Helper01.data01[(int)File_Helper01.text_string.Language_Abbreviation]}\n" +
 $"Language_Name:{File_Helper01.data01[(int)File_Helper01.text_string.Language_Name]}\n" +
 $"Sql_info01:{File_Helper01.data01[(int)File_Helper01.text_string.Sql_info01]}\n" +
 $"The_Bible_KJV:{File_Helper01.data01[(int)File_Helper01.text_string.The_Bible_KJV]}\n" +
 $"The_Book_of_Enoch:{File_Helper01.data01[(int)File_Helper01.text_string.The_Book_of_Enoch]}\n" +
 $"The_Book_of_Jubilees:{File_Helper01.data01[(int)File_Helper01.text_string.The_Book_of_Jubilees]}\n" +
 $"nba_text:{File_Helper01.data01[(int)File_Helper01.text_string.nba_text]}\n" +
 $"Linux01:{File_Helper01.data01[(int)File_Helper01.text_string.Linux01]}\n" +
 $"mytextfile01:{File_Helper01.data01[(int)File_Helper01.text_string.mytextfile01]}\n" +
 $"mytextfile02:{File_Helper01.data01[(int)File_Helper01.text_string.mytextfile02]}\n" +
 $"mytextfile03:{File_Helper01.data01[(int)File_Helper01.text_string.mytextfile03]}\n" +
 $"mytextfile04:{File_Helper01.data01[(int)File_Helper01.text_string.mytextfile04]}\n" +
 $"mytextfile05:{File_Helper01.data01[(int)File_Helper01.text_string.mytextfile05]}\n" +
 $"mytextfile06:{File_Helper01.data01[(int)File_Helper01.text_string.mytextfile06]}\n" +
 $"mytextfile07:{File_Helper01.data01[(int)File_Helper01.text_string.mytextfile07]}\n" +
 $"aboutus:{File_Helper01.data01[(int)File_Helper01.text_string.aboutus]}\n"

     ;

        }

        private void API01()
        {
            label01.Text = File_Manger01.API01;
        }
        private void API02()
        {

            label01.Text = File_Manger01.API02;
        }
        private void API03()
        {

            label01.Text = File_Manger01.API03;
        }
        private void Client_Textfile01()
        {
            label01.Text = File_Manger01.API03;
        }
        private void Client_Textfile02()
        {
            label01.Text = File_Manger01.API03;
        }
        private void Client_Textfile03()
        {
            label01.Text = File_Manger01.API03;
        }
        private void Client_Textfile04()
        {
            label01.Text = File_Manger01.API03;
        }
        private void Client_Textfile05()
        {
            label01.Text = File_Manger01.API03;
        }
        private void cloudinary_com_text01()
        {
            label01.Text = File_Manger01.API03;
        }
        private void cloudinary_com_text02()
        {
            label01.Text = File_Manger01.API03;
        }
        private void cloudinary_com_text03()
        {
            label01.Text = File_Manger01.API03;
        }
        private void Admin_text01()
        {
            label01.Text = File_Manger01.API03;
        }
        private void Admin_text02()
        {
            label01.Text = File_Manger01.API03;
        }
        private void Admin_text03()
        {
            label01.Text = File_Manger01.API03;
        }
        private void Admin_text04()
        {
            label01.Text = File_Manger01.API03;
        }
        private void Linux_text04()
        {
            label01.Text = File_Manger01.API03;
        }
        private void Linux_text05()
        {
            label01.Text = File_Manger01.API03;
        }
        private void Linux_text06()
        {
            label01.Text = File_Manger01.API03;
        }
        private void list_all_textfiles()
        {
            int count = 0;
            foreach (string a in File_Helper01.text_files_list)
            {
                count++;
                label01.Text = $"{count}.){a}\n";
            }

        }
        private void list_all_saved_textfiles()
        {
            label01.Text = $"{File_Helper01.SavedTextDirectory[(int)File_Helper01.SavedTextDirectory_strings.mytextfile01]}\n" +
                              $"{File_Helper01.SavedTextDirectory[(int)File_Helper01.SavedTextDirectory_strings.mytextfile02]}\n" +
                              $"{File_Helper01.SavedTextDirectory[(int)File_Helper01.SavedTextDirectory_strings.mytextfile03]}\n" +
                              $"{File_Helper01.SavedTextDirectory[(int)File_Helper01.SavedTextDirectory_strings.mytextfile04]}\n" +
                              $"{File_Helper01.SavedTextDirectory[(int)File_Helper01.SavedTextDirectory_strings.mytextfile05]}\n" +
                              $"{File_Helper01.SavedTextDirectory[(int)File_Helper01.SavedTextDirectory_strings.mytextfile06]}\n";

        }
        private void load_Selection_View01()
        {
            Background_D01.background01(this);
            Image01_D01.image01(image01);
            image01.Source = File_M02.source[(int)File_Manger02.image_index01.Easy_Callender_page_1];
            Entrys01_D01.Entrys02(entry01);
            load_default_view();
            border01_D01.border008(border01);
            border01_D01.border002(border02);
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

        private void load_default_view()
        {
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = true;
        }
        private void load_default_view01()
        {
            border01.IsVisible = true;
            border02.IsVisible = true;
            border03.IsVisible = true;
        }
        private void Picker01_SelectedIndexChanged(object? sender, EventArgs e)
        {

            switch (menu_array01[picker01.SelectedIndex])
            {
                case "API01":
                    load_default_view();
                    break;
                case "API02":
                    load_default_view();
                    break;
                case "API03":
                    load_default_view();
                    break;
                case "Client_Textfile01":
                    load_default_view();
                    break;
                case "Client_Textfile02":
                    load_default_view();
                    break;
                case "Client_Textfile03":
                    load_default_view();
                    break;
                case "Client_Textfile04":
                    load_default_view();
                    break;
                case "Client_Textfile05":
                    load_default_view();
                    break;
                case "cloudinary_com_text01":
                    load_default_view();
                    break;
                case "cloudinary_com_text02":
                    load_default_view();
                    break;
                case "cloudinary_com_text03":
                    load_default_view();
                    break;
                case "Admin_text01":
                    load_default_view();
                    break;
                case "Admin_text02":
                    load_default_view();
                    break;
                case "Admin_text03":
                    load_default_view();
                    break;
                case "Admin_text04":
                    load_default_view();
                    break;
                case "Linux_text04":
                    load_default_view();
                    break;
                case "Linux_text05":
                    load_default_view();
                    break;
                case "Linux_text06":
                    load_default_view();
                    break;
                case "list all textfiles":
                    load_default_view();
                    break;
                case "list all saved textfiles":
                    load_default_view();
                    break;
                case "list all saved textfiles 01":
                    load_default_view();
                    break;
                case "list all directories":
                    load_default_view();
                    break;
                case "list all directories 01":
                    load_default_view();
                    break;
                case "data reader":
                    load_default_view();
                    break;
                case "data reader 01":
                    load_default_view();
                    break;
                case "file array":
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
            await button02.Navigation.PushAsync(new Test_Main_View01());
        }
    }
}