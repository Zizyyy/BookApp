using BookApplication.ClassHelper;
using BookApplication.DB;
using Microsoft.Win32;
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

namespace BookApplication.Windows.UserWindows
{
    /// <summary>
    /// Логика взаимодействия для ListVideoWindow.xaml
    /// </summary>
    public partial class ListVideoWindow : Window
    {
        private List<Tutorial> listTutorial = new List<Tutorial>();

        public static User User;

        public ListVideoWindow()
        {
            InitializeComponent();

            TblRole.Text = User.Role.Title + ": ";
            if (User.MName == "")
            {
                TblName.Text = $"{User.LName} {User.FName.Substring(0, 1)}.";
            }
            else
            {
                TblName.Text = $"{User.LName} {User.FName.Substring(0, 1)}. {User.MName.Substring(0, 1)}.";
            }

            GetTutorialList();
        }

        public static ListVideoWindow Auth(User user)
        {
            User = user;
            return new ListVideoWindow();
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
        private void BtnProfile_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null) { return; }
            var user = button.DataContext as User;
            ProfileUserWindow profileUserWindow = new ProfileUserWindow(User);
            profileUserWindow.Show();
            Close();
        }

        private void GetTutorialList()
        {
            listTutorial = EFClass.context.Tutorial.ToList();

            listTutorial = listTutorial.Where(x => x.Title.ToLower().Contains(TbSearch.Text.ToLower())).ToList();

            LvTutorial.ItemsSource = listTutorial;
        }

        private void BtnTest_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();
            Close();
        }

        private void BtnLesson_Click(object sender, RoutedEventArgs e)
        {
            ListLessonWindow listLessonWindow = new ListLessonWindow();
            listLessonWindow.Show();
            Close();
        }

        private void BtnOpenVideo_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                if (openFileDialog.FileName.EndsWith("mp4"))
                {
                    OpenedVideoWindow.Video(openFileDialog.FileName).Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Поддерживается только mp4 формат.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
        }

        private void TbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            GetTutorialList();
        }

        private void BtnOpen_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo(EFClass.context.Tutorial.ToList().FirstOrDefault().UrlPath) { UseShellExecute = true });
        }
    }
}
