using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Collections.Generic;

namespace adsfmlk
{
    public sealed partial class Skierowania : Page
    {
        public List<Item> Items { get; set; }

        public Skierowania()
        {
            this.InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            // Przyk³adowe dane
            Items = new List<Item>
            {
                new Item { Id = 1, Name = "Element 1", Details = "Szczegó³y dla Element 1" },
                new Item { Id = 2, Name = "Element 2", Details = "Szczegó³y dla Element 2" },
                new Item { Id = 3, Name = "Element 3", Details = "Szczegó³y dla Element 3" }
            };

            ItemsListView.ItemsSource = Items;
        }

        private void ItemsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ItemsListView.SelectedItem is Item selectedItem)
            {
                DetailsContentControl.Content = new TextBlock
                {
                    Text = selectedItem.Details,
                    FontSize = 24,
                    Margin = new Thickness(10)
                };
            }
        }
    }
}