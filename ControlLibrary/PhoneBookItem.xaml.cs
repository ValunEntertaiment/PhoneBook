using System.Windows.Controls;

namespace ControlLibrary
{
    /// <summary>
    /// Логика взаимодействия для PhoneBookItem.xaml
    /// </summary>
    public partial class PhoneBookItem : UserControl
    {
        //int Id { get; set; }
        
        public string Title { get; set; }

        public string Phone { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }

        public PhoneBookItem()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
