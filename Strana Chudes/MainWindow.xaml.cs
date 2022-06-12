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

namespace Strana_Chudes
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        burEntities context;

        public MainWindow()
        {
            InitializeComponent();
            context = new burEntities();
        }

        private void EnterClick(object sender, RoutedEventArgs e)
        {
            try
            {
                int tubNum = Convert.ToInt32(login.Text);
                string pass = password.Text;

                Employer employer = context.Employer.ToList().Find(x => x.tabNum == tubNum);
                if (employer == null)
                {
                    MessageBox.Show("Сотрудника с таким номером не существует!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    if (employer.pasword.Equals(pass))
                    {
                        MessageBox.Show("Успешная авторизация!", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Пароли не совпадают", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверно введен номер пользователя!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch
            {
                MessageBox.Show("Ошибка!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
