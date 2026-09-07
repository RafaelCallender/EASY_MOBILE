using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.LABELS.LABEL_DEFAULTS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGEBUTTON.IMAGEBUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGEBUTTON.IMAGEBUTTON_DEFAULT;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.AI_VIEW.AI_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILE_SERVICES.FILE_PICKER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.AI_SERVICES.IMAGE_EDIT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BORDER.BORDER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS.ENTRY_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.IMAGE_SERVICES;
namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.AI_VIEW.AI_SELECTION_VIEW
{

    public partial class Ai_Selection_View03 : ContentPage
    {
        private static string[] data01 = new string[100];
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static Border01_Default border01_D01 = new Border01_Default();
        private static Image01_Default Image01_D01 = new Image01_Default();
        private static Labels01_Default Labels01_D01 = new Labels01_Default();
        private static string menu_string01 = $"Anime Face\n";
        private static string[] menu_array01 = menu_string01.Split("\n");
        private static Button_Animation01 Button_A01 = new Button_Animation01();
        private static ImageButton01_Default ImageButton01_D01 = new ImageButton01_Default();
        private static Picker01_Animation Picker01_A01 = new Picker01_Animation();
        private static Entrys01_Default Entrys01_D01 = new Entrys01_Default();
        private static ImageButton_Animaiton01 ImageButton_A01 = new ImageButton_Animaiton01();
        private static Ai_Image_Edit01 Ai_Image_E01 = new Ai_Image_Edit01();
        private static File_Picker01 File_P01 = new File_Picker01();
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Image_Services01 Image_Serv01 = new Image_Services01();
        private static File_Manger02 File_M02 = new File_Manger02();
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        public Ai_Selection_View03()
        {

            InitializeComponent();
            load_Ai_Selection_View03();
        }
        private void load_Ai_Selection_View03()
        {

            load_default_view01();
            Entrys01_D01.Entrys01(entry01);
            border01_D01.border001(border01);
            border01_D01.border002(border02);
            Labels01_D01.label01(label01);
            Button01_D01.button01(button01);
            Button01_D01.button02(button02);
            ImageButton01_D01.ImageButton01(imagebutton01);
            Image01_D01.image01(image01);
            image01.Source = File_M02.source[(int)File_Manger02.image_index01.Easy_Callender_page_1];
            imagebutton01.Source = File_M02.source[(int)File_Manger02.image_index01.Easy_Callender_page_1];
            button01.Clicked += button01_clicked;
            button02.Clicked += button02_clicked;
            button01.Text = "ok";
            button02.Text = "back";
            picker01.SelectedIndexChanged += Picker01_SelectedIndexChanged;
            picker01.ItemsSource = menu_array01.ToList();
            picker01.Title = "Select";
            imagebutton01.Clicked += imagebutton01_clicked;
        }
        private void load_default_view01()
        {
            label01.IsVisible = false;
            border01.IsVisible = false;
            border02.IsVisible = false;
            border03.IsVisible = true;
            imagebutton01.IsVisible = true;
        }
        private void Picker01_SelectedIndexChanged(object? sender, EventArgs e)
        {

            switch (picker01.SelectedIndex)
            {
                case 0:
                    load_default_view01();
                    break;


            }
        }
        private void load_Selection_data01()
        {
            for (int i = 0; i < menu_array01.Length; i++)
            {
                string procedure = menu_array01[i].Trim();
                switch (menu_array01[picker01.SelectedIndex])
                {
                    case "Anime Face":
                        _commands.Add(procedure, Anime_Face);
                        break;
                }
            }
        }
        private void Anime_Face()
        {
            if (data01[10] != null)
            {


                if (Security_Serv01.isphoto(data01[10], out data01[24]) == true)
                {
                    label01.IsVisible = false;
                    Image_Serv01.image_to_url(data01[10]).Wait();
                    data01[4] =  Ai_Image_E01.PhotoAnime(data01[3]).GetAwaiter().GetResult();
                    
                    image01.Source = ImageSource.FromUri(new Uri(data01[4]));


                }
                else
                {
                    label01.IsVisible = true;
                    label01.Text = data01[24];
                }
            }
            else
            {
                label01.IsVisible = true;
                ImageButton_A01.imagebutton_scaleto01(imagebutton01).Wait();
                label01.Text = "please select a photo";

            }

        }
        private void load_Ai_Selection_View03_data()
        {
            if (Security_Serv01.isPicker_selected(picker01, out data01[24]) == true)
            {
                int selection = picker01.SelectedIndex;
                int stringlength = menu_array01.Length;

                if (selection >= 0 &&
                    selection < stringlength)
                {
                    string key = menu_array01[selection].Trim();
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
            load_Ai_Selection_View03_data();
        }

        private async void imagebutton01_clicked(object? sender, EventArgs e)
        {
            await ImageButton_A01.imagebutton_scaleto01(imagebutton01);
    
            label01.Text = data01[10];


        }

        private async void button02_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button02);
            await button02.Navigation.PushAsync(new Ai_Main_View01());
        }
    }
}