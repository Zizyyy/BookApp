using BookApplication.ClassHelper;
using BookApplication.DB;
using BookApplication.Windows.UserWindows;
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

namespace BookApplication.Windows.AdminWindows
{
    /// <summary>
    /// Логика взаимодействия для AdminListTutorialWindow.xaml
    /// </summary>
    public partial class AdminListTutorialWindow : Window
    {
        private List<Tutorial> listTutorial = new List<Tutorial>();

        public static User User;

        public AdminListTutorialWindow()
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

        public static AdminListTutorialWindow Auth (User user)
        {
            User = user;
            return new AdminListTutorialWindow();
        }

        private void GetTutorialList()
        {
            listTutorial = EFClass.context.Tutorial.ToList();

            listTutorial = listTutorial.Where(x => x.Title.ToLower().Contains(TbSearch.Text.ToLower())).ToList();

            LvTutorial.ItemsSource = listTutorial;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void BtnOpen_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo(EFClass.context.Tutorial.ToList().FirstOrDefault().UrlPath) { UseShellExecute = true });
        }

        private void BtnOpenVideo_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                if (openFileDialog.FileName.EndsWith("mp4"))
                {
                    AdminOpenedVideoWindow.Video(openFileDialog.FileName).Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Поддерживается только mp4 формат.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
        }

        private void BtnClose_MouseDown(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();
            Close();
        }

        private void TbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            GetTutorialList();
        }

        private void BtnTest_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnUserList_Click(object sender, RoutedEventArgs e)
        {
            UserListWindow.Auth(User).Show();
            Close();
        }

        private void BtnLesson_Click(object sender, RoutedEventArgs e)
        {
            AdminListLessonWindow.Auth(User).Show();
            Close();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddEditListTutorialWindow addEditListTutorial = new AddEditListTutorialWindow();
            addEditListTutorial.Show();
            Close();
        }

        private void BtnEditing_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null) { return; }
            var listTutorial = button.DataContext as Tutorial;
            AddEditListTutorialWindow addEditListTutorial = new AddEditListTutorialWindow(listTutorial);
            addEditListTutorial.Show();
            Close();
        }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null)
            {
                return;
            }
            var tutorial = button.DataContext as Tutorial;
            EFClass.context.Tutorial.Remove(tutorial);
            EFClass.context.SaveChanges();
            MessageBox.Show("Урок удален", "Удаление", MessageBoxButton.OK, MessageBoxImage.Information);

            new AdminListTutorialWindow().Show();
            Close();
        }
    }
}
