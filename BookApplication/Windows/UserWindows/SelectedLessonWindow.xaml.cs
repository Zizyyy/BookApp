using BookApplication.DB;
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

namespace BookApplication.Windows.UserWindows
{
    /// <summary>
    /// Логика взаимодействия для SelectedLessonWindow.xaml
    /// </summary>
    public partial class SelectedLessonWindow : Window
    {
        public SelectedLessonWindow()
        {
            InitializeComponent();
        }

        public SelectedLessonWindow(Lesson lesson)
        {
            InitializeComponent();
            TblTitle.Text = lesson.Title;
            TblContent.Text = lesson.ContentLesson.ToString();
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
            ListLessonWindow listLessonWindow = new ListLessonWindow();
            listLessonWindow.Show();
            this.Close();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            ListLessonWindow listLessonWindow = new ListLessonWindow();
            listLessonWindow.Show();
            this.Close();
        }
    }
}
