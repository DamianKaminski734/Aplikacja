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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Glowne
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            btnStart.Visibility = Visibility.Hidden;
            MessageBox.Show("Witaj świecie");
            btnStart.Visibility = Visibility.Visible;
        }

        private void btnTime_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTime_MouseEnter(object sender, MouseEventArgs e)
        {
            DateTime data = DateTime.Now;
            btnTime.Content = data.ToString("T");
        }

        private void btnTime_MouseLeave(object sender, MouseEventArgs e)
        {
            btnTime.Content = "Czas";
        }

        private void btnActivate_Click(object sender, RoutedEventArgs e)
        {
            btnStart.IsEnabled = true;
        }

        private void btnNo_Click(object sender, RoutedEventArgs e)
        {
            if(btnNo.Content == "Nie")
            {
                MessageBox.Show("Bardzo dobrze");
            } 
            else
            {
                btnNo.Content = "Nie";
                btnYes.Content = "Tak";
            }
        }

        private void btnYes_Click(object sender, RoutedEventArgs e)
        {
            if(btnYes.Content == "Nie")
            {
                MessageBox.Show("Bardzo dobrze");
            } 
            else
            {
                btnNo.Content = "Tak";
                btnYes.Content = "Nie";
            }
        }
    }
}
