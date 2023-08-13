﻿using App1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddSensorPage : ContentPage
	{
		public AddSensorPage ()
		{
			this.BindingContext = new NewSensorViewModel();
			InitializeComponent ();
		}

		public async void OnAddButton(object sender, EventArgs e)
		{
			await ((NewSensorViewModel)this.BindingContext).AddButtonHandler();
			if (((NewSensorViewModel)this.BindingContext).success) 
			{ 
				await Navigation.PushModalAsync(new ListViewPage1()); 
			}
        }

        public void OnBack(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ListViewPage1());
        }
    }
}