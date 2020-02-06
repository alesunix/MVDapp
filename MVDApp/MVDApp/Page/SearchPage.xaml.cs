using MVDApp.Models;
using MVDApp.Page;
using Newtonsoft.Json;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVDApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FioPage : ContentPage
	{
        RestService _restService;
        bool Result;
        public FioPage ()
		{
			InitializeComponent ();
            //StackLayout1.BackgroundColor = Color.FromRgb(33, 40, 47);//цвет
            _restService = new RestService();
            Entry[] entrys = new Entry[] { Entry1, Entry2, Entry3, Entry4, Entry5, Entry6, Entry7, Entry8, Entry9, Entry10, Entry11, Entry12 };
            for (int i = 0; i < entrys.Length; i++)
            {
                entrys[i].Text = "";//Очистка полей чтобы при возврате на страницу небыло возможности сохранения пустых полей
            }
        }

        //После ввода ФИО или ИНН осуществляется поиск по базе данных «М-data» ГУИТ МВД КР.
        async void OnButtonClicked(object sender, EventArgs e)//Поиск
        {                  
            if (!string.IsNullOrWhiteSpace(EntrySearch1.Text))
            {
                PassportModel.EntrySearch1 = EntrySearch1.Text;//передать в модель строку поиска
                PersonalData personalData = await _restService.GetPersonalData(GenerateRequestUri(Constants.OpenMapEndpoint));
                BindingContext = personalData;

                //test photo
                photo.Source = new UriImageSource
                {
                    CachingEnabled = false,
                    Uri = new Uri("http://foto-all.ru/images/photo1.jpg")
                };

                CategoryControlCard cardStatus = new CategoryControlCard();
                cardStatus.Status = false;
                if (cardStatus.Status == true)
                {
                    chekСard.Source = new UriImageSource
                    {
                        CachingEnabled = false,
                        Uri = new Uri("https://bloggood.ru/wp-content/uploads/2015/05/checkbox-php-3.png")
                    };
                    labelCard.Text = "Контрольная карточка заведена";
                    //Button4.IsEnabled = false;
                }
                else
                {
                    labelCard.Text = "Контрольная карточка не заведена"; 
                }
            }
            else
            {
                EntrySearch1.Text = "Нет данных";
            }
        }

        string GenerateRequestUri(string endpoint)
        {
            string requestUri = endpoint;
            requestUri += $"?q={PassportModel.EntrySearch1}";
            requestUri += "&units=imperial"; // or units=metric
            requestUri += $"&APPID={Constants.OpenMapAPIKey}";
            return requestUri;
        }

        private async void Button2_Click(object sender, EventArgs e)//Сохранить
        {
            if (EntrySearch3.Text != "")// цель осуществления поика
            {
                Entry[] entrys = new Entry[] { Entry1, Entry2, Entry3, Entry4, Entry5, Entry6, Entry7, Entry8, Entry9, Entry10, Entry11, Entry12 };
                for (int i = 0; i < entrys.Length; i++)
                {
                    //entrys[i].RemoveBinding(Entry.TextProperty);//Удаляем привязку
                    //Entry1.RemoveBinding(Entry.TextProperty);//Удаляем привязку
                    if (entrys[i].Text == "")
                    {
                        Result = false;
                    }
                    else
                    {
                        Result = true;
                    }
                }

                if (Entry1.Text != "" & Entry2.Text != "" & Entry3.Text != "" & Entry4.Text != "" & Entry5.Text != "" & Entry6.Text != "" & Entry7.Text != "" & Entry8.Text != "" & Entry9.Text != "" & Entry10.Text != "" & Entry11.Text != "" & Entry12.Text != "")
                {
                    PassportModel.Inn = Entry1.Text;
                    PassportModel.FullName = Entry2.Text;
                    PassportModel.FormerName = Entry3.Text;
                    PassportModel.PassportSeries = Entry4.Text;
                    PassportModel.PassportID = Entry5.Text;
                    PassportModel.DateOfIssue = Entry6.Text;
                    PassportModel.ExpirationDate = Entry7.Text;
                    PassportModel.IssuingAuthority = Entry8.Text;
                    PassportModel.DateOfBirth = Entry9.Text;
                    PassportModel.Gender = Entry10.Text;
                    PassportModel.Nationality = Entry11.Text;
                    PassportModel.FamilyStatus = Entry12.Text;
                    //post
                    await Navigation.PushAsync(new CategoryPage());//переход на страницу Категории
                }
                else
                {
                    await DisplayAlert("Внимание!", "Не все поля заполнены!", "ОК");
                    return;
                }
            }
            else
            {
                await DisplayAlert("Внимание!", "Введите цель осуществления поиска!", "ОК");
            }                           
        }
    }
}