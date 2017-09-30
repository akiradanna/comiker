using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Comiker
{
    public partial class AboutProject : ContentPage
    {
        public AboutProject()
        {
            InitializeComponent();
            //when summary field is unfocused, save summary under the project folder
            //display a list of chapters and characters in the project folder
            //there must be a delete option per chapter and character
            //when either of the add buttons are pressed a text field for name, cancel and create buttons appear below
            //user can choose to create (add character/chapter to project folder) or cancel creation
            //when user chooses character go to AboutCharacter
            //when user chooses chapter go to Pages
            //back button to ComikerPage
        }
    }
}
