using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.LABELS.LABEL_DEFAULTS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_ANIMATION;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.TRANSLATE_VIEW.TRANSLATE_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BORDER.BORDER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGEBUTTON.IMAGEBUTTON_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGEBUTTON.IMAGEBUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS.ENTRY_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LINUX.LINUX_SERVICES;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.LINUX_VIEW.LINUX_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;

namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.LINUX_VIEW.LINUX_SELECTION_VIEW
{
    public partial class Linux_Selection_View02 : ContentPage
    {
        private static string[] data01 = new string[100];
        private static Image01_Default Image01_D01 = new Image01_Default();
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static Border01_Default border01_D01 = new Border01_Default();
        private static Labels01_Default Labels01_D01 = new Labels01_Default();
        private static Button_Animation01 Button_A01 = new Button_Animation01();
        private static Picker01_Animation Picker01_A01 = new Picker01_Animation();
        private static Entrys01_Default Entrys01_D01 = new Entrys01_Default();
        private static Picker01_Default Picker01_D = new Picker01_Default();
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static ImageButton_Animaiton01 ImageButton_A01 = new ImageButton_Animaiton01();
        private static ImageButton01_Default ImageButton01_D = new ImageButton01_Default();
        private static int counter01 = 0;
        private bool statuescheck = false;
        private static Linux_Services02 Linux_S02 = new Linux_Services02();
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        private static string menu_string01 = $"github_upload_all_projects\n" +
                    $"github_upload_EASYWEBB\n" +
                    $"github_upload_EASYCONSOLE\n" +
                    $"github_upload_EASY_MOBILE\n" +
                    $"github_upload_EASY_CALLENDER01\n" +
                    $"create repository\n" +
                    $"choose repository\n" +
                    $"delete repository\n";

        private static string[] menu_array01 = menu_string01.Split("\n");

        private static File_Manger02 File_M02 = new File_Manger02();

        public Linux_Selection_View02()
        {

            InitializeComponent();
            load_Selection_View01();
        }
        private void load_Selection_data01()
        {
            for (int i = 0; i < menu_array01.Length; i++)
            {
                string procedure = menu_array01[i].Trim();
                switch (menu_array01[int.Parse(data01[4])])
                {

                    case "github_upload_all_projects":
                        _commands.Add(procedure, github_upload_all_projects);
                        break;
                    case "github_upload_EASYWEBB":
                        _commands.Add(procedure, github_upload_EASYWEBB);
                        break;
                    case "github_upload_EASYCONSOLE":
                        _commands.Add(procedure, github_upload_EASYCONSOLE);
                        break;
                    case "github_upload_EASY_MOBILE":
                        _commands.Add(procedure, github_upload_EASY_MOBILE);
                        break;
                    case "github_upload_EASY_CALLENDER01":
                        _commands.Add(procedure, github_upload_EASY_CALLENDER01);
                        break;
                    case "create_repository":
                        _commands.Add(procedure, create_repository);
                        break;
                    case "choose_repository":
                        _commands.Add(procedure, choose_repository);
                        break;
                    case "delete_repository":
                        _commands.Add(procedure, delete_repository);
                        break;
                }
            }
        }


        private void github_upload_all_projects()
        {
            label01.Text = Linux_S02.github_upload_all_projects();
        }
        private void github_upload_EASYWEBB()
        {
            label01.Text = Linux_S02.github_upload_EASYWEBB();
        }
        private void github_upload_EASYCONSOLE()
        {
            label01.Text = Linux_S02.github_upload_EASYCONSOLE();

        }
        private void github_upload_EASY_MOBILE()
        {
            label01.Text = Linux_S02.github_upload_EASY_MOBILE();
        }
        private void github_upload_EASY_CALLENDER01()
        {
            label01.Text = Linux_S02.github_upload_EASY_CALLENDER01();
        }
        private void create_repository()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                label01.Text = Linux_S02.github_create_repository(entry01.Text);
            }
            else
            {
                label01.Text = data01[23];
            }
        }
        private void choose_repository()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {

                label01.Text = Linux_S02.github_list_repository(entry01.Text);
            }
            else
            {
                label01.Text = data01[23];
            }

        }
        private void delete_repository()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[23]) == true)
            {
                label01.Text = Linux_S02.github_delete_repository(entry01.Text);
            }
            else
            {
                label01.Text = data01[23];
            }
        }

        private void load_Selection_View01()
        {
            load_default_view();
            Image01_D01.image01(image01);
            image01.Source = File_M02.source[(int)File_Manger02.image_index01.Easy_Callender_page_1];
            Entrys01_D01.Entrys01(entry01);
            border01_D01.border001(border01);
            border01_D01.border002(border02);
            border01_D01.border002(border03);
            border01_D01.border002(border04);
            Labels01_D01.label01(label01);
            Labels01_D01.label01(label02);
            Labels01_D01.label01(label03);
            Picker01_D.picker01(picker01);
            Picker01_D.picker01(picker02);
            ImageButton01_D.ImageButton01(imagebutton01);
            Button01_D01.button01(button01);
            Button01_D01.button02(button02);
            button01.Clicked += button01_clicked;
            button02.Clicked += button02_clicked;
            imagebutton01.Clicked += imagebutton01_clicked;
            button01.Text = "ok";
            button02.Text = "back";
            picker01.SelectedIndexChanged += Picker01_SelectedIndexChanged;
            picker01.ItemsSource = menu_array01.ToList();
            picker01.Title = "Select";


        }
        private void load_default_view()
        {
            label01.IsVisible = false;
            label02.IsVisible = false;
            label03.IsVisible = false;
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = true;
            border04.IsVisible = false;
            imagebutton01.IsVisible = false;
        }
        private void load_default_view01()
        {
            label01.IsVisible = false;
            label02.IsVisible = false;
            label03.IsVisible = false;
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = true;
            imagebutton01.IsVisible = false;
        }

        private void load_default_view02()
        {
            label01.IsVisible = false;
            label02.IsVisible = false;
            label03.IsVisible = false;
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = true;
            imagebutton01.IsVisible = false;
        }
        private void Picker01_SelectedIndexChanged(object? sender, EventArgs e)
        {

            switch (menu_array01[picker01.SelectedIndex])
            {
                case "display images":
                    load_default_view01();
                    label03.Text = string.Empty;
                    break;
                case "github_upload_all_projects":
                    load_default_view01();
                    label03.Text = string.Empty;
                    break;
                case "github_upload_EASYWEBB":
                    load_default_view01();
                    label03.Text = string.Empty;
                    break;
                case "github_upload_EASYCONSOLE":
                    load_default_view01();
                    label03.Text = string.Empty;
                    break;
                case "github_upload_EASY_MOBILE":
                    load_default_view01();
                    label03.Text = string.Empty;
                    break;
                case "github_upload_EASY_CALLENDER01":
                    load_default_view01();
                    label03.Text = string.Empty;
                    break;
                case "create repository":
                    load_default_view01();
                    label03.Text = string.Empty;
                    break;
                case "choose repository":
                    load_default_view01();
                    label03.Text = string.Empty;
                    break;
                case "delete repository":
                    load_default_view01();
                    label03.Text = string.Empty;
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
                    label02.Text = $"{key} command not found";
                }
            }
            else
            {
                label02.Text = data01[24];
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
            await button02.Navigation.PushAsync(new Linux_Main_View01());
        }
        private async void imagebutton01_clicked(object? sender, EventArgs e)
        {
            await ImageButton_A01.imagebutton_rotateto01(imagebutton01);
            statuescheck = true;
        }

    }
}