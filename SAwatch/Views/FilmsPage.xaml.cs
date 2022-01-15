using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SAwatch.Views;
using SAwatch.Data;
using SAwatch.Models;

namespace SAwatch.Views
{
    public partial class FilmsPage : ContentPage
    {
        public FilmsPage()
        {
            Title = "Фильмы";
            InitializeComponent();
        }
        protected override async void OnAppearing() 
        {
            collectionView.ItemsSource = await App.FilmsDB.GetFilmsAsync();

            base.OnAppearing();
        }
        private async void OnAddFilmButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(FilmsAddingPage));
        }

        private void OnFinishedFilmButton_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = "+";
            button.BackgroundColor = Color.CadetBlue;
        }
    }
}