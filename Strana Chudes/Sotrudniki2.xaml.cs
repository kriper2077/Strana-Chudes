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
    /// Логика взаимодействия для Sotrudniki2.xaml
    /// </summary>
    public partial class Sotrudniki2 : Page
    {
        burEntities context;
        public Sotrudniki2()
        {
            InitializeComponent();
            context = new burEntities();
            mastertable.ItemsSource = context.Employer.ToList();
            var positionList = context.Position.ToList();
            positionList.Insert(0, new Position() { Titile="Все", });

            positionBox.ItemsSource = positionList;
        }

        public void RefreshData()
        {
            var list = context.Employer.ToList();
            if (positionBox.SelectedIndex >= 0)
            {
                Position pos = positionBox.SelectedItem as Position;
                list = list.Where(x => x.Position1 == pos).ToList();
            }

            if (string.IsNullOrWhiteSpace(fioBox.Text))
            {
                list = list.Where(x => x.name.ToLower().Contains(fioBox.Text.ToLower())).ToList();
            }
            mastertable.ItemsSource = list;
        }

        private void ChangePosition(object sender, SelectionChangedEventArgs e)
        {
            RefreshData();
        }

        private void ChangeFio(object sender, TextChangedEventArgs e)
        {
            RefreshData();
        }

        private void Addmaster(object sender, RoutedEventArgs e)
        {

        }
    }
}
