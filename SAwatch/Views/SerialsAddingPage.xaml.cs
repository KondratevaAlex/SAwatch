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
    public partial class SerialsAddingPage : ContentPage
    {
        public SerialsAddingPage()
        {
            InitializeComponent();
            BindingContext = new Serials();
        }

        private async void AddSerialButton_Clicked(object sender, EventArgs e)
        {
            Serials serial = (Serials)BindingContext;
            if (!string.IsNullOrWhiteSpace(serial.NameOfSerial) & !string.IsNullOrWhiteSpace(serial.NumberOfSeasons) & !string.IsNullOrWhiteSpace(serial.NumberOfSeries))
            {
                await App.SerialsDB.SaveSerialAsync(serial);
            }
            await Shell.Current.GoToAsync("..");
        }
    }
}