using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BACKGROUND.BACKGROUND_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.LABELS.LABEL_DEFAULTS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_ANIMATION;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.SCIENCE_VIEW.SCIENCE_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BORDER.BORDER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SCIENCE_SERVICES.CHEMISTRY.CHEMISTRY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SCIENCE_SERVICES.CHEMISTRY.CHEMISTRY_HELPER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS.ENTRY_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;

namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.SCIENCE_VIEW.SCIENCE_SELECTION_VIEW
{
    public partial class Science_Selection_View01 : ContentPage
    {
        private Background_Default01 Background_D01 = new Background_Default01();
        private static string[] data01 = new string[100];
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static Image01_Default Image01_D01 = new Image01_Default();
        private static Labels01_Default Labels01_D01 = new Labels01_Default();
        private static string menu_string01 = $"find_element_using_textfile\n" +
            $"view_all_elements_using_textfile\n" +
            $"find_element_using_textfile_grid\n" +
            $"find_category_elements_using_textfile\n";
        private static string[] menu_array01 = menu_string01.Split("\n");
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        private static Button_Animation01 Button_A01 = new Button_Animation01();
        private static Picker01_Animation Picker01_A01 = new Picker01_Animation();
        private static Entrys01_Default Entrys01_D01 = new Entrys01_Default();
        private static Border01_Default border01_D01 = new Border01_Default();
        private static Chemistry_Services01 Chemistry_Serv01 = new Chemistry_Services01();
        private static Chemistry_Helper01 Chemistry_H01 = new Chemistry_Helper01();
        private static File_Manger02 File_M02 = new File_Manger02();
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        public Science_Selection_View01()
        {
            InitializeComponent();
            load_Selection_View01();
        }


        private void load_Selection_data01()
        {
            string procedure = menu_array01[picker01.SelectedIndex].Trim();
            switch (procedure)
            {
                case "find_element_using_textfile":
                    _commands.Add(procedure, find_element_using_textfile);
                    break;
                case "view_all_elements_using_textfile":
                    _commands.Add(procedure, view_all_elements_using_textfile);
                    break;
                case "find_category_elements_using_textfile":
                    _commands.Add(procedure, find_category_elements_using_textfile);
                    break;
                case "find_element_using_textfile_grid":
                    _commands.Add(procedure, find_element_using_textfile_grid);
                    break;
            }


        }

        private void find_element_using_textfile()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                label01.Text = Chemistry_Serv01.find_element_using_textfile(entry01.Text);

            }
            else
            {
                label01.Text = data01[23];
            }

        }

        private void find_element_using_textfile_grid()
        {

            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                load_default_view03();
                string[] res_array = Chemistry_Serv01.find_element_using_textfile(entry01.Text).Split("\n");
                AtomicNumberLabel.Text = $"Atomic Number {res_array[0]}";
                SymbolLabel.Text = res_array[2];
                NameLabel.Text = res_array[1];
                AtomicNumberValue.Text = res_array[3];
                ElementNameValue.Text = res_array[1];
                SymbolValue.Text = res_array[2];
                AtomicMassValue.Text = res_array[3];
                ElectronsValue.Text = res_array[4];
                ProtonsValue.Text = res_array[5];
                NeutronsValue.Text = res_array[6];

            }
            else
            {
                load_default_view01();
                label01.Text = data01[23];
            }

        }
        private void view_all_elements_using_textfile()
        {
            label01.Text = Chemistry_Serv01.view_all_elements_using_textfile();

        }
        private void find_category_elements_using_textfile()
        {
            if (Security_Serv01.isPicker_selected(picker02, out data01[24]) == true)
            {
                label01.Text = Chemistry_Serv01.find_category_elements_using_textfile(picker02.SelectedIndex);
            }
            else
            {
                label01.Text = data01[24];
            }
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
            border01_D01.border008(border04);
            Labels01_D01.label04(label01);
            Labels01_D01.label04(label02);
            Labels01_D01.label04(label03);
            Button01_D01.button03(button01);
            Button01_D01.button03(button02);
            button01.Clicked += button01_clicked;
            button02.Clicked += button02_clicked;
            button01.Text = "ok";
            button02.Text = "back";
            picker01.SelectedIndexChanged += Picker01_SelectedIndexChanged;
            picker01.ItemsSource = menu_array01.ToList();
            picker02.ItemsSource = Chemistry_H01.data_array.ToList();
            picker01.Title = "Select";
            picker02.Title = "Select Catagory";
        }
        private void load_default_view()
        {

            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = true;
            border04.IsVisible = false;
            border05.IsVisible = false;

        }
        private void load_default_view01()
        {

            border01.IsVisible = true;
            border02.IsVisible = true;
            border03.IsVisible = true;
            border04.IsVisible = false;
            border05.IsVisible = false;

        }

        private void load_default_view03()
        {

            border01.IsVisible = true;
            border02.IsVisible = true;
            border03.IsVisible = true;
            border04.IsVisible = false;
            border05.IsVisible = true;

        }
        private void load_default_view04()
        {

            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = true;
            border04.IsVisible = true;
            border05.IsVisible = false;

        }
        private void Picker01_SelectedIndexChanged(object? sender, EventArgs e)
        {

            switch (menu_array01[picker01.SelectedIndex])
            {
                case "find_element_using_textfile":
                    load_default_view01();
                    entry01.Placeholder = "element name";
                    label01.Text = string.Empty;
                    label02.Text = string.Empty;

                    break;
                case "view_all_elements_using_textfile":
                    load_default_view();

                    label01.Text = string.Empty;
                    label02.Text = string.Empty;

                    break;
                case "find_category_elements_using_textfile":
                    load_default_view04();

                    label01.Text = string.Empty;
                    label02.Text = string.Empty;
                    break;
                case "find_element_using_textfile_grid":
                    load_default_view03();
                    entry01.Placeholder = "element name";
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
            await button02.Navigation.PushAsync(new Science_Main_View01());
        }
    }
}