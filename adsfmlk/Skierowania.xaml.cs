using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Collections.Generic;

namespace adsfmlk
{
    public sealed partial class Skierowania : Page
    {
        public List<Skierowanie> Items { get; set; }

        public Skierowania()
        {
            this.InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            Items = new List<Skierowanie>
            {
                new Skierowanie { Id_ = 1, Text_ = "Skierowanie na oddzia³ kardiologiczny", Date_ = "2021-01-01" },
                new Skierowanie { Id_ = 2, Text_ = "Skierowanie na oddzia³ neurologiczny", Date_ = "2021-02-01" },
                new Skierowanie { Id_ = 3, Text_ = "Skierowanie na oddzia³ ortopedyczny", Date_ = "2021-03-01" }
            };

            ItemsListView.ItemsSource = Items;
        }

        private void ItemsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ItemsListView.SelectedItem is Skierowanie selectedItem)
            {
                var detailsPanel = new StackPanel
                {
                    Margin = new Thickness(10)
                };

           
                detailsPanel.Children.Add(new TextBlock
                {
                    Text = $"{selectedItem.Text_}",
                    FontSize = 20
                });

                detailsPanel.Children.Add(new TextBlock
                {
                    Text = $"{selectedItem.Date_}",
                    FontSize = 20,
                    FontStyle = Windows.UI.Text.FontStyle.Italic
                });

                DetailsContentControl.Content = detailsPanel;
            }
        }
    }
}