using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ZakatApp
{
	public partial class Pertanian : ContentPage
	{
		public Pertanian()
		{
			InitializeComponent();
			Title = "Zakat Pertanian";
		}

		void Handle_Toggled(object sender, Xamarin.Forms.ToggledEventArgs e)
		{
			bool isToogled = e.Value;
			if (isToogled == true)
			{
				Irigasi.Text = "Ya";
			}
			else
			{
				Irigasi.Text = "Tidak";
			}

		}

		void OnHitung(object sender, EventArgs args)
		{
			double panenan = double.Parse(JumlahPanen.Text);
			double harganya = double.Parse(HargaJual.Text);
			double hasil;

			string apairigasi = Irigasi.Text;

			if (apairigasi == "Ya")
			{
				hasil = panenan * harganya * 0.05;
			}
			else
			{ 
				hasil = panenan * harganya * 0.1;
			}

			JumlahZakat.Text = hasil.ToString();
		}


	}
}
