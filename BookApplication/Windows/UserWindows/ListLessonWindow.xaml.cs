using System;
using System.Collections.Generic;
using System.Diagnostics;
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

using BookApplication.ClassHelper;
using BookApplication.DB;

namespace BookApplication.Windows.UserWindows
{
    /// <summary>
    /// Логика взаимодействия для ListLessonWindow.xaml
    /// </summary>
    public partial class ListLessonWindow : Window
    {
        public static User User;

        public ListLessonWindow()
        {
            InitializeComponent();
            TblRole.Text = User.Role.Title +": ";
            TblName.Text = User.LName + " " + User.FName;
            GetList();
        }

        public static ListLessonWindow Auth(User user)
        {
            User = user;
            return new ListLessonWindow();
        }

        private void GetList()
        {
            List<Lesson> listLesson = new List<Lesson>();
            
            listLesson = EFClass.context.Lesson.ToList();

            listLesson = listLesson.Where(x => x.Title.ToLower().Contains(TbSearch.Text.ToLower())).ToList();
            
            LvLesson.ItemsSource = listLesson;
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
            this.Close();
        }

        private void TbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            GetList();
        }

        private void BtnOpen_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null) { return; }
            var lesson = button.DataContext as Lesson;
            SelectedLessonWindow selectedLessonWindow = new SelectedLessonWindow(lesson);
            selectedLessonWindow.Show();
            this.Close();
        }

        private void BtnTest_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnVideoLesson_Click(object sender, RoutedEventArgs e)
        {
            //Process.Start(new ProcessStartInfo("https://www.twitch.tv/sqreendota2") { UseShellExecute = true });
        }
    }
}
