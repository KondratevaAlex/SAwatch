using SAwatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SAwatch.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FilmsAddingPage : ContentPage
    {
        public FilmsAddingPage()
        {
            InitializeComponent();
            BindingContext = new Films();
        }

        private async void AddFilmButton_Clicked(object sender, EventArgs e)
        {
            Films film = (Films)BindingContext;
            if (!string.IsNullOrWhiteSpace(film.NameOfFilm) & !string.IsNullOrWhiteSpace(film.DurationOfFilm))
            {
                await App.FilmsDB.SaveNoteAsync(film);
            }
            await Shell.Current.GoToAsync("..");
        }
    }
}