using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ZakatApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			Title = "Aplikasi Zakat";
		}

		async void OnPertanian(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Pertanian());
		}
	}
}
