using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Comiker
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            //display page information from page that is selected
            //when '+ add panel' is selected, automatically add item (panel) to the page folder
            //has to have delete option per panel
            //information about characters, dialog, notes for each panel
        }
		private void AddImageButton_OnClicked(object sender, EventArgs e)
		{
			DisplayAlert("Add Image", "Choose where to get image", "Gallery", "Camera");
            //this was meant to be the taking image bit, i wanna display an alert that enables the user to choose gallery or camera
            //has to have delete option
            //back button to Pages
		}
    }
}
