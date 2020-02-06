using MVDApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVDApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CardPage : ContentPage
	{
        public string Result { get; set; }
        public string LabelResult { get; set; }
        public List<CategoryControlCard> Categoryes { get; set; }
        public List<CategoryControlCard> CategoryesResult { get; set; }
        Label label = new Label();
        public CardPage ()
		{
			InitializeComponent ();           
            Categoryes = new List<CategoryControlCard>         
        {
            new CategoryControlCard {Title="Освобожденных из мест лишения свободы, в отношении которых установлены ограничения в соответствии с законом" },
            new CategoryControlCard {Title="С непогашенной судимостью" },
            new CategoryControlCard {Title="Осужденные к мерам наказания, не связанными с лишением свободы" },
            new CategoryControlCard {Title="Освобожденные от уголовной ответственности по нереабилитирующим основаниям" },
            new CategoryControlCard {Title="Допускает правонарушения в сфере семейно-бытовых отношений" },
            new CategoryControlCard {Title="Болен хроническим алкоголизмом" },
            new CategoryControlCard {Title="Лиц, больных наркоманией" },
            new CategoryControlCard {Title="Допускающих потребление психотропных веществ без назначения врача" },
            new CategoryControlCard {Title="Допускающих потребление наркотических веществ без назначения врача" },
            new CategoryControlCard {Title="Из числа состоящих на учете в учреждениях здравоохранения" },
            new CategoryControlCard {Title="Болен психическим заболеванием" },
            new CategoryControlCard {Title="Представляет непосредственную опасность для себя и окружающих" },
            new CategoryControlCard {Title="Состоит на учете в учреждениях здравоохранения" },
            new CategoryControlCard {Title="Иные" },
        };
            
            this.BindingContext = this;
        }
        public void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            CategoryControlCard selected = e.Item as CategoryControlCard;
            if (selected != null)
            {
                DatePicker1.IsVisible = true;
                DatePicker2.IsVisible = true;
                Entry3.IsVisible = true;
                Button1.IsVisible = true;
                Result = selected.Title + $".\r\n с {DatePicker1.Date.ToShortDateString() + "\n"} по {DatePicker2.Date.ToShortDateString()}" + ".\r\n\n";//выбраная категория
                //DisplayAlert("Выбранная модель", $"{selected.Title}", "OK");
            }
            
            CategoryesResult = new List<CategoryControlCard>
            {
                new CategoryControlCard() { ResultCard = $"1{Result + "\n"}" }
            };
        }

        private void Button1_Clicked(object sender, EventArgs e)//Сохранить
        {
            LabelResult += Result + "\r\n";
            DisplayAlert("Заведена контрольная карточка", $"{Result}", "OK");
            label.IsVisible = false;
            Grid2.Children.Add(label = new Label { Text = LabelResult, FontSize = 10 }, 1, 1);
            DatePicker1.IsVisible = false;
            DatePicker2.IsVisible = false;
            Entry3.IsVisible = false;
            Button1.IsVisible = false;
        }
        private async void Button2_Clicked(object sender, EventArgs e)//В личный кабинет
        {
            bool result = await DisplayAlert("Вы уверены?", "Все верно?", "OK", "Отмена");

            if (result)
            {
                await Navigation.PushAsync(new Home());//переход на Главную
            }
        }
    }  
}