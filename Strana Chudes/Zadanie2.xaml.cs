﻿using System;
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
    /// Логика взаимодействия для Zadanie2.xaml
    /// </summary>
    public partial class Zadanie2 : Window
    {
        public Zadanie2()
        {
            InitializeComponent();
            myFrame.Navigate(new Sotrudniki2());
        }

        private void ShowMasters(object sender, RoutedEventArgs e)
        {
            myFrame.Navigate(new Sotrudniki2());
        }
    }
}