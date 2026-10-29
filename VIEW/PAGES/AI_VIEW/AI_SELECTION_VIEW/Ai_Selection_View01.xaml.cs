using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BACKGROUND.BACKGROUND_DEFAULT;
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
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.AI_SERVICES.IMAGE_EDIT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.IMAGE_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BORDER.BORDER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS.ENTRY_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_DEFAULT;

namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.AI_VIEW.AI_SELECTION_VIEW
{

    public partial class Ai_Selection_View01 : ContentPage
    {
        private Background_Default01 Background_D01 = new Background_Default01();
        private static string[] data01 = new string[100];
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static Border01_Default border01_D01 = new Border01_Default();
        private static Image01_Default Image01_D01 = new Image01_Default();
        private static Labels01_Default Labels01_D01 = new Labels01_Default();
        private static string menu_string01 = $"Hairstyle_Changer_Pro\n";
        private static string[] menu_array01 = menu_string01.Split("\n");
        private static Button_Animation01 Button_A01 = new Button_Animation01();
        private static File_Manger02 File_M02 = new File_Manger02();
        private static ImageButton01_Default ImageButton01_D01 = new ImageButton01_Default();
        private static Picker01_Animation Picker01_A01 = new Picker01_Animation();
        private static Entrys01_Default Entrys01_D01 = new Entrys01_Default();
        private static ImageButton_Animaiton01 ImageButton_A01 = new ImageButton_Animaiton01();
        private static Image_Edit02 Image_E02 = new Image_Edit02();
        private static File_Picker01 File_P01 = new File_Picker01();
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Image_Services01 Image_Serv01 = new Image_Services01();
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        private static Picker01_Default Picker01_D = new Picker01_Default();
        private static bool res01 = false;

        public Ai_Selection_View01()
        {
            InitializeComponent();
            load_Selection_View01();
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
            border01_D01.border008(border04);
            border01_D01.border008(border05);
            Labels01_D01.label09(label01);
            Labels01_D01.label09(label02);
            Labels01_D01.label09(label03);
            Labels01_D01.label09(label04);
            Button01_D01.button03(button01);
            Button01_D01.button03(button02);
            Button01_D01.button03(button03);
            Button01_D01.button03(button04);
            Picker01_D.picker01(picker01);
            Picker01_D.picker01(picker02);
            Picker01_D.picker01(picker03);
            button01.Clicked += button01_clicked;
            button02.Clicked += button02_clicked;
            button03.Clicked += button03_clicked;
            button04.Clicked += button04_clicked;
            button01.Text = "ok";
            button02.Text = "back";
            button03.Text = "Take Photo";
            button04.Text = "Choose Photo";
            picker01.SelectedIndexChanged += Picker01_SelectedIndexChanged;
            picker01.ItemsSource = menu_array01.ToList();
            picker02.ItemsSource = Image_E02.hairstyle_data02.ToList();
            picker03.ItemsSource = Image_E02.hairstyle_data03.ToList();
            picker01.Title = "Select";
            picker02.Title = "Select";
            picker03.Title = "Select";

        }


        private void load_default_view01()
        {

            label01.IsVisible = false;
            label02.IsVisible = false;
            label03.IsVisible = false;
            label04.IsVisible = false;
            border01.IsVisible = false;
            border02.IsVisible = false;
            border03.IsVisible = true;
            border04.IsVisible = false;
            border05.IsVisible = false;
            button03.IsVisible = false;
            button04.IsVisible = false;


        }
        private void load_default_view02()
        {
            label01.IsVisible = false;
            label02.IsVisible = false;
            label03.IsVisible = false;
            label04.IsVisible = false;
            border01.IsVisible = false;
            border02.IsVisible = false;
            border03.IsVisible = true;
            border04.IsVisible = true;
            border05.IsVisible = true;
            button03.IsVisible = true;
            button04.IsVisible = true;


        }


        private void Picker01_SelectedIndexChanged(object? sender, EventArgs e)
        {
            switch (menu_array01[picker01.SelectedIndex])
            {
                case "Hairstyle_Changer_Pro":
                    load_default_view02();
                    break;

                default:
                    load_default_view01();
                    break;
            }
        }

        private void load_Selection_data01()
        {
            string procedure = menu_array01[picker01.SelectedIndex].Trim();
            switch (procedure)
            {
                case "Hairstyle_Changer_Pro":
                    _commands.Add(procedure, Hairstyle_Changer_Pro);
                    break;
            }

        }
        private async void Hairstyle_Changer_Pro()
        {


            int count = 0;
            if (Security_Serv01.isPicker_selected(picker02, out data01[24]) == true)
            {
                count++;
                label03.IsVisible = false;
                label03.Text = string.Empty;
            }
            else
            {
                count--;
                label03.IsVisible = true;
                label03.Text = data01[24];
            }
            if (Security_Serv01.isPicker_selected(picker03, out data01[25]) == true)
            {
                count++;
                label04.IsVisible = false;
                label04.Text = string.Empty;
            }
            else
            {
                count--;
                label04.IsVisible = true;
                label04.Text = data01[25];
            }
            if (res01 == true)
            {
                count++;
            }
            else
            {
                count--;
            }
            if (count == 3)
            {
                var res = await File_P01.file_picker_andriod_mobile();
                if (res.success == true)
                {
                    if (Security_Serv01.isphoto(res.output, out data01[26]) == true)
                    {
                        //                        data01[3] = await Image_Serv01.image_to_url(res.output);
                        //                      image01.Source = ImageSource.FromUri(new Uri(data01[3]));

                        label04.Text = $"{Image_E02.hairstyle_data02[picker02.SelectedIndex]}\n," +
                                          $"{Image_E02.hairstyle_data03[picker03.SelectedIndex]}\n" +
                                          $"{res.output}\n";
                        label04.IsVisible = true;

                    }
                    else
                    {
                        label04.Text = data01[26];
                        label04.IsVisible = true;
                    }
                }
                else
                {

                    label04.Text = res.output;
                    label04.IsVisible = true;

                }
            }
            else
            {
                label04.Text = "Please fix erros";
                label04.IsVisible = true;
            }
        }
        private void load_Selection01()
        {
            if (Security_Serv01.isPicker_selected(picker01, out data01[22]) == true)
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
                label01.Text = data01[22];
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
            await button02.Navigation.PushAsync(new Ai_Main_View01());
        }
        private async void button03_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button03);
            var res = await Security_Serv01.andriod_take_photo();
            if (res.success == true)
            {
                res01 = true;
                //image01.Source = res.output.Trim();
                label04.IsVisible = true;
                label04.Text = res.output;
            }
            else
            {
                res01 = false;
                label04.IsVisible = true;
                label04.Text = res.output;
            }
        }
        private async void button04_clicked(object? sender, EventArgs e)
        {

            await Button_A01.button_translateto(button04);
            var res = await Security_Serv01.andriod_choose_photo();
            if (res.success == true)
            {
                res01 = true;
                //image01.Source = res.output.Trim();
                label04.IsVisible = true;
                label04.Text = res.output;
            }
            else
            {
                res01 = false;
                label04.IsVisible = true;
                label04.Text = res.output;
            }
        }
    }
}