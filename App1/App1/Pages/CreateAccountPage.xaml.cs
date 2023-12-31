﻿using App1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreateAccountPage : ContentPage
	{
		public CreateAccountPage ()
		{
			this.BindingContext = new CreateAccountViewModel();
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        public async void OnCreateAttempt(object sender, EventArgs e)
        {
            CreateAccountViewModel cont = (CreateAccountViewModel)BindingContext;

            await cont.CreateButtonHandler();

            if (cont.create_success)
            {
                await App.NavigationService.NavigateToPageAsync(new LoginPage());
            }
        }

        public async void OnBack(object sender, EventArgs e)
        {
            await App.NavigationService.NavigateToPageAsync(new LoginPage());
        }
    }
}