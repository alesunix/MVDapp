using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVDApp.Models.MultiSelectListView
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
            BindingContext = new MainPageViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            ((MainPageViewModel)BindingContext).OnAppearing();
        }
    }
}