using System.Windows.Controls;

namespace ControlLibrary
{
    /// <summary>
    /// Логика взаимодействия для PhoneBookItem.xaml
    /// </summary>
    public partial class PhoneBookItem : UserControl, IPhoneBookItem
    {
        public string Title { get; set; }

        public string Phone { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }

        public PhoneBookItem()
        {
            InitializeComponent();
            
        }

        //void SavePhone(PhoneBookItem PhoneBookItem)
        //{
        //    File.WriteAllText("", JsonConvert.SerializeObject(PhoneBookItem));
        //}
    }
}
