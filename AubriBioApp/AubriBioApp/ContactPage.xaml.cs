using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AubriBioApp
{
    public partial class ContactPage : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {

            if (string.IsNullOrEmpty(fullNameEntry.Text))
            {
                DisplayAlert("Error!", "Enter name", "Ok!");
                return;
            }


            if (string.IsNullOrEmpty(emailEntry.Text))
            {
                DisplayAlert("Error!", "Enter email", "Ok!");
                return;
            }


            if (string.IsNullOrEmpty(phoneEntry.Text))
            {
                DisplayAlert("Error!", "Enter phone", "Ok!");
                return;
            }

            DisplayAlert("Hello!", "Your message has been sent","Ok!");
           
        }

        public ContactPage()
        {
            InitializeComponent();
        }
    }
}
