using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Comiker
{
    public partial class AboutCharacter : ContentPage
    {
        public AboutCharacter()
        {
            InitializeComponent();
            //displays information of character selected
            //when text field is unfocused, save info
        }

        private async void AddImageButton_OnClicked(object sender, EventArgs e)
        {
            var option = await DisplayAlert("Add Image", "Choose where to get image", "Gallery", "Camera");
            //this was meant to make the user choose between gallery or camera
            //has to have delete option
            if (option)
            { 
                
            }
            else
            {
                await Navigation.PopAsync();
            }
            //when '+ add custom ..' is selected there should be a text field for question, as well as create and cancel buttons - self explanatory
            //back button to AboutProject
        }
    }
}
