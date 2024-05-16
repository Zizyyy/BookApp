using BookApplication.ClassHelper;
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
    /// Логика взаимодействия для ProfileUserWindow.xaml
    /// </summary>
    public partial class ProfileUserWindow : Window
    {
        private User changesUser;

        //public static User User;
        public ProfileUserWindow()
        {
            InitializeComponent();
        }
        
        public ProfileUserWindow(User user)
        {
            InitializeComponent();
            TbEmail.Text = user.Email;
            TbFName.Text = user.FName;
            TbLName.Text = user.LName;
            TbMName.Text = user.MName;
            PbPassword.Password = user.Password;
            DpDateOfBirth.Text = user.DateOfBirth.ToString();

            changesUser = user;
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

        private void CbPassword_Checked(object sender, RoutedEventArgs e)
        {
            if(CbPassword.IsChecked == true)
            {
                MessageBox.Show($"Ваш пароль: {PbPassword.Password}", "Пароль", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            CbPassword.IsChecked = false;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            changesUser.Email = TbEmail.Text;
            changesUser.FName = TbFName.Text;
            changesUser.LName = TbLName.Text;
            changesUser.MName = TbMName.Text;
            changesUser.Password = PbPassword.Password;
            changesUser.DateOfBirth = DateTime.Parse(DpDateOfBirth.Text);
            changesUser.DateOfRegistration = DateTime.Now;

            EFClass.context.SaveChanges();
            MessageBox.Show("Ваш профиль успешно изменен", "Изменение", MessageBoxButton.OK, MessageBoxImage.Information);
            ListLessonWindow listLessonWindow = new ListLessonWindow();
            listLessonWindow.Show();
            Close();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            ListLessonWindow listLessonWindow = new ListLessonWindow();
            listLessonWindow.Show();
            Close();
        }
    }
}
