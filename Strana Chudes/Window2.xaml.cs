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
using System.Windows.Shapes;

namespace Strana_Chudes
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        burEntities burEntities;
        public Window2()
        {
            InitializeComponent();
            burEntities = new burEntities();
        }

        private void Batdobb(object sender, RoutedEventArgs e)
        {
            {
                DateTime dateTime;
                dateTime = Convert.ToDateTime(datess.Text);
                string fio = fioo.Text;
                int dolzh = Convert.ToInt32(poss.Text);
                int tabnum = Convert.ToInt32(tabnumm.Text);

                Employer em = burEntities.Employer.ToList().Find(x => x.tabNum == tabnum && x.name == fio && x.position == dolzh && x.dateStartWork == dateTime);
                if (em == null)
                {
                    MessageBox.Show("Нет такокго сотрудника‚Ошибка!");
                }
                else
                {
                    pokaz.Text = em.pasword;
                }

            }
        }
    }
}
