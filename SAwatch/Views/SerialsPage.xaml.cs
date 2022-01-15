﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SAwatch.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SerialsPage : ContentPage
    {
        public SerialsPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            collectionView.ItemsSource = await App.SerialsDB.GetSerialsAsync();

            base.OnAppearing();
        }

        private async void OnAddSerialButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(SerialsAddingPage));
        }

        private void OnFinishedSerialButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}