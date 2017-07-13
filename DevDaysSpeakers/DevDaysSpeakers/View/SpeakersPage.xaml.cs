using DevDaysSpeakers.Model;
using DevDaysSpeakers.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DevDaysSpeakers.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SpeakersPage : ContentPage
    {
        SpeakersViewModel vm;
        public SpeakersPage()
        {
            InitializeComponent();
            vm = new SpeakersViewModel();

            BindingContext = vm;


            ListViewSpeakers.ItemSelected += ListViewSpeakers_ItemSelectedAsync;
        }

        private async void ListViewSpeakers_ItemSelectedAsync(object sender, SelectedItemChangedEventArgs e)
        {
            var speaker = e.SelectedItem as Speaker;
            if (speaker == null)
                return;



            await Navigation.PushModalAsync(new DetailsPage(speaker));
            ListViewSpeakers.SelectedItem = null;

        }
    }
}