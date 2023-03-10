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
    /// Логика взаимодействия для PageSetGrade.xaml
    /// </summary>
    public partial class PageSetGrade : Page
    {
        public PageSetGrade()
        {
            InitializeComponent();
            CmbSelectStudent.DisplayMemberPath = "PersonalData";
            CmbSelectStudent.SelectedValuePath = "Id";
            CmbSelectStudent.ItemsSource = TestContext.connectPoint.User.Where(x => x.RoleId == 6).ToList();

            CmbSelectDiscipline.DisplayMemberPath = "Name";
            CmbSelectDiscipline.SelectedValuePath = "Id";
            CmbSelectDiscipline.ItemsSource = TestContext.connectPoint.Discipline.ToList();

            for (int i = 2; i < 6; i++) CmbSelectGrade.Items.Add(i); 
        }

        private void BtnSetGrade_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Journal jAddGrade = new Journal()
                {
                    User = CmbSelectStudent.SelectedItem as User,
                    Discipline = CmbSelectDiscipline.SelectedItem as Discipline,
                    Grade = Convert.ToInt32(CmbSelectGrade.Text)
                };

                TestContext.connectPoint.Journal.Add(jAddGrade);
                TestContext.connectPoint.SaveChanges();
                MessageBox.Show("Оценка выставлена!", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
