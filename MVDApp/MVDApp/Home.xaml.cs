using MVDApp.Page;
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
	public partial class Home : ContentPage
	{
		public Home ()
		{
			InitializeComponent ();
            //StackLayout1.BackgroundColor = Color.FromRgb(33, 40, 47);//цвет
            SwitchTogled();
        }
        void OnToggled(object sender, ToggledEventArgs e)// Событие Switch OnToggled
        {
            if (Switch1.IsToggled == true)
            {
                Switch2.IsToggled = false;
                Switch1.IsToggled = true;
            }
            if (Switch2.IsToggled == true)
            {
                Switch1.IsToggled = false;
                Switch2.IsToggled = true;
            }
        }
        void SwitchTogled()
        {
            Switch2.IsToggled = true;
        }
        private async void Button1_Click(object sender, EventArgs e)//ФИО
        {
            FioPage fioPage = new FioPage();
            NavigationPage.SetHasBackButton(fioPage, false);//скрыть переход назад
            //NavigationPage.SetHasNavigationBar(fioPage, false);// скрыть верхнюю панель полностью
            await Navigation.PushAsync(fioPage);//переход на страницу поиск по ФИО         
        }
        private async void Button3_Click(object sender, EventArgs e)//Обьект
        {
            await Navigation.PushAsync(new ObjectPage());
        }
    }
}