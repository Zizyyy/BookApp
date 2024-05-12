using BookApplication.ClassHelper;
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
    /// Логика взаимодействия для AdminListLessonWindow.xaml
    /// </summary>
    public partial class AdminListLessonWindow : Window
    {
        public static User User;

        public AdminListLessonWindow()
        {
            InitializeComponent();
            TblRole.Text = User.Role.Title + ": ";
            if (User.MName == null)
            {
                TblName.Text = $"{User.LName} {User.FName.Substring(1)}";
            }
            else
            {
                TblName.Text = User.LName + " " + User.FName.Substring(1) + ". " + $"{User.MName.Substring(1)}";
            }

            GetList();
        }

        public static AdminListLessonWindow Auth(User user)
        {
            AdminListLessonWindow.User = user;
            return new AdminListLessonWindow();
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
            AdminSelectedLessonWindow selectedLessonWindow = new AdminSelectedLessonWindow(lesson);
            selectedLessonWindow.Show();
            this.Close();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddEditLessonWindow addEditLesson = new AddEditLessonWindow();
            addEditLesson.Show();
            Close();
        }

        private void BtnEditing_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null) { return; }
            var listLesson = button.DataContext as Lesson;
            AddEditLessonWindow addEditLesson = new AddEditLessonWindow(listLesson);
            addEditLesson.Show();
            Close();
        }

        private void BtnTest_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnUserList_Click(object sender, RoutedEventArgs e)
        {
            UserListWindow.Auth(User).Show();
            Close();
        }
    }
}
