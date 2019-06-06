using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DotaWinrates
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
		private void Button_Clicked(object sender, EventArgs e)
		{
			var newAddPage = new LoadingPage();
			newAddPage.BindingContext = this.BindingContext;
			App.Current.MainPage = new NavigationPage(newAddPage);
		}
	}
}
