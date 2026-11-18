using CommunityToolkit.Maui.Extensions;
using CommunityToolkit.Maui.Views;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.LABELS.LABEL_DEFAULTS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BORDER.BORDER_DEFAULT;

namespace EASYPROJECT01.EASY_MOBILE.VIEW.POPUP;

public partial class PopUpPage01 : Popup
{
    private static Button01_Default Button01_D01 = new Button01_Default();
    private static Border01_Default border01_D01 = new Border01_Default();
    private static Button_Animation01 Button_A01 = new Button_Animation01();
    private static Labels01_Default Labels01_D01 = new Labels01_Default();
    private static string[] data01 = new string[100];
    public PopUpPage01(string input)
	{
		InitializeComponent();
        data01[0] = input;  
        load_PopUpPage01();        
    }
	private void load_PopUpPage01()
	{
        Labels01_D01.label01(label01);
        border01_D01.border001(border01);
        Button01_D01.button01(button01);
        button01.Clicked += Button01_Clicked;   
        button01.Text = "ok";
        label01.Text = data01[0];

    }

    private async void Button01_Clicked(object? sender, EventArgs e)
    {
        await Button_A01.button_translateto(button01);
        await this.CloseAsync();

    }
}