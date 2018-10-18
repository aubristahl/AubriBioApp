using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AubriBioApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
            InitializeComponent();
            Image imageButton = new Image
            {
                Source = "bioButton.png" };

            TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += async (s, e) => {
                await Navigation.PushAsync(new MainPage());
            }; imageButton.GestureRecognizers.Add(tapGestureRecognizer);

        }

        void Handle_Tapped(object sender, System.EventArgs e)
        {
            //throw new NotImplementedException();
        }
	}
}
