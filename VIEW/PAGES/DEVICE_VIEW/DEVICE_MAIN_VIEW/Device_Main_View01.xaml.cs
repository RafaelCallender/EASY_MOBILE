using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BACKGROUND.BACKGROUND_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_DEFAULT;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.SELECTION_VIEW.SELECTION_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BORDER.BORDER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.COLORS_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.DEVICE_VIEW.DEVICE_SELECTION_VIEW;
namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.DEVICE_VIEW.DEVICE_MAIN_VIEW
{

    public partial class Device_Main_View01 : ContentPage
    {
        private Background_Default01 Background_D01 = new Background_Default01();
        private static Border01_Default border01_D01 = new Border01_Default();
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static Button_Animation01 Button_A01 = new Button_Animation01();
        private static Image01_Default Image01_D01 = new Image01_Default();

        private static File_Manger02 File_M02 = new File_Manger02();
          private static string menu_string01 =
                                           $"device  01\n" +
                                                   $"back\n" ;
                       


        private static string[] menu_array01 = menu_string01.Split("\n");
        public Device_Main_View01()
        {
            InitializeComponent();
            load_Colors_Main_View01();
        }
        private void load_Colors_Main_View01()
        {
            Background_D01.background01(this);
            Image01_D01.image01(image01);
            image01.Source = File_M02.source[(int)File_Manger02.image_index01.Easy_Callender_page_1];
            border01_D01.border008(border01);
            Button01_D01.button03(button01);
            Button01_D01.button03(button02);
            button01.Clicked += button01_clicked;
            button02.Clicked += button02_clicked;
            button01.Text =menu_array01[0];
            button02.Text =menu_array01[1];

        }



        private async void button01_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button01);
            await button01.Navigation.PushAsync(new Device_Selection_View01());
        }
        private async void button02_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button02);
            await button02.Navigation.PushAsync(new Selection_Main_View01());
        }
    }
}