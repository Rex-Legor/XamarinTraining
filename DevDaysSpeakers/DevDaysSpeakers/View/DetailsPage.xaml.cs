using DevDaysSpeakers.Model;
using Plugin.TextToSpeech;
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
    public partial class DetailsPage : ContentPage
    {
  
        Speaker speaker;
        public DetailsPage(Speaker item)
        {
            InitializeComponent();
            this.speaker = item;
            BindingContext = this.speaker;
        }
        private void ButtonWebsite_Clicked(object sender, EventArgs e)
        {
            if (speaker.Website.StartsWith("http"))
                Device.OpenUri(new Uri(speaker.Website));
        }

        private void ButtonSpeak_Clicked(object sender, EventArgs e)
        {
            CrossTextToSpeech.Current.Speak(this.speaker.Description);
        }
    }
}