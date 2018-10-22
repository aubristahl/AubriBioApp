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


        }

        private void BioButtonGestureRecognizer_OnTapped(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AboutMePage());
        }

        private void SkillsButton_Tapped(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new skillsPage());
        }

        private void ContactButton_Tapped(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ContactPage());
           
        }
    }


}
