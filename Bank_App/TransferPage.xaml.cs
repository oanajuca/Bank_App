using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Bank_App.Models;

namespace Bank_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TransferPage : ContentPage
    {
        public TransferPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            transferView.ItemsSource = await App.Database.GeTranzactiisAsync();
        }
        async void OnTransferAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TranzactiePage
            {
                BindingContext = new Tranzactii()
            });
        }
        async void OnTransferViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new TranzactiePage
                {
                    BindingContext = e.SelectedItem as Tranzactii
                });
            }
        }
    }
}