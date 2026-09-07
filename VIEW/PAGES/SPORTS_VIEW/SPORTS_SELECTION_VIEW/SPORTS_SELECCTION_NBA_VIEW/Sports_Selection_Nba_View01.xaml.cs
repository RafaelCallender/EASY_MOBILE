using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_ANIMATION;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BUTTONS.BUTTON_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.IMAGE.IMAGE_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.LABELS.LABEL_DEFAULTS;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_ANIMATION;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.SCIENCE_VIEW.SCIENCE_MAIN_VIEW;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.SPORTS_VIEW.SPORTS_MAIN_VIEW;
using EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.SELECTION_VIEW.SELECTION_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BORDER.BORDER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.DATEPICKER.DATEPICKER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.PICKER.PICKER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.DATEPICKER.DATEPICKER_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS.ENTRY_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;

namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.SPORTS_VIEW.SPORTS_SELECTION_VIEW.SPORTS_SELECCTION_NBA_VIEW
{
    public partial class Sports_Selection_Nba_View01 : ContentPage
    {
        private static string[] data01 = new string[100];
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static Border01_Default border01_D01 = new Border01_Default();
        private static Image01_Default Image01_D01 = new Image01_Default();
        private static Labels01_Default Labels01_D01 = new Labels01_Default();
        private static string menu_string01 =


                       $"GET_Seasons\n" +
                        $"GET_Leagues\n" +
                        $"GET_Games\n" +
                        $"GET_Games_between_two_teams\n" +
                        $"GET_Games_in_live\n" +
                        $"GET_Games_per_season\n" +
                        $"GET_Games_per_date\n" +
                        $"GET_Games_per_team_and_season\n" +
                        $"GET_Games_per_id\n" +
                        $"GET_Teams GET_Teams_per_conference\n" +
                        $"GET_Teams_per_division\n" +
                        $"GET_Teams_per_codeGET_Teams_per_id\n" +
                        $"GET_Teams GET_Standings\n" +
                        $"GET_Standings_per_conference_and_season\n" +
                        $"GET_Standings_per_division_and_season\n" +
                        $"GET_Standings_per_team_and_season GET_Games_Statistics\n" +
                        $"GET_Teams_Statistics\n" +
                        $"GET_Players_Statistics_per_player_and_season\n" +
                        $"GET_Players_Statistics_per_team_and_season\n" +
                        $"GET_Players_Statistics_per_game_id GET_Search_teams()\n" +
                        $"GET_Search_players()\n";
        private static string[] menu_array01 = menu_string01.Split("\n");

        private static Button_Animation01 Button_A01 = new Button_Animation01();
        private static File_Manger02 File_M02 = new File_Manger02();
        private static Picker01_Animation Picker01_A01 = new Picker01_Animation();
        private static Entrys01_Default Entrys01_D01 = new Entrys01_Default();
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static DatePicker_Default_01 DatePicker_D01 = new DatePicker_Default_01();
        private static Picker01_Default Picker01_D = new Picker01_Default();
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        private static int year_ = 0;
        private static int team = 0;
        private static string date_ = string.Empty;
        private static int conference = 0;
        private static int divison = 0;
        public Sports_Selection_Nba_View01()
        {

            InitializeComponent();
            load_Selection_View01();
        }

        private void load_default_view01()
        {
            label01.IsVisible = false;
            label02.IsVisible = false;
            label03.IsVisible = false;
            label04.IsVisible = false;
            border01.IsVisible = false;
            border02.IsVisible = true;
            border03.IsVisible = true;
            border04.IsVisible = true;
            border05.IsVisible = true;

        }
        private void load_Selection_View01()
        {
            load_default_view01();
            Image01_D01.image01(image01);
            image01.Source = File_M02.source[(int)File_Manger02.image_index01.Easy_Callender_page_1];
            Entrys01_D01.Entrys01(entry01);
            border01_D01.border001(border01);
            border01_D01.border002(border02);
            border01_D01.border002(border03);
            border01_D01.border002(border04);
            border01_D01.border002(border05);
            Labels01_D01.label01(label01);
            Button01_D01.button01(button01);
            Button01_D01.button02(button02);
            Picker01_D.picker01(picker01);
            Picker01_D.picker01(picker02);
            Picker01_D.picker01(picker03);
            DatePicker_D01.datepicker01(datepicker01);
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
                case "GET_Seasons":
                    load_default_view01();
                    entry01.Placeholder = "code";
                    label02.Text = string.Empty;
                    break;



            }
        }

        private void load_Selection_data01()
        {
            for (int i = 0; i < menu_array01.Length; i++)
            {
                string procedure = menu_array01[i].Trim();
                switch (menu_array01[int.Parse(data01[4])])
                {
                    case "GET_Seasons":
                        _commands.Add(procedure, unknown01);
                        break;
                }
            }
        }
        private void unknown01()
        {
            label01.Text = "not yet developed";
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
            await button02.Navigation.PushAsync(new Sports_Main_View01());
        }
    }
}