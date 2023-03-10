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
    /// Логика взаимодействия для PageCreateUser.xaml
    /// </summary>
    public partial class PageCreateUser : Page
    {
        public PageCreateUser()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigation.frameView.GoBack();
        }

        private void BtnCreateUser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                User userAdd = new User() 
                { 
                    Login = TxbLogin.Text,
                    Password = PsbPassword.Password,
                    Name = TxbName.Text,
                    Surname = TxbSurname.Text,
                    Patronomic = TxbPatronymic.Text,
                    RoleId = 6
                };

                TestContext.connectPoint.User.Add(userAdd);
                TestContext.connectPoint.SaveChanges();
                MessageBox.Show("Пользователь успешно добавлен!", "Подтверждено", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
