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
	public partial class MultiSelect : ContentPage
	{
        public MultiSelect(List<SelectableData<ExampleData>> data)
        {
            InitializeComponent();
            BindingContext = new MultiSelectViewModel(data);
        }
    }
}