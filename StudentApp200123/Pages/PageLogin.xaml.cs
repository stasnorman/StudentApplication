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
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private void BtnSightIn_Click(object sender, RoutedEventArgs e)
        {
            string Login = TxbLogin.Text;
            string Password = PswbUser.Password;

            var getUserInfo = TestContext.connectPoint.User.FirstOrDefault(x => x.Login == Login && x.Password == Password);

            if (getUserInfo != null)
            {
                switch (getUserInfo.RoleId)
                {
                    case 1:
                        FrameNavigation.frameView.Navigate(new PageMainAdmin());
                        MessageBox.Show($"Вы успешно авторизовались, {getUserInfo.Name}! Ваша роль: {getUserInfo.Role.Name}.",
                               "Уведомление системы",
                               MessageBoxButton.OK,
                               MessageBoxImage.Information);
                        break;

                        case 5:
                        FrameNavigation.frameView.Navigate(new PageSetGrade());
                        MessageBox.Show($"Вы успешно авторизовались, {getUserInfo.Name}! Ваша роль: {getUserInfo.Role.Name}.",
                           "Уведомление системы",
                           MessageBoxButton.OK,
                           MessageBoxImage.Information);
                        break;


                    default:
                        MessageBox.Show($"{getUserInfo.Name}, для вас функционал ещё не разработан. Ожидайте.",
                           "Уведомление системы",
                           MessageBoxButton.OK,
                           MessageBoxImage.Information);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Такого пользователя нет.",
                                    "Уведомление системы",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Warning);
            }
        }

        private void BtnCreateUser_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigation.frameView.Navigate(new PageCreateUser());
        }
    }
}
