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

namespace BookApplication.Windows.UserWindows
{
    /// <summary>
    /// Логика взаимодействия для OpenedVideoWindow.xaml
    /// </summary>
    public partial class OpenedVideoWindow : Window
    {
        private static string PathVideo;
        private TimeSpan savedPosition;

        public OpenedVideoWindow()
        {
            InitializeComponent();
            MediaEl.Source = new Uri(PathVideo);
            MediaEl.LoadedBehavior = MediaState.Manual;
            //MediaEl.ScrubbingEnabled = true;
            MediaEl.Play();
            //MediaEl.UnloadedBehavior = MediaState.Manual;
            TblNma.Text = PathVideo;
        }

        public static OpenedVideoWindow Video(string path)
        {
            PathVideo = path;
            return new OpenedVideoWindow();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void BtnClose_MouseDown(object sender, RoutedEventArgs e)
        {
            ListVideoWindow listVideoWindow = new ListVideoWindow();
            listVideoWindow.Show();
            this.Close();
        }

        private void BtnExit_Click(object obj, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();
            Close();
        }

        private void BtnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Normal;
        }

        private void BtnPlay_Click(object sender, RoutedEventArgs e)
        {
            MediaEl.Position = savedPosition;
            MediaEl.Play();
        }

        private void BtnPause_Click(object sender, RoutedEventArgs e)
        {
            savedPosition = MediaEl.Position;
            MediaEl.Stop();
        }

        private void BtnFull_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Maximized;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            ListVideoWindow listVideoWindow = new ListVideoWindow();
            listVideoWindow.Show();
            this.Close();
        }
    }
}
