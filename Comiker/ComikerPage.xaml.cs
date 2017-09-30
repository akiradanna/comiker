using System;
using Xamarin.Forms;
using PCLStorage;

namespace Comiker
{
	public partial class ComikerPage : ContentPage
	{
        
        public ComikerPage()
		{
            InitializeComponent();
            ProjectList.ItemTemplate = new DataTemplate();
            //hiding the add project things
            CreateProjectButton.IsVisible = false;
            CancelProjectButton.IsVisible = false;
            ProjectTitle.IsVisible = false;
            EnterTitle.IsVisible = false;
		}
        private void AddProjectButton_OnClicked(object sender, EventArgs e)
        //when '+ add project' is pressed they should appear
        {
			CreateProjectButton.IsVisible = true;
			CancelProjectButton.IsVisible = true;
			ProjectTitle.IsVisible = true;
            EnterTitle.IsVisible = true;
			void CreateProjectButton_OnClicked(object sender2, EventArgs args)
			{
                //when 'create' is clicked, add project folder, add project to the list displayed below '+ add project'
			}
			void CancelProjectButton_OnClicked(object sender2, EventArgs args)
			{
                //cancels the creation, hide buttons and text field
				CreateProjectButton.IsVisible = false;
				CancelProjectButton.IsVisible = false;
				ProjectTitle.IsVisible = false;
				EnterTitle.IsVisible = false;
			}
        }
        //display a list of projects, make them clickable to AboutProject
        //each item also must have a delete option
	}
}