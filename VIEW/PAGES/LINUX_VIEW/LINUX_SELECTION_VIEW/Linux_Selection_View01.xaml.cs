using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.LABELS.LABEL_DEFAULTS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_ANIMATION;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.TEST_VIEW.TEST_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BORDER.BORDER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS.ENTRY_DEFAULT;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.LINUX_VIEW.LINUX_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LINUX.LINUX_SERVICES;

namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.LINUX_VIEW.LINUX_SELECTION_VIEW
{
    public partial class Linux_Selection_View01 : ContentPage
    {
        private static string[] data01 = new string[100];
        private static Image01_Default Image01_D01 = new Image01_Default();
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static Border01_Default border01_D01 = new Border01_Default();
        private static Labels01_Default Labels01_D01 = new Labels01_Default();
        private static string menu_string01 = $"delete files to onedive\n" +
                   $"make files to onedive\n" +
                   $"upload files to onedive\n" +
                   $"delete/upload files to onedive\n";
        private static string[] menu_array01 = menu_string01.Split("\n");
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        private static Button_Animation01 Button_A01 = new Button_Animation01();
        private static Picker01_Animation Picker01_A01 = new Picker01_Animation();
        private static Entrys01_Default Entrys01_D01 = new Entrys01_Default();
        private static Picker01_Default Picker01_D = new Picker01_Default();
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Linux_Services01 Linux_S01 = new Linux_Services01();
        private static File_Manger02 File_M02 = new File_Manger02();
        private static int counter01 = 0;
        public Linux_Selection_View01()
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

                    case "delete files to onedive":
                        _commands.Add(procedure, delete_files_to_onedive);
                        break;
                    case "make files to onedive":
                        _commands.Add(procedure, make_files_to_onedive);
                        break;
                    case "upload files to onedive":
                        _commands.Add(procedure, upload_files_to_onedive);
                        break;
                    case "delete/upload files to onedive":
                        _commands.Add(procedure, delete_upload_files_to_onedive);
                        break;
                }
            }
        }

        private void delete_files_to_onedive()
        {
            label02.Text = Linux_S01.DeleteRemoteFolder01();
        }
        private void make_files_to_onedive()
        {
            label02.Text = Linux_S01.MakeRemoteFolder01();
        }
        private void upload_files_to_onedive()
        {
            label02.Text = Linux_S01.UploadRemoteFolder01();
        }
        private void delete_upload_files_to_onedive()
        {
            label02.Text = $"{Linux_S01.DeleteRemoteFolder01()}\n" +
                  $"{Linux_S01.MakeRemoteFolder01()}\n" +
                  $"{Linux_S01.UploadRemoteFolder01()}\n";
        }

        private void load_default_view()
        {
            label01.IsVisible = false;
            label02.IsVisible = false;
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = true;

        }
        private void load_default_view01()
        {
            label01.IsVisible = false;
            label02.IsVisible = false;
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = true;
        }
        private void load_default_view02()
        {
            label01.IsVisible = false;
            label02.IsVisible = false;
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = true;

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
            Labels01_D01.label01(label01);
            Labels01_D01.label01(label02);
            Picker01_D.picker01(picker01);
            Button01_D01.button01(button01);
            Button01_D01.button02(button02);
            button01.Clicked += button01_clicked;
            button02.Clicked += button02_clicked;
            button01.Text = "ok";
            button02.Text = "back";
            picker01.SelectedIndexChanged += Picker01_SelectedIndexChanged;
            picker01.ItemsSource = menu_string01.ToList();
            picker01.Title = "Select";
        }

        private void Picker01_SelectedIndexChanged(object? sender, EventArgs e)
        {
            switch (menu_array01[picker01.SelectedIndex])
            {
                case "display images":
                    load_default_view01();
                    label02.Text = string.Empty;
                    break;
                case "delete files to onedive":
                    load_default_view01();
                    label02.Text = string.Empty;
                    break;
                case "make files to onedive":
                    load_default_view01();
                    label02.Text = string.Empty;
                    break;
                case "upload files to onedive":
                    load_default_view01();
                    label02.Text = string.Empty;
                    break;
                case "delete/upload files to onedive":
                    load_default_view01();
                    label02.Text = string.Empty;
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
    }
}