using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.BACKGROUND.BACKGROUND_DEFAULT;
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
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LANGUAGE.LANGUAGE_HELPER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LANGUAGE.LANGUAGE_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.MOBILE_TEMPLATE.ENTRYS.ENTRY_DEFAULT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.AUDIO_SERVICES;

namespace EASYPROJECT01.EASY_MOBILE.VIEW.PAGES.TRANSLATE_VIEW.TRANSLATE_SELECTION_VIEW
{
    public partial class Translate_Selection_View01 : ContentPage
    {
        private Background_Default01 Background_D01 = new Background_Default01();
        private static string[] data01 = new string[100];
        private static Image01_Default Image01_D01 = new Image01_Default();
        private static Button01_Default Button01_D01 = new Button01_Default();
        private static Picker01_Animation Picker01_A01 = new Picker01_Animation();
        private static Border01_Default border01_D01 = new Border01_Default();
        private static Labels01_Default Labels01_D01 = new Labels01_Default();
        private static string menu_string01 =
        $"Tranlate_Text\n" +
       $"Batch_Translation\n" +
       $"Translate_JSON\n" +
       $"Translate_HTML\n" +
       $"Detect_Language\n" +
       $"Translate text to voice\n" +
         $"Translate speech to text\n" +
       $"Supported_languages\n";

        private static string[] menu_array01 = menu_string01.Split("\n");
        private static Button_Animation01 Button_A01 = new Button_Animation01();
        private static Entrys01_Default Entrys01_D01 = new Entrys01_Default();
        private static Picker01_Default Picker01_D = new Picker01_Default();
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Language_Services01 Language_Serv01 = new Language_Services01();
        private static Language_Helper01 Language_H01 = new Language_Helper01();
        private static File_Manger02 File_M02 = new File_Manger02();
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        private static int counter01 = 0;
        private static Audio_Services01 Audio_Serv01 = new Audio_Services01();
        public Translate_Selection_View01()
        {

            InitializeComponent();
            load_Selection_View01();
        }
        private void load_Selection_data01()
        {

            string procedure = menu_array01[picker01.SelectedIndex].Trim();
            switch (procedure)
            {
                case "Tranlate_Text":
                    _commands[procedure] = Tranlate_Text;
                    break;
                case "Tranlate_Text 01":
                    _commands[procedure] = Tranlate_Text;
                    break;
                case "Batch_Translation":
                    _commands[procedure] = Batch_Translation;
                    break;
                case "Translate_JSON":
                    _commands[procedure] = Translate_JSON;
                    break;
                case "Translate_HTML":
                    _commands[procedure] = Translate_HTML;
                    break;
                case "Detect_Language":
                    _commands[procedure] = Detect_Language;
                    break;
                case "Supported_languages":
                    _commands[procedure] = Supported_languages;
                    break;
                case "Translate text to voice":
                    _commands[procedure] = Translate_text_to_voice;
                    break;
                    /* case "Translate speech to text":
                         _commands[procedure] = Translate_speech_to_text;
                         break;*/


            }

        }


        private async void Translate_text_to_voice()
        {

            counter01 = 0;
            var res = await Security_Serv01.isPicker_selected_mobile(picker01);
            if (res.success == true)
            {
                counter01++;

                label02.Text = string.Empty;
            }
            else
            {
                counter01--;
                await Picker01_A01.Picker_rotateto01(picker02);
                label02.Text = $"{res.output}\n";
            }

            if (Security_Serv01.empty_string(entry01.Text, out data01[24]) == true)
            {
                label01.Text = string.Empty;
                counter01++;
            }
            else
            {
                counter01--;
                label01.Text = $"{data01[24]}\n";
            }
            if (counter01 == 2)
            {

                try
                {
                    string lang01 = await Language_Serv01.Tranlate_Text(Language_H01.code[picker02.SelectedIndex], entry01.Text.Trim());
                    label01.Text = lang01;
                    await TextToSpeech.Default.SpeakAsync(lang01);
                    Language_CollectionView01.ItemsSource = Language_Services01.collection_item01;
                }
                catch (Exception ex)
                {
                    label01.Text = $"Translation failed: {ex.Message}";
                }
            }
            else
            {
                label01.Text = $"fix the errors\n";

            }
        }
        private async void Batch_Translation()
        {
            counter01 = 0;
            var res = await Security_Serv01.isPicker_selected_mobile(picker01);

            if (res.success == true)
            {
                counter01++;
                label02.Text = string.Empty;
                label02.IsVisible = false;
            }
            else
            {

                counter01--;
                label02.IsVisible = true;
                label02.Text = $"{res.output}\n";
            }
            if (Security_Serv01.empty_string(entry01.Text, out data01[24]) == true)
            {
                label03.Text = string.Empty;
                label03.IsVisible = false;
                counter01++;
            }
            else
            {
                counter01--;
                label03.IsVisible = true;
                label01.Text = $"{data01[24]}\n";
            }
            if (counter01 == 2)
            {
                if (Security_Serv01.is_connected_to_netwrok_andriod(out data01[40]) == true)
                {
                    try
                    {
                label03.IsVisible = true;
                        //  label03.Text = await Language_Serv01.Batch_Translation(Language_H01.code[entry01.Text.Trim(), picker02.SelectedIndex]);
                        label03.Text = "not yet developed";
                        //  Language_CollectionView01.ItemsSource = Language_Services01.collection_item01;
                    }
                    catch (Exception ex)
                    {
                        label03.IsVisible = true;
                        label03.Text = $"Translation failed: {ex.Message}";
                    }
                }
                else
                {
                    label03.IsVisible = true;
                    label03.Text = data01[40];
                }
            }
            else
            {
                label03.IsVisible = true;
                label03.Text = $"{data01[25]}\n";
            }
        }
        private async void Translate_JSON()
        {
            counter01 = 0;
            var res = await Security_Serv01.isPicker_selected_mobile(picker01);

            if (res.success == true)
            {
                counter01++;
                label02.Text = string.Empty;
                label02.IsVisible = false;
            }
            else
            {

                counter01--;
                label02.IsVisible = true;
                label02.Text = $"{res.output}\n";
            }
            if (Security_Serv01.empty_string(entry01.Text, out data01[24]) == true)
            {
                label03.Text = string.Empty;
                label03.IsVisible = false;
                counter01++;
            }
            else
            {
                counter01--;
                label03.IsVisible = true;
                label01.Text = $"{data01[24]}\n";
            }
            if (counter01 == 2)
            {
                if (Security_Serv01.is_connected_to_netwrok_andriod(out data01[40]) == true)
                {
                    try
                    {
                      label03.IsVisible = true;
                        //  label03.Text = await Language_Serv01.Translate_JSON(Language_H01.code[entry01.Text.Trim(), picker02.SelectedIndex]);
                        label03.Text = "not yet developed";
                        //  Language_CollectionView01.ItemsSource = Language_Services01.collection_item01;
                    }
                    catch (Exception ex)
                    {
                        label03.IsVisible = true;
                        label03.Text = $"Translation failed: {ex.Message}";
                    }
                }
                else
                {
                    label03.IsVisible = true;
                    label03.Text = data01[40];
                }
            }
            else
            {
                label03.IsVisible = true;
                label03.Text = $"{data01[25]}\n";
            }
        }
        private async void Translate_HTML()
        {
            counter01 = 0;
            var res = await Security_Serv01.isPicker_selected_mobile(picker01);

            if (res.success == true)
            {
                counter01++;
                label02.Text = string.Empty;
                label02.IsVisible = false;
            }
            else
            {

                counter01--;
                label02.IsVisible = true;
                label02.Text = $"{res.output}\n";
            }
            if (Security_Serv01.empty_string(entry01.Text, out data01[24]) == true)
            {
                label03.Text = string.Empty;
                label03.IsVisible = false;
                counter01++;
            }
            else
            {
                counter01--;
                label03.IsVisible = true;
                label01.Text = $"{data01[24]}\n";
            }
            if (counter01 == 2)
            {
                if (Security_Serv01.is_connected_to_netwrok_andriod(out data01[40]) == true)
                {
                    try
                    {
                    label03.IsVisible = true;
                        //  label03.Text = await Language_Serv01.Translate_HTML(Language_H01.code[entry01.Text.Trim(), picker02.SelectedIndex]);
                        label03.Text = "not yet developed";
                        //  Language_CollectionView01.ItemsSource = Language_Services01.collection_item01;
                    }
                    catch (Exception ex)
                    {
                        label03.IsVisible = true;
                        label03.Text = $"Translation failed: {ex.Message}";
                    }
                }
                else
                {
                    label03.IsVisible = true;
                    label03.Text = data01[40];
                }
            }
            else
            {
                label03.IsVisible = true;
                label03.Text = $"{data01[25]}\n";
            }
        }
        private async void Detect_Language()
        {
            if (Security_Serv01.empty_string(entry01.Text, out data01[24]) == true)
            {
                label01.IsVisible = true;
                label01.Text = await Language_Serv01.Detect_Language(entry01.Text);
                counter01++;
            }
            else
            {
                label01.IsVisible = true;
                label01.Text = $"{data01[25]}\n";
            }


        }
        private async void Supported_languages()
        {
            label01.IsVisible = true;
            label01.Text = await Language_Serv01.Supported_languages();
        }
        private async void Tranlate_Text()
        {
            counter01 = 0;
            var res = await Security_Serv01.isPicker_selected_mobile(picker01);

            if (res.success == true)
            {
                counter01++;
                label02.Text = string.Empty;
                label02.IsVisible = false;
            }
            else
            {

                counter01--;
                label02.IsVisible = true;
                label02.Text = $"{res.output}\n";
            }
            if (Security_Serv01.empty_string(entry01.Text, out data01[24]) == true)
            {
                label03.Text = string.Empty;
                label03.IsVisible = false;
                counter01++;
            }
            else
            {
                counter01--;
                label03.IsVisible = true;
                label01.Text = $"{data01[24]}\n";
            }
            if (counter01 == 2)
            {
                if (Security_Serv01.is_connected_to_netwrok_andriod(out data01[40]) == true)
                {
                    try
                    {
                        label03.IsVisible = false;
                        label03.Text = await Language_Serv01.Tranlate_Text(Language_H01.code[picker02.SelectedIndex], entry01.Text.Trim());
                        Language_CollectionView01.ItemsSource = Language_Services01.collection_item01;
                    }
                    catch (Exception ex)
                    {
                        label03.IsVisible = true;
                        label03.Text = $"Translation failed: {ex.Message}";
                    }
                }
                else
                {
                    label03.IsVisible = true;
                    label03.Text = data01[40];
                }
            }
            else
            {
                label03.IsVisible = true;
                label03.Text = $"{data01[25]}\n";
            }
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
            border05.IsVisible = false;
            button01.IsVisible = true;
            button02.IsVisible = true;
            button03.IsVisible = false;
            button04.IsVisible = false;
        }
        private void load_default_view01()
        {

            label01.IsVisible = false;
            label02.IsVisible = false;
            label03.IsVisible = false;
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = true;
            border04.IsVisible = true;
            border05.IsVisible = false;
            button01.IsVisible = true;
            button02.IsVisible = true;
            button03.IsVisible = false;
            button04.IsVisible = false;
        }
        private void load_default_view02()
        {
            label01.IsVisible = false;
            label02.IsVisible = false;
            label03.IsVisible = false;
            border01.IsVisible = true;
            border02.IsVisible = false;
            border03.IsVisible = true;
            border04.IsVisible = true;
            border05.IsVisible = false;
            button01.IsVisible = true;
            button02.IsVisible = true;
            button03.IsVisible = true;
            button04.IsVisible = true;
        }


        private void load_Selection_View01()
        {

            Background_D01.background01(this);
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
            Picker01_D.picker01(picker01);
            Picker01_D.picker01(picker02);
            Button01_D01.button03(button01);
            Button01_D01.button03(button02);
            Button01_D01.button03(button03);
            Button01_D01.button03(button04);
            Button01_D01.button03(button05);
            button01.Clicked += button01_clicked;
            button02.Clicked += button02_clicked;
            button03.Clicked += button03_clicked;
            button04.Clicked += button04_clicked;
            button05.Clicked += button05_clicked;
            button01.Text = "ok";
            button02.Text = "back";
            button03.Text = "Start Speaking";
            button04.Text = "Stop Recording";
            button05.Text = "clear";
            picker01.SelectedIndexChanged += Picker01_SelectedIndexChanged;
            picker01.ItemsSource = menu_array01.ToList();
            picker01.Title = "Select";
            picker02.ItemsSource = Language_H01.language.ToList();
            picker02.Title = "Select Language";

        }

        private void Picker01_SelectedIndexChanged(object? sender, EventArgs e)
        {


            switch (menu_array01[picker01.SelectedIndex])
            {
                case "Tranlate_Text":
                    load_default_view01();
                    label01.Text = string.Empty;
                    entry01.Placeholder = "Type";
                    break;
                case "Tranlate_Text 01":
                    load_default_view01();
                    label01.Text = string.Empty;
                    entry01.Placeholder = "Type";
                    break;
                case "Batch_Translation":
                    load_default_view01();
                    label01.Text = string.Empty;
                    entry01.Placeholder = "BATCH";
                    break;
                case "Translate_JSON":
                    load_default_view01();
                    label01.Text = string.Empty;
                    entry01.Placeholder = "JSON";
                    break;
                case "Translate_HTML":
                    load_default_view01();
                    label01.Text = string.Empty;
                    entry01.Placeholder = "HTML";
                    break;
                case "Detect_Language":
                    load_default_view01();
                    label01.Text = string.Empty;
                    entry01.Placeholder = "Type";
                    break;
                case "Supported_languages":
                    load_default_view();
                    label01.Text = string.Empty;
                    entry01.Placeholder = string.Empty;
                    break;
                case "Translate text to voice":
                    load_default_view01();
                    label01.Text = string.Empty;
                    entry01.Placeholder = "type";
                    break;
                case "Translate speech to voice":
                    load_default_view02();
                    label01.Text = string.Empty;
                    entry01.Placeholder = string.Empty;
                    break;


            }
        }

        private async Task load_Selection01()
        {
            var res = await Security_Serv01.isPicker_selected_mobile(picker01);
            if (res.success == true)
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
                    label01.IsVisible = true;
                    label01.Text = $"{key} command not found";
                }
            }
            else
            {
                label01.IsVisible = true;
                label01.Text = res.output;
            }
        }


        private async void button01_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button01);
            await load_Selection01();
        }
        private async void button02_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button02);
            await button02.Navigation.PushAsync(new Translate_Main_View01());
        }
        private async void button03_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button03);
            string output = await Audio_Serv01.speech_to_text_start_andriod();
            label03.IsVisible = true;
            label03.Text = output;
        }
        private async void button04_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button04);
            string output = await Audio_Serv01.speech_to_text_end_andriod();
            label03.IsVisible = true;
            label03.Text = output;
        }
        private async void button05_clicked(object? sender, EventArgs e)
        {
            await Button_A01.button_translateto(button05);
            label03.IsVisible = true;
            label03.Text = "Ready.";
        }
    }
}