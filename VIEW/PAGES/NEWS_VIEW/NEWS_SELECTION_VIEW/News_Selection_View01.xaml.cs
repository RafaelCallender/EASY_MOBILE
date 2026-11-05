using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BACKGROUND.BACKGROUND_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.LABELS.LABEL_DEFAULTS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_ANIMATION;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.NEWS_VIEW.NEWS_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BORDER.BORDER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.NEWS_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS.ENTRY_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.MODEL.NEWS_MODEL.NEWS_SET_MODEL;
using System.Collections.ObjectModel;

namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.NEWS_VIEW.NEWS_SELECTION_VIEW
{
    public partial class News_Selection_View01 : ContentPage
    {
        private Background_Default01 Background_D01 = new Background_Default01();
        private static string[] data01 = new string[100];
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static Border01_Default border01_D01 = new Border01_Default();
        private static Image01_Default Image01_D01 = new Image01_Default();
        private static Labels01_Default Labels01_D01 = new Labels01_Default();
        private static string menu_string01 =
                                            "Real_Time_News_Data_GET_Search\n" +
"Real_Time_News_Data_GET_Top_Headlines\n" +
"Real_Time_News_Data_GET_Topic_Headlines\n" +
"Real_Time_News_Data_GET_Topic_News_By_Section\n" +
"Real_Time_News_Data_GET_Search_grid\n" +
"Local_Headlines_Geo\n";
        private static string[] menu_array01 = menu_string01.Split("\n");
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        private static Button_Animation01 Button_A01 = new Button_Animation01();
        private static Picker01_Animation Picker01_A01 = new Picker01_Animation();
        private static Entrys01_Default Entrys01_D01 = new Entrys01_Default();
        private static Picker01_Default Picker01_D = new Picker01_Default();
        private static News_Services01 News_Serv01 = new News_Services01();
        private static File_Manger02 File_M02 = new File_Manger02();
        private static Security_Services01 Security_Serv01 = new Security_Services01();



        public News_Selection_View01()
        {

            InitializeComponent();

            load_Selection_View01();
        }


        private void load_Selection_data01()
        {
            string procedure = menu_array01[picker01.SelectedIndex].Trim();
            switch (procedure)
            {

                case "Real_Time_News_Data_GET_Search":
                    _commands.Add(procedure, Real_Time_News_Data_GET_Search);
                    break;
                case "Real_Time_News_Data_GET_Top_Headlines":
                    _commands.Add(procedure, Real_Time_News_Data_GET_Top_Headlines);
                    break;
                case "Real_Time_News_Data_GET_Topic_Headlines":
                    _commands.Add(procedure, Real_Time_News_Data_GET_Topic_Headlines);
                    break;
                case "Real_Time_News_Data_GET_Topic_News_By_Section":
                    _commands.Add(procedure, Real_Time_News_Data_GET_Topic_News_By_Section);
                    break;
                case "Local_Headlines_Geo":
                    _commands.Add(procedure, Local_Headlines_Geo);
                    break;
                case "Real_Time_News_Data_GET_Search_grid":
                    _commands.Add(procedure, Real_Time_News_Data_GET_Search_grid);
                    break;

            }
        }
        private async void Real_Time_News_Data_GET_Search_grid()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                label01.Text = await News_Serv01.Real_Time_News_Data_GET_Search(entry01.Text);
                newsCollectionView01.ItemsSource = News_Services01.NewsItems01;
            }
            else
            {
                label01.Text = data01[23];
            }
        }
        private async void Real_Time_News_Data_GET_Search()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.is_connected_to_netwrok_andriod(out data01[25]) == true)
                {
                    label01.Text = await News_Serv01.Real_Time_News_Data_GET_Search(entry01.Text);
                }
                else
                {
                    label01.Text = data01[25];
                }
            }
            else
            {
                label01.Text = data01[23];
            }
        }
        private async void Real_Time_News_Data_GET_Top_Headlines()
        {
            if (Security_Serv01.is_connected_to_netwrok_andriod(out data01[25]) == true)
            {
                label01.Text = await News_Serv01.Real_Time_News_Data_GET_Top_Headlines();
                newsCollectionView02.ItemsSource = News_Services01.NewsItems02;
            }
            else
            {
                label01.Text = data01[25];
            }
        }
        private async void Real_Time_News_Data_GET_Topic_Headlines()
        {
            if (Security_Serv01.is_connected_to_netwrok_andriod(out data01[25]) == true)
            {
                label01.Text = await News_Serv01.Real_Time_News_Data_GET_Topic_Headlines();
                newsCollectionView02.ItemsSource = News_Services01.NewsItems02;
            }
            else
            {
                label01.Text = data01[25];

            }

        }
        private async void Real_Time_News_Data_GET_Topic_News_By_Section()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                if (Security_Serv01.is_connected_to_netwrok_andriod(out data01[25]) == true)
                {
                    label01.Text = await News_Serv01.Real_Time_News_Data_GET_Topic_News_By_Section(entry01.Text);
                    newsCollectionView02.ItemsSource = News_Services01.NewsItems02;
                }
                else
                {
                    label01.Text = data01[25];

                }
            }
            else
            {
                label01.Text = data01[23];
            }
        }
        private async void Local_Headlines_Geo()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                label01.Text = await News_Serv01.Local_Headlines_Geo(entry01.Text);
                newsCollectionView01.ItemsSource = News_Services01.NewsItems01;
            }
            else
            {
                label01.Text = data01[23];
            }

        }
        private void load_default_view()
        {
            label01.IsVisible = false;
            label02.IsVisible = false;
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = true;
            border04.IsVisible = false;
            border05.IsVisible = false;
        }
        private void load_default_view01()
        {
            label01.IsVisible = true;
            label02.IsVisible = false;
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = true;
            border04.IsVisible = false;
            border05.IsVisible = false;


        }
        private void load_default_view02()
        {
            label01.IsVisible = true;
            label02.IsVisible = false;
            border01.IsVisible = true;
            border02.IsVisible = true;
            border03.IsVisible = true;
            border04.IsVisible = false;
            border05.IsVisible = false;

        }
        private void load_default_view03()
        {
            label01.IsVisible = false;
            label02.IsVisible = false;
            border01.IsVisible = true;
            border02.IsVisible = true;
            border03.IsVisible = true;
            border04.IsVisible = true;
            border05.IsVisible = false;
        }
        private void load_default_view04()
        {
            label01.IsVisible = false;
            label02.IsVisible = false;
            border01.IsVisible = true;
            border02.IsVisible = true;
            border03.IsVisible = true;
            border04.IsVisible = false;
            border05.IsVisible = true;
        }
        private void load_Selection_View01()
        {
            Background_D01.background01(this);
            load_default_view();
            Image01_D01.image01(image01);
            image01.Source = File_M02.source[(int)File_Manger02.image_index01.Easy_Callender_page_1];
            Entrys01_D01.Entrys02(entry01);
            border01_D01.border008(border01);
            border01_D01.border002(border02);
            border01_D01.border008(border03);
            Picker01_D.picker01(picker01);
            Labels01_D01.label04(label01);
            Labels01_D01.label04(label02);
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

                case "Real_Time_News_Data_GET_Search":
                    load_default_view03();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    entry01.Placeholder = "City";
                    break;
                case "Real_Time_News_Data_GET_Top_Headlines":
                    load_default_view04();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    break;
                case "Real_Time_News_Data_GET_Topic_Headlines":
                    load_default_view04();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    break;
                case "Real_Time_News_Data_GET_Topic_News_By_Section":
                    load_default_view04();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    entry01.Placeholder = "topic";
                    break;
                case "Local_Headlines_Geo":
                    load_default_view04();
                    entry01.Placeholder = "City";
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    break;
                case "Real_Time_News_Data_GET_Search_grid":
                    load_default_view03();
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    break;
                default:
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
            await button02.Navigation.PushAsync(new News_Main_View01());
        }
    }
}
