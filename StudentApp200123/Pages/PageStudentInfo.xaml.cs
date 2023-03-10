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
    /// Логика взаимодействия для PageStudentInfo.xaml
    /// </summary>
    public partial class PageStudentInfo : Page
    {
        public PageStudentInfo(User userInfo)
        {
            InitializeComponent();

            TxbLoginStudent.Text = userInfo.Login;
            TxbNameStudent.Text = userInfo.Name;
            DateTimeNow.Text = DateTime.Now.ToString();
            GridGradeListStudent.ItemsSource = TestContext.connectPoint.Journal.Where(x => x.UserId == userInfo.Id).ToList();
        }
    }
}
