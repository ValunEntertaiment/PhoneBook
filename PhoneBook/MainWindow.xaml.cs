using ControlLibrary;
using System;
using System.Collections.Generic;
using System.Windows;
using PhoneBook.ViewModel;

namespace PhoneBook
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //надо сделать так же только через привязку данных в xaml
            //PhoneBookItem phoneBookItem1 = new PhoneBookItem() { Title = "Папа", Phone = "1234567890", Image = "C:\\Users\\timva\\Desktop\\2K8V8nA-auU.jpg" };
            //PhoneBookItem phoneBookItem2 = new PhoneBookItem() { Title = "Мама", Phone = "0987654321", Image = "C:\\Users\\timva\\Desktop\\pingvin.png" };
            //PhoneBookItem phoneBookItem3 = new PhoneBookItem() { Title = "Алина", Phone = "89173123123", Image = "C:\\Users\\timva\\Desktop\\pingvin.png" };
            //PhoneBookItems.Add(phoneBookItem1);
            //PhoneBookItems.Add(phoneBookItem2);
            //array.ItemsSource = PhoneBookItems;
        }
    }
}
