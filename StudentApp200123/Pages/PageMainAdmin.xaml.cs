using StudentApp200123.Action;
using StudentApp200123.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentApp200123.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageMainAdmin.xaml
    /// </summary>
    public partial class PageMainAdmin : Page
    {
        public PageMainAdmin()
        {
            InitializeComponent();
            GridUser.ItemsSource = TestContext.connectPoint.User.ToList();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigation.frameView.GoBack();
        }
    }
}
