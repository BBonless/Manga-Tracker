using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MangaTracker
{
    /// <summary>
    /// Interaction logic for ChooseDay.xaml
    /// </summary>
    public partial class ChooseDay : Window
    {
        public ChooseDay()
        {
            InitializeComponent();
        }
        public int day { get; private set; }
        private void Monday(object sender, RoutedEventArgs e)
        {
            day = 1;
            DayLabel.Content = "Monday";

        }
        private void Tuesday(object sender, RoutedEventArgs e)
        {
            day = 2;
            DayLabel.Content = "Tuesday";

        }
        private void Wednesday(object sender, RoutedEventArgs e)
        {
            day = 3;
            DayLabel.Content = "Wednesday";

        }
        private void Thursday(object sender, RoutedEventArgs e)
        {
            day = 4;
            DayLabel.Content = "Thursday";

        }
        private void Friday(object sender, RoutedEventArgs e)
        {
            day = 5;
            DayLabel.Content = "Friday";

        }
        private void Saturday(object sender, RoutedEventArgs e)
        {
            day = 6;
            DayLabel.Content = "Saturday";

        }
        private void Sunday(object sender, RoutedEventArgs e)
        {
            
            day = 7;
            DayLabel.Content = "Sunday";

        }
        public int Confirm(object sender, RoutedEventArgs e)
        {
            return day; 
        }
    }
}
