using BookApplication.DB;
using BookApplication.Windows.UserWindows;
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

namespace BookApplication.Windows.AdminWindows
{
    /// <summary>
    /// Логика взаимодействия для AdminSelectedLessonWindow.xaml
    /// </summary>
    public partial class AdminSelectedLessonWindow : Window
    {
        public AdminSelectedLessonWindow()
        {
            InitializeComponent();
        }

        public AdminSelectedLessonWindow(Lesson lesson)
        {
            InitializeComponent();
            TblTitle.Text = lesson.Title;
            TblContent.Text = lesson.ContentLesson.ToString();
            try
            {
                ImgPhoto.Source = new BitmapImage(new Uri(lesson.PhotoPath));
            } 
            catch (Exception ex)
            {
                ImgPhoto.Source = null;
            }
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
            AdminListLessonWindow adminListLesson = new AdminListLessonWindow();
            adminListLesson.Show();
            this.Close();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            AdminListLessonWindow adminListLesson = new AdminListLessonWindow();
            adminListLesson.Show();
            this.Close();
        }
    }
}
