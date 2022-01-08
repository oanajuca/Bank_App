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
    public partial class CardEntryPage : ContentPage
    {
        public CardEntryPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            cardView.ItemsSource = await App.Database.GetCardsAsync();
        }
        async void OnCardAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CardPage
            {
                BindingContext = new Carduri()
            });
        }
        async void OnCardViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new TransferPage
                {
                    BindingContext = e.SelectedItem as Tranzactii
                });
            }
        }
        
       

           
    }
}