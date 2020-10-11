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
        /// <summary>
        /// Коллекция номеров используемая в телефонной книге.
        /// </summary>
        List<IPhoneBookItem> PhoneBookItems = new List<IPhoneBookItem>(); 

        
        public MainWindow()
        {
            InitializeComponent();
            PhoneBookItem phoneBookItem1 = new PhoneBookItem() { Title = "Папа", Phone = "1234567890", Image = "C:\\Users\\timva\\Desktop\\2K8V8nA-auU.jpg" };
            PhoneBookItem phoneBookItem2 = new PhoneBookItem() { Title = "Мама", Phone = "0987654321", Image = "C:\\Users\\timva\\Desktop\\pingvin.png" };
            PhoneBookItems.Add(phoneBookItem1);
            PhoneBookItems.Add(phoneBookItem2);
            array.ItemsSource = PhoneBookItems;
        }
    }
}
