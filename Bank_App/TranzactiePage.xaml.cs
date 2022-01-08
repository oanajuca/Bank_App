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
    public partial class TranzactiePage : ContentPage
    {
        public TranzactiePage()
        {
            InitializeComponent();
        }
        async void OnTransferButtonClicked(object sender, EventArgs e)
        {
            var slist = (Tranzactii)BindingContext;
            await App.Database.SaveTranzactiiAsync(slist);
            await Navigation.PopAsync();
        }
        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var slist = (Tranzactii)BindingContext;
            await App.Database.DeleteTranzactiiAsync(slist);
            await Navigation.PopAsync();
        }
    }
}