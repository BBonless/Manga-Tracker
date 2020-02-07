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
    /// Interaction logic for NewEntry.xaml
    /// </summary>
    public partial class NewEntry : Window
    {
        public string Name;
        public int Day;

        public NewEntry()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            NameOfManga.Text = Convert.ToString(Day);

        }

        private void ChooseDay(object sender, RoutedEventArgs e)
        {
            ChooseDay CD = new ChooseDay();
            CD.ShowDialog();
            Day = CD.Confirm();
            NameOfManga.Text = Convert.ToString(Day);
            

        }
    }
}
