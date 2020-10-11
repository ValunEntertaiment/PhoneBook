using MaterialDesignThemes.Wpf;
using System.Windows;
using System.Windows.Controls;

namespace ControlLibrary
{
    /// <summary>
    /// Логика взаимодействия для PhoneBookSearch.xaml
    /// </summary>
    public partial class PhoneBookSearch : UserControl
    {
        public PhoneBookSearch()
        {
            InitializeComponent();
            ShadowAssist.SetShadowDepth(this, ShadowDepth.Depth0);
        }
    }
}
