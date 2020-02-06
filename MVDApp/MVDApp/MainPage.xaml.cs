using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net;
using System.Net.Http;
using Newtonsoft;
using Newtonsoft.Json;

namespace MVDApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //StackLayout1.BackgroundColor = Color.FromRgb(33, 40, 47);//цвет
        }
        
        private async void Button2_Click(object sender, EventArgs e)//Авторизация
        {
            await Navigation.PushAsync(new Home());//переход на новую страницу
        }
        
    }
}
