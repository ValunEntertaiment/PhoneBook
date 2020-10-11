using ControlLibrary;
using System;
using System.Collections.Generic;
using System.Windows;

namespace PhoneBook
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<PhoneBookItem> PhoneBookItems = new List<PhoneBookItem>();


        public MainWindow()
        {
            InitializeComponent();
            array.ItemsSource = PhoneBookItems;
        }
    }
}
