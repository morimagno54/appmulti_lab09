using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace lab09
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            TapBtn.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new TapDemo());
            };
            PinchBtn.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new PinchDemo());
            };
            PanBtn.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new PanDemo());
            };
            SwipeBtn.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new SwipeDemo());
            };
        }
    }
}
