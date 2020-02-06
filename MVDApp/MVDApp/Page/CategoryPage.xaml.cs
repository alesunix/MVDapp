using MVDApp.Models;
using MVDApp.Models.CategoryModels;
using MVDApp.Models.MultiSelectListView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVDApp.Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoryPage : ContentPage
    {
        RestService _restService;
        public string Result { get; set; }
        List<CategoryPeople> listCategory = new List<CategoryPeople>();

        public List<CategoryPeople> Categoryes { get; set; }
        public CategoryPage()
        {
            InitializeComponent();  
            _restService = new RestService();
            Button[] buttons = new Button[] { Button21, Button22, Button23, Button24, Button25, Button26, Button27, Button28, Button29, Button30, Button31, Button32, Button33, Button34 };
            for(int i = 0; i< buttons.Length; i++)
            {
                buttons[i].TextColor = Color.Black;
                buttons[i].BackgroundColor= Color.FloralWhite;
                buttons[i].BorderColor = Color.SlateGray;
                buttons[i].BorderWidth = 2;
                buttons[i].CornerRadius = 10;
                buttons[i].Margin = -1;
                buttons[i].HorizontalOptions = LayoutOptions.Fill;
                buttons[i].IsVisible = false;
            }
            //Инициализируем кнопки
            Button2 = new Button
            {
                BackgroundColor = Color.SteelBlue,
                TextColor = Color.White,
                BorderWidth = 1,
                BorderColor = Color.SlateGray,
                CornerRadius = 5,
                HorizontalOptions = LayoutOptions.Fill,
                Text = "Отмена",
                IsVisible = true,
            };
            Categoryes = new List<CategoryPeople>
        {
            new CategoryPeople {Title="Проживающий на участке" },
            new CategoryPeople {Title="Сотрудник органов внутренних дел или военнослужащий" },
            new CategoryPeople {Title="Внештатный помощник милиции" },
            new CategoryPeople {Title="Имеющий в личном пользовании оружие" },
            new CategoryPeople {Title="Осуществляющий незаконное предоставление, передачу жилых помещений" },
            new CategoryPeople {Title="Ранее судимый" },
            new CategoryPeople {Title="Освобожденный из мест лишения свободы" },
            new CategoryPeople {Title="Осужденный к уголовному наказанию, не связанному с лишением свободы" },
            new CategoryPeople {Title="Освобожденный от уголовной ответственности по не реабилитирующим основаниям" },
            new CategoryPeople {Title="Совершающий правонарушения в сфере семейно-бытовых отношений" },
            new CategoryPeople {Title="Хронический алкоголик, состоящие на учете в учреждениях здравоохранения" },
            new CategoryPeople {Title="Больной наркоманией, а также допускающий потребление наркотических средств и психотропных веществ без назначения врача, состоящий на учете в учреждениях" },
            new CategoryPeople {Title="Психически больной, представляющий непосредственную опасность для себя  и окружающих, состоящий на учете в учреждениях здравоохранения" },
            new CategoryPeople {Title="Несовершеннолетний, состоящие на учете в инспекции по делам несовершеннолетних" },
            new CategoryPeople {Title="Уклоняющий от военной службы, из числа проживающих на административном участке" },
            new CategoryPeople {Title="Находится в розыске, из числа проживающих на административном участке" },
            new CategoryPeople {Title="Входящий в  объединения экстремистского толка, в т.ч. неформальные молодежные объединения" },
            new CategoryPeople {Title="Задержанный за нарушения общественного порядка при проведении  массовых мероприятий" },
            new CategoryPeople {Title="Постоянно проживающий иностранный гражданин и лицо без гражданства" },
        };
            this.BindingContext = this;
        }

        Button Button1 = new Button();
        Button Button2 = new Button();
        Button Button3 = new Button();
        Entry Entry1 = new Entry();
        Entry Entry2 = new Entry();
        Entry Entry3 = new Entry();
        Entry Entry4 = new Entry();
        Entry Entry5 = new Entry();
        Entry Entry6 = new Entry();
        Entry Entry7 = new Entry();
        Entry Entry8 = new Entry();
        Entry Entry9 = new Entry();
        Entry Entry10 = new Entry();
        Label Label1 = new Label();
        Label Label2 = new Label();
        Label Label3 = new Label();
        DatePicker datePicker1 = new DatePicker();
        DatePicker datePicker2 = new DatePicker();
        DatePicker datePicker3 = new DatePicker();


        public void Hide()
        {
            //StackLayout.Children.Remove(button1);
            //StackLayout.Children.Remove(button2);
            //StackLayout.Children.Remove(button3);    
        }
        //protected override void OnAppearing()
        //{
        //    //Получение с проверкой на наличие:
        //    if (App.Current.Properties.TryGetValue("name21", out object name21) &&
        //        App.Current.Properties.TryGetValue("name22", out object name22) &&
        //        App.Current.Properties.TryGetValue("name23", out object name23) &&
        //        App.Current.Properties.TryGetValue("name24", out object name24) &&
        //        App.Current.Properties.TryGetValue("name25", out object name25) &&
        //        App.Current.Properties.TryGetValue("name26", out object name26) &&
        //        App.Current.Properties.TryGetValue("name27", out object name27) &&
        //        App.Current.Properties.TryGetValue("name28", out object name28) &&
        //        App.Current.Properties.TryGetValue("name29", out object name29) &&
        //        App.Current.Properties.TryGetValue("name30", out object name30) &&
        //        App.Current.Properties.TryGetValue("name31", out object name31) &&
        //        App.Current.Properties.TryGetValue("name32", out object name32) &&
        //        App.Current.Properties.TryGetValue("name33", out object name33) &&
        //        App.Current.Properties.TryGetValue("name34", out object name34) &&
        //        App.Current.Properties.TryGetValue("Ename30", out object Ename30) &&
        //        App.Current.Properties.TryGetValue("Ename31", out object Ename31) &&
        //        App.Current.Properties.TryGetValue("Ename32", out object Ename32) &&
        //        App.Current.Properties.TryGetValue("Ename33", out object Ename33) &&
        //        App.Current.Properties.TryGetValue("Ename34", out object Ename34) &&
        //        App.Current.Properties.TryGetValue("Ename35", out object Ename35) &&
        //        //App.Current.Properties.TryGetValue("title", out object title) &&
        //        App.Current.Properties.TryGetValue("sw1", out object sw1) &&
        //        App.Current.Properties.TryGetValue("sw2", out object sw2) &&
        //        App.Current.Properties.TryGetValue("sw3", out object sw3) &&
        //        App.Current.Properties.TryGetValue("sw4", out object sw4) &&
        //        App.Current.Properties.TryGetValue("sw5", out object sw5) &&
        //        App.Current.Properties.TryGetValue("sw6", out object sw6) &&
        //        App.Current.Properties.TryGetValue("sw7", out object sw7) &&
        //        App.Current.Properties.TryGetValue("sw8", out object sw8) &&
        //        App.Current.Properties.TryGetValue("sw9", out object sw9) &&
        //        App.Current.Properties.TryGetValue("sw10", out object sw10) &&
        //        App.Current.Properties.TryGetValue("sw11", out object sw11) &&
        //        App.Current.Properties.TryGetValue("sw12", out object sw12) &&
        //        App.Current.Properties.TryGetValue("sw13", out object sw13) &&
        //        App.Current.Properties.TryGetValue("sw14", out object sw14) &&
        //        App.Current.Properties.TryGetValue("sw15", out object sw15) &&
        //        App.Current.Properties.TryGetValue("sw16", out object sw16) &&
        //        App.Current.Properties.TryGetValue("sw17", out object sw17) &&
        //        App.Current.Properties.TryGetValue("sw18", out object sw18) &&
        //        App.Current.Properties.TryGetValue("sw19", out object sw19)
        //        )
        //    {
        //        Button21.IsEnabled = (bool)name21;
        //        Button22.IsEnabled = (bool)name22;
        //        Button23.IsEnabled = (bool)name23;
        //        Button24.IsEnabled = (bool)name24;
        //        Button25.IsEnabled = (bool)name25;
        //        Button26.IsEnabled = (bool)name26;
        //        Button27.IsEnabled = (bool)name27;
        //        Button28.IsEnabled = (bool)name28;
        //        Button29.IsEnabled = (bool)name29;
        //        Button30.IsEnabled = (bool)Ename30;
        //        Button31.IsEnabled = (bool)Ename31;
        //        Button32.IsEnabled = (bool)Ename32;
        //        Button33.IsEnabled = (bool)Ename33;
        //        Button34.IsEnabled = (bool)Ename34;
        //        Button35.IsEnabled = (bool)Ename35;

        //        Button30.IsVisible = (bool)name30;
        //        Button31.IsVisible = (bool)name31;
        //        Button32.IsVisible = (bool)name32;
        //        Button33.IsVisible = (bool)name33;
        //        Button34.IsVisible = (bool)name34;

        //        //Title = (string)title;
        //        switch1.IsToggled = (bool)sw1;
        //        switch2.IsToggled = (bool)sw2;
        //        switch3.IsToggled = (bool)sw3;
        //        switch4.IsToggled = (bool)sw4;
        //        switch5.IsToggled = (bool)sw5;
        //        switch6.IsToggled = (bool)sw6;
        //        switch7.IsToggled = (bool)sw7;
        //        switch8.IsToggled = (bool)sw8;
        //        switch9.IsToggled = (bool)sw9;
        //        switch10.IsToggled = (bool)sw10;
        //        switch11.IsToggled = (bool)sw11;
        //        switch12.IsToggled = (bool)sw12;
        //        switch13.IsToggled = (bool)sw13;
        //        switch14.IsToggled = (bool)sw14;
        //        switch15.IsToggled = (bool)sw15;
        //        switch16.IsToggled = (bool)sw16;
        //        switch17.IsToggled = (bool)sw17;
        //        switch18.IsToggled = (bool)sw18;
        //        switch19.IsToggled = (bool)sw19;
        //    }
        //    base.OnAppearing();
        //}
        //public void Properties()
        //{
        //    //Добавление данных в словарь:
        //    //string value = Title;
        //    bool value21 = Button21.IsEnabled;
        //    bool value22 = Button22.IsEnabled;
        //    bool value23 = Button23.IsEnabled;
        //    bool value24 = Button24.IsEnabled;
        //    bool value25 = Button25.IsEnabled;
        //    bool value26 = Button26.IsEnabled;
        //    bool value27 = Button27.IsEnabled;
        //    bool value28 = Button28.IsEnabled;
        //    bool value29 = Button29.IsEnabled;
        //    bool Evalue30 = Button30.IsEnabled;
        //    bool Evalue31 = Button31.IsEnabled;
        //    bool Evalue32 = Button32.IsEnabled;
        //    bool Evalue33 = Button33.IsEnabled;
        //    bool Evalue34 = Button34.IsEnabled;
        //    bool Evalue35 = Button35.IsEnabled;

        //    bool value30 = Button30.IsVisible;
        //    bool value31 = Button31.IsVisible;
        //    bool value32 = Button32.IsVisible;
        //    bool value33 = Button33.IsVisible;
        //    bool value34 = Button34.IsVisible;
        //    bool value1 = switch1.IsToggled;
        //    bool value2 = switch2.IsToggled;
        //    bool value3 = switch3.IsToggled;
        //    bool value4 = switch4.IsToggled;
        //    bool value5 = switch5.IsToggled;
        //    bool value6 = switch6.IsToggled;
        //    bool value7 = switch7.IsToggled;
        //    bool value8 = switch8.IsToggled;
        //    bool value9 = switch9.IsToggled;
        //    bool value10 = switch10.IsToggled;
        //    bool value11= switch11.IsToggled;
        //    bool value12= switch12.IsToggled;
        //    bool value13= switch13.IsToggled;
        //    bool value14 = switch14.IsToggled;
        //    bool value15 = switch15.IsToggled;
        //    bool value16 = switch16.IsToggled;
        //    bool value17 = switch17.IsToggled;
        //    bool value18 = switch18.IsToggled;
        //    bool value19 = switch19.IsToggled;
        //    //App.Current.Properties["title"] = value;
        //    App.Current.Properties["name21"] = value21;
        //    App.Current.Properties["name22"] = value22;
        //    App.Current.Properties["name23"] = value23;
        //    App.Current.Properties["name24"] = value24;
        //    App.Current.Properties["name25"] = value25;
        //    App.Current.Properties["name26"] = value26;
        //    App.Current.Properties["name27"] = value27;
        //    App.Current.Properties["name28"] = value28;
        //    App.Current.Properties["name29"] = value29;
        //    App.Current.Properties["name30"] = value30;
        //    App.Current.Properties["name31"] = value31;
        //    App.Current.Properties["name32"] = value32;
        //    App.Current.Properties["name33"] = value33;
        //    App.Current.Properties["name34"] = value34;
        //    App.Current.Properties["Ename30"] = Evalue30;
        //    App.Current.Properties["Ename31"] = Evalue31;
        //    App.Current.Properties["Ename32"] = Evalue32;
        //    App.Current.Properties["Ename33"] = Evalue33;
        //    App.Current.Properties["Ename34"] = Evalue34;
        //    App.Current.Properties["Ename35"] = Evalue35;
        //    App.Current.Properties["sw1"] = value1;
        //    App.Current.Properties["sw2"] = value2;
        //    App.Current.Properties["sw3"] = value3;
        //    App.Current.Properties["sw4"] = value4;
        //    App.Current.Properties["sw5"] = value5;
        //    App.Current.Properties["sw6"] = value6;
        //    App.Current.Properties["sw7"] = value7;
        //    App.Current.Properties["sw8"] = value8;
        //    App.Current.Properties["sw9"] = value9;
        //    App.Current.Properties["sw10"] = value10;
        //    App.Current.Properties["sw11"] = value11;
        //    App.Current.Properties["sw12"] = value12;
        //    App.Current.Properties["sw13"] = value13;
        //    App.Current.Properties["sw14"] = value14;
        //    App.Current.Properties["sw15"] = value15;
        //    App.Current.Properties["sw16"] = value16;
        //    App.Current.Properties["sw17"] = value17;
        //    App.Current.Properties["sw18"] = value18;
        //    App.Current.Properties["sw19"] = value19;
        //}
        //public void DeleteProperties()
        //{
        //    //Удаление данных:
        //    //App.Current.Properties.Remove("title");
        //    App.Current.Properties.Remove("name21");
        //    App.Current.Properties.Remove("name22");
        //    App.Current.Properties.Remove("name23");
        //    App.Current.Properties.Remove("name24");
        //    App.Current.Properties.Remove("name25");
        //    App.Current.Properties.Remove("name26");
        //    App.Current.Properties.Remove("name27");
        //    App.Current.Properties.Remove("name28");
        //    App.Current.Properties.Remove("name29");
        //    App.Current.Properties.Remove("name30");
        //    App.Current.Properties.Remove("name31");
        //    App.Current.Properties.Remove("name32");
        //    App.Current.Properties.Remove("name33");
        //    App.Current.Properties.Remove("name34");
        //    App.Current.Properties.Remove("Ename30");
        //    App.Current.Properties.Remove("Ename31");
        //    App.Current.Properties.Remove("Ename32");
        //    App.Current.Properties.Remove("Ename33");
        //    App.Current.Properties.Remove("Ename34");
        //    App.Current.Properties.Remove("Ename35");
        //    App.Current.Properties.Remove("sw1");
        //    App.Current.Properties.Remove("sw2");
        //    App.Current.Properties.Remove("sw3");
        //    App.Current.Properties.Remove("sw4");
        //    App.Current.Properties.Remove("sw5");
        //    App.Current.Properties.Remove("sw6");
        //    App.Current.Properties.Remove("sw7");
        //    App.Current.Properties.Remove("sw8");
        //    App.Current.Properties.Remove("sw9");
        //    App.Current.Properties.Remove("sw10");
        //    App.Current.Properties.Remove("sw11");
        //    App.Current.Properties.Remove("sw12");
        //    App.Current.Properties.Remove("sw13");
        //    App.Current.Properties.Remove("sw14");
        //    App.Current.Properties.Remove("sw15");
        //    App.Current.Properties.Remove("sw16");
        //    App.Current.Properties.Remove("sw17");
        //    App.Current.Properties.Remove("sw18");
        //    App.Current.Properties.Remove("sw19");
        //}
        async void GetSearch()//метод поиска
        {
            if (!string.IsNullOrWhiteSpace(PassportModel.EntrySearch1))
            {
                PersonalData personalData = await _restService.GetPersonalData(GenerateRequestUri(Constants.OpenMapEndpoint));
                BindingContext = personalData;
            }

            string GenerateRequestUri(string endpoint)
            {
                string requestUri = endpoint;
                requestUri += $"?q={PassportModel.EntrySearch1}";
                requestUri += "&units=imperial"; // or units=metric
                requestUri += $"&APPID={Constants.OpenMapAPIKey}";
                return requestUri;
            }
        }
        void Clicked()//Деактивация и Скрытие кнопок //Отключаем свичи 
        {
            Button[] buttons = new Button[] { Button21, Button22, Button23, Button24, Button25, Button26, Button27, Button28, Button29, Button30, Button31, Button32, Button33, Button34 };
            for (int i = 0; i < buttons.Length; i++)
            {
                if (buttons[i].Text == Title)
                {
                    buttons[i].IsVisible = true;
                    buttons[i].IsEnabled = false;
                }
                else if (buttons[i].Text != Title)
                {
                    buttons[i].IsVisible = false;
                }
            }
            //Отключаем свичи
            Switch[] switches = new Switch[] { switch1, switch2, switch3, switch4, switch5, switch6, switch7, switch8, switch9, switch10, switch11, switch12, switch13, switch14, switch15, switch16, switch17, switch18, switch19 };
            for (int i = 0; i < switches.Length; i++)
            {
                switches[i].IsEnabled = false;
            }          
        }
        void SwitchTogled()
        {
            Switch[] switches = new Switch[] { switch1, switch2, switch3, switch4, switch5, switch6, switch7, switch8, switch9, switch10, switch11, switch12, switch13, switch14, switch15, switch16, switch17, switch18, switch19 };
            for (int i = 0; i < switches.Length; i++)
            {
                if (switches[i].IsToggled == false)
                {
                    #region Условия Switch
                    if (switch2.IsToggled == false)
                    {
                        Button30.IsVisible = false;
                    }
                    if (switch3.IsToggled == false)
                    {
                        Button31.IsVisible = false;
                    }
                    if (switch4.IsToggled == false)
                    {
                        Button30.IsVisible = false;
                    }
                    if (switch5.IsToggled == false)
                    {
                        Button32.IsVisible = false;
                    }
                    if (switch6.IsToggled == false)
                    {
                        Button33.IsVisible = false;
                    }
                    if (switch7.IsToggled == false)
                    {
                        Button33.IsVisible = false;
                    }
                    if (switch8.IsToggled == false)
                    {
                        Button33.IsVisible = false;
                    }
                    if (switch9.IsToggled == false)
                    {
                        Button33.IsVisible = false;
                    }
                    if (switch10.IsToggled == false)
                    {
                        Button32.IsVisible = false;
                    }
                    if (switch11.IsToggled == false)
                    {
                        Button32.IsVisible = false;
                    }
                    if (switch12.IsToggled == false)
                    {
                        Button32.IsVisible = false;
                    }
                    if (switch13.IsToggled == false)
                    {
                        Button32.IsVisible = false;
                    }
                    if (switch14.IsToggled == false)
                    {
                        Button32.IsVisible = false;
                    }
                    if (switch15.IsToggled == false)
                    {
                        Button34.IsVisible = false;
                    }
                    if (switch16.IsToggled == false)
                    {
                        Button34.IsVisible = false;
                    }
                    if (switch17.IsToggled == false)
                    {
                        Button34.IsVisible = false;
                    }
                    if (switch18.IsToggled == false)
                    {
                        Button34.IsVisible = false;
                    }
                    if (switch19.IsToggled == false)
                    {
                        Button32.IsVisible = false;
                    }
                    #endregion
                }
            }
            for (int i = 0; i < switches.Length; i++)
            {
                if (switches[i].IsToggled == true)
                {
                    #region Условия Switch
                    if (switch2.IsToggled == true)
                    {
                        Button30.IsVisible = true;
                    }
                    if (switch3.IsToggled == true)
                    {
                        Button31.IsVisible = true;
                    }
                    if (switch4.IsToggled == true)
                    {
                        Button30.IsVisible = true;
                    }
                    if (switch5.IsToggled == true)
                    {
                        Button32.IsVisible = true;
                    }
                    if (switch6.IsToggled == true)
                    {
                        Button33.IsVisible = true;
                    }
                    if (switch7.IsToggled == true)
                    {
                        Button33.IsVisible = true;
                    }
                    if (switch8.IsToggled == true)
                    {
                        Button33.IsVisible = true;
                    }
                    if (switch9.IsToggled == true)
                    {
                        Button33.IsVisible = true;
                    }
                    if (switch10.IsToggled == true)
                    {
                        Button32.IsVisible = true;
                    }
                    if (switch11.IsToggled == true)
                    {
                        Button32.IsVisible = true;
                    }
                    if (switch12.IsToggled == true)
                    {
                        Button32.IsVisible = true;
                    }
                    if (switch13.IsToggled == true)
                    {
                        Button32.IsVisible = true;
                    }
                    if (switch14.IsToggled == true)
                    {
                        Button32.IsVisible = true;
                    }
                    if (switch15.IsToggled == true)
                    {
                        Button34.IsVisible = true;
                    }
                    if (switch16.IsToggled == true)
                    {
                        Button34.IsVisible = true;
                    }
                    if (switch17.IsToggled == true)
                    {
                        Button34.IsVisible = true;
                    }
                    if (switch18.IsToggled == true)
                    {
                        Button34.IsVisible = true;
                    }
                    if (switch19.IsToggled == true)
                    {
                        Button32.IsVisible = true;
                    }
                    #endregion
                }
            }
        }
        void OnToggled(object sender, ToggledEventArgs e)// Событие Switch OnToggled
        {
            Button[] buttons = new Button[] { Button21, Button22, Button23, Button24, Button25, Button26, Button27, Button28, Button29, Button30, Button31, Button32, Button33, Button34 };
            Switch[] switches = new Switch[] { switch1, switch2, switch3, switch4, switch5, switch6, switch7, switch8, switch9, switch10, switch11, switch12, switch13, switch14, switch15, switch16, switch17, switch18, switch19 };
            
            if ((sender as Switch).IsToggled == true)
            {
                //Включить те что выбраны
                for (int i = 0; i < switches.Length; i++)
                {
                    if (switches[i].IsToggled == true)
                    {
                        #region Условия Switch
                        if (switch2.IsToggled == true)
                        {
                            Button30.IsVisible = true;
                        }
                        if (switch3.IsToggled == true)
                        {
                            Button31.IsVisible = true;
                        }
                        if (switch4.IsToggled == true)
                        {
                            Button30.IsVisible = true;
                        }
                        if (switch5.IsToggled == true)
                        {
                            Button32.IsVisible = true;
                        }
                        if (switch6.IsToggled == true)
                        {
                            Button33.IsVisible = true;
                        }
                        if (switch7.IsToggled == true)
                        {
                            Button33.IsVisible = true;
                        }
                        if (switch8.IsToggled == true)
                        {
                            Button33.IsVisible = true;
                        }
                        if (switch9.IsToggled == true)
                        {
                            Button33.IsVisible = true;
                        }
                        if (switch10.IsToggled == true)
                        {
                            Button32.IsVisible = true;
                        }
                        if (switch11.IsToggled == true)
                        {
                            Button32.IsVisible = true;
                        }
                        if (switch12.IsToggled == true)
                        {
                            Button32.IsVisible = true;
                        }
                        if (switch13.IsToggled == true)
                        {
                            Button32.IsVisible = true;
                        }
                        if (switch14.IsToggled == true)
                        {
                            Button32.IsVisible = true;
                        }
                        if (switch15.IsToggled == true)
                        {
                            Button34.IsVisible = true;
                        }
                        if (switch16.IsToggled == true)
                        {
                            Button34.IsVisible = true;
                        }
                        if (switch17.IsToggled == true)
                        {
                            Button34.IsVisible = true;
                        }
                        if (switch18.IsToggled == true)
                        {
                            Button34.IsVisible = true;
                        }
                        if (switch19.IsToggled == true)
                        {
                            Button32.IsVisible = true;
                        }
                        #endregion
                        Button21.IsVisible = true;
                        Button22.IsVisible = true;
                        Button23.IsVisible = true;
                        Button24.IsVisible = true;
                        Button25.IsVisible = true;
                        Button26.IsVisible = true;
                        Button27.IsVisible = true;
                        Button28.IsVisible = true;
                        Button29.IsVisible = true;
                    }
                }
            }
            else
            {   //Отключить все кнопки          
                for (int i = 0; i < switches.Length; i++)
                {
                    for (int j = 0; j < buttons.Length; j++)
                    {
                        if (switches[i].IsToggled == false)
                        {
                            buttons[j].IsVisible = false;                            
                        }
                    }
                }
                //Включить те что выбраны
                for (int i = 0; i < switches.Length; i++)
                {
                    if (switches[i].IsToggled == true)
                    {
                        #region Условия Switch
                        if (switch2.IsToggled == true)
                        {
                            Button30.IsVisible = true;
                        }
                        if (switch3.IsToggled == true)
                        {
                            Button31.IsVisible = true;
                        }
                        if (switch4.IsToggled == true)
                        {
                            Button30.IsVisible = true;
                        }
                        if (switch5.IsToggled == true)
                        {
                            Button32.IsVisible = true;
                        }
                        if (switch6.IsToggled == true)
                        {
                            Button33.IsVisible = true;
                        }
                        if (switch7.IsToggled == true)
                        {
                            Button33.IsVisible = true;
                        }
                        if (switch8.IsToggled == true)
                        {
                            Button33.IsVisible = true;
                        }
                        if (switch9.IsToggled == true)
                        {
                            Button33.IsVisible = true;
                        }
                        if (switch10.IsToggled == true)
                        {
                            Button32.IsVisible = true;
                        }
                        if (switch11.IsToggled == true)
                        {
                            Button32.IsVisible = true;
                        }
                        if (switch12.IsToggled == true)
                        {
                            Button32.IsVisible = true;
                        }
                        if (switch13.IsToggled == true)
                        {
                            Button32.IsVisible = true;
                        }
                        if (switch14.IsToggled == true)
                        {
                            Button32.IsVisible = true;
                        }
                        if (switch15.IsToggled == true)
                        {
                            Button34.IsVisible = true;
                        }
                        if (switch16.IsToggled == true)
                        {
                            Button34.IsVisible = true;
                        }
                        if (switch17.IsToggled == true)
                        {
                            Button34.IsVisible = true;
                        }
                        if (switch18.IsToggled == true)
                        {
                            Button34.IsVisible = true;
                        }
                        if (switch19.IsToggled == true)
                        {
                            Button32.IsVisible = true;
                        }
                        #endregion
                        Button21.IsVisible = true;
                        Button22.IsVisible = true;
                        Button23.IsVisible = true;
                        Button24.IsVisible = true;
                        Button25.IsVisible = true;
                        Button26.IsVisible = true;
                        Button27.IsVisible = true;
                        Button28.IsVisible = true;
                        Button29.IsVisible = true;
                    }
                }
            }
            //Properties();
        }
        void SelectedCategory()//Выбраные категории
        {
            #region Условия Switch //Добавление в список и включение кнопок
            if (switch1.IsToggled == true)
            {
                listCategory.Add(new CategoryPeople() { Category = "Проживающий на участке" });
            }
            if (switch2.IsToggled == true)
            {
                listCategory.Add(new CategoryPeople() { Category = "Сотрудник органов внутренних дел или военнослужащий" });
            }
            if (switch3.IsToggled == true)
            {
                listCategory.Add(new CategoryPeople() { Category = "Внештатный помощник милиции" });
            }
            if (switch4.IsToggled == true)
            {
                listCategory.Add(new CategoryPeople() { Category = "Имеющий в личном пользовании оружие" });
            }
            if (switch5.IsToggled == true)
            {
                listCategory.Add(new CategoryPeople() { Category = "Осуществляющий незаконное предоставление, передачу жилых помещений" });
            }
            if (switch6.IsToggled == true)
            {
                listCategory.Add(new CategoryPeople() { Category = "Ранее судимый" });
            }
            if (switch7.IsToggled == true)
            {
                listCategory.Add(new CategoryPeople() { Category = "Освобожденный из мест лишения свободы" });
            }
            if (switch8.IsToggled == true)
            {
                listCategory.Add(new CategoryPeople() { Category = "Осужденный к уголовному наказанию, не связанному с лишением свободы" });
            }
            if (switch9.IsToggled == true)
            {
                listCategory.Add(new CategoryPeople() { Category = "Освобожденный от уголовной ответственности по не реабилитирующим основаниям" });
            }
            if (switch10.IsToggled == true)
            {
                listCategory.Add(new CategoryPeople() { Category = "Совершающий правонарушения в сфере семейно-бытовых отношений" });
            }
            if (switch11.IsToggled == true)
            {
                listCategory.Add(new CategoryPeople() { Category = "Хронический алкоголик, состоящие на учете в учреждениях здравоохранения" });
            }
            if (switch12.IsToggled == true)
            {
                listCategory.Add(new CategoryPeople() { Category = "Больной наркоманией, а также допускающий потребление наркотических средств и психотропных веществ без назначения врача, состоящий на учете в учреждениях" });
            }
            if (switch13.IsToggled == true)
            {
                listCategory.Add(new CategoryPeople() { Category = "Психически больной, представляющий непосредственную опасность для себя  и окружающих, состоящий на учете в учреждениях здравоохранения" });
            }
            if (switch14.IsToggled == true)
            {
                listCategory.Add(new CategoryPeople() { Category = "Несовершеннолетний, состоящие на учете в инспекции по делам несовершеннолетних" });
            }
            if (switch15.IsToggled == true)
            {
                listCategory.Add(new CategoryPeople() { Category = "Уклоняющий от военной службы, из числа проживающих на административном участке" });
            }
            if (switch16.IsToggled == true)
            {
                listCategory.Add(new CategoryPeople() { Category = "Находится в розыске, из числа проживающих на административном участке" });
            }
            if (switch17.IsToggled == true)
            {
                listCategory.Add(new CategoryPeople() { Category = "Входящий в объединения экстремистского толка, в т.ч. неформальные молодежные объединения" });
            }
            if (switch18.IsToggled == true)
            {
                listCategory.Add(new CategoryPeople() { Category = "Задержанный за нарушения общественного порядка при проведении  массовых мероприятий" });
            }
            if (switch19.IsToggled == true)
            {
                listCategory.Add(new CategoryPeople() { Category = "Постоянно проживающий иностранный гражданин и лицо без гражданства" });
            }
            #endregion
            foreach (CategoryPeople category in listCategory)
            {
                Result += category.Category + "\n";//Выбраные категории                                                       
            }
            DisplayAlert("Выбраные категории", Result, "ОK");
            listCategory.Clear();
            Result = "";
        }

        private async void Home_Clicked(object sender, EventArgs e)//На главную в Личный кабинет
        {
            bool result = await DisplayAlert("Вы уверены?", "Все верно?", "OK", "Отмена");

            if (result)
            {
                //DeleteProperties();
                await Navigation.PushAsync(new Home());//переход на Главную
            }
        }
        private async void Card_Clicked(object sender, EventArgs e)//Завести контрольную карточку
        {
            bool result = await DisplayAlert("Вы уверены что хотите завести контрольную карточку?", "Все верно?", "OK", "Отмена");

            if (result)
            {
                //DeleteProperties();
                await Navigation.PushAsync(new CardPage());//переход 
            }
        }

        private async void Save(object sender, EventArgs e)//Сохранить
        {
            bool result = await DisplayAlert("Вы уверены что хотите Сохранить введенные данные?", "Все верно?", "OK", "Отмена");

            if (result)
            {
                Entry[] entrys = new Entry[] { Entry1, Entry2, Entry3, Entry4, Entry5, Entry6, Entry7, Entry8, Entry9, Entry10 };
                for (int i = 0; i < entrys.Length; i++)
                {
                    if (entrys[i].IsVisible == true)
                    {
                        entrys[i].IsVisible = false;
                    }
                }
                Button[] buttons = new Button[] { Button21, Button22, Button23, Button24, Button25, Button26, Button27, Button28, Button29, Button30, Button31, Button32, Button33, Button34 };
                for (int i = 0; i < buttons.Length; i++)
                {
                    if (buttons[i].Text == Title)
                    {
                        buttons[i].IsEnabled = false;
                    }
                }
                //Включаем свичи
                Switch[] switches = new Switch[] { switch1, switch2, switch3, switch4, switch5, switch6, switch7, switch8, switch9, switch10, switch11, switch12, switch13, switch14, switch15, switch16, switch17, switch18, switch19 };
                for (int i = 0; i < switches.Length; i++)
                {
                    switches[i].IsEnabled = true;
                }
                Button21.IsVisible = true;
                Button22.IsVisible = true;
                Button23.IsVisible = true;
                Button24.IsVisible = true;
                Button25.IsVisible = true;
                Button26.IsVisible = true;
                Button27.IsVisible = true;
                Button28.IsVisible = true;
                Button29.IsVisible = true;

                Button1.IsVisible = false;
                Button2.IsVisible = false;
                Button3.IsVisible = false;
                datePicker1.IsVisible = false;
                datePicker2.IsVisible = false;
                datePicker3.IsVisible = false;
                Label1.IsVisible = false;
                Label2.IsVisible = false;
                Label3.IsVisible = false;

                SwitchTogled();
                //PlaceOfBirthModel.Country = Entry1.Text;
                //PlaceOfBirthModel.Region = Entry2.Text;
                //PlaceOfBirthModel.Area = Entry3.Text;
                //PlaceOfBirthModel.Sity = Entry4.Text;
                //PlaceOfBirthModel.Street = Entry5.Text;
                //PlaceOfBirthModel.House = Entry6.Text;
                //PlaceOfBirthModel.Apartment = Entry7.Text;

                //Properties();
                //await Navigation.PushAsync(new CategoryPage());//переход на страницу Категории
                SelectedCategory();//Выбраные категории
            }
        }
        private void Cancel(object sender, EventArgs e)//Отмена
        {
            Entry[] entrys = new Entry[] { Entry1, Entry2, Entry3, Entry4, Entry5, Entry6, Entry7, Entry8, Entry9, Entry10 };
            for (int i = 0; i < entrys.Length; i++)
            {
                if (entrys[i].IsVisible == true)
                {
                    entrys[i].IsVisible = false;
                }
            }
            Button[] buttons = new Button[] { Button21, Button22, Button23, Button24, Button25, Button26, Button27, Button28, Button29, Button30, Button31, Button32, Button33, Button34 };
            for (int i = 0; i < buttons.Length; i++)
            {
                if (buttons[i].Text == Title)
                {
                    buttons[i].IsEnabled = true;
                }
            }
            //Включаем свичи
            Switch[] switches = new Switch[] { switch1, switch2, switch3, switch4, switch5, switch6, switch7, switch8, switch9, switch10, switch11, switch12, switch13, switch14, switch15, switch16, switch17, switch18, switch19 };
            for (int i = 0; i < switches.Length; i++)
            {
                switches[i].IsEnabled = true;
            }

            Button21.IsVisible = true;
            Button22.IsVisible = true;
            Button23.IsVisible = true;
            Button24.IsVisible = true;
            Button25.IsVisible = true;
            Button26.IsVisible = true;
            Button27.IsVisible = true;
            Button28.IsVisible = true;
            Button29.IsVisible = true;

            Button1.IsVisible = false;
            Button2.IsVisible = false;
            Button3.IsVisible = false;
            datePicker1.IsVisible = false;
            datePicker2.IsVisible = false;
            datePicker3.IsVisible = false;
            Label1.IsVisible = false;
            Label2.IsVisible = false;
            Label3.IsVisible = false;

            SwitchTogled();
        }

        private void Birthplace_Clicked(object sender, EventArgs e)//Место рождения
        {
            //GetSearch();//метод поиска
            Title = "Место рождения";
            Grid2.Children.Add(Entry1 = new Entry { Placeholder = "Страна" }, 0, 1);
            Grid2.Children.Add(Entry2 = new Entry { Placeholder = "Область" }, 0, 2);
            Grid2.Children.Add(Entry3 = new Entry { Placeholder = "Район" }, 0, 3);
            Grid2.Children.Add(Entry4 = new Entry { Placeholder = "Аймак/город/пгт/ж.м" }, 0, 4);
            Grid2.Children.Add(Entry5 = new Entry { Placeholder = "Улица" }, 0, 5);
            Grid2.Children.Add(Entry6 = new Entry { Placeholder = "Дом" }, 0, 6);
            Grid2.Children.Add(Entry7 = new Entry { Placeholder = "Квартира" }, 0, 7);
            Grid2.Children.Add(Button1 = new Button { Text = "Сохранить"}, 0, 8);
            Grid2.Children.Add(Button2, 0, 9);
            Button1.Clicked += Save;
            Button2.Clicked += Cancel;
            Button1.IsVisible = true;
            Button2.IsVisible = true;
            //Entry1.Text = PlaceOfBirthModel.Country;
            //Entry2.Text = PlaceOfBirthModel.Region;
            //Entry3.Text = PlaceOfBirthModel.Area;
            //Entry4.Text = PlaceOfBirthModel.Sity;
            //Entry5.Text = PlaceOfBirthModel.Street;
            //Entry6.Text = PlaceOfBirthModel.House;
            //Entry7.Text = PlaceOfBirthModel.Apartment;

            //Entry1.SetBinding(Entry.TextProperty, new Binding("Title"));
            //Entry2.SetBinding(Entry.TextProperty, new Binding("Main.Temperature"));
            //Entry3.SetBinding(Entry.TextProperty, new Binding("Wind.Speed"));
            //Entry4.SetBinding(Entry.TextProperty, new Binding("Weather[0].Visibility"));
            //Entry5.SetBinding(Entry.TextProperty, new Binding("Main.Humidity"));
            //Entry6.SetBinding(Entry.TextProperty, new Binding("Main.Humidity"));
            //Entry7.SetBinding(Entry.TextProperty, new Binding("Main.Humidity"));

            //button1.Clicked += Birthplace_Save;
            //button2.Clicked += Birthplace_Cancel;
            //StackLayout.Children.Add(Entry1);
            //StackLayout.Children.Add(Entry2);
            //StackLayout.Children.Add(Entry3);
            //StackLayout.Children.Add(Entry4);
            //StackLayout.Children.Add(Entry5);
            //StackLayout.Children.Add(Entry6);
            //StackLayout.Children.Add(Entry7);
            //StackLayout.Children.Add(button1);
            //StackLayout.Children.Add(button2);
            //scrollView.Content = StackLayout;
            //Content = scrollView; 
            Clicked();
        }        
        private void Dwellingplace_Clicked(object sender, EventArgs e)//Место жительства
        {
            Title = "Место жительства";           
            Grid2.Children.Add(Entry1 = new Entry { Placeholder = "Область" }, 0, 2);
            Grid2.Children.Add(Entry2 = new Entry { Placeholder = "Район" }, 0, 3);
            Grid2.Children.Add(Entry3 = new Entry { Placeholder = "Аймак/город/пгт/ж.м" }, 0, 4);
            Grid2.Children.Add(Entry4 = new Entry { Placeholder = "Улица" }, 0, 5);
            Grid2.Children.Add(Entry5 = new Entry { Placeholder = "Дом" }, 0, 6);
            Grid2.Children.Add(Entry6 = new Entry { Placeholder = "Квартира" }, 0, 7);
            Grid2.Children.Add(Entry7 = new Entry { Placeholder = "Домашний телефон" }, 0, 8);
            Grid2.Children.Add(Button1 = new Button { Text = "Сохранить" }, 0, 9);
            Grid2.Children.Add(Button2, 0, 10);
            Button1.Clicked += Save;
            Button2.Clicked += Cancel;
            Button1.IsVisible = true;
            Button2.IsVisible = true;
            Clicked();
        }
        private void Job_Clicked(object sender, EventArgs e)//Место работы или учебы
        {
            Title = "Место работы или учебы";
            Grid2.Children.Add(Entry1 = new Entry { Placeholder = "Область" }, 0, 3);
            Grid2.Children.Add(Entry2 = new Entry { Placeholder = "Район" }, 0, 4);
            Grid2.Children.Add(Entry3 = new Entry { Placeholder = "Аймак/город/пгт/ж.м" }, 0, 5);
            Grid2.Children.Add(Entry4 = new Entry { Placeholder = "Улица" }, 0, 6);
            Grid2.Children.Add(Entry5 = new Entry { Placeholder = "Дом" }, 0, 7);
            Grid2.Children.Add(Entry6 = new Entry { Placeholder = "Квартира" }, 0, 8);
            Grid2.Children.Add(Entry7 = new Entry { Placeholder = "Рабочий телефон" }, 0, 9);
            Grid2.Children.Add(Button1 = new Button { Text = "Сохранить" }, 0, 10);
            Grid2.Children.Add(Button2, 0, 11);
            Button1.Clicked += Save;
            Button2.Clicked += Cancel;
            Button1.IsVisible = true;
            Button2.IsVisible = true;
            Clicked();
        }
        private void Degree_Clicked(object sender, EventArgs e)//Степень родства
        {
            
        }
        private void Pets_Clicked(object sender, EventArgs e)//Сельскохозяйственные, домашние животные
        {
            Title = "Сельскохозяйственные, домашние животные";
            Grid2.Children.Add(Entry1 = new Entry { Placeholder = "Наименование" }, 0, 5);
            Grid2.Children.Add(Entry2 = new Entry { Placeholder = "Порода" }, 0, 6);
            Grid2.Children.Add(Entry3 = new Entry { Placeholder = "Окрас" }, 0, 7);
            Grid2.Children.Add(Entry4 = new Entry { Placeholder = "Кличка" }, 0, 8);
            Grid2.Children.Add(Entry5 = new Entry { Placeholder = "Особые приметы" }, 0, 9);
            Grid2.Children.Add(Button1 = new Button { Text = "Сохранить" }, 0, 10);
            Grid2.Children.Add(Button2, 0, 11);
            Button1.Clicked += Save;
            Button2.Clicked += Cancel;
            Button1.IsVisible = true;
            Button2.IsVisible = true;
            Clicked();
        }
        private void Avtotransport_Clicked(object sender, EventArgs e)//Наличие автомототранспорта
        {
            Title = "Наличие автомототранспорта";
            Grid2.Children.Add(Entry1 = new Entry { Placeholder = "VID" }, 0, 6);
            Grid2.Children.Add(Entry2 = new Entry { Placeholder = "Марка" }, 0, 7);
            Grid2.Children.Add(Entry3 = new Entry { Placeholder = "Модель" }, 0, 8);
            Grid2.Children.Add(Entry4 = new Entry { Placeholder = "Типы цветов" }, 0, 9);
            Grid2.Children.Add(Entry5 = new Entry { Placeholder = "Год выпуска" }, 0, 10);
            Grid2.Children.Add(Entry6 = new Entry { Placeholder = "Страна происхождения" }, 0, 11);
            Grid2.Children.Add(Entry7 = new Entry { Placeholder = "Вид кузова" }, 0, 12);
            Grid2.Children.Add(Entry8 = new Entry { Placeholder = "Тип кузова" }, 0, 13);
            Grid2.Children.Add(Entry9 = new Entry { Placeholder = "Объем двигателя" }, 0, 14);
            Grid2.Children.Add(Entry10 = new Entry { Placeholder = "Иное" }, 0, 15);
            Grid2.Children.Add(Button1 = new Button { Text = "Сохранить" }, 0, 16);
            Grid2.Children.Add(Button2, 0, 17);
            Button1.Clicked += Save;
            Button2.Clicked += Cancel;
            Button1.IsVisible = true;
            Button2.IsVisible = true;
            Clicked();
        }
        private void NameAvtotransport_Clicked(object sender, EventArgs e)//ФИО владельца автотранспорта
        {
            Title = "ФИО владельца автотранспорта";
            Grid2.Children.Add(Entry1 = new Entry { Placeholder = "Фамилия" }, 0, 7);
            Grid2.Children.Add(Entry2 = new Entry { Placeholder = "Имя" }, 0, 8);
            Grid2.Children.Add(Entry3 = new Entry { Placeholder = "Отчество" }, 0, 9);
            Grid2.Children.Add(Button1 = new Button { Text = "Сохранить" }, 0, 10);
            Grid2.Children.Add(Button2, 0, 11);
            Button1.Clicked += Save;
            Button2.Clicked += Cancel;
            Button1.IsVisible = true;
            Button2.IsVisible = true;
            Clicked();
        }
        private void Mobile_Clicked(object sender, EventArgs e)//Мобильный телефон
        {
            Title = "Мобильный телефон";
            Grid2.Children.Add(Entry1 = new Entry { Placeholder = "Номер телефона" }, 0, 8);
            Grid2.Children.Add(Button3 = new Button { Text = "+", BackgroundColor = Color.Chocolate, BorderColor = Color.SlateGray, BorderWidth=1, CornerRadius=5, }, 0, 10);
            Grid2.Children.Add(Button1 = new Button { Text = "Сохранить" }, 0, 11);
            Grid2.Children.Add(Button2, 0, 12);
            Button3.Clicked += Mobile_Add;
            Button1.Clicked += Save;
            Button2.Clicked += Cancel;
            Button1.IsVisible = true;
            Button2.IsVisible = true;
            Clicked();
        }
        private void Mobile_Add(object sender, EventArgs e)//Мобильный телефон еще добавить
        {
            Grid2.Children.Add(Entry2 = new Entry { Placeholder = "Номер телефона" }, 0, 9);
        }
        private void Notes_Clicked(object sender, EventArgs e)//Примечания
        {

        }

        private void Weapon_Clicked(object sender, EventArgs e)//Оружие
        {
            Title = "Оружие";
            Grid2.Children.Add(Entry1 = new Entry { Placeholder = "Виды оружия" }, 1, 3);
            Grid2.Children.Add(Entry2 = new Entry { Placeholder = "Номер разрешения" }, 1, 4);
            Grid2.Children.Add(Entry3 = new Entry { Placeholder = "Марка" }, 1, 5);
            Grid2.Children.Add(Entry4 = new Entry { Placeholder = "Калибр" }, 1, 6);
            Grid2.Children.Add(Entry5 = new Entry { Placeholder = "Количество стволов" }, 1, 7);
            Grid2.Children.Add(Entry6 = new Entry { Placeholder = "Количество зарядов" }, 1, 8);
            Grid2.Children.Add(Entry7 = new Entry { Placeholder = "Орган выдавший" }, 1, 9);
            Grid2.Children.Add(Label1 = new Label { Text = " Дата выпуска", VerticalOptions = LayoutOptions.Start }, 1, 10);
            Grid2.Children.Add(datePicker1 = new DatePicker { VerticalOptions = LayoutOptions.End }, 1, 10);
            Grid2.Children.Add(Button1 = new Button { Text = "Сохранить" }, 1, 11);
            Grid2.Children.Add(Button2, 1, 12);
            Button1.Clicked += Save;
            Button2.Clicked += Cancel;
            Button1.IsVisible = true;
            Button2.IsVisible = true;
            Clicked();
        }
        private void IssuingCertificate_Clicked(object sender, EventArgs e)//ОВД, выдавший удостоверение внештатному помощнику милиции
        {
            Title = "ОВД, выдавший удостоверение внештатному помощнику милиции";
            Grid2.Children.Add(Entry1 = new Entry { Placeholder = "Наименование ОВД" }, 1, 4);
            Grid2.Children.Add(Entry2 = new Entry { Placeholder = "Номер удостоверения" }, 1, 5);
            Grid2.Children.Add(Label1 = new Label { Text = " Действителен до", VerticalOptions= LayoutOptions.Start }, 1, 6);
            Grid2.Children.Add(datePicker1 = new DatePicker { VerticalOptions = LayoutOptions.End }, 1, 6);
            Grid2.Children.Add(Button1 = new Button { Text = "Сохранить" }, 1, 7);
            Grid2.Children.Add(Button2, 1, 8);
            Button1.Clicked += Save;
            Button2.Clicked += Cancel;
            Button1.IsVisible = true;
            Button2.IsVisible = true;
            Clicked();
        }
        private void Offense_Clicked(object sender, EventArgs e)//Правонарушение
        {
            Title = "Правонарушение";
            Grid2.Children.Add(Entry1 = new Entry { Placeholder = "Наличие правонарушений, совершенных в данных местах" }, 1, 5);          
            Grid2.Children.Add(Label1 = new Label { Text = " Дата правонарушений, совершенных в данных местах", VerticalOptions = LayoutOptions.Start }, 1, 6);
            Grid2.Children.Add(datePicker1 = new DatePicker { VerticalOptions = LayoutOptions.End }, 1, 6);
            Grid2.Children.Add(Entry2 = new Entry { Placeholder = "Статья правонарушения" }, 1, 7);
            Grid2.Children.Add(Entry3 = new Entry { Placeholder = "Принятые меры" }, 1, 8);
            Grid2.Children.Add(Button1 = new Button { Text = "Сохранить" }, 1, 9);
            Grid2.Children.Add(Button2, 1, 10);
            Button1.Clicked += Save;
            Button2.Clicked += Cancel;
            Button1.IsVisible = true;
            Button2.IsVisible = true;
            Clicked();
        }
        private void CriminalRecord_Clicked(object sender, EventArgs e)//Наличие судимости
        {
            Title = "Наличие судимости";
            Grid2.Children.Add(Entry1 = new Entry { Placeholder = "Статья УККР" }, 1, 6);
            Grid2.Children.Add(Label1 = new Label { Text = " Дата освобождений из мест лишения свободы", VerticalOptions = LayoutOptions.Start }, 1, 7);
            Grid2.Children.Add(datePicker1 = new DatePicker { VerticalOptions = LayoutOptions.End }, 1, 7);
            Grid2.Children.Add(Label2 = new Label { Text = " Дата постановки на учет", VerticalOptions = LayoutOptions.Start }, 1, 8);
            Grid2.Children.Add(datePicker2 = new DatePicker { VerticalOptions = LayoutOptions.End }, 1, 8);
            Grid2.Children.Add(Label3 = new Label { Text = " Дата снятия с учета", VerticalOptions = LayoutOptions.Start }, 1, 9);
            Grid2.Children.Add(datePicker3 = new DatePicker { VerticalOptions = LayoutOptions.End }, 1, 9);
            Grid2.Children.Add(Button1 = new Button { Text = "Сохранить" }, 1, 10);
            Grid2.Children.Add(Button2, 1, 11);
            Button1.Clicked += Save;
            Button2.Clicked += Cancel;
            Button1.IsVisible = true;
            Button2.IsVisible = true;
            Clicked();
        }
        private void AccountingDate_Clicked(object sender, EventArgs e)//Дата учета
        {
            Title = "Дата учета";
            Grid2.Children.Add(Label1 = new Label { Text = " Дата постановки на учет", VerticalOptions = LayoutOptions.Start }, 1, 7);
            Grid2.Children.Add(datePicker1 = new DatePicker { VerticalOptions = LayoutOptions.End }, 1, 7);
            Grid2.Children.Add(Label2 = new Label { Text = " Дата снятия с учета", VerticalOptions = LayoutOptions.Start }, 1, 8);
            Grid2.Children.Add(datePicker2 = new DatePicker { VerticalOptions = LayoutOptions.End }, 1, 8);
            Grid2.Children.Add(Button1 = new Button { Text = "Сохранить" }, 1, 9);
            Grid2.Children.Add(Button2, 1, 10);
            Button1.Clicked += Save;
            Button2.Clicked += Cancel;
            Button1.IsVisible = true;
            Button2.IsVisible = true;
            Clicked();

        }











    }
}