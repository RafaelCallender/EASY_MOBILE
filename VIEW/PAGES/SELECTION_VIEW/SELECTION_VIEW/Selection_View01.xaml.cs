using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_DEFAULT;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.SELECTION_VIEW.SELECTION_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BORDER.BORDER_DEFAULT;

namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.SELECTION_VIEW.SELECTION_VIEW
{

    public partial class Selection_View01 : ContentPage
    {
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static Button_Animation01 Button_A01 = new Button_Animation01();
        public Selection_View01()
        {
            InitializeComponent();
            load_Selection_View01();
        }
        private void load_Selection_View01()
        {
            Button01_D01.button01(button01);
            Button01_D01.button01(button02);
            button01.Clicked += button01_clicked;
            button02.Clicked += button02_clicked;   
            button01.Text = "no data";
            button02.Text = "back";

        }
        private async void button01_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button01);
            await button01.Navigation.PushAsync(new Selection_Main_View01());
        }
        private async void button02_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button02);
            await button02.Navigation.PushAsync(new Selection_Main_View01());
        }

    }
}