using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_DEFAULT;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.AI_VIEW.AI_MAIN_VIEW;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.EMAIL_VIEW.EMAIL_MAIN_VIEW;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.LIFE_STUDY_VIEW.LIFE_MAIN_VIEW;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.MOVIES_VIEW.MOVIES_MAIN_VIEW;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.NEWS_VIEW.NEWS_MAIN_VIEW;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.SCIENCE_VIEW.SCIENCE_MAIN_VIEW;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.SPORTS_VIEW.SPORTS_MAIN_VIEW;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.STUIDO_VIEW.STUDIO_MAIN_VIEW;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.TEST_VIEW.TEST_MAIN_VIEW;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.TRANSLATE_VIEW.TRANSLATE_MAIN_VIEW;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.USER_VIEW.USER_MAIN_VIEW;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.JOURNAL_VIEW.JOURNAL_MAIN_VIEW;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.LOCATION_VIEW.LOCATION_MAIN_VIEW;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.CLIENT_VIEW.CLIENT_MAIN_VIEW;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.NETWORK_VIEW.NETWORK_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BORDER.BORDER_DEFAULT;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.DOCUMENT_VIEW.DOCUMENT_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT;

namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.SELECTION_VIEW.SELECTION_MAIN_VIEW
{
    public partial class Selection_Main_View01 : ContentPage
    {
        private static File_Manger02 File_M02 = new File_Manger02();
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static Button_Animation01 Button_A01 = new Button_Animation01();
        private static Border01_Default border01_D01 = new Border01_Default();
        private static Image01_Default Image01_D01 = new Image01_Default();
        private static string menu_string = $"AI_VIEW\n" +
                    $"CLIENT_VIEW\n" +
                    $"EMAIL_VIEW\n" +
                    $"JOURNAL_VIEW\n" +
                    $"LIFE_STUDY_VIEW\n" +
                    $"LOCATION_VIEW\n" +
                    $"MOVIES_VIEW\n" +
                    $"NETWORK_VIEW\n" +
                    $"NEWS_VIEW\n" +
                    $"SCIENCE_VIEW\n" +
                    $"SPORTS_VIEW\n" +
                    $"STUDIO_VIEW\n" +
                    $"TEST_VIEW\n" +
                    $"TRANSLATE_VIEW\n" +
                    $"USER_VIEW\n" +
                    $"DOCUMENT_VIEW\n";

        private static string[] menu_array = menu_string.Split("\n");




        public Selection_Main_View01()
        {
            InitializeComponent();
            load_Selection_Main_View01();
        }
        private void load_Selection_Main_View01()
        {
            Image01_D01.image01(image01);
            image01.Source = File_M02.source[(int)File_Manger02.image_index01.Easy_Callender_page_1];
            Button01_D01.button01(button01);
            Button01_D01.button01(button02);
            Button01_D01.button01(button03);
            Button01_D01.button01(button04);
            Button01_D01.button01(button05);
            Button01_D01.button01(button06);
            Button01_D01.button01(button07);
            Button01_D01.button01(button08);
            Button01_D01.button01(button09);
            Button01_D01.button01(button10);
            Button01_D01.button01(button11);
            Button01_D01.button01(button12);
            Button01_D01.button01(button13);
            Button01_D01.button01(button14);
            Button01_D01.button01(button15);
            Button01_D01.button01(button16);
            button01.Clicked += button01_clicked;
            button02.Clicked += button02_clicked;
            button03.Clicked += button03_clicked;
            button04.Clicked += button04_clicked;
            button05.Clicked += button05_clicked;
            button06.Clicked += button06_clicked;
            button07.Clicked += button07_clicked;
            button08.Clicked += button08_clicked;
            button09.Clicked += button09_clicked;
            button10.Clicked += button10_clicked;
            button11.Clicked += button11_clicked;
            button12.Clicked += button12_clicked;
            button13.Clicked += button13_clicked;
            button14.Clicked += button14_clicked;
            button15.Clicked += button15_clicked;
            button16.Clicked += button16_clicked;
            button01.Text = menu_array[0];
            button02.Text = menu_array[1];
            button03.Text = menu_array[2];
            button04.Text = menu_array[3];
            button05.Text = menu_array[4];
            button06.Text = menu_array[5];
            button07.Text = menu_array[6];
            button08.Text = menu_array[7];
            button09.Text = menu_array[8];
            button10.Text = menu_array[9];
            button11.Text = menu_array[10];
            button12.Text = menu_array[11];
            button13.Text = menu_array[12];
            button14.Text = menu_array[13];
            button15.Text = menu_array[14];
            button15.Text = menu_array[15];
        }
        private async void button01_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button01);
            await button01.Navigation.PushAsync(new Ai_Main_View01());
        }
        private async void button02_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button02);
            await button02.Navigation.PushAsync(new Client_Main_View01());
        }
        private async void button03_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button03);
            await button03.Navigation.PushAsync(new Email_Main_View01());
        }
        private async void button04_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button04);
            await button04.Navigation.PushAsync(new Journal_Main_View01());
        }
        private async void button05_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button05);
            await button05.Navigation.PushAsync(new Life_Main_View01());
        }
        private async void button06_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button06);
            await button06.Navigation.PushAsync(new Location_Main_View01());
        }
        private async void button07_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button07);
            await button07.Navigation.PushAsync(new Movies_Main_View01());
        }
        private async void button08_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button08);
            await button08.Navigation.PushAsync(new Network_Main_View01());
        }
        private async void button09_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button09);
            await button09.Navigation.PushAsync(new News_Main_View01());
        }
        private async void button10_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button10);
            await button10.Navigation.PushAsync(new Science_Main_View01());
        }
        private async void button11_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button11);
            await button11.Navigation.PushAsync(new Sports_Main_View01());
        }
        private async void button12_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button12);
            await button12.Navigation.PushAsync(new Studio_Main_View01());
        }
        private async void button13_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button13);
            await button13.Navigation.PushAsync(new Test_Main_View01());
        }
        private async void button14_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button14);
            await button14.Navigation.PushAsync(new Translate_Main_View01());
        }
        private async void button15_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button15);
            await button15.Navigation.PushAsync(new User_Main_View01());
        }
        private async void button16_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button15);
            await button15.Navigation.PushAsync(new Document_Main_View01());
        }
    }
}