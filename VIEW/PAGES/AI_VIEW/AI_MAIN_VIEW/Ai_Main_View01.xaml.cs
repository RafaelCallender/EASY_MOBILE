
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.SELECTION_VIEW.SELECTION_MAIN_VIEW;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.AI_VIEW.AI_SELECTION_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BORDER.BORDER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.SELECTION_VIEW.SELECTION_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BACKGROUND.BACKGROUND_DEFAULT;
namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.AI_VIEW.AI_MAIN_VIEW
{

    public partial class Ai_Main_View01 : ContentPage
    {
        private Background_Default01 Background_D01 = new Background_Default01();
        private static File_Manger02 File_M02 = new File_Manger02();
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static Image01_Default Image01_D01 = new Image01_Default();
        private static Button_Animation01 Button_A01 = new Button_Animation01();
        private static Border01_Default border01_D01 = new Border01_Default();

        private static string menu_string = $"Hair changer\n" +
                                              "text to text generation\n" +
                                              "anime face changer\n" +
                                              "image generation\n" +
                                               "back\n";

        private static string[] menu_array = menu_string.Split("\n");

        public Ai_Main_View01()
        {

            InitializeComponent();
            load_Ai_Main_View01();
        }
        private void load_Ai_Main_View01()
        {
            Background_D01.background01(this);
            Image01_D01.image01(image01);
            image01.Source = File_M02.source[(int)File_Manger02.image_index01.Easy_Callender_page_1];
            border01_D01.border008(border01);
            Button01_D01.button03(button01);
            Button01_D01.button03(button02);
            Button01_D01.button03(button03);
            Button01_D01.button03(button04);
            Button01_D01.button03(button05);


            button01.Clicked += button01_clicked;
            button02.Clicked += button02_clicked;
            button03.Clicked += button03_clicked;
            button04.Clicked += button04_clicked;
            button05.Clicked += button05_clicked;

            button01.Text = menu_array[0];
            button02.Text =  menu_array[1];
            button03.Text =  menu_array[2];
            button04.Text =  menu_array[3];
            button05.Text =  menu_array[4];

        }


        private async void button01_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button01);
            await button01.Navigation.PushAsync(new Ai_Selection_View01());
        }
        private async void button02_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button02);
            await button02.Navigation.PushAsync(new Ai_Selection_View02());
        }
        private async void button03_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button03);
            await button03.Navigation.PushAsync(new Ai_Selection_View03());
        }
        private async void button04_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button04);
            await button04.Navigation.PushAsync(new Ai_Selection_View04());
        }
        private async void button05_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button05);
            await button05.Navigation.PushAsync(new Selection_Main_View01());
        }
    }

}