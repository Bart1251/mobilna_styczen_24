using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace mobilna
{
    public partial class MainPage : ContentPage
    {
        List<string> items = new List<string>() { "Pies", "Kot", "Świnka morska" };
        public MainPage()
        {
            InitializeComponent();
            list.ItemsSource = items;
            list.HeightRequest = 40 * items.Count + 10;
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (list.SelectedItem)
            {
                case "Pies":
                    slider.Maximum = 18;
                    break;
                case "Kot":
                    slider.Maximum = 20;
                    break;
                case "Świnka morska":
                    slider.Maximum = 9;
                    break;
            }
        }

        private void DisplayData(object sender, EventArgs e)
        {
            DisplayAlert("Wprowadzone dane", owner.Text + ", " + list.SelectedItem + ", " + (int)slider.Value + ", " + purpose.Text + ", " + time.Time, "OK");
        }
    }
}
